using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dobro dosli u aplikaciju!");

            //Trazenje informacija o korisniku
            Person user = new Person();

            Console.Write("Unesite vase ime: ");
            user.ime = Console.ReadLine();

            Console.Write("Unesite vase prezime: ");
            user.prezime = Console.ReadLine();

            //Kreiranje korisnickog imena
            Console.WriteLine($"Vase korisnicko ime je: {user.ime.ToLower()}.{user.prezime.ToLower()}");
            Console.ReadLine();
        }
    }
}
