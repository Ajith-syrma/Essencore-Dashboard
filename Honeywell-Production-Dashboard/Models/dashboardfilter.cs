using Microsoft.AspNetCore.Mvc.Rendering;

namespace Honeywell_Production_Dashboard.Models
{
    public class dashboardfilter
    {
        public string SelectedModelId { get; set; }
        public string SelectedFGNumber { get; set; }
        public DateTime? SelectedDate { get; set; }

        public DateTime fromdate { get; set; }

        public DateTime todate { get; set; } = DateTime.MinValue;

        public TimeOnly fromtime { get; set; }
        public TimeOnly totime { get; set; }


        // Dropdown lists
        public List<SelectListItem> ModelList { get; set; }
        public List<SelectListItem> FGNumberList { get; set; }

        public dashboardfilter()
        {
            ModelList = new List<SelectListItem>();
            FGNumberList = new List<SelectListItem>();
        }
    }
}
