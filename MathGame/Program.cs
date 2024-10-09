using System;
using System.Security.Cryptography.X509Certificates;
using static System.Formats.Asn1.AsnWriter;
using MathGame;     // so I can use the internal classes in the project

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            string name = GetName();

            menu.ShowMenu(name);       // using the Menu menu object to call the ShowMenu(); method.

        }

        static string GetName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        

    }
}
