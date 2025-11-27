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
        List<Dashboard_HourlyOP> getfailtype1(Dashboard_HourlyOP dashboard_HourlyOP);
        List<Dashboard_HourlyOP> getfailtype2(Dashboard_HourlyOP dashboard_HourlyOP);
        List<Dashboard_HourlyOP> getfailtype3(Dashboard_HourlyOP dashboard_HourlyOP);

        List<Dashboard_HourlyOP> getHourlyOP(Dashboard_HourlyOP dashboard_HourlyOP);
        List<Dashboard_HourlyOP> getHourlyyield(Dashboard_HourlyOP dashboard_yield_OP);
        List<Lineutilization> getlineutildata(Lineutilization dashboard_lineutildata_OP);
        List<labrlosspercentage> getlablosData(labrlosspercentage dashboard_lablossper_OP);

        List<Dashboard_HourlyOP> gethourlyoutput(Dashboard_HourlyOP dashboard_HourlyOP);
        List<Dashboard_HourlyOP> gethourlyone(Dashboard_HourlyOP dashboard_HourlyOP);
        List<Dashboard_HourlyOP> gethourlytwo(Dashboard_HourlyOP dashboard_HourlyOP);
        List<Dashboard_HourlyOP> gethourlythree(Dashboard_HourlyOP dashboard_HourlyOP);
        List<Dashboard_HourlyOP> gethourlyfour(Dashboard_HourlyOP dashboard_HourlyOP);
        List<Dashboard_HourlyOP> gethourlyfive(Dashboard_HourlyOP dashboard_HourlyOP);

        List<Dashboard_HourlyOP> getyieldDataOne(Dashboard_HourlyOP dashboard_yield);
        List<Dashboard_HourlyOP> getyieldDatatwo(Dashboard_HourlyOP dashboard_yield);
        List<Dashboard_HourlyOP> getyieldDatathree(Dashboard_HourlyOP dashboard_yield);
        List<Dashboard_HourlyOP> getyieldDatafour(Dashboard_HourlyOP dashboard_yield);
        List<Dashboard_HourlyOP> getyieldDatafive(Dashboard_HourlyOP dashboard_yield);
        loginmodel logindetails(loginmodel loginmodel);

        // Add these two for model/FG dropdown functionality
        List<SelectListItem> GetModelList();
        List<SelectListItem> GetFgNumberList(string modelId);
        List<Dashboard_HourlyOP> gethourlyoutputfilter(Dashboard_HourlyOP dashboard_HourlyOP);
        List<Dashboard_HourlyOP> gethourlyonefilter(Dashboard_HourlyOP dashboard_HourlyOP);
        List<Dashboard_HourlyOP> gethourlytwofilter(Dashboard_HourlyOP dashboard_HourlyOP);
        List<Dashboard_HourlyOP> gethourlythreefilter(Dashboard_HourlyOP dashboard_HourlyOP);

        List<Dashboard_HourlyOP> getyieldDataOnefilter(Dashboard_HourlyOP dashboard_yield);
        List<Dashboard_HourlyOP> getyieldDatatwofilter(Dashboard_HourlyOP dashboard_yield);
        List<Dashboard_HourlyOP> getyieldDatathreefilter(Dashboard_HourlyOP dashboard_yield);//getfailtypefilter

        List<Dashboard_HourlyOP> getfailtypefilter(Dashboard_HourlyOP dashboard_HourlyOP);
        List<Dashboard_HourlyOP> getfailtype1filter(Dashboard_HourlyOP dashboard_HourlyOP);
        List<Dashboard_HourlyOP> getfailtype2filter(Dashboard_HourlyOP dashboard_HourlyOP);
        List<Dashboard_HourlyOP> getfailtype3filter(Dashboard_HourlyOP dashboard_HourlyOP);

    }
}
