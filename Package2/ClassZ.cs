using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassZ
    {
        IJ objj;
        IQ objq;
        public void Method2()
        {
            if (objj != null && objq != null)
            {
                objj.Method1();
                objq.method3();
            }
        }
    }
}
