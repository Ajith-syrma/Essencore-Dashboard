using Microsoft.AspNetCore.Mvc.Rendering;

namespace Honeywell_Production_Dashboard.Models
{
    public class dashboardfilter
    {
        public string SelectedModelId { get; set; }
        public string SelectedFGNumber { get; set; }
        public DateTime? SelectedDate { get; set; }

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
