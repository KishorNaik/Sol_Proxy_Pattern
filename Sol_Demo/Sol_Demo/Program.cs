using Sol_Demo.Business.Proxy;
using Sol_Demo.Cores.Proxy;
using System;
using System.Threading.Tasks;

namespace Sol_Demo
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IMathProxy mathProxy = new MathProxy();

            var result = await mathProxy.Add(2, 2);
            Console.WriteLine($"Add : {result}");

            result = await mathProxy.Sub(4, 2);
            Console.WriteLine($"Sub : {result}");

            result = await mathProxy.Mul(2, 2);
            Console.WriteLine($"Mul : {result}");

            var resultDiv = await mathProxy.Div(10, 2);
            Console.WriteLine($"Div : {resultDiv}");
        }
    }
}