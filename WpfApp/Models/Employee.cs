using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Models
{
    public class Employee
    {
        public Employee(
            int id,
            string fname,
            string lname,
            int money)
        {
            empId = id;
            Firstname = fname;
            Lastname = lname;
            Money = money;
        }
        public int empId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Money { get; set; }
    }
}
