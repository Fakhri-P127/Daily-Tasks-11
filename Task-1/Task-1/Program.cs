using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First we choose Word:"); 
            MainPrintFile printFileWord = new Word();
            printFileWord.Print();
            Console.WriteLine("------------------------");
            Console.WriteLine("Then we choose Excel:");
            MainPrintFile printFileExcel = new Excel();
            printFileExcel.Print();
            Console.WriteLine("------------------------");
            Console.WriteLine("And lastly we choose PDF:");
            MainPrintFile printFilePdf = new PDF();
            printFilePdf.Print();          
        }
    }
}
