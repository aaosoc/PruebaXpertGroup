using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XpertGroup.Utils.Helpers;

namespace XpertGroup.Utils.Windsor
{
    public class Installer : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IProcessOperationsCubeSum>()
               .ImplementedBy<ProcessOperationsCubeSum>().LifestyleTransient());

            container.Register(Component.For<ICubeSumManager>()
              .ImplementedBy<CubeSumManager>().LifestyleTransient());
        }
    }
}
