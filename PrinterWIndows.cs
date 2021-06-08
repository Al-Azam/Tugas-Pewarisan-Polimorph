using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pewarisan_dan_Polimorphisme
{
    public class PrinterWIndows
    {
        public virtual void Show() 
        {
            Console.WriteLine("\nWindows Printer Dimension");
        }
        public virtual void Print() 
        {
            Console.WriteLine("\nWindows Printer Printing....");        
        }
    }

    public class Epson : PrinterWIndows
    {
        public override void Show()
        {
            Console.WriteLine("\nEpson display dimention : 10*11");
        }
        public override void Print()
        {
            Console.WriteLine("\nEpson Printer Printing....");
        }
    }
    public class Canon : PrinterWIndows 
    {
        public override void Show()
        {
            Console.WriteLine("\nCanon display dimention : 9.5*12");
        }
        public override void Print()
        {
            Console.WriteLine("\nCanon Printer Printing....");
        }
    }
    public class LaserJet : PrinterWIndows
    {
        public override void Show()
        {
            Console.WriteLine("\nLaserJet display dimention : 12*12");
        }
        public override void Print()
        {
            Console.WriteLine("\nLaserJet Printer Printing....");
        }

    }
}
