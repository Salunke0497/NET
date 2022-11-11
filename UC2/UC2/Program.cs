using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxmin
{
    internal class maxmin
    {
        static void Main(string[] args)
        {
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int c=Convert.ToInt32(Console.ReadLine());
            int d=Convert.ToInt32(Console.ReadLine());
            int e=Convert.ToInt32(Console.ReadLine());
            int x = Math.Min(a, b, c, d, e);
            int y= Math.Max(a, b, c, d, e);
            Console.WriteLine("minimum number is" + x);
            Console.WriteLine("maximum number is" + y);
            Console.ReadLine();
        }
    }
}
