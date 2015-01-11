using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Package2;
namespace Package1
{

    public class ClassX : IX
    {
        IR objr;
        public void setr(IR obr)
        {
            objr = obr;
        }

        public void Method1()
        {
            if (objr != null)
            {
                objr.Method1();
            }
        }
    }
}
