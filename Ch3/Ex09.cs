using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DevTraining
{
    [TestFixture]
    public class Ex09
    {
        public class Exercise_9_1_Tester
        {
            public void Run()
            {
                int myInt = 42;
                float myFloat = 9.685f;
                Console.WriteLine("Before starting: \n value of myInt:{0}\n value of myFloat:{1}", myInt, myFloat);
                // pass the variables by reference
                Multiply(ref myInt, ref myFloat);
                Console.WriteLine("After finishing: \n value of myInt:{0}\n value of myFloat:{1}", myInt, myFloat);
            }

            private static void Multiply(ref int theInt,
                                         ref float theFloat)
            {
                theInt = theInt*2;
                theFloat = theFloat*2;
                Divide(ref theInt, ref theFloat);
            }

            private static void Divide(ref int theInt,
                                       ref float theFloat)
            {
                theInt = theInt/3;
                theFloat = theFloat/3;
                Add(ref theInt, ref theFloat);
            }

            public static void Add(ref int theInt,
                                   ref float theFloat)
            {
                theInt = theInt + theInt;
                theFloat = theFloat + theFloat;
            }

            [Test]
            public void Main()
            {
                Exercise_9_1_Tester t = new Exercise_9_1_Tester();
                t.Run();
            }
        }

        public class Exercise_9_2_Tester
        {
            public void Run()
            {
                int myInt = 42;
                float myFloat = 9.685f;
                Console.WriteLine("Before starting: \n value of myInt:{0}\n value of myFloat:{1}", myInt, myFloat);
                // pass the variables by reference
                Multiply(ref myInt, ref myFloat);
                Console.WriteLine("After finishing: \n value of myInt:{0}\n value of myFloat:{1}", myInt, myFloat);
            }

            private static void Multiply(ref int theInt,
                                         ref float theFloat)
            {
                theInt = theInt*2;
                theFloat = theFloat*2;
                Divide(ref theInt, ref theFloat);
            }

            private static void Divide(ref int theInt,
                                       ref float theFloat)
            {
                theInt = theInt/3;
                theFloat = theFloat/3;
                Add(ref theInt, ref theFloat);
            }

            public static void Add(ref int theInt,
                                   ref float theFloat)
            {
                theInt = theInt + theInt;
                theFloat = theFloat + theFloat;
            }

            [Test]
            public void Main()
            {
                Exercise_9_2_Tester t = new Exercise_9_2_Tester();
                t.Run();
            }
        }

        public class Exercise_9_3_Program
        {
            public static int Factorial(int myInt)
            {
                int result = 1;
                for (int i = 1; i <= myInt; i++)
                {
                    result = result * i;
                }
                return result;
            }

            [Test]
            public void Main()
            {
                int input = 5;
                Console.WriteLine("{0} factorial is {1}", input, Factorial(input));
            }
        }
    }

}

