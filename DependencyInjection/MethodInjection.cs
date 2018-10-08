using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class MethodInjection
    {
        IKernal kernal = null;

        public void Test(IKernal kernal, string msg)
        {
            this.kernal = kernal;
            kernal.Hello(msg);
        }

    }
}
