using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <=5; i++)
            {
                for (int j = 1; j <=5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}
