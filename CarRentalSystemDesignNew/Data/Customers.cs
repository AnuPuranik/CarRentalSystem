using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalSystemDesignNew
{
    // Customer class to store information related to customers including name, DOB, Insurance number.
    // Customer ID is auto generated from the function
    public class Customers
    {
        public string CustomerFname { get; set; }
        public string CustomerLname { get; set; }
        public DateTime DOB { get; set; }
        private static int count = 200;
        public string InsuranceNumber { get; set; }
        public int CID { get; set; }

        public Customers(string FirstName, string LastName, DateTime DOB, string InsuranceNumber)
        {
            this.CustomerFname = FirstName;
            this.CustomerLname = LastName;
            this.DOB = DOB;
            this.CID = GenerateCustomerID();
            this.InsuranceNumber = InsuranceNumber;

        }
        private static int GenerateCustomerID()
        {
            return count++;
        }

        public string GetCustomerName(string fname, string lname)
        {
            this.CustomerFname = fname;
            this.CustomerLname = lname;
            return this.CustomerFname + " " + this.CustomerLname;
        }

        public DateTime GetCustomerDOB(DateTime Dob)
        {
            this.DOB = Dob;
            return this.DOB;
        }
    }
}
