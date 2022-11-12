using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int emp_full_time = 1;
            int emp_rate_per_hour = 20;
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck==emp_full_time)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = (emphrs * emp_rate_per_hour);
            Console.WriteLine("empwage" + empwage);
            Console.ReadLine();
        }
    }
}
