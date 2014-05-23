using System;
using NUnit.Framework;

namespace Chapter_10
{
    [TestFixture]
    public class Chapter_10_Examples
    {
        public class Button
        {
            public string name { get; set; }
        }

        [Test]
        public void BasicArrayTest()
        {
            int[] myIntArray = new int[5] {11, 22, 33, 44, 55};

            foreach (var i in myIntArray)
                Console.WriteLine(i);
            Console.WriteLine();

            for (int cnt = 0; cnt < myIntArray.Length; cnt++)
            {
                Console.WriteLine("myIntArray[{0}] = {1}", cnt, myIntArray[cnt]*2);
            }
            Console.WriteLine();

            int[] myIntArray_2 = {2, 4, 6, 8, 10, 20, 21, 102};

            foreach (var i in myIntArray_2)
                Console.WriteLine(i);
            Console.WriteLine();


            Button[] myButtonArray = new Button[3];

            Button button = new Button();
            button.name = "shong";

            myButtonArray[0] = button;
            myButtonArray[1] = button;
            myButtonArray[2] = button;

            foreach (var b in myButtonArray)
                Console.WriteLine(b.name);

            int res = Array.BinarySearch(myIntArray_2, 102);
            Console.WriteLine("The finding value is {0}th from the Array[0].", res);

        }

        public class Example_10_1____Using_arraysTester
        {
            public void Run()
            {
                int[] myIntArray = new int[10];

                //populate the array
                for (int i = 0; i < myIntArray.Length; i++)
                {
                    myIntArray[i] = 2*(i + 1);
                }
                //output the array
                for (int i = 0; i < myIntArray.Length; i++)
                {
                    Console.WriteLine("Value in index {0} is {1}.", i, myIntArray[i]);
                }
            }

            [Test]
            public void Main()
            {
                Example_10_1____Using_arraysTester t = new Example_10_1____Using_arraysTester();
                t.Run();
            }
        }




        // a simple class to store in the array
        public class Employee
        {
            public int EmpID { get; set; }

            public Employee(int empID)
            {
                EmpID = empID;
            }
        }

        public class Example_10_2____Arrays_and_Objects_Tester
        {
            [Test]
            public void Main()
            {
                Employee[] empArray;
                empArray = new Employee[3];
                // populate the arrays
                for (int i = 0; i < empArray.Length; i++)
                {
                    empArray[i] = new Employee(i + 1005);
                }

                // output array values
                Console.WriteLine("\nemployee IDs:");

                //foreach (var employee in empArray)
                //{
                //    Console.WriteLine(employee.EmpID);
                //}

                for (int i = 0; i < empArray.Length; i++)
                {
                    Console.WriteLine(empArray[i].EmpID);
                }
            }
        }


        public class Example_10_4____params_keyword_Tester
        {
            public void DisplayVals(params int[] intVals)
            {
                foreach (int i in intVals)
                {
                    Console.WriteLine("DisplayVals {0}", i);
                }
            }

            [Test]
            public void Main()
            {
                Example_10_4____params_keyword_Tester t = new Example_10_4____params_keyword_Tester();
                t.DisplayVals(5, 6, 7, 8);

                int[] explicitArray = new int[] {1, 2, 3, 4, 5};
                t.DisplayVals(explicitArray);
            }
        }


        public class Example_10_5____Rectangular_array_Tester
        {
            [Test]
            public void Main()
            {
                const int rows = 4;
                const int columns = 3;
                // declare a 4x3 integer array
                int[,] rectangularArray = new int[rows,columns];

                // populate the array
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        rectangularArray[i, j] = i*10 + j;
                    }
                }

                // report the contents of the array
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.WriteLine("rectangularArray[{0},{1}] = {2}", i, j, rectangularArray[i, j]);
                    }
                }
            }
        }


        public class Example_10_6____Initializing_multidimensional_arrays_Tester
        {
            [Test]
            public void Main()
            {
                const int rows = 4;
                const int columns = 3;
                // imply a 4x3 array
                int[,] rectangularArray_2 =
                    {
                        {0, 1, 2}, {3, 4, 5}, {6, 7, 8}, {9, 10, 11}
                    };


                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {

                        Console.WriteLine("rectangularArray_2[{0},{1}] = {2}", i, j, rectangularArray_2[i, j]);
                        //Console.Write("\t{0}", rectangularArray[i, j]);
                    }
                    Console.WriteLine();
                }

                // imply a 4x3x2 array
                int[,,] rectangularArray_3 =
                    {
                        {{0, 1}, {2, 3}, {4, 5}}, {{10, 11}, {12, 13}, {14, 15}}, {{20, 21}, {22, 23}, {24, 25}},
                        {{30, 31}, {32, 33}, {34, 35}}
                    };

                for (int o = 0; o < 4; o++)
                {

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {

                            Console.WriteLine("rectangularArray_3[{0},{1},{2}] = {3}", o, i, j,
                                              rectangularArray_3[o, i, j]);
                            //Console.Write("\t{0}", rectangularArray[i, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }



        public class Example_10_7____Jagged_arrays_Program
        {
            [Test]
            public void Main()
            {
                const int rows = 4;

                // declare the jagged array as 4 rows high
                int[][] jaggedArray = new int[rows][];

                // the first row has 5 elements
                jaggedArray[0] = new int[5];
                // a row with 2 elements
                jaggedArray[1] = new int[2];
                // a row with 3 elements
                jaggedArray[2] = new int[3];
                // the last row has 5 elements
                jaggedArray[3] = new int[5];
                // Fill some (but not all) elements of the rows
                jaggedArray[0][3] = 15;
                jaggedArray[1][1] = 12;
                jaggedArray[2][1] = 9;
                jaggedArray[2][2] = 99;
                jaggedArray[3][0] = 10;
                jaggedArray[3][1] = 11;
                jaggedArray[3][2] = 12;
                jaggedArray[3][3] = 13;
                jaggedArray[3][4] = 14;

                int cc = 0;
                foreach (var i in jaggedArray[0])
                {
                    Console.WriteLine("jaggedArray[0][{0}] = {1}", cc, i);
                    cc++;
                }
                cc = 0;
                foreach (var i in jaggedArray[1])
                {
                    Console.WriteLine("jaggedArray[1][{0}] = {1}", cc, i);
                    cc++;
                }
                cc = 0;
                foreach (var i in jaggedArray[2])
                {
                    Console.WriteLine("jaggedArray[2][{0}] = {1}", cc, i);
                    cc++;
                }
                cc = 0;
                foreach (var i in jaggedArray[3])
                {
                    Console.WriteLine("jaggedArray[3][{0}] = {1}", cc, i);
                    cc++;
                }

                Console.WriteLine("");

                for (int cnt = 0; cnt < 4; cnt++)
                {
                    int c = 0;
                    foreach (var i in jaggedArray[cnt])
                    {
                        Console.Write("[{0}][{1}] = {2}\t", cnt, c, i);
                        c++;
                    }
                    Console.WriteLine();
                }
            }
        }


        public class Example_10_8____Sorting_and_Reversing_Arrays_Tester
        {
            public void PrintMyArray(string[] theArray)
            {
                int cnt = 0;
                foreach (string str in theArray)
                {
                    Console.WriteLine("Value[{0}]: {1}", cnt, str);
                    cnt++;
                }
                Console.WriteLine("\n");
            }


            [Test]
            public void test_debug()
            {
                int ArraySize = 10;
                int[] myIntArray = new int[ArraySize];

                for (int i = 0; i < myIntArray.Length; i++)
                {
                    Console.WriteLine("Init Value in index {0} is {1}.", i, myIntArray[i]);
                }

                //populate the array
                for (int i = 0; i < myIntArray.Length; i++)
                {
                    myIntArray[i] = 2*(i + 1);
                }

                //output the array
                for (int i = 0; i < myIntArray.Length; i++)
                {
                    Console.WriteLine("Value in index {0} is {1}.",
                                      i, myIntArray[i]);
                }
            }

            [Test]
            public void Main()
            {
                String[] myArray =
                    {
                        "Proust", "Faulkner", "Mann", "Hugo"
                    };
                Console.WriteLine("The original array:");
                PrintMyArray(myArray);

                // Reverse( ) : Overloaded public static method that reverses the order of the elements in a onedimensional array
                Array.Reverse(myArray);
                Console.WriteLine("The reversed array:");
                PrintMyArray(myArray);

                String[] myOtherArray =
                    {
                        "We", "Hold", "These", "Truths",
                        "Town", "Zoo", "Truths", "To", "Be",
                    };
                Console.WriteLine("The original array:");
                PrintMyArray(myOtherArray);

                // Copy( ) : Overloaded public static method that copies a section of one array to another array
                // Length : Public property that returns the length of the array
                String[] myCopiedArray = new string[myOtherArray.Length];
                Array.Copy(myOtherArray, myCopiedArray, myOtherArray.Length);
                Console.WriteLine("The copied array:");
                PrintMyArray(myCopiedArray);

                // Sort( ) : Overloaded public static method that sorts the values in a one-dimensional array
                Array.Sort(myOtherArray);
                Console.WriteLine("The sorted array:");
                PrintMyArray(myOtherArray);

                Console.WriteLine("The current array:");
                PrintMyArray(myCopiedArray);

                // BinarySearch( ) : Overloaded public static method that searches a one-dimensional sorted array
                int res = Array.BinarySearch(myCopiedArray, "Truths");
                Console.WriteLine("The BinarySearch Of array:");
                Console.WriteLine("The finding value (Truths) is {0}th in the current Array.\n", res);

                // IndexOf( ) : Overloaded public static method that returns the index (offset) of the first instance of a value in a one-dimensional array
                int idx = Array.IndexOf(myCopiedArray, "Truths");
                Console.WriteLine("The Index Of array:");
                Console.WriteLine("The finding value (Truths) is {0}th in the current Array.\n", idx);

                // LastIndexOf( ) : Overloaded public static method that returns the index of the last instance of a value in a one-dimensional array
                int lastidx = Array.LastIndexOf(myCopiedArray, "Truths");
                Console.WriteLine("The Last Index Of array:");
                Console.WriteLine("The finding value (Truths) is {0}th IndexOf the current Array.\n", lastidx);

                // Clear( ) : Public static method that sets a range of elements in the array either to zero or to a null reference, depending on the element type
                Array.Clear(myCopiedArray, 0, myCopiedArray.Length);
                Console.WriteLine("The copied array was cleared:");
                PrintMyArray(myCopiedArray);



                //// Error...
                //// CreateInstance( ) : Overloaded public static method that instantiates a new instance of an array
                //string tmp = "shong,qa,test";
                //string[] instances = tmp.Split(',');
                //Array instlist = Array.CreateInstance(typeof(object), instances.Length);

                //object item;
                //for (int i = 0; i < instances.Length; i++)
                //{
                //    // create the object from the specification string
                //    Console.WriteLine("Creating instance of: {0}", instances[i]);
                //    item = Activator.CreateInstance(Type.GetType(instances[i]));
                //    instlist.SetValue(item, i);
                //}
                //Console.WriteLine("\nObjects and their default values:\n");
                //foreach (object o in instlist)
                //{
                //    Console.WriteLine("Type:     {0}\nValue:    {1}\nHashCode: {2}\n",
                //        o.GetType().FullName, o.ToString(), o.GetHashCode());
                //}







            }
        }

        public class DynamicInstanceList
        {
            private static string instanceSpec = "System.EventArgs;System.Random;" +
                                                 "System.Exception;System.Object;System.Version";

            [Test]
            public void Main()
            {
                string[] instances = instanceSpec.Split(';');
                Array instlist = Array.CreateInstance(typeof (object), instances.Length);
                object item;
                for (int i = 0; i < instances.Length; i++)
                {
                    // create the object from the specification string
                    Console.WriteLine("Creating instance of: {0}", instances[i]);
                    item = Activator.CreateInstance(Type.GetType(instances[i]));
                    instlist.SetValue(item, i);
                }
                Console.WriteLine("\nObjects and their default values:\n");
                foreach (object o in instlist)
                {
                    Console.WriteLine("Type:     {0}\nValue:    {1}\nHashCode: {2}\n",
                                      o.GetType().FullName, o.ToString(), o.GetHashCode());
                }
            }
        }
    }


    [TestFixture]
    public class Chapter_10_Excercises
    {
        public class Dog
        {
            private int weight;
            private string name;

            public Dog(string theName, int theWeight)
            {
                weight = theWeight;
                name = theName;
            }


            public int Weight
            {
                get { return weight; }
                set { weight = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }

        [Test]
        public void Excercise_10_1()
        {
            Dog[] dogs = new Dog[3];

            dogs[0] = new Dog("Milo", 26);
            dogs[1] = new Dog("Frisky", 10);
            dogs[2] = new Dog("Laika", 50);

            int cnt = 0;
            foreach (var dog in dogs)
            {
                Console.WriteLine("{0} .. Name : {1} / Weight : {2}", cnt, dog.Name, dog.Weight);
                cnt++;
            }
        }

        [Test]
        public void Excercise_10_2()
        {
            int[] myList = new int[10] {21, 32, 43, 44, 55, 16, 17, 38, 29, 11};

            Console.WriteLine("Original Array");
            int cnt = 0;
            foreach (var l in myList)
            {
                Console.WriteLine("{0} .. {1}", cnt, l);
                cnt++;
            }

            Array.Sort(myList);
            Array.Reverse(myList);

            Console.WriteLine("Sorted Array");
            cnt = 0;
            foreach (var l in myList)
            {
                Console.WriteLine("{0} .. {1}", cnt, l);
                cnt++;
            }
        }

        [Test]
        public void Excercise_10_3()
        {
            const int rows = 3;

            // declare and populate the dogs array
            Dog milo = new Dog("Milo", 26);
            Dog frisky = new Dog("Frisky", 10);
            Dog laika = new Dog("Laika", 50);
            Dog[] dogArray = {milo, frisky, laika};

            // declare the dogAwards array as 3 rows high
            string[][] dogAwardsArray = new string[rows][];

            // declare the rows
            dogAwardsArray[0] = new string[3];
            dogAwardsArray[1] = new string[1];
            dogAwardsArray[2] = new string[2];

            // Populate the rows
            dogAwardsArray[0][0] = "Best in Show";
            dogAwardsArray[0][1] = "Best of Breed";
            dogAwardsArray[0][2] = "Judge's Cup";
            dogAwardsArray[1][0] = "Best Toy Tog";
            dogAwardsArray[2][0] = "Best Working Dog";
            dogAwardsArray[2][1] = "Best Large Dog";

            // Output the contents
            for (int i = 0; i < dogAwardsArray.Length; i++)
            {
                Console.WriteLine("{0}'s awards: ", dogArray[i].Name);
                for (int j = 0; j < dogAwardsArray[i].Length; j++)
                {
                    Console.WriteLine("\t{0}", dogAwardsArray[i][j]);
                }
            }
        }

        [Test]
        public void Excercise_10_4()
        {
            const int rows = 8;
            const int columns = 8;
            string[,] chessboardArray = new string[rows, columns];

            // populate the chessboard array
            for (int i = 0; i < rows; i++)
            {
                // if row starts with a black square
                if ((i%2) == 0)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if ((j%2) == 0)
                        {
                            chessboardArray[i, j] = "black";
                        }
                        else
                        {
                            chessboardArray[i, j] = "white";
                        }
                    }
                }
                    // else row starts with a white square
                else
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if ((j%2) == 0)
                        {
                            chessboardArray[i, j] = "white";
                        }
                        else
                        {
                            chessboardArray[i, j] = "black";
                        }
                    }
                }
            }

            for (int i = 0; i < 8;i++)
            {
                for (int j = 0; j < 8; j++)
                    Console.Write(chessboardArray[i, j] + "\t");

                Console.WriteLine();
            }

            // ask the user for coordinates to test
            //Console.Write("Enter the row to test (1 through 8): ");
            string rowEntry = "3"; // Console.ReadLine();
            int testRow = Convert.ToInt32(rowEntry);
            
            //Console.Write("Enter the column to test (1 through 8): ");
            string colEntry = "8"; // Console.ReadLine();
            int testCol = Convert.ToInt32(colEntry);

            // output the value at those coordinates
            Console.WriteLine("The square at {0}, {1} is {2}.", testRow, testCol, chessboardArray[(testRow - 1), (testCol - 1)]);
        
        }


    
    
    }
}
