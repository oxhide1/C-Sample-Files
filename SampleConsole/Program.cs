//namespaces
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFeatures;
namespace SampleConsole
{

    struct MyStruct
    {
        private int[] myArr;
        public int this[int index]
        {
            get { return this.myArr[index]; }
            set { this.myArr[index] = value; }
        }

        public MyStruct(int[] values)
        {
            this.myArr = values;
        }


    }

    class Employee
    {

        public Employee(int id, string fname, string lname)
        {
            empId = id;
            Firstname = fname;
            Lastname = lname;
        }
        public int empId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            






            Hashtable hashtable = new Hashtable();
            hashtable.Add("jd", new Employee(1, "John", "Doe"));
            hashtable.Add("jad", new Employee(2, "Jane", "Doe"));
            hashtable.Add("pp", new Employee(3, "Peter", "Pan"));

            var result = from Employee employee in hashtable.Values
                         where employee.Lastname.Equals("xx")
                         orderby employee.Firstname descending
                         select employee;

            

            foreach (var key in result.ToList())
            {
                Employee emp = (Employee)key;
                Console.WriteLine(emp.Firstname);
            }

            //Employee employee4 = (Employee)hashtable["jad"];
            //Console.WriteLine(employee4.Firstname);

            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //MyStruct ms = new MyStruct(arr);

            //Console.WriteLine(ms[2]);



            //ms.field1 = 45;
            //ms.field2 = 45;
            // Console.WriteLine(ms.Add());
            // Console.WriteLine(ms.field1);
            // Console.WriteLine(ms.field2);


            //MyStruct myStruct2;
            ////myStruct.field1 = 5;
            ////myStruct.field2 = 10;
            //myStruct2 = ms;
            //Console.WriteLine(myStruct2.Add());
            //Console.WriteLine(myStruct2.Add());

        }
    }
}
