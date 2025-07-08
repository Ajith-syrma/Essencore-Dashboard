namespace Honeywell_Production_Dashboard.Models
{
    public class ProductionDetails
    {
        public int TransactionId { get; set; }
        public string station { get; set; }
        public string cycle_time { get; set; }
        public string Hourly_output { get; set; }
        public int Op_count { get; set; }
        public string Man_output { get; set; }
        public int FgId { get; set; }
    }
}
