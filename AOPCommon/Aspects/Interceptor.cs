using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AopAlliance.Intercept;

namespace AOPCommon.Aspects
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
