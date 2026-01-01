using Honeywell_Production_Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Drawing;

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

        public JsonResult GetHourlyoutput(string Fgname, string type)
        {
            Dashboard_HourlyOP objDashboard0 = new Dashboard_HourlyOP();
            //  objDashboard3.FGName = Fgname.ToString();
            //objDashboard3.TestType = type.ToString();
            objDashboard0.TestType = string.Empty;
            var dashboardhrlyop = interface_DashBoard.gethourlyoutput(objDashboard0);
            return Json(dashboardhrlyop);
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

        //public IActionResult DhasBoardInputs1()
        //{
        //    var model = new dashboardfilter();

        //    //// Populate your dropdown lists
        //    //model.ModelList = GetModelList();       // Populate with SelectListItems
        //    //model.FGNumberList = GetFGNumberList(); // Populate with SelectListItems

        //    return View(model);
        //}

        // Load Model dropdown on page load
        [HttpGet]
        public IActionResult DhasBoardInputs1()
        {
            dashboardfilter objDashbrd1 = new dashboardfilter
            {
                // Call through interface
                ModelList = interface_DashBoard.GetModelList(),
                FGNumberList = new List<SelectListItem>() // empty initially
            };

            return View(objDashbrd1);
        }

        [HttpGet]
        public IActionResult GetFgNumbersByModel(string modelId)
        {
            if (string.IsNullOrEmpty(modelId))
            {
                return Json(new List<object>()); // return empty list if no model selected
            }

            // Fetch FG numbers from your interface/service
   
            var list = interface_DashBoard.GetFgNumberList(modelId);

            // Return JSON in the format { value, text }
            return Json(list);
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
            var dashbaordfailtypqt = interface_DashBoard.getfailtype3(objoeeDashboardfailty);
            return Json(dashbaordfailtypqt);
        }


        //--------------------code for filter
        public JsonResult GetHourlyoutputfilter(string Fgname, string type, string fdate, string tdate, string ftime,string ttime)
        {
            Dashboard_HourlyOP obj = new Dashboard_HourlyOP();
            obj.FGName = Fgname;
            obj.TestType = type;
            obj.fdate = fdate;
            obj.tdate = tdate;
            obj.ftime = ftime;
            obj.ttime = ttime;
            var data = interface_DashBoard.gethourlyoutputfilter(obj);
            return Json(data);
        }
        public JsonResult GetyieldDataOnefilter(string Fgname, string type, string fdate, string tdate, string ftime, string ttime)
        {
            Dashboard_HourlyOP obj = new Dashboard_HourlyOP();
            obj.FGName = Fgname;
            obj.TestType = type;
            //obj.Date = fdate;
            obj.fdate = fdate;
            obj.tdate = tdate;
            obj.ftime = ftime;
            obj.ttime = ttime;
            var data = interface_DashBoard.getyieldDataOnefilter(obj);
            return Json(data);
        }

        public JsonResult GetHourlyOnefilter(string Fgname, string type, string fdate, string tdate, string ftime, string ttime)
        {
            Dashboard_HourlyOP obj = new Dashboard_HourlyOP();
            obj.FGName = Fgname;
            obj.TestType = type;
            //obj.Date = fdate;
            obj.fdate = fdate;
            obj.tdate = tdate;
            obj.ftime = ftime;
            obj.ttime = ttime;
            var data = interface_DashBoard.gethourlyonefilter(obj);
            return Json(data);
        }

        public JsonResult GetyieldDatatwofilter(string Fgname, string type, string fdate, string tdate, string ftime, string ttime)
        {
            Dashboard_HourlyOP obj = new Dashboard_HourlyOP();
            obj.FGName = Fgname;
            obj.TestType = type;
            //obj.Date = fdate;
            obj.fdate = fdate;
            obj.tdate = tdate;
            obj.ftime = ftime;
            obj.ttime = ttime;
            var data = interface_DashBoard.getyieldDatatwofilter(obj);
            return Json(data);
        }

        public JsonResult GetHourlytwofilter(string Fgname, string type, string fdate, string tdate, string ftime, string ttime)
        {
            Dashboard_HourlyOP obj = new Dashboard_HourlyOP();
            obj.FGName = Fgname;
            obj.TestType = type;
            //obj.Date = fdate;
            obj.fdate = fdate;
            obj.tdate = tdate;
            obj.ftime = ftime;
            obj.ttime = ttime;
            var data = interface_DashBoard.gethourlytwofilter(obj);
            return Json(data);
        }

        public JsonResult GetyieldDatathreefilter(string Fgname, string type, string fdate, string tdate, string ftime, string ttime)
        {
            Dashboard_HourlyOP obj = new Dashboard_HourlyOP();
            obj.FGName = Fgname;
            obj.TestType = type;
            //obj.Date = fdate;
            obj.fdate = fdate;
            obj.tdate = tdate;
            obj.ftime = ftime;
            obj.ttime = ttime;
            var data = interface_DashBoard.getyieldDatathreefilter(obj);
            return Json(data);
        }

        public JsonResult GetHourlythreefilter(string Fgname, string type, string fdate, string tdate, string ftime, string ttime)
        {
            Dashboard_HourlyOP obj = new Dashboard_HourlyOP();
            obj.FGName = Fgname;
            obj.TestType = type;
            //obj.Date = fdate;
            obj.fdate = fdate;
            obj.tdate = tdate;
            obj.ftime = ftime;
            obj.ttime = ttime;
            var data = interface_DashBoard.gethourlythreefilter(obj);
            return Json(data);
        }


        public JsonResult GetFailTypes1filter(string Fgname, string type, string fdate, string tdate, string ftime, string ttime)
        {
            Dashboard_HourlyOP obj = new Dashboard_HourlyOP();
            obj.FGName = Fgname;
            obj.TestType = type;
            obj.Date = fdate;

            var data = interface_DashBoard.getfailtype1filter(obj);
            return Json(data);
        }

        public JsonResult GetFailTypes2filter(string Fgname, string type, string fdate, string tdate, string ftime, string ttime)
        {
            Dashboard_HourlyOP obj = new Dashboard_HourlyOP();
            obj.FGName = Fgname;
            obj.TestType = type;
            obj.Date = fdate;

            var data = interface_DashBoard.getfailtype2filter(obj);
            return Json(data);
        }

        public JsonResult GetFailTypes3filter(string Fgname, string type, string fdate, string tdate, string ftime, string ttime)
        {
            Dashboard_HourlyOP obj = new Dashboard_HourlyOP();
            obj.FGName = Fgname;
            obj.TestType = type;
            obj.Date = fdate;

            var data = interface_DashBoard.getfailtype3filter(obj);
            return Json(data);
        }

        public JsonResult GetFailBreakdownbyfiler(string Fgname, string type, string date,int failtype)
        {
            Dashboard_HourlyOP objoeeDashboardfailty = new Dashboard_HourlyOP();
             objoeeDashboardfailty.FGName = Fgname.ToString();
            objoeeDashboardfailty.TestType = type.ToString();
            objoeeDashboardfailty.Date = date;
            objoeeDashboardfailty.fail_type_id = failtype;
            var dashbaordfailtypqt = interface_DashBoard.getfailtypefilter(objoeeDashboardfailty);
            return Json(dashbaordfailtypqt);
        }









    }
}
