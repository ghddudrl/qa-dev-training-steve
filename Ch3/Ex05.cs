using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DevTraining
{
    [TestFixture]
    public class Ex05
    {
        [Test]
        public void Ex51()
        {
            int count;
            int loopcount;


            Console.Out.WriteLine("While Loop");
            loopcount = 1;
            while (loopcount <= 3)
            {
                Console.Out.WriteLine("\nloopcount = {0}\n", loopcount);

                count = 1;
                while (count <= 10)
                {
                    Console.Out.WriteLine("count = {0}", count);
                    count++;
                }
                loopcount++;
            }

            Console.Out.WriteLine("Do-While Loop");
            loopcount = 1;
            do
            {
                Console.Out.WriteLine("\nloopcount = {0}\n", loopcount);

                count = 1;
                do
                {
                    Console.Out.WriteLine("count = {0}", count);
                    count++;
                } while (count <= 10);

                loopcount++;
            } while (loopcount <= 3);

        }

        [Test]
        public void Ex52()
        {
            string buf = "0, 90, 120, 21, 351315511";
            List<string> strInputList = new List<string>();
            strInputList = buf.Split(',').ToList();


            foreach (string strInput in strInputList)
            {

                int intInput = Convert.ToInt32(strInput);

                Console.WriteLine("\ninput is : {0}", intInput); 

                if (intInput == 0)
                {
                    Console.WriteLine("input is zero : {0}", intInput);
                }
                else if (intInput > 100)
                {
                    Console.WriteLine("input is too big : {0}", intInput);
                }
                else
                {
                    if (intInput % 2 == 0)
                    {
                        Console.WriteLine("input is even number : {0}", intInput);
                        if (intInput % 10 == 0)
                        {
                            Console.WriteLine("\tand it is also a multiple of 10 : {0}", intInput);
                        }
                    }
                    else if (intInput % 2 == 1)
                    {
                        Console.WriteLine("input is odd number : {0}", intInput);
                    }
                }
            }
        }

        //enum Person : int { Abby = 135, Bob = 175, Charlie = 55, Dawn = 45 };
        enum valCondition
        {
            zero, even, odd, multipleOfTen, tooBig, unknown
        }
        [Test]
        public void Ex53()
        {
            string buf = "0, 90, 120, 21, 351315511";
            List<string> strInputList = new List<string>();
            strInputList = buf.Split(',').ToList();

            valCondition inputCondition = valCondition.unknown;


            foreach (string strInput in strInputList)
            {

                int intInput = Convert.ToInt32(strInput);

                Console.WriteLine("\ninput is : {0}", intInput);

                if (intInput == 0) inputCondition = valCondition.zero;
                else if (intInput > 100) inputCondition = valCondition.tooBig;
                else if (intInput % 2 == 1) inputCondition = valCondition.odd;
                else if (intInput % 2 == 0)
                {
                    inputCondition = valCondition.even;
                    if (intInput % 10 == 0) inputCondition = valCondition.multipleOfTen;
                }

                switch (inputCondition)
                {
                    case valCondition.zero:
                        Console.WriteLine("input is zero : {0}", intInput);
                        break;
                    case valCondition.tooBig:
                        Console.WriteLine("input is too big : {0}", intInput);
                        break;
                    case valCondition.odd:
                        Console.WriteLine("input is odd number : {0}", intInput);
                        break;
                    case valCondition.even:
                        Console.WriteLine("input is even number : {0}", intInput);
                        break;
                    case valCondition.multipleOfTen:
                        Console.WriteLine("input is even number : {0}", intInput);
                        Console.WriteLine("\tand it is also a multiple of 10 : {0}", intInput);
                        break;
                    default:
                        Console.WriteLine("I'm sorry, I didn't understand that.");
                        break;
                }
                
            }
            
        }

        [Test]
        public void Ex54()
        {
            int i; // for count up
            int j; // for count down

            for (i = 0, j = 25; i < j; ++i, --j)
            {
                Console.WriteLine("i = {0}, j = {1}", i, j);
            }
            Console.WriteLine("i = {0}, j = {1} : \"Crossed over!\"", i, j);
        }
        
    }


}
