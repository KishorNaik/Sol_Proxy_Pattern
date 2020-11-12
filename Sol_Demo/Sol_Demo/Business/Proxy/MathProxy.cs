using Sol_Demo.Business.Concretes;
using Sol_Demo.Cores.Concretes;
using Sol_Demo.Cores.Proxy;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sol_Demo.Business.Proxy
{
    public class MathProxy : IMathProxy
    {
        async Task<int> IAdd.Add(int value1, int value2)
        {
            IAdd addObj = new Add();
            return await addObj.Add(value1, value2);
        }

        async Task<double> IDiv.Div(int value1, int value2)
        {
            IDiv divObj = new Div();
            return await divObj.Div(value1, value2);
        }

        async Task<int> IMul.Mul(int value1, int value2)
        {
            IMul mulObj = new Mul();
            return await mulObj.Mul(value1, value2);
        }

        async Task<int> ISub.Sub(int value1, int value2)
        {
            ISub subObj = new Sub();
            return await subObj.Sub(value1, value2);
        }
    }
}