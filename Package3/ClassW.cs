using Package1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Package1;
namespace Package3
{
    public class ClassW
    {
        private IInterfaceSomething _something;
        IY objy;

        public ClassW(IInterfaceSomething something)
        {
            _something = something;
        }

        public int Method2()
        {
            if (objy != null)
            {
                return objy.Method2();
            }
            else return 0;
        }

        public void Method3()
        {
            _something.Method7();
            _something.Method8();
        }
    }
}
