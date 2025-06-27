namespace WpfMrpSimulatorApp.Models
{
    // JSON용 클래스. 다른데 안 씀!
    public class PrcMsg
    {
        public string ClientID { get; set; }
        public string PlantCode { get; set; }
        public string FacilityId { get; set; }
        public string Timestamp { get; set; }
        public string Flag { get; set; }
    }
}
