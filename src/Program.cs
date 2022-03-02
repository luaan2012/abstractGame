using System;
using Jogos_em_obj.src.Entities;

namespace Jogos_em_obj
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus",23,"Knight \n");
            WhiteWizard wizard = new WhiteWizard("Jessica",55,"White Wizard");


            Console.WriteLine(knight.Attack(15));
            Console.WriteLine(wizard.Attack(15));

        }
    }
}
