using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class Employee
    {
        protected int empid;
        protected string empname, empaddress ;
        public void SetEmpDetails( int a, string b ,string c)
        {
            empid = a;
            empname = b;
            empaddress = c;
        }
    }
    class person : Employee
    {
        private string firstname, lastname;
        public void SetName(string a, string b)
        {
            firstname = a;
            lastname = b;

        }
        public void DisplyFullName()
        {
            Console.WriteLine("Employee ID :"+ empid);
            Console.WriteLine("Employee Name :"+ empname);
            Console.WriteLine("Employee Address :"+ empaddress);
            Console.WriteLine();
            Console.WriteLine("Person Name :" + firstname + " " + lastname);
        }
    }

     class PrivateProtected
    {
        static void Main()
        {
            person obj = new person();
            obj.SetEmpDetails(145644, "Ramkant sharma", " Umesh Nagar");
            obj.SetName("Suresh", "Patil");
            obj.DisplyFullName();
        }
    }
}
