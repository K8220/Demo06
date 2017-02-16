using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedostotA
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "0";
            string line = "1";
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter("test.txt");


            while (!line.Equals(x))
            {
                Console.Write("Gimme a line, end line with 'enter', 0 to end program : ");
                line = Console.ReadLine();
                if (line.Equals(x))
                {
                    break;
                }
                outputFile.WriteLine(line);
            }
            outputFile.Close();
            
            string text = System.IO.File.ReadAllText(@"D:\K8220\olio\Demo06\TiedostotA\bin\Debug\test.txt");
            Console.WriteLine("\nContents of test.txt:\n" + text);
        }
    }
}
