using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS04.Abstraction
{
    internal class Rectanglee : Shape
    {
        public override double GetArea()
        {
            return dim01 * dim02;
        }
        public override double Perimeter
        {
            get
            {
                return (dim01 + dim02) * 2;
            }
        }
    }
}
