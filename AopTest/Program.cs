using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AopTest.AOPBLL;
using Spring.Context;
using Spring.Context.Support;

namespace AopTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            ICommand command = (ICommand)ctx["myCommand"];
            command.Execute();
            Console.Read();
        }
    }
}
