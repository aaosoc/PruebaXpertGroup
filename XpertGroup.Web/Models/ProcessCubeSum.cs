using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XpertGroup.Web.Models
{
    public class ProcessCubeSum
    {
        public string CubeSumProcess(string[] data)
        {
            string response = "";
            using (CubeSumService.ServiceClient client = new CubeSumService.ServiceClient())
            {
                 response = client.GetCubeSum(data);
            }

            return response;
        }
    }
}