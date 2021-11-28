﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melendez_CourseProject_part2
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private string ssn;
        private DateTime hireDate;

        //constructors
        public Employee()
        {
            firstName = "unknown";
            lastName = "unknown";
            ssn = "unknown";
            hireDate = new DateTime(1900, 1, 1);
        }

        public Employee(string firstName, string lastName, string ssn, DateTime hireDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.hireDate = hireDate;
        }

        //behaviors

        public override string ToString()
        {
            return "firstName=" + firstName + ", lastName=" + lastName + ", ssn+" + ssn + ",hireDate=" + hireDate.ToShortDateString();
        }

        public double CalculatePay()
        {
            return 0;
        }

        //properties
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string SSN
        {
            get
            {
                return ssn;
            }

            set
            {
                //222-22-2222 or 222222222
                if (value.Length == 9 || value.Length == 11)
                    this.ssn = value;
                else
                    this.ssn = "unknown";
            }
        }

        public DateTime HireDate
        {
            get
            {
                return hireDate;
            }

            set
            {
                hireDate = value;
            }
        }


    }
}
