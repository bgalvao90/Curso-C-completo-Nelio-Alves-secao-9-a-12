using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula125.Entites.Exceptions
{
    class DomainException : ApplicationException
    {

        public DomainException(string message) : base(message)
        {
        }
    }
}
