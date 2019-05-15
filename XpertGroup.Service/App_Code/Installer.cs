using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

/// <summary>
/// Descripción breve de Installer
/// </summary>
public class Installer:IWindsorInstaller
{
    public void Install(IWindsorContainer container, IConfigurationStore store)
    {
        container.Install(new XpertGroup.Business.Windsor.Installer(), new XpertGroup.Utils.Windsor.Installer());
    }
}