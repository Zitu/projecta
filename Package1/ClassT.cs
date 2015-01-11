using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Package2;
namespace Package1
{
    public class ClassT : IT
    {
        IX objx;
        private ClassE e;
        IE obje;
        IE _ie;
        public void Sett()
        {
 
        }
        public ClassT(IE ie)
        {
            _ie = ie;
        }

        public void UseOfConstructort(IE obe)
        {
            ClassT t = new ClassT(obe);
        }

        public void Method2()
        {
            if ((objx != null) &&(_ie != null) )
            {
                objx.Method1();

                _ie.Method5();
            }
        }
    }
}
