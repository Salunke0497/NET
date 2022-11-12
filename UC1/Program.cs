using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace UC1
{
    internal class attendance
    {
        static void Main(string[] args)
        {
            Random random = new Random();
                int x = 1;
                int empcheck = random.Next(0, 1);
                if (empcheck == x)
                {
                    Console.WriteLine("emp present");
                }
                else
                {
                    Console.WriteLine("emp absent");
                }
                Console.ReadLine();
        }
    }

}
