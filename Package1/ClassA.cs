using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Package2;
namespace Package1
{
    public class ClassA : IA
    {
        IS objs;
        IY objy;
        public void Setsy(IS obs, IY oby)
        {
            objs = obs;
            objy = oby;
        }

        public void Method1()
        {

        }

        public void Method2()
        {
            if (objs != null)
            {
                objs.Method3();
                objs.Method1();
            }
        }

        public void Method3()
        {
            if (objy != null)
            {
                objy.Method2();
            }
        }
    }
}
