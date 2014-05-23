using System;
using NUnit.Framework;

namespace Chapter_08
{
    [TestFixture]
    public class Chapter_08_Excercises
    {

        /// <summary>
        /// //////////////////////////////////////
        /// </summary>

        private class Tripler
        {
            //public void DoubleInt(int firstNum, int secondNum)
            public void TripleInt(ref int firstNum, ref int secondNum)
            {
                firstNum = firstNum * 3;
                secondNum = secondNum * 3;
            }
            
            public void TripleInt(ref float firstNum, ref float secondNum)
            {
                firstNum = (float)(firstNum * 3);
                secondNum = (float)(secondNum * 3);
            }
        }
        [Test]
        public void Example_81()
        {
            int first = 5;
            int second = 10;

            Console.WriteLine("Before tripling:");
            Console.WriteLine("First number: {0}, Second number: {1}", first, second);

            Tripler d = new Tripler();
            d.TripleInt(ref first, ref second);

            Console.WriteLine("After tripling:");
            Console.WriteLine("First number: {0}, Second number: {1}", first, second);

            float firstF = 0.5F;
            float secondF = 1.2F;

            Console.WriteLine("Before tripling:");
            Console.WriteLine("First number: {0}, Second number: {1}", firstF, secondF);

            d.TripleInt(ref firstF, ref secondF);

            Console.WriteLine("After tripling:");
            Console.WriteLine("First number: {0}, Second number: {1}", firstF, secondF);
        }

        private class Dog
        {
            private int weight;
            private string color = "White and Red";
            public string pub;
            public string Pub { get; set; }

            public string Color
            {
                set { color = value; }
                get { return color; }
            }

            public int Weight
            {
                set { weight = value; }
                get { return weight; }
            }
        }

        [Test]
        public void Example_82()
        {
            Dog dog = new Dog();

            //dog.Weight = Convert.ToInt32(Console.ReadLine());
            dog.Weight = 100;
            dog.pub = "sss";
            dog.Pub = "SSS";

            Console.WriteLine("Dog's Color: {0}", dog.Color);
            Console.WriteLine("Dog's Weight: {0}", dog.Weight);
            Console.WriteLine("Dog's pub: {0}", dog.pub);
            Console.WriteLine("Dog's Pub: {0}", dog.Pub);
        }

        private class DoubleTripleMethods
        {
            public void DoubleTriple(int val, ref int forDouble, ref int forTriple)
            {
                forDouble = val * 2;
                forTriple = val * 3;
            }

            public void DoubleTripler(int val, out int forDouble, out int forTriple)
            {
                forDouble = val * 2;
                forTriple = val * 3;
            }
        }

        [Test]
        public void Example_83()
        {
            int forDouble = 0;
            int forTriple = 0;

            int val = 10;

            DoubleTripleMethods m = new DoubleTripleMethods();

            m.DoubleTriple(val, ref forDouble, ref forTriple);

            Console.WriteLine("Val: {0}", val);
            Console.WriteLine("Double: {0}, Triple: {1}", forDouble, forTriple);
        }


        [Test]
        public void Example_84()
        {
            int forDouble;
            int forTriple;

            int val = 11;

            DoubleTripleMethods m = new DoubleTripleMethods();

            m.DoubleTripler(val, out forDouble, out forTriple);

            Console.WriteLine("Val: {0}", val);
            Console.WriteLine("Double: {0}, Triple: {1}", forDouble, forTriple);

        }
    }

    namespace Exercise_8_4
    {
        class Tester
        {
            public void Run()
            {
                Console.Write("Input an integer: ");
                int x = 11;// Convert.ToInt32(Console.ReadLine());
                int doubleX; // uninitialized
                int tripleX; // uninitialized
                DoublerAndTripler(x, out doubleX, out tripleX);
                Console.WriteLine("Double {0} = {1}; triple {2} = {3}",
                x, doubleX, x, tripleX);
            }
            static void DoublerAndTripler(int theVal, out int doubleValue,
            out int tripleValue)
            {
                doubleValue = theVal * 2;
                tripleValue = theVal * 3;
            }

            [Test]
            public void Main()
            {
                Tester t = new Tester();
                t.Run();
            }
        }
    }
    
    namespace Example_8_1____Overloading
    {
        public class Box
        {
            // private variables
            private int length;
            private int width;
            private int height;
            private string color;
            // public methods
            public void DisplayBox()
            {
                Console.WriteLine("Length: {0}, Width: {1}, Height: {2}, Color:{3}", length, width, height, color);
            }

            // constructor overloading..
            public Box(int theLength, int theWidth, int theHeight)
            {
                length = theLength;
                width = theWidth;
                height = theHeight;
                color = "brown";
            }

            public Box(int theLength, int theWidth, int theHeight, string theColor)
            {
                length = theLength;
                width = theWidth;
                height = theHeight;
                color = theColor;
            }

            // method overloading..
            public void PrintColor(int i)
            {
                Console.WriteLine("int Color:{0}", color);
            }

            public void PrintColor(float f)
            {
                Console.WriteLine("float Color:{0}", color);
            }
        }

        public class Tester
        {
            [Test]
            public void Main()
            {
                Box box1 = new Box(4, 8, 3);
                box1.DisplayBox();

                Box blueBox = new Box(3, 5, 7, "blue");
                blueBox.DisplayBox();

                // calling overloading methods..
                box1.PrintColor(10);
                box1.PrintColor(1.1F);

            }
        }
    }

    namespace Example_8_2____Properties
    {
        public class Box
        {
            // private variables
            private int length;
            private int width;
            private int height;

            // property
            //public int Length
            //{
                // get Accessor
                //get { return length; }

                //set Accessor
                //set { length = value; }
            //}

            //Automatic Properties
            public int Length { get; set; }

            // public methods
            public void DisplayBox()
            {
                Console.WriteLine("Length: {0}, Width: {1}, Height:{2}", Length, width, height);
            }

            // constructor
            public Box(int theLength, int theWidth, int theHeight)
            {
                Length = theLength;
                width = theWidth;
                height = theHeight;
            }
        }

        public class Tester
        {
            public void Run()
            {
                // create a box for testing and display it
                Box testBox = new Box(3, 5, 7);
                testBox.DisplayBox();

                // access the length, store it in a local variable
                int testLength = testBox.Length;
                Console.WriteLine("Length of box is: {0}", testLength);

                // increment the length
                testLength++;

                // assign the new value to the member variable
                testBox.Length = testLength;

                // display the box again to test the new value
                testBox.DisplayBox();

                Console.WriteLine("(*) Now, 'testLength' is: {0}", testLength);
            }

            [Test]
            public void Main()
            {
                Tester t = new Tester();
                t.Run();
            }
        }
    }

    namespace Example_8_3____Returning_multiple_values
    {
        internal class Doubler
        {
            public void DoubleInt(int firstNum, int secondNum)
            {
                firstNum = firstNum * 2;
                secondNum = secondNum * 2;
            }
        }
        
        internal class Tester
        {
            public void Run()
            {
                int first = 5;
                int second = 10;
                Console.WriteLine("Before doubling:");
                Console.WriteLine("First number: {0}, Second number: {1}", first, second);

                Doubler d = new Doubler();
                d.DoubleInt(first, second);

                Console.WriteLine("After doubling:");
                Console.WriteLine("First number: {0}, Second number: {1}", first, second);
            }

            [Test]
            public void Main()
            {
                Tester t = new Tester();
                t.Run();
            }
        }
    }


    namespace Example_8_4____Passing_by_Reference
    {
        internal class Doubler
        {
            public void DoubleInt(ref int firstNum, ref int secondNum)
            {
                firstNum = firstNum*2;
                secondNum = secondNum*2;
            }
        }

        internal class Tester
        {
            public void Run()
            {
                int first = 5;
                int second = 10;
                Console.WriteLine("Before doubling:");
                Console.WriteLine("First number: {0}, Second number: {1}",
                                  first, second);
                Doubler d = new Doubler();
                d.DoubleInt(ref first, ref second);
                Console.WriteLine("After doubling:");
                Console.WriteLine("First number: {0}, Second number: {1}",
                                  first, second);
            }

            [Test]
            public void Main()
            {
                Tester t = new Tester();
                t.Run();
            }
        }
    }

    namespace Example_8_4_1___Passing_by_Out
    {
        internal class Doubler
        {
            public void DoubleInt(int firstNum, out int secondNum)
            {
                secondNum = firstNum * 2;
            }
        }

        internal class Tester
        {
            public void Run()
            {
                int first = 15;
                int second = 10;
                Console.WriteLine("Before doubling:");
                Console.WriteLine("First number: {0}, Second number: {1}",
                                  first, second);
                Doubler d = new Doubler();
                d.DoubleInt(first, out second);
                Console.WriteLine("After doubling:");
                Console.WriteLine("First number: {0}, Second number: {1}",
                                  first, second);
            }

            [Test]
            public void Main()
            {
                Tester t = new Tester();
                t.Run();
            }
        }
    }


}

