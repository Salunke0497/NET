using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    internal class multiplication
    {
        static void Main(string[] args)
        {
            int a, b, r;
            Console.WriteLine("enter first number here");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter sec number here");
            b=Convert.ToInt32(Console.ReadLine());
            r = (a*b);
            Console.WriteLine("answer is" + r);
            Console.ReadLine();
        }
    }
}
