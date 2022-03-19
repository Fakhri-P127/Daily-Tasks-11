using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class PDF : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Printed PDF");
        }
    }
}
