using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitdemoproj
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("adding a new line");
            Program p=new Program();
            p.sayHello();
            p.PrintWelcome();
        }
    }
}
