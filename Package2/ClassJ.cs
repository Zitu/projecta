using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassJ : IJ
    {
        IK objk;
        public void setk(IK obk)
        {
            objk = obk;
        }
        public void Method1()
        {
            if (objk != null)
            {
                objk.method1();
            }
        }
    }
}
