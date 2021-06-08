using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pewarisan_dan_Polimorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWIndows printer = new PrinterWIndows();

            Console.WriteLine("\nPilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("\nNomor Printer [1..3] :");
            int noPrinter = Convert.ToInt32(Console.ReadLine());

            if (noPrinter == 1)
                printer = new Epson();
            else if (noPrinter == 2)
                printer = new Canon();
            else
                printer = new LaserJet();

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
