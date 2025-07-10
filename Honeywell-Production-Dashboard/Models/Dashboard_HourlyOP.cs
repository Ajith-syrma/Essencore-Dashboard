namespace Honeywell_Production_Dashboard.Models
{
    public class Dashboard_HourlyOP
    {

        public string Label { get; set; }   // e.g., "Availability", "Performance", "Quality"
        public decimal Value { get; set; }
        public string Passcount { get; set; }
        public string Failcount { get; set; }
        public int Totalcount { get; set; }

        public string TestType { get; set; } // Keep if still used elsewhere
        public string HourIntervel { get; set; }
        public int LogCount { get; set; }

        public string FGName { get; set; }
    }


    public class Perforamce_value
    {
        public int Passcount { get; set; }
        public int Failcount { get; set; }
        public int Totalcount { get; set; }
    }
}
