﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    public class Canon : PrinterWindows
    {
        public override void show()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
        public override void print()
        {
            Console.WriteLine("Canon printer printing...");
        }
    }
}
