using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate int calculator(int n);
namespace Delegates
{
    internal class Program
    {
        static int number = 100;
        public static int add(int n)
        {
            number += n;
            return number;
        }
        public static int mul(int n)
        {
            number *= n;
            return number;
        }
        public static int display()
        {
            return number;
        }
        static void Main(string[] args)
        {
            calculator o1 = new calculator(add);
            calculator o2 = new calculator(mul);
            o1(10);
            o2(20);
            Console.WriteLine(display());
        }
    }
}
