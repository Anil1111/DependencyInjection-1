using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class HelloWorld
    {
        IKernal ikernal = null;

        public HelloWorld(IKernal ikernal)
        {
            this.ikernal = ikernal;
        }

        public void message(string message)
        {
            this.ikernal.Hello(message);
        }
    }
}
