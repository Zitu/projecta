using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Package1;
namespace Package3
{
    public class ClassH
    {
        IG objg;
        public void Method2()
        {
            if (objg != null)
            objg.Method1();
        }
    }
}
