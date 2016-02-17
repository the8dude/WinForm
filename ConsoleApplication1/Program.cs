using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = ((Convert.ToInt32(50000)) * ((7 / 12) / (1 - (1 + (7 / 12)) ^ -20)));
            Console.WriteLine(N);
        }
    }
}
