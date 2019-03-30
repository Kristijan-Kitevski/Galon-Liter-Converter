using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMetods
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool runing = true;

            while (runing)
            {
                   Console.WriteLine("-------------------------------------");
                   Console.WriteLine("Select The convertor direction");
                   Console.WriteLine("1 Galons to liters");
                   Console.WriteLine("2 Liters to galon");
                   Console.WriteLine("3 Exit Converter");
                   Console.WriteLine("-------------------------------------");

                   string selection = Console.ReadLine();

                    switch (selection)
                    {
                        case "1":
                            Console.WriteLine("Enter galons to convert");
                            double liters = Converter.GalonToLiter(Console.ReadLine());
                            Console.WriteLine($"{liters} Liters");
                            break;
                        case "2":
                            Console.WriteLine("Enter Liters to convert");
                            double galons = Converter.LiterToGalion(Console.ReadLine());
                            Console.WriteLine($"{galons} galons");
                            break;
                        case "3":
                            Console.WriteLine("Press enter to exit");
                               runing = false;
                            break;
                    }
               
            }
            Console.Read();
        }

    }
}
