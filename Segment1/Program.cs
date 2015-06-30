using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segment1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3==0 && i% 5==0)
                {
                    Console.WriteLine("SupportTraining");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Training");
                }
                else if (i % 5 == 0)
                { Console.WriteLine("Support"); }
                else
                {
                     Console.WriteLine(i.ToString());
                }
            }
            Console.Read();



        }
    }
}
