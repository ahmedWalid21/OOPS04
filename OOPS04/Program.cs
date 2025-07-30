

using OOPS04.Operator_overrloading;

namespace OOPS04
{
    internal class Program
    {
        static void Main()
        {
            //Abstraction:
            //Abstract: C# keyword[method - class - properties]

            /// Rectanglee r = new Rectanglee() { dim01 = 2, dim02 = 13 };
            // Console.WriteLine(r.GetArea());
            // Console.WriteLine(r.Perimeter);


            //interface VS Abstract Class


            //operator overloading


          

            Complexx c = new Complexx() { Real = 5, Imag = 4 };
            Complexx c2 = new Complexx() { Real = 3, Imag = 1 };
            Console.WriteLine(c);
            Console.WriteLine(c2);
            Complexx c3 = c -null;
            Console.WriteLine(c3);


        }
    }
}
