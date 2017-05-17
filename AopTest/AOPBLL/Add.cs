using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AopTest.AOPBLL
{
    public class Add : IAdd
    {
        public void Run()
        {
            Console.WriteLine("Run...");
        }
    }
}
