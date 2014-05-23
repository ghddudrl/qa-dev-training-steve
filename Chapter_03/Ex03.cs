using System;
using NUnit.Framework;

namespace Chapter_03
{
    [TestFixture]
    public class Chapter_03_Examples
    {
        [Test]
        public void Example_31()
        {
            int i = 42;
            float f = 98.6F;
            double d = 12345.6789;
            char z = 'Z';
            string s = "The quick brown fox jumped over the lazy dogs.";

            Console.Out.WriteLine("int i = {0}", i);
            Console.Out.WriteLine("float f = {0}", f);
            Console.Out.WriteLine("double d = {0}", d);
            Console.Out.WriteLine("char c = {0}", z);
            Console.Out.WriteLine("string s = {0}", s);
        }

        [Test]
        public void Example_32()
        {
            int i = 42;
            float f = 98.6F;
            double d = 12345.6789;
            char z = 'Z';
            string s = "The quick brown fox jumped over the lazy dogs.";

            i = 25;
            f = 100.3F;
            d = 98765.4321;
            z = 'M';
            s = "A quick movement of the enemy will jeopardize six gun boats.";

            Console.Out.WriteLine("int i = {0}", i);
            Console.Out.WriteLine("float f = {0}", f);
            Console.Out.WriteLine("double d = {0}", d);
            Console.Out.WriteLine("char c = {0}", z);
            Console.Out.WriteLine("string s = {0}", s);
        }

        [Test]
        public void Example_33()
        {
            const double Pi = 3.14159;

            Console.Out.WriteLine("double Pi = {0}", Pi);

            //Pi = 3.1; // Compile Error Happens..

            Console.Out.WriteLine("double Pi = {0}", Pi);
        }

        enum Months : byte { January = 1, Fabruary = 2, March = 3, April = 4, May = 5, June = 6, July = 7, August = 8, September = 9, October = 10, November = 11, December = 12 };
        [Test]
        public void Example_34()
        {
            Console.Out.WriteLine("The value of June = {0}", (int)Months.June);
        }
    }
}
