using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Package2;
namespace Package1
{
    public class ClassL : IL
    {
        IP objp;
        
        public ClassL(IP obp)
        {
            objp = obp;
        }


        public void Method1()
        {
            if (objp != null)
            {
                objp.Method10();
            }
        }
    }
}
