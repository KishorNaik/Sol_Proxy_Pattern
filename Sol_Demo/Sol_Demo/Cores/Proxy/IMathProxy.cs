using Sol_Demo.Cores.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Demo.Cores.Proxy
{
    public interface IMathProxy : IAdd, ISub, IMul, IDiv
    {
    }
}