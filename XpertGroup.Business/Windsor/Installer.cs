using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XpertGroup.Business.Facade;

namespace XpertGroup.Business.Windsor
{
    public class Installer : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IFacadeCubeSum>()
                .ImplementedBy<FacadeCubeSum>()
                .LifestyleTransient());
        }
    }
}
