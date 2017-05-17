using System;
using AopAlliance.Intercept;

namespace AopTest.Aspects
{
    class Interceptor : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            var beforeTime = DateTime.Now;
            Console.Out.WriteLine($"before invoke {invocation.Method.Name}:{beforeTime}");
            object result = invocation.Proceed();
            var afterTime = DateTime.Now;
            Console.Out.WriteLine($"after invoke {invocation.Method.Name}:{afterTime}");
            return result;
        }
    }
}
