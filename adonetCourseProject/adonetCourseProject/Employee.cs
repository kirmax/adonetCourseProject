﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonetCourseProject
{
    class Employee
    {
        public int Id { get; set; }
        public int MyProperty { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set;}
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public Byte[] Photo { get; set; }
        public decimal Salary { get; set; }
        public decimal Reward { get; set; }
        public Position PositionId { get; set; }
    }

}