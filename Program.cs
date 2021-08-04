using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Human1");
            Human human2 = new Human("Human2");
            human1.Attack(human2);
            Console.WriteLine($"The Health of each person is... {human1.Health} and {human2.Health} ");
        }
    }
}
