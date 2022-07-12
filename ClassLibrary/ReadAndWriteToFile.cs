using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
    public class ReadAndWriteToFile
    {
        string fileName = "data.txt";
        string _path;

        public string[] ReadFile()
        {
            _path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);

            string[] dataArray = File.ReadAllLines(_path);
            
            return dataArray;
        }


    }
}
