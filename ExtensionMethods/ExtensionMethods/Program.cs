using System;
using ExtensionMethods;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Capital letter 
            Console.Write("Please enter your string: ");
            string str = Console.ReadLine();
            Console.WriteLine(str.StartWithCapitalLetter());
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(str.Pluralize());
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(str.CapitalizeWord());
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(str.CapitalizeAndPluralize());
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(str.CharCounter());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.Write("Please enter the price without VAT: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(amount.ApplyVAT());
            Console.WriteLine("----------------------------------------------------------------------------------------");


        }





    }

}
