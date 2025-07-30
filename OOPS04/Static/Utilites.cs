using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS04.Static
{
    internal static class Utilites
    {
        private static double Pi=3.14;
        //public int X {  get; set; } 
        //public int Y { get; set; }
        static Utilites()
        {
            Pi = 3.14;
        }
        //static method: class member method
        public static double CmtoInch(double cm)
        {
            return cm / 2.54;
        }

        public static double PI
        {
            get
            {
                return Pi;

            }
        }
    }
}
