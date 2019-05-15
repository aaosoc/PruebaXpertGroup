using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XpertGroup.Utils.Helpers;
using XpertGroup.Utils.Log;

namespace XpertGroup.Business.Facade
{
    public class FacadeCubeSum : IFacadeCubeSum
    {

        IProcessOperationsCubeSum validations;
        ICubeSumManager cubeManager;

        public FacadeCubeSum(IProcessOperationsCubeSum validations, ICubeSumManager cubeManager)
        {
            this.validations = validations;
            this.cubeManager = cubeManager;
        }
        public string GetDataSumCube(string[] data)
        {
            string response = "";

            if (data != null && data.Length > 0)
            {
                try
                {
                    response = cubeManager.GetResultCubeSum(data);
                }
                catch (Exception exception)
                {
                    LogService.Default.Error("Error", exception);
                }
            }
           
            return response;
        }
    }
}
