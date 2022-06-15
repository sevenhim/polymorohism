using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
     public class PrinterWindows
    {
        public virtual void show()
        {
            Console.WriteLine(" Printer Display dimension :");
        }
        public virtual void print()
        {
            Console.WriteLine("Printer printing...");
        }
    }
}
