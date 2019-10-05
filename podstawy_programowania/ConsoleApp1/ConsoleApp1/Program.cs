using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //komentarz
            Console.Write("Imię: ");//wyswietli Imie:
            Console.WriteLine("Janusz");
            /*Komentarz w wielu
             * liniach
            */
            Console.WriteLine("\n#\n##\n###\n####");

            string name;
            name = "Kasia";
            // + kontatenacja
            Console.WriteLine("Masz na imie: " + name);

            Console.WriteLine("Masz na imie: {0}", name);

            int age = 20;
            Console.WriteLine("Masz na imie: {0}, wiek:{1}", name, age);

            sbyte age1 = 20;
            Console.WriteLine("Masz na imie: {0}, wiek:{1}", name, age1);
            /*
             uzytkownik podaje z klawiatury dlugosc boku oblicz pole kwadratu
             */

            Console.WriteLine("\nPodaj bok a: ");
            string a = Console.ReadLine();
            Console.WriteLine("Bok a wynosi: {0}", a);

            double results = double.Parse(a) * double.Parse(a);
            Console.WriteLine("Pole kwadratu wynosi: {0}", result);

            /*
       Oblicz pole trojkata
       dane podaje uzytkownik z klawiatury
     * */

            Console.WriteLine("\nPodaj wysokosc ");
            string h = Console.ReadLine();
            Console.WriteLine("Podaj bok ");
            string a = Console.ReadLine();
            double results = (double.Parse(a) * double;.Parse(h)/2);
            Console.WriteLine("Pole trojkata wynosi: {0}", result);

            uint x = 10;
            Console.WriteLine(x);

            float y = 14.55F;




            Console.ReadKey();
        }
    }
}
