using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
     class MainPrintFile
    {
        public MainPrintFile()
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "word":
                    Word word = new Word();
                    word.Print();
                    break;
                case "excel":
                    Excel excel = new Excel();
                    excel.Print();
                    break;
                case "pdf":
                    PDF pdf = new PDF();
                    pdf.Print();                   
                    break;
                default:
                    Console.WriteLine("enter valid input");
                    break;
            }
        }                
    }
}
