using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DevTraining
{
    class FunTimer
    {
    }
}


namespace FunTimer
{
    [TestFixture]
    public class FunTimer
    {
        public class StopWatch
        {
            private DateTime endTime;

            public DateTime EndTime
            {
                get { return endTime; }
                set { endTime = value; }
            }

            public void TimeLeft()
            {
                DateTime curTime = DateTime.Now;

                Console.WriteLine("Current Time is {0}", curTime);
                Console.WriteLine("End Time is {0}", endTime);

                int sec = (int) endTime.Subtract(curTime).TotalSeconds;
                Console.WriteLine(" >> (int) endTime.Subtract(curTime).TotalSeconds = " + (int)endTime.Subtract(curTime).TotalSeconds);
                if (sec > 0)
                {
                    int min = sec/60;
                    Console.WriteLine(" >> int min = sec/60 : " + min);

                    int hours = min/60;
                    Console.WriteLine(" >> int hours = min/60 : " + hours);

                    int days = hours/24;
                    Console.WriteLine(" >> int days = hours/24 : " + days);

                    hours %= 24;
                    Console.WriteLine(" >> hours %= 24 : " + hours);

                    min %= 60;
                    Console.WriteLine(" >> min %= 60 : " + min);

                    sec %= 60;
                    Console.WriteLine(" >> sec %= 60 : " + sec);

                    Console.WriteLine("You have {0} day(s), {1} hour(s), {2} minute(s), and {3} second(s) left", days,
                        hours, min, sec);
                }
                else
                {
                    Console.WriteLine("Sorry, you have missed your deadline!");
                }
            }
        }

        [Test]
        public void ReportTime()
        {
            StopWatch w = new StopWatch();
            //w.EndTime = DateTime.Parse("Fri, 09 May 2014 12:00:00");
            w.EndTime = DateTime.Parse("Fri, 03 July 2015 12:00:00");

            w.TimeLeft();
        }
    }
}
