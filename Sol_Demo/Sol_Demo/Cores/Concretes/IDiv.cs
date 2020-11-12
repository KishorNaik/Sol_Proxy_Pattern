using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Cores.Concretes
{
    public interface IDiv
    {
        Task<double> Div(int value1, int value2);
    }
}