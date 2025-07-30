using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS04.Abstraction
{
    //Abstract Class : partial class[not fully implemented class]
    internal abstract class Shape
    {

        public double dim01 {  get; set; }
        public double dim02 { get; set; }
        //abstract method
        public abstract double GetArea();
        //abstract property
        public abstract double Perimeter { get; }
    }
}
