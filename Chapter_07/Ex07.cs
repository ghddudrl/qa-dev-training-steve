using System;
using NUnit.Framework;

namespace Chapter_07
{
    [TestFixture]
    public class Chapter_07_Examples
    {
        public class Box_7_1
        {
            // private variables
            private int length;
            private int width;
            private int height;
            // public methods
            public void DisplayBox()
            {
                Console.WriteLine("Stub for displaying the box.");
            }
        }

        [Test]
        public void Example_7_1__The_Box_Class()
        {
            Box_7_1 box71Object = new Box_7_1();
            box71Object.DisplayBox();
        }

        public class MyClass
        {
            public void SomeMethod(int firstParam, float secondParam)
            {
                Console.WriteLine("Here are the parameters received: {0}, {1}", firstParam, secondParam);
            }
        }

        public class Multiplier
        {
            public int Multiply(int firstOperand, int secondOperand)
            {
                return firstOperand*secondOperand;
            }
        }

        [Test]
        public void Example_7_2()
        {
            int howManyPeople = 5;
            float pi = 3.14f;
            MyClass mc = new MyClass();
            mc.SomeMethod(howManyPeople, pi);

            int x = 4;
            int y = 10;
            Multiplier myMultiplier = new Multiplier();
            int result = myMultiplier.Multiply(x, y);

            Console.WriteLine("Here are the result received: {0}", result);
        }

        public class Box_7_3
        {
            // private variables
            private int length;
            private int width;
            private int height;
            // public methods

            public void DisplayBox()
            {
                Console.WriteLine("Length: {0}, Width: {1}, Height: {2}",
                                  length, width, height);
            }

            // constructor
            public Box_7_3(int theLength, int theWidth, int theHeight)
            {
                length = theLength;
                width = theWidth;
                height = theHeight;
            }
        }

        [Test]
        public void Example_7_3()
        {
            Box_7_3 boxObject = new Box_7_3(4, 8, 3);
            boxObject.DisplayBox();
        }


        public class Box_7_4
        {
            // private variables
            private int length;
            private int width;
            private int height = 6;
            // public methods
            public void DisplayBox()
            {
                Console.WriteLine("Length: {0}, Width: {1}, Height: {2}",
                                  length, width, height);
            }

            // constructor
            public Box_7_4(int theLength, int theWidth)
            {
                length = theLength;
                width = theWidth;
            }
        }

        [Test]
        public void Example_7_4()
        {
            Box_7_4 boxObject = new Box_7_4(4, 8);
            boxObject.DisplayBox();
        }

        public class Dog
        {
            public string name;
            public int weight;
            // constructor
            public Dog()
            {
            }

            public Dog(string myName)
            {
                this.name = myName;
            }

            public Dog(string name, int weight)
            {
                this.name = name;
                this.weight = weight;
            }

            public void PrintName()
            {
                Console.WriteLine("Dog's name : {0} and weight : {1}", name, weight);
            }
        }

        [Test]
        public void DogTest_7_4()
        {
            Dog milo = new Dog("Milo");
            milo.weight = 5;
            milo.PrintName();

            Dog hilo = new Dog("Hilo") {weight = 15};
            hilo.PrintName();

            var red = new Dog() {name = "Red", weight = 13};
            red.PrintName();

            var foo = new {Color = "Blue", Size = 25}; // These fields are read-only..

            var blue = new Dog();
            blue.name = foo.Color;
            blue.weight = foo.Size;
            blue.PrintName();

            Dog white = new Dog("White", 11);
            white.PrintName();
        }

        // declare a Cat class, stripped down
        public class Cat
        {
            // a private static member to keep track of how many Cat objects
            // have been created
            private static int instances = 0;
            private int weight;
            private String name;
            // cat constructor, increments the count of Cats
            public Cat(String name, int weight)
            {
                instances++;
                this.name = name;
                this.weight = weight;
            }

            // Static method to retrieve the current number of Cats
            public static void HowManyCats()
            {
                Console.WriteLine("{0} cats adopted", instances);
            }

            public void TellWeight()
            {
                Console.WriteLine("{0} is {1} pounds", name, weight);
            }
        }

        private class Tester
        {
            public void Run()
            {
                Cat.HowManyCats();

                Cat frisky = new Cat("Frisky", 5);
                frisky.TellWeight();
                Cat.HowManyCats();

                Cat whiskers = new Cat("Whiskers", 7);
                whiskers.TellWeight();
                Cat.HowManyCats();
            }
        }

        [Test]
        public void Main()
        {
            Tester t = new Tester();
            t.Run();
        }


        private class Testing : IDisposable
        {
            private bool is_disposed = false;

            protected virtual void Dispose(bool disposing)
            {
                if (!is_disposed) // only dispose once!
                {
                    if (disposing)
                    {
                        // OK to reference other objects
                    }
                    // perform cleanup for this object
                    Console.WriteLine("Disposing...");
                }
                this.is_disposed = true;
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }

        public class Dog_7_7
        {
            public int weight;
        }

        private class Tester_7_7
        {
            public void Run()
            {
                // create an integer
                int firstInt = 5;
                // create a second integer
                int secondInt = firstInt;
                // display the two integers
                Console.WriteLine("firstInt: {0} secondInt: {1}",
                                  firstInt, secondInt);
                // modify the second integer
                secondInt = 7;
                // display the two integers
                Console.WriteLine("firstInt: {0} secondInt: {1}",
                                  firstInt, secondInt);
                // create a dog
                Dog_7_7 milo = new Dog_7_7();
                // assign a value to weight
                milo.weight = 5;
                // create a second reference to the dog
                Dog_7_7 fido = milo;
                // display their values
                Console.WriteLine("milo: {0}, fido: {1}",
                                  milo.weight, fido.weight);
                // assign a new weight to the second reference
                fido.weight = 7;
                // display the two values
                Console.WriteLine("milo: {0}, fido: {1}",
                                  milo.weight, fido.weight);
            }
        }

        [Test]
        public void Main_7_7()
        {
            Tester_7_7 t = new Tester_7_7();
            t.Run();
        }

    }
    
    [TestFixture]
    public class Chapter_07_Excercises
     {

    /// <summary>
        /// //////////////////////////////////////
        /// </summary>
        
        private class Math
        {
        
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Subtract(int a, int b)
            {
                return a - b;
            }

            public int Multiply(int a, int b)
            {
                return a * b;
            }

            public int Divide(int a, int b)
            {
                return a / b;
            }
        }

        [Test]
        public void Exercise_71_Main()
        {
            int result;

            Math Calc = new Math();

            result = Calc.Add(100, 5);
            Console.Out.WriteLine("The result is : {0}", result);

            result = Calc.Subtract(100, 5);
            Console.Out.WriteLine("The result is : {0}", result);

            result = Calc.Multiply(100, 5);
            Console.Out.WriteLine("The result is : {0}", result);

            result = Calc.Divide(100, 5);
            Console.Out.WriteLine("The result is : {0}", result);
        }


        private class Math_NoInstance
        {

            static public int Add(int a, int b)
            {
                return a + b;
            }

            static public int Subtract(int a, int b)
            {
                return a - b;
            }

            static public int Multiply(int a, int b)
            {
                return a * b;
            }

            static public int Divide(int a, int b)
            {
                return a / b;
            }
        }

        [Test]
        public void Exercise_72()
        {
            int result;

            Math_NoInstance Calc = new Math_NoInstance();

            //result = Calc.Add(100, 5);
            result = Math_NoInstance.Add(100, 10);
            Console.Out.WriteLine("The result is : {0}", result);

            result = Math_NoInstance.Subtract(100, 10);
            Console.Out.WriteLine("The result is : {0}", result);

            result = Math_NoInstance.Multiply(100, 10);
            Console.Out.WriteLine("The result is : {0}", result);

            result = Math_NoInstance.Divide(100, 10);
            Console.Out.WriteLine("The result is : {0}", result);
            
        }

        private class Book
        {
            private string title;
            private string author;
            private string publisher = "O’Reilly";
            private string ISBN;

            public Book(string title, string author, string ISBN)
            {
                this.title = title;
                this.author = author;
                //this.publisher = publisher;
                this.ISBN = ISBN;
            }

            public void DisplayBook()
            {
                Console.Out.WriteLine("{0} \t {1} \t {2} \t {3}", title, author, publisher, ISBN);
            }
        }

        [Test]
        public void Exercise_73()
        {
            Book book1 = new Book("Programming C# 3.0", "Jesse Liberty and Donald Xie", "9780596527433");
            Book book2 = new Book("C# 3.0 In a Nutshell", "Joseph Albahari and Ben Albahari", "9780596527570");
            Book book3 = new Book("C# 3.0 Cookbook", "Jay Hilyard and Stephen Teilhet", "9780596516109");
            
            book1.DisplayBook();
            book2.DisplayBook();
            book3.DisplayBook();
        }

        private class Point
        {
            public int x, y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void DisplayingCoordinates()
            {
                Console.Out.WriteLine("x = {0} \t y = {1}", x, y);
            }
        }

        private class Square
        {

            //public Square(int x, int y, int length)
            public Square(Point point, int length)
            {
                Console.WriteLine("The four corners : ");

                Point point1 = new Point(point.x, point.y);
                point1.DisplayingCoordinates();

                Point point2 = new Point(point.x + length, point.y);
                point2.DisplayingCoordinates();

                Point point3 = new Point(point.x, point.y + length);
                point3.DisplayingCoordinates();

                Point point4 = new Point(point.x + length, point.y + length);
                point4.DisplayingCoordinates();

            }
        }

        [Test]
        public void Exercise_74()
        {
            Point pt = new Point(45, 7);
            int length = 10;
            Square sq = new Square(pt, length);
        }

    }


}
