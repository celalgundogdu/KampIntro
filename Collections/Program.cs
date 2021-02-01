using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Atiba", "Josef", "Aboubakar", "Rachid" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5]; // yeni adres olusur ve onceki verilere ulasılamaz
            //names[4] = "";
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]); // null


            List<string> names2 = new List<string> { "Atiba", "Josef", "Aboubakar", "Rachid" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Rosier");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);  


            Console.Read();
        }
    }
}
