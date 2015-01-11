using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Package1;
using Package2;
using Package3;

namespace ProjectA
{
    public class ModuleBinding : NinjectModule
    {
        public override void Load()
        {
            Bind<IInterfaceSomething>().To<ClassM>();
            Bind<IA>().To<ClassA>();
            Bind<IK>().To<ClassK>();
            Bind<IL>().To<ClassL>();
            Bind<IT>().To<ClassT>();
            Bind<IX>().To<ClassX>();
            Bind<IJ>().To<ClassJ>();
            Bind<IP>().To<ClassP>();
            Bind<IG>().To<ClassG>();
            Bind<IR>().To<ClassR>();
            Bind<IS>().To<ClassS>();
            Bind<IY>().To<ClassY>();

        }
    }
}
