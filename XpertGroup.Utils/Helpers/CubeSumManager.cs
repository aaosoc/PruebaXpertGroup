using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpertGroup.Utils.Helpers
{
    public class CubeSumManager : ICubeSumManager
    {
        private readonly IProcessOperationsCubeSum processCubeSum;

        public CubeSumManager(IProcessOperationsCubeSum processCubeSum)
        {
            this.processCubeSum = processCubeSum;
        }
        public string GetResultCubeSum(string[] data)
        {
            int CurrentLine = 0;           
            string response="";
            int cases = int.Parse(data[CurrentLine++]);
            for (int i = 0; i < cases; i++)
            {
                var infoCases = data[CurrentLine++].Split(' ');
                int size = int.Parse(infoCases[0]);
                int operations = int.Parse(infoCases[1]);
                processCubeSum.CreateMatrix(size);

                for (int j = 0; j < operations; j++)
                {
                    string Operation = data[CurrentLine++];                    
                    var operationArray = Operation.Split(' ');
                    string typeOperation = operationArray[0];

                    if (typeOperation == "UPDATE")
                    {
                        processCubeSum.OperationUpdate(int.Parse(operationArray[1]) - 1, int.Parse(operationArray[2]) - 1, int.Parse(operationArray[3]) - 1, int.Parse(operationArray[4]));
                    }
                    if (typeOperation.Equals("QUERY"))
                    {
                        var result = processCubeSum.OperationQuery(int.Parse(operationArray[1]) - 1, int.Parse(operationArray[2]) - 1, int.Parse(operationArray[3]) - 1, int.Parse(operationArray[4]) - 1, int.Parse(operationArray[5]) - 1, int.Parse(operationArray[6]) - 1);
                        response = response + result.ToString();
                    }
                }
            }

            return response;
        }
    }
}
