using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models  //custom type/entity class/POCO class/Model class/DTO class/ViewModel class
{
    internal class Doctor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Specialization { get; set; }

        public string Phone { get; set; }

        public string Experience { get; set; }
    }
}
