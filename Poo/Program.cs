// See https://aka.ms/new-console-template for more information
using System;
using dio.src.entites;


namespace dio
{
    class program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 42, 749, 72);
            Ninja ninja = new Ninja("Wedge", 42, 574, 89);
            WhiteWizard whitewizard = new WhiteWizard("Jenica", 42, 601, 482);
            BlackWizard blackwizard = new BlackWizard("Topapa", 42, 385, 641);

            Console.WriteLine(knight.Attack());
            Console.WriteLine(knight.Attack(5));
            Console.WriteLine(knight.Attack(7));
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(ninja.Attack(5));
            Console.WriteLine(ninja.Attack(7));
            Console.WriteLine(whitewizard.Attack());
            Console.WriteLine(whitewizard.Attack(5));
            Console.WriteLine(whitewizard.Attack(7));
            Console.WriteLine(blackwizard.Attack());
            Console.WriteLine(blackwizard.Attack(5));
            Console.WriteLine(blackwizard.Attack(7));

        }
    }
}











