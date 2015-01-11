using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Package2;
namespace Package1
{
    public class ClassD
    {
        IA obja;
        public ClassD(IA oba)
        {
            obja = oba;
        }

        public void Method1()
        {
            if (obja != null)
            {
                obja.Method1();
            }
        }
    }
}
