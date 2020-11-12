using Sol_Demo.Cores.Concretes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Business.Concretes
{
    internal sealed class Add : IAdd
    {
        Task<int> IAdd.Add(int value1, int value2)
        {
            return Task.Run(() => value1 + value2);
        }
    }
}