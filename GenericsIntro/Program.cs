using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---List---");
            MyList<string> names = new MyList<string>();
            names.Add("Ati");
            names.Add("Abu");

            Console.WriteLine(names.Length);

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("---Dictionary---");
            MyDictionary<int, string> players = new MyDictionary<int, string>();
            players.Add(2, "Rosier");
            players.Add(24, "Vida");
            players.Add(4, "Montero");

            players.print();

            players.Add(4, "Welinton");

            players.print();

            Console.Read();
        }
    }
}
