using Microsoft.AspNetCore.Mvc.Rendering;

namespace Honeywell_Production_Dashboard.Models
{
    public interface Interface_DashBoard
    {
        List<SelectListItem> getCustomerName();
        List<SelectListItem> getFgName(int customer);
        int insertManpower(CustomerMasterModel customermodel);
        List<ProductionDetails> getCustomerMasterModels();
        List<Dashboard_HourlyOP> getoee(Dashboard_HourlyOP dashboard_HourlyOP);

        List<Dashboard_HourlyOP> getHourlyOP(Dashboard_HourlyOP dashboard_HourlyOP);
        List<Dashboard_HourlyOP> getHourlyyield(Dashboard_HourlyOP dashboard_yield_OP);
        List<Lineutilization> getlineutildata(Lineutilization dashboard_lineutildata_OP);
        List<labrlosspercentage> getlablosData(labrlosspercentage dashboard_lablossper_OP);



        loginmodel logindetails(loginmodel loginmodel);


    }
}
