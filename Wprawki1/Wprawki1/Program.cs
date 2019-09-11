using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wprawki1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = (float)0.1;
            float y = 0.1f;

            float suma = 0;

            for (int i = 1; i <= 1000000; i++)
            {
                suma = suma + x;
            }
            Console.WriteLine(suma);
        


           
        }

    }
}
