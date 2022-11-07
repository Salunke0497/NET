using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    internal class human
    {
        public static void Main(string[] args)
        {
            int x;
            string personName;
            int phoneNum;
            Console.WriteLine("enter number");
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter person name");
            personName=Console.ReadLine();
            Console.WriteLine("enter phone number");
            phoneNum= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x={0}\n personName={1}\n phoneNum={2}",x,personName,phoneNum);
            Console.ReadLine();
        }
    }
}
