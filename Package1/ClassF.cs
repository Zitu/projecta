using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Package2;
namespace Package1
{
    class ClassF
    {
        IA obja;
        public ClassF()
        {
        }

        public void Method1()
        {
            if (obja != null)
            {
                obja.Method2();
                obja.Method1();
            }
        }

        public void Method2()
        {
            if (obja != null)
            {
                obja.Method1();
            }
        }

        public void Method3()
        {
            if (obja != null)
            {
                obja.Method1();
            }
        }
    }
}
