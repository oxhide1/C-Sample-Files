using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Interfaces;

namespace WpfApp
{
    public class Generics<T>
    {
        List<T> myList = new List<T>();
        public void Add(T value) {
            myList.Add(value);
        }
    }
}
