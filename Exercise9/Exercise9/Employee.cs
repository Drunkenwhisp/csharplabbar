using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Employee
    {

        private string fName;
        private string lName;
        private string ssn;
        private double wage;

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }


        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public double Wage
        {
            get { return wage; }
            set { wage = value; }
        }

        public string FullName
        {
            get { return FName + " " + lName; }
        }


        public Employee(string fName,string lName, string socialSecurityNumber, double hourlyWage)
        {
            this.fName = fName;
            this.lName = lName;
            this.ssn = socialSecurityNumber;
            this.wage = hourlyWage;
        }
        public Employee(string socialSecurityNumber)
        {
            this.ssn = socialSecurityNumber;
        }
    }
}
