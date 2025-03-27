using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula113.Entities
{
    class OutSoucedEmployee : Employee
    {


        public double AdditionalCharge { get; set; }

        public OutSoucedEmployee()
        {
        }

        public OutSoucedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
