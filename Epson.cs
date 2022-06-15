﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    public class Epson : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public override void print()
        {
            Console.WriteLine("Epson printer printing...");
        }
    }
}
