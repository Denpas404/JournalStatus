using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Logic
    {

        public string[] splitDataArray(string[] dataArray)
        {
            string[] vs = new string[0];

            foreach (var item in dataArray)
            {
                vs = item.Split(';');

                return vs;
            }
            return null;
        }


    }
}
