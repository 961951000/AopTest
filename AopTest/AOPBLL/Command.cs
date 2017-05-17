using System;

namespace AopTest.AOPBLL
{
    public class Command : ICommand
    {
        public void Execute()
        {
            Console.Out.WriteLine("Command.Execute");
        }

        public void UnExecute()
        {
            Console.Out.WriteLine("Command.UnExecute");
        }
    }
}
