using Sol_Demo.Cores.Concretes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Business.Concretes
{
    internal sealed class Div : IDiv
    {
        Task<double> IDiv.Div(int value1, int value2)
        {
            return Task.Run<double>(() => value1 / value2);
        }
    }
}