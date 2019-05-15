using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Castle.Windsor;
using XpertGroup.Business.Facade;

namespace XpertGroup.Test
{
    [TestClass]
    public class CubeSumTest
    {
        private WindsorContainer container;
        private readonly IFacadeCubeSum facade;
        public CubeSumTest()
        {
            this.container = new WindsorContainer();
            container.Install(new Windsor.Installer());

            this.facade = this.container.Resolve<IFacadeCubeSum>();
        }

        [TestMethod]
        public void TestCubeSum()
        {
            string[] request = CreateInputArray();
            string responseService = facade.GetDataSumCube(request);

            Assert.AreEqual(responseService, "4427011");
        }

        [TestMethod]
        public void TestCubeSumNull()
        {
            string responseService = facade.GetDataSumCube(null);

            Assert.AreEqual(responseService, "");
        }

        [TestMethod]
        public void TestCubeSumEmpty()
        {
            string[] request = new string[] { };
            string responseService = facade.GetDataSumCube(request);

            Assert.AreEqual(responseService, "");
        }

        private string[] CreateInputArray()
        {
            string[] data = new string[] { "2", "4 5", "UPDATE 2 2 2 4", "QUERY 1 1 1 3 3 3", "UPDATE 1 1 1 23", "QUERY 2 2 2 4 4 4",
            "QUERY 1 1 1 3 3 3","2 4","UPDATE 2 2 2 1","QUERY 1 1 1 1 1 1","QUERY 1 1 1 2 2 2","QUERY 2 2 2 2 2 2"};

            return data;
        }
    }
}
