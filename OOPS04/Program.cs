

using OOPS04.Mapping;
using OOPS04.Operator_overrloading;
using OOPS04.Static;
using static System.Net.Mime.MediaTypeNames;

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




            // Complexx c = new Complexx() { Real = 3, Imag = 4 };
            // Complexx c2 = new Complexx() { Real = 3, Imag = 4 };
            //Console.WriteLine(c);
            //Console.WriteLine(c2);
            //Complexx c3 = c -null;
            //Console.WriteLine(c3);
            // Console.WriteLine(c);
            //  c--;
            //  Console.WriteLine(c);

            // if (c ==c2)
            // {
            ///    Console.WriteLine("C == c2");
            //}
            /// else
            // Console.WriteLine("C !=c2");


            //User Defined casting opertaor
            //Complex -----> string 

            //Complexx c1 = new Complexx(){Real = 3, Imag = 2};
            //string c = (string)c1;
            //Console.WriteLine(c);

            //int x = (int)c1;
            //Console.WriteLine(x);



            //User u=new User();
            ////Manual Mapping
            //UserDto ud = new UserDto()
            //{
            //    name = u.name,
            //    email = u.email,
            //    PhoneNumber = u.PhoneNumber
            //};

            //Auto Mapping: Mapping Automatic

            //Static: C# keyword[class, Attribute, property, constructor,method]

          //  Utilites u1= new Utilites();
           // Utilites u2= new Utilites();
           // Utilites u3= new Utilites();
            //Console.WriteLine(u1.CmtoInch(254));
            //Console.WriteLine(u2.CmtoInch(254));
            //Console.WriteLine(u3.CmtoInch(254));

            Console.WriteLine(Utilites.CmtoInch(254));
            Console.WriteLine(Utilites.CmtoInch(254));

            Console.WriteLine(Utilites.PI);
            Console.WriteLine(Utilites.PI);




        }
    }
}
