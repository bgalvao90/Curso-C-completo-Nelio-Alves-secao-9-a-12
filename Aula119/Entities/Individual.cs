using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula119.Entities
{
    class Individual : Person
    {
        public double HealthExpendt { get; set; }

        public Individual(string name, double annualIncome, double healthExpendt) : base(name, annualIncome)
        {
            HealthExpendt = healthExpendt;
        }

        public override double Tax()
        {
            if (AnnualIncome < 20000.00)
            {
                return (AnnualIncome * 0.15) - (HealthExpendt * 0.50);
            }
            else
            {
                return (AnnualIncome * 0.25) - (HealthExpendt * 0.50);
            }
        }
    }
}
