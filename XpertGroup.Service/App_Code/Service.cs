using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Castle.Windsor;
using XpertGroup.Business.Facade;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class Service : IService
{
    private WindsorContainer container;
    private readonly IFacadeCubeSum facade;

    public Service()
    {
        this.container = new WindsorContainer();
        container.Install(new Installer());

        this.facade = this.container.Resolve<IFacadeCubeSum>();
    }
    public string GetCubeSum(string[] value)
	{
        return facade.GetDataSumCube(value);
	}
}
