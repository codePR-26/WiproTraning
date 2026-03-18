using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ConsoleApp2
{
    internal class CategoryCRUD
    {
        // DB connection
        SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["MyConnection"].ToString()
        );

        // Add category
        public void AddCategory(Category c)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "insert into categories values (@name)", con);
            cmd.Parameters.AddWithValue("@name", c.Name);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        // Update category
        public string UpdateCategory(Category c)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "update categories set name=@name where id=@id", con);
                cmd.Parameters.AddWithValue("@name", c.Name);
                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                con.Close();
            }
        }

        // Delete category
        public string DeleteCategory(int id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "delete from categories where id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
