using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS04.Operator_overrloading
{
    internal class Complexx
    {
        public int Real {  get; set; }
        public int Imag {  get; set; }
        public override string ToString()
        {
            return $"{Real} + {Imag} i";
        }

        public static Complexx operator +(Complexx right, Complexx left)
        {
            return new Complexx()
            {
                
            };
        }

        public static Complexx operator -(Complexx right, Complexx left)
        {
            return new Complexx()
            {
                Real =( right?.Real ?? 0) -( left?.Real ?? 0),
                Imag = (right?.Imag ?? 0 )- (left?.Imag ?? 0)
            };
        }
        //unary operator
        public static Complexx operator ++(Complexx c)
        {
            if (c != null)
            {
                c.Real++;
                return c;
            }
            return new Complexx();
        }
        public static Complexx operator --(Complexx c)
        {
            if (c != null)
            {
                c.Real--;
                return c;
            }
            return new Complexx();
        }

        public static bool operator >(Complexx c1, Complexx c2)
        {
            if (c1.Real == c2.Real)
                return c1.Imag > c1.Imag;

            return c1.Real > c2.Real;
        }

        public static bool operator <(Complexx c1, Complexx c2)
        {
            if (c1.Real == c2.Real)
                return c1.Imag < c1.Imag;

            return c1.Real < c2.Real;
        }

        public static bool operator >=(Complexx c1, Complexx c2)
        {
            if (c1.Real == c2.Real)
                return c1.Imag >= c1.Imag;

            return c1.Real >= c2.Real;
        }

        public static bool operator <=(Complexx c1, Complexx c2)
        {
            if (c1.Real == c2.Real)
                return c1.Imag <= c1.Imag;

            return c1.Real <= c2.Real;
        }


      public static bool operator ==(Complexx c1, Complexx c2)
        {
            return c1.Real == c2.Real && c1.Imag == c2.Imag;
        }

        public static bool operator !=(Complexx c1, Complexx c2)
        {
            return c1.Real != c2.Real || c1.Imag != c2.Imag;
        }





    }
}
