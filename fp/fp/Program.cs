using System;

namespace fp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imię: "); //komentarz w jednej linii
            Console.WriteLine("Nazwisko: ");
            /*komentarz
             * w
             * wie
             * lu
             * liniach
             */

            string name = "Anna";
            Console.WriteLine("Masz na imię: " + name);
            Console.Write("Masz na imię: ");
            Console.WriteLine(name);

            Console.WriteLine("Masz na imię: {0}", name);

            int age = 20;
            sbyte age1 = 20;
            Console.WriteLine("Wiek: {0}, Imię: {1}", age, name);
            Console.ReadKey();
        }
    }
}
