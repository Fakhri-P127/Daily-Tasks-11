using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Enter the Print type you want to see(pdf,excel,word)");
                MainPrintFile mainPrintFile = new MainPrintFile();
                Console.WriteLine("If You want to exit the program Press 0. If not then press any other digit");
                string numStr = Console.ReadLine();
                num = int.Parse(numStr);
            } while (num !=0);
           
                          
            
           
        }
    }
}
