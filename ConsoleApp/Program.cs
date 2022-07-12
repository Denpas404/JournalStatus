using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Logic logic = new Logic();
            ReadAndWriteToFile readAndWriteToFile = new ReadAndWriteToFile();

            foreach (var item in logic.splitDataArray(readAndWriteToFile.ReadFile()))
            {
                Console.WriteLine(item);
            }




            Console.ReadKey();
        }
    }
}
