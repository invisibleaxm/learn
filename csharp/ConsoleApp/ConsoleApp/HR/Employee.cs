using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.HR
{
    internal class Employee
    {
        private string _firstName;
        private double _hourlyRate;

        public Employee(string firstName, double hourlyRate)
        {
            HourlyRate = hourlyRate;
            FirstName = firstName;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public double HourlyRate
        {
            get { return _hourlyRate;  }
            private set { _hourlyRate = value; }
        }
    }
}
