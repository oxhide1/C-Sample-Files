using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Models;

namespace WpfApp.Events
{
    public delegate void OutOfMoneyHandler(
        Employee employee,
        EventArgs args);

    internal class AppEvents
    {
        public EventArgs e;
        public event OutOfMoneyHandler OutOfMoney;
        Employee employee;
        public AppEvents()
        {
            employee = new Employee(1, "John", "Doe", 100);
        }


        public void SpendMoney()
        {
            employee.Money = employee.Money - 10;

            if (employee.Money <= 0)
            {
                if (OutOfMoney != null)
                {
                    OutOfMoney(employee, e);
                }
            }
        }

        public void Subscribe()
        {
            this.OutOfMoney += Spend_OutOfMoney;
        }
        public void Trigger()
        {
            Spend_OutOfMoney(employee, e);
        }
        private void Spend_OutOfMoney(Employee employee, EventArgs args)
        {
            this.SpendMoney();
        }
    }
}
