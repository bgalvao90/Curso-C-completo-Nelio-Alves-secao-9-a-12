using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Aula_128.Entities.Enums;
namespace Aula_128.Entities
{
    abstract class Shape
    {

        public Color Color { get; set; }


        public Shape(Color color)
        {
            Color = color;
        }


        public abstract double Area();
        
    }
}
