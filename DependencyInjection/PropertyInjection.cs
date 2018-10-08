using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{

    class PropertyInjection
    {
        IKernal kernal = null;

        // property injection
        public IKernal Kernal
        {
            get
            {
                return kernal;
            }
            set
            {
                kernal = value;
            }
        }

        public void Hello(string message)
        {
            kernal.Hello(message);
        }
    }
}
