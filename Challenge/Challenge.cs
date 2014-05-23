using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Challenge
{
    [TestFixture]
    public class Challenge
    {
        
        [Test]
        public void Challenge_1()
        {
            int val;
            decimal buff;

            Console.WriteLine("\nBelow 10");
            buff = 0;
            for (val = 1; val < 10; val++)
            {
                if ((val % 3 == 0) || (val % 5 == 0))
                {
                    buff += val;
                    Console.WriteLine("val = {0}, buff = {1}", val, buff);
                }
            } // 23

            Console.WriteLine("\nBelow 1000");
            buff = 0;
            for (val = 1; val<1000; val++)
            {
                if ((val % 3 == 0 ) || (val % 5 == 0))
                {
                    buff += val;
                    Console.WriteLine("val = {0}, buff = {1}", val, buff);
                }
            } // 233168
        }


        [Test]
        public void Challenge_2()
        {
            decimal sumOfeven = 0;

            int limitCount = 40;
            int limitNum = 4000000;

            for (int cnt = -2; cnt <= limitCount; cnt++)
            {
                int result = simpleFibonacci(cnt);
                Debug.WriteLine(" > simpleFibonacci result[{0}] = {1}", cnt, result);

                if (result <= limitNum && result % 2 == 0)
                    sumOfeven += result;
                else if (result > limitNum)
                    break;

            }
            Console.WriteLine("\n(*) Sum of even numbers : {0} for limit value [{1}]\n", sumOfeven, limitCount);

            //MyFibonacci(limitNum, out sumOfeven);// Sum of even numbers : 4613732
            //Console.WriteLine("\n3) Sum of even numbers : {0} for limit value [{1}]\n", sumOfeven, limitNum);
            

        }

        public int simpleFibonacci(int maxLoop)
        {
            int prev_prev_val = 0;
            int prev_val = 1;

            int current_val = 0;

            for (int cnt = 0; cnt < maxLoop; cnt++)
            {
                prev_prev_val = prev_val;
                prev_val = current_val;
                current_val = prev_prev_val + prev_val;

                //Debug.WriteLine("Current val[{0}] = {1}", cnt, current_val);
            }
            return current_val;
        }

        public void MyFibonacci(int end_val, out decimal even_sum)
        {
            decimal prev_result = 0;
            decimal curt_result = 1;
            even_sum = 0;
            List<decimal> list_result = new List<decimal>();
            List<decimal> list_even = new List<decimal>();


            if (end_val <= 0)
            {
                even_sum = 0;
                return;
            }
            else if(end_val == 1)
            {
                even_sum = 1;
                return;
            }
            else if (end_val == 2)
            {
                even_sum = 2;
                return;
            }
            else
            {
                list_result.Add(1);
                list_result.Add(2);

                list_even.Add(2);

                Debug.WriteLine("Fibonacci function running when end_val = {0}", end_val);
                int cnt = 2;
                while ((list_result[cnt - 1] + list_result[cnt - 2]) <= end_val)
                {
                    list_result.Add(list_result[cnt - 1] + list_result[cnt - 2]);

                    if (list_result[cnt]%2 == 0)
                    {
                        list_even.Add(list_result[cnt]);
                        
                    }
                    cnt++;
                }

                Debug.WriteLine("");

                cnt = 0;
                foreach (decimal v in list_result)
                {
                    Debug.WriteLine("Fibonacci sequence[{0}] : {1}", cnt, v);
                    cnt++;
                }
                
                cnt = 0;
                foreach (decimal v in list_even)
                {
                    Debug.WriteLine("even numbers[{0}] in Fibonacci : {1}", cnt, v);
                    even_sum += v;
                    cnt++;
                }

                //return even_sum;
            }
        }
    }
}
