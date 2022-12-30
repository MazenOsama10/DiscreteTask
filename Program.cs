using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int firstnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end number");
            int endnum = int.Parse(Console.ReadLine());
            Boolean f=true;
            for (int i = firstnum; i <= endnum; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        f = false;
                        break;
                    }
                    else
                    {
                        f = true;
                        continue;
                    }
                }
                if (f == true)
                    Console.WriteLine(i);
            }
             
        }
    }
}
