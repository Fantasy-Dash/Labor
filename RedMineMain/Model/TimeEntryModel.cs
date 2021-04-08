namespace RedMine.Model
{
    public class TimeEntryModel
    {
        public string ProjectName { get; set; }
        public string Comments { get; set; }
        public float? Percent { get; set; }
        public decimal Hours { get; set; }
    }
}
