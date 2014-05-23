using System;
using NUnit.Framework;

namespace Misc
{
    [TestFixture]
    public class Week1
    {
        [Test]
        public void ImplicitCasting()
        {
            int i = 12;
            byte j = 4;
            Console.Out.WriteLine("int {0} +  byte {1} = total int {2}", i, j, i + j);
        }
        [Test]
        public void ExplicitCastingToDecimal()
        {
            decimal myDecimal = 12m;
            double myDouble = 12.4;
            Console.Out.WriteLine("decimal {0} +  double {1} = total decimal {2}", myDecimal, myDouble, myDecimal + (decimal) myDouble);
        }
        [Test]
        public void ExplicitCastingToDouble()
        {
            decimal myDecimal = 12m;
            double myDouble = 12.4;
            Console.Out.WriteLine("decimal {0} +  double {1} = total double {2}", myDecimal, myDouble, (double)myDecimal + myDouble);
        }
        [Test]
        public void ImplicitCastingToString()
        {
            string myString = "12";
            double myDouble = 12.4;
            Console.Out.WriteLine("string {0} +  double {1} = concatinated string {2}", myString, myDouble, myString + myDouble);
        }
    }
}
