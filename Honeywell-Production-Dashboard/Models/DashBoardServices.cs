using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Honeywell_Production_Dashboard.Models
{
    
    public class DashBoardServices : Interface_DashBoard
    {
        private readonly DataManagement dataManagement;

        public DashBoardServices(DataManagement _datamanagement)
        {
            dataManagement = _datamanagement;
        }
        public List<SelectListItem> getCustomerName()
        {
            var cusname= dataManagement.getcustomername();
            return cusname;
        }

        public List<SelectListItem> getFgName(int customerid)
        {
            var fgName = dataManagement.getFgName(customerid);
            return fgName;
        }

        public List<ProductionDetails> getCustomerMasterModels()
        {
            var prodetails= dataManagement.getCustomerMasterModels();
            return prodetails;
        }

        public int insertManpower(CustomerMasterModel customermodel)
        {
            var result= dataManagement.insertManpower(customermodel);
            return result;
        }

        public List<Dashboard_HourlyOP> getHourlyOP(Dashboard_HourlyOP dashboard_HourlyOP)
        {
            var resulthourly=dataManagement.getHourlyOP(dashboard_HourlyOP);
            return resulthourly;
        }

        public loginmodel logindetails(loginmodel loginmodel)
        {
            var resultlogin= dataManagement.logindetails(loginmodel);
            return resultlogin;
        }

        public List<Dashboard_HourlyOP> getoee(Dashboard_HourlyOP dashboard_HourlyOP)
        {
            List<Dashboard_HourlyOP> oeeResults = new List<Dashboard_HourlyOP>();

            // 1. Availability
            int downtime_seconds = dataManagement.getdowntime(dashboard_HourlyOP);
            int downtime = downtime_seconds - 2400;
            int runtimeValue = 26400 - downtime_seconds;

            decimal availability = (runtimeValue > 0)
                ? ((decimal)runtimeValue / 26400) * 100
                : 0;

            // 2. Get Performance Metrics
            var performanceList = dataManagement.getperf(dashboard_HourlyOP);

            int passCount = 0, failCount = 0, totalCount = 0;

            if (performanceList != null && performanceList.Count > 0)
            {
                var item = performanceList.First();
                int.TryParse(item.Passcount, out passCount);
                int.TryParse(item.Failcount, out failCount);
                totalCount = item.Totalcount;
            }

            // 3. Quality
            decimal quality = totalCount > 0
                ? ((decimal)passCount / totalCount) * 100
                : 0;

            // 4. Performance
            decimal idealCycleTime = dataManagement.getidealcycletime(dashboard_HourlyOP); // in seconds
            decimal performance = (totalCount > 0 && runtimeValue > 0)
                ? ((decimal)totalCount * idealCycleTime / runtimeValue) * 100
                : 0;

            // 5. Add to result list
            oeeResults.Add(new Dashboard_HourlyOP { Label = "Availability", Value = Math.Round(availability, 2) });
            oeeResults.Add(new Dashboard_HourlyOP { Label = "Performance", Value = Math.Round(performance, 2) });
            oeeResults.Add(new Dashboard_HourlyOP { Label = "Quality", Value = Math.Round(quality, 2) });

            return oeeResults;
        }





    }
}
