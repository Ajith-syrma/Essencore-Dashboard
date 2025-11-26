using Honeywell_Production_Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Honeywell_Production_Dashboard.Controllers
{
    public class DashBoardMasterController : Controller
    {
        private readonly Interface_DashBoard interface_DashBoard;
        private readonly DataManagement _OEEData;


        public DashBoardMasterController(Interface_DashBoard _interface_DashBoard, DataManagement OEEData)
        {
            interface_DashBoard = _interface_DashBoard;
            _OEEData = OEEData;
        }
        public IActionResult ProdcutionMaster()
        {
            CustomerMasterModel customerMasterModel = new CustomerMasterModel();
            customerMasterModel.Customers = interface_DashBoard.getCustomerName();
            var getProdcutiondettails = interface_DashBoard.getCustomerMasterModels();

            customerMasterModel.inputDetails = getProdcutiondettails;
            return View(customerMasterModel);
        }


        [HttpPost]
        public IActionResult ProdcutionMaster(CustomerMasterModel customermodel)
        {
            //var inputResult = interface_DashBoard.insertManpower(customermodel); 
            customermodel.Customers = interface_DashBoard.getCustomerName();

            var getProdcutiondettails = interface_DashBoard.getCustomerMasterModels();
            // return View(customermodel);
            return RedirectToAction("DhasBoardInput", customermodel);
        }

        public IActionResult Angenic()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Angenic(CustomerMasterModel customermodel)
        {
            var inputResult = interface_DashBoard.insertManpower(customermodel);
            customermodel.Customers = interface_DashBoard.getCustomerName();

            var getProdcutiondettails = interface_DashBoard.getCustomerMasterModels();
            // return View(customermodel);
            return RedirectToAction("DhasBoardInputs", customermodel);
            //return View(customermodel);
        }

        public JsonResult GetyieldDataOne(string Fgname, string type)
        {
            Dashboard_HourlyOP objDashboard3 = new Dashboard_HourlyOP();
           // objDashboard3.FGName = Fgname.ToString();
            //objDashboard3.TestType = type.ToString();
            objDashboard3.TestType = string.Empty;
            var dashboardlablosper = interface_DashBoard.getyieldDataOne(objDashboard3);
            return Json(dashboardlablosper);
        }

        public JsonResult GetHourlyOne(string Fgname, string type)
        {
            Dashboard_HourlyOP objDashboard3 = new Dashboard_HourlyOP();
          //  objDashboard3.FGName = Fgname.ToString();
            //objDashboard3.TestType = type.ToString();
            objDashboard3.TestType = string.Empty;
            var dashboardlablosper = interface_DashBoard.gethourlyone(objDashboard3);
            return Json(dashboardlablosper);
        }

        public JsonResult GetyieldDatatwo(string Fgname, string type)
        {
            Dashboard_HourlyOP objDashboard3 = new Dashboard_HourlyOP();
          //  objDashboard3.FGName = Fgname.ToString();
            //objDashboard3.TestType = type.ToString();
            objDashboard3.TestType = string.Empty;
            var dashboardlablosper = interface_DashBoard.getyieldDatatwo(objDashboard3);
            return Json(dashboardlablosper);
        }

        public JsonResult GetHourlytwo(string Fgname, string type)
        {
            Dashboard_HourlyOP objDashboard3 = new Dashboard_HourlyOP();
          //  objDashboard3.FGName = Fgname.ToString();
            //objDashboard3.TestType = type.ToString();
            objDashboard3.TestType = string.Empty;
            var dashboardlablosper = interface_DashBoard.gethourlytwo(objDashboard3);
            return Json(dashboardlablosper);
        }


        public JsonResult GetyieldDatathree(string Fgname, string type)
        {
            Dashboard_HourlyOP objDashboard3 = new Dashboard_HourlyOP();
            //objDashboard3.FGName = Fgname.ToString();
            //objDashboard3.TestType = type.ToString();
            objDashboard3.TestType = string.Empty;
            var dashboardlablosper = interface_DashBoard.getyieldDatathree(objDashboard3);
            return Json(dashboardlablosper);
        }

        public JsonResult GetHourlythree(string Fgname, string type)
        {
            Dashboard_HourlyOP objDashboard3 = new Dashboard_HourlyOP();
       //     objDashboard3.FGName = Fgname.ToString();
            //objDashboard3.TestType = type.ToString();
            objDashboard3.TestType = string.Empty;
            var dashboardlablosper = interface_DashBoard.gethourlythree(objDashboard3);
            return Json(dashboardlablosper);
        }

        public JsonResult GetyieldDatafour(string Fgname, string type)
        {
            Dashboard_HourlyOP objDashboard3 = new Dashboard_HourlyOP();
          //  objDashboard3.FGName = Fgname.ToString();
            //objDashboard3.TestType = type.ToString();
            objDashboard3.TestType = string.Empty;
            var dashboardlablosper = interface_DashBoard.getyieldDatafour(objDashboard3);
            return Json(dashboardlablosper);
        }

        public JsonResult GetHourlyfour(string Fgname, string type)
        {
            Dashboard_HourlyOP objDashboard3 = new Dashboard_HourlyOP();
          //  objDashboard3.FGName = Fgname.ToString();
            //objDashboard3.TestType = type.ToString();
            objDashboard3.TestType = string.Empty;
            var dashboardlablosper = interface_DashBoard.gethourlyfour(objDashboard3);
            return Json(dashboardlablosper);
        }

        public JsonResult GetyieldDatafive(string Fgname, string type)
        {
            Dashboard_HourlyOP objDashboard3 = new Dashboard_HourlyOP();
          //  objDashboard3.FGName = Fgname.ToString();
            //objDashboard3.TestType = type.ToString();
            objDashboard3.TestType = string.Empty;
            var dashboardlablosper = interface_DashBoard.getyieldDatafive(objDashboard3);
            return Json(dashboardlablosper);
        }

        public JsonResult GetHourlyfive(string Fgname, string type)
        {
            Dashboard_HourlyOP objDashboard3 = new Dashboard_HourlyOP();
       //     objDashboard3.FGName = Fgname.ToString();
            //objDashboard3.TestType = type.ToString();
            objDashboard3.TestType = string.Empty;
            var dashboardlablosper = interface_DashBoard.gethourlyfive(objDashboard3);
            return Json(dashboardlablosper);
        }
        public JsonResult getFGNameList(string cusid)
        {
            var lstFgName = interface_DashBoard.getFgName(Convert.ToInt32(cusid));
            return Json(lstFgName);
        }

        public IActionResult DhasBoardInput(CustomerMasterModel dashboardHourly)
        {
            CustomerMasterModel obj = new CustomerMasterModel();
          //  obj.FGName = dashboardHourly.FGNameText;
          //  obj.Type = dashboardHourly.Type;
            return View(obj);
        }

        public IActionResult DhasBoardInputs(CustomerMasterModel dashboardHourly)
        {
            CustomerMasterModel obj = new CustomerMasterModel();
           // obj.FGName = dashboardHourly.FGNameText;
            obj.Type = dashboardHourly.Type;
            return View(obj);
        }

        [HttpGet]
        public JsonResult GetChartData(string Fgname, string type)
        {
            // var data = new List<Dashboard_HourlyOP>
            Dashboard_HourlyOP objDashboard = new Dashboard_HourlyOP();
          //  objDashboard.FGName = Fgname.ToString();
            // objDashboard.TestType = type.ToString();
            objDashboard.TestType = string.Empty;
            var dashboardHourly = interface_DashBoard.getHourlyOP(objDashboard);
            return Json(dashboardHourly);
        }

        [HttpGet]
        public JsonResult GetyieldData(string Fgname, string type)
        {
            // var data = new List<Dashboard_HourlyOP>
            Dashboard_HourlyOP objDashboard1 = new Dashboard_HourlyOP();
          //  objDashboard1.FGName = Fgname.ToString();
            //objDashboard1.TestType = type.ToString();
            objDashboard1.TestType = string.Empty;
            var dashboardyield = interface_DashBoard.getHourlyyield(objDashboard1);
            return Json(dashboardyield);
        }

        [HttpGet]
        public JsonResult GetlineutilData(string Fgname, string type)
        {
            // var data = new List<Dashboard_HourlyOP>
            Lineutilization objDashboard2 = new Lineutilization();
          //  objDashboard2.FGName = Fgname.ToString();
            //objDashboard2.TestType = type.ToString();
            objDashboard2.TestType = string.Empty;
            var dashboardlineutil = interface_DashBoard.getlineutildata(objDashboard2);
            return Json(dashboardlineutil);
        }


        [HttpGet]
        public JsonResult GetlablosData(string Fgname, string type)
        {
            // var data = new List<Dashboard_HourlyOP>
            labrlosspercentage objDashboard3 = new labrlosspercentage();
         //   objDashboard3.FGName = Fgname.ToString();
            //objDashboard3.TestType = type.ToString();
            objDashboard3.TestType = string.Empty;
            var dashboardlablosper = interface_DashBoard.getlablosData(objDashboard3);
            return Json(dashboardlablosper);
        }

        [HttpGet]
        public JsonResult GetChartDataoee(string Fgname, string type)
        {
            Dashboard_HourlyOP objoeeDashboard = new Dashboard_HourlyOP
            {
                FGName = Fgname,
                TestType = type
            };

            // Call updated method that returns List<Dashboard_HourlyOP>
            List<Dashboard_HourlyOP> OEE = interface_DashBoard.getoee(objoeeDashboard);


            return Json(OEE); // Return as JSON to frontend
        }


        public JsonResult GetFailTypes1(string Fgname, string type)
        {
            Dashboard_HourlyOP objoeeDashboardfailty = new Dashboard_HourlyOP();
            // objDashboard3.FGName = Fgname.ToString();
            //objDashboard3.TestType = type.ToString();
            //objoeeDashboardfailty.fail_types = string.Empty;
            //objoeeDashboardfailty.fail_type_ct = 0;
            var dashbaordfailtypqt = interface_DashBoard.getfailtype1(objoeeDashboardfailty);
            return Json(dashbaordfailtypqt);
        }

        public JsonResult GetFailTypes2(string Fgname, string type)
        {
            Dashboard_HourlyOP objoeeDashboardfailty = new Dashboard_HourlyOP();
            // objDashboard3.FGName = Fgname.ToString();
            //objDashboard3.TestType = type.ToString();
            //objoeeDashboardfailty.fail_types = string.Empty;
            //objoeeDashboardfailty.fail_type_ct = 0;
            var dashbaordfailtypqt = interface_DashBoard.getfailtype2(objoeeDashboardfailty);
            return Json(dashbaordfailtypqt);
        }

        public JsonResult GetFailTypes3(string Fgname, string type)
        {
            Dashboard_HourlyOP objoeeDashboardfailty = new Dashboard_HourlyOP();
            // objDashboard3.FGName = Fgname.ToString();
            //objDashboard3.TestType = type.ToString();
            //objoeeDashboardfailty.fail_types = string.Empty;
            //objoeeDashboardfailty.fail_type_ct = 0;
            var dashbaordfailtypqt = interface_DashBoard.getfailtype2(objoeeDashboardfailty);
            return Json(dashbaordfailtypqt);
        }


    }
}
