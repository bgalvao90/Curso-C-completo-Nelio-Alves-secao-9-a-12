using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula119.Entities
{
    class Company : Person
    {
        public int Employee { get; set; }

        public Company(string name, double annualIncome, int employee) : base(name, annualIncome)
        {
            Employee = employee;
        }

        public override double Tax()
        {
            if (Employee > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}