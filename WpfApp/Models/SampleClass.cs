using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Interfaces;

namespace WpfApp.Models
{
    public class SampleClass : ISampleClass,ISampleInterface
    {
        public string AnotherMessage()
        {
            return "Hello!";
        }

        public string Message()
        {
            return "Hello!";
        }

        public string Messages()
        {
            return "Hello!";
        }

        public string SomeMethod()
        {
            throw new NotImplementedException();
        }
    }
}
