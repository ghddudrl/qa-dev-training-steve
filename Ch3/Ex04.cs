using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DevTraining
{
    [TestFixture]
    public class Ex04
    {
        [Test]
        public void Ex41()
        {
            int x = 25;
            int y = 5;

            Console.Out.WriteLine("int x + y = {0}", x + y);
            Console.Out.WriteLine("int x - y = {0}", x - y);
            Console.Out.WriteLine("int x * y = {0}", x * y);
            Console.Out.WriteLine("int x / y = {0}", x / y);
            Console.Out.WriteLine("int x % y = {0}", x % y);
        }

        [Test]
        public void Ex42()
        {
            int varA = 5;
            int varB = ++varA;
            int varC = varB++;
            Console.WriteLine("A: {0}, B: {1}, C: {2}", varA, varB, varC);  // A: 6, B: 7, C: 6
        }

        //enum Person : int { Abby = 135, Bob = 175, Charlie = 55, Dawn = 45 };
        [Test]
        public void Ex43()
        {
            int passengers = 2;
            const int minWeightLimit = 100;
            const int maxWeightLimit = 300;
            int family = 4;

            const int Abby = 135;
            const int Bob = 175;
            const int Charlie = 55;
            const int Dawn = 45;

            int weight1;
            int weight2;
            bool canRide;

            // Abby + Bob
            weight1 = Abby;
            weight2 = Bob;
            canRide = ((weight1 + weight2) > minWeightLimit) && ((weight1 + weight2) <= maxWeightLimit);
            Console.WriteLine("Abby and Bob can ride? {0}", canRide);

            // Abby + Charlie
            weight1 = Abby;
            weight2 = Charlie;
            canRide = ((weight1 + weight2) > minWeightLimit) && ((weight1 + weight2) <= maxWeightLimit);
            Console.WriteLine("Abby and Charlie can ride? {0}", canRide);

            // Abby + Dawn
            weight1 = Abby;
            weight2 = Dawn;
            canRide = ((weight1 + weight2) > minWeightLimit) && ((weight1 + weight2) <= maxWeightLimit);
            Console.WriteLine("Abby and Dawn can ride? {0}", canRide);

            // Bob + Charlie
            weight1 = Bob;
            weight2 = Charlie;
            canRide = ((weight1 + weight2) > minWeightLimit) && ((weight1 + weight2) <= maxWeightLimit);
            Console.WriteLine("Bob and Charlie can ride? {0}", canRide);
            
            // Bob + Dawn
            weight1 = Bob;
            weight2 = Dawn;
            canRide = ((weight1 + weight2) > minWeightLimit) && ((weight1 + weight2) <= maxWeightLimit);
            Console.WriteLine("Bob and Dawn can ride? {0}", canRide);
            
            // Charlie + Dawn
            weight1 = Charlie;
            weight2 = Dawn;
            canRide = ((weight1 + weight2) > minWeightLimit) && ((weight1 + weight2) <= maxWeightLimit);
            Console.WriteLine("Charlie and Dawn can ride? {0}", canRide);
        }

        [Test]
        public void Ex44()
        {
            const float Pi = 3.14159f;
            const float radius = 5f;

            float surfaceArea = 4f * Pi * (radius * radius);
            float volume = (4f / 3f) * Pi * (radius * radius * radius);

            Console.WriteLine("Surface area: {0}", surfaceArea);
            Console.WriteLine("Volume: {0}", volume);
            
            var result = (volume > surfaceArea) ? "positive" : "negative";

            Console.WriteLine("Volume is greater than Surface area ? : {0}", result);

        }

        [Test]
        public void Ex45()
        {
            int passengers = 2;
            const int minWeightLimit = 100;
            const int maxWeightLimit = 300;
            int family = 4;

            const int Abby = 135;
            const int Bob = 175;
            const int Charlie = 55;
            const int Dawn = 45;

            List<int> list1 = new List<int>();

            list1.Add(Abby);
            list1.Add(Bob);
            list1.Add(Charlie);
            list1.Add(Dawn);




            List<Member> list = new List<Member>();

            Member m1 = new Member();
            m1.Set("Abby", Abby);
            list.Add(m1);

            Member m2 = new Member();
            m2.Set("Bob", Bob);
            list.Add(m2);

            Member m3 = new Member();
            m3.Set("Charlie", Charlie);
            list.Add(m3);

            Member m4 = new Member();
            m4.Set("Dawn", Dawn);
            list.Add(m4);

            foreach (var i in list)
            {
                foreach (var m in list)
                {
                    var sum = i.getWeight() + m.getWeight();
                    
                    bool tmp = ((sum > 100) && (sum <= 300)) ? true : false;

                    if (tmp == true)
                    {
                        if (i.getName() != m.getName())
                            Console.WriteLine("out name = {0}, out weight = {1} and inner name = {2}, inner weight = {3} ==> sum is {4}",i.getName(), i.getWeight(), m.getName(), m.getWeight(), i.getWeight() + m.getWeight());

                    }
                }
                //Console.WriteLine("name = {0}, weight = {1} and", i.getName(), i.getWeight());
            }
        }
    }


    class Member
    {
        private string name;
        private int weight;

        public Member()
        {
            string name;
            int weight;
        }

        public void Set (string n, int w)
        {
            this.name = n;
            this.weight = w;
        }
        
        public string getName()
        {
            return this.name;
        }

        public int getWeight()
        {
            return this.weight;
        }
    }
}
