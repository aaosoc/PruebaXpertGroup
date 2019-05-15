using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XpertGroup.Web.Models;

namespace XpertGroup.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string GetCubeSum(string[] data)
        {
            ProcessCubeSum cubeSum = new ProcessCubeSum();
            string response = cubeSum.CubeSumProcess(data);

            return response;
        }
    }
}