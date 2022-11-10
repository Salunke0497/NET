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
            Console.WriteLine("roll number\n" +random.Next(1,10));           
            Console.ReadLine();     
        }
    }
}
