using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnit mu = new MilitaryUnit(3,5,1);
            SettlerUnit su = new SettlerUnit();

            mu.Move();
            Console.WriteLine(mu.Health);
            Console.WriteLine(mu.Cost);

            su.Move();
            Console.WriteLine(su.Health);
            Console.WriteLine(su.Cost);

            mu.Attack(su);
            Console.WriteLine(su.Health);
            Console.WriteLine(su.Cost);
        }
    }
}
