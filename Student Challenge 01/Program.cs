using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Challenge_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string strUserName = Console.ReadLine();
            Console.WriteLine("Hello " + strUserName);
            Console.ReadKey();
        }
    }
}
