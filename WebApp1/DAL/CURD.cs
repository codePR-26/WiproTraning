using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;
using WiproWebApp.Controllers;
using WiproWebApp.Models;

namespace WiproWebApp.DAL
{
    public class CRUD
    {
        private readonly string _config;
        private readonly string _connStr;

        public CRUD(IConfiguration config)
        {
            _connStr = config.GetConnectionString("DefaultConnection");
        }

        public void AddPatient(Patient p)
        {
            SqlConnection con = new SqlConnection(_connStr);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into patients values('" + p.Name + "','" + p.Phone + "')", con);
            cmd.ExecuteNonQuery();
        }

        public List<Patient> GetPatients()
        {
            SqlConnection con = new SqlConnection(_connStr);
            SqlDataAdapter da = new SqlDataAdapter("select * from patients", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Patient> patients = new List<Patient>();
            foreach (DataRow dr in dt.Rows)
            {

                Patient p = new Patient()
                {
                    Id = int.Parse(dr["id"].ToString()),
                    Name = dr["name"].ToString(),
                    Phone = dr["phone"].ToString()
                };
                patients.Add(p);
            }
            return patients;
        }
    }
}