namespace EmployeesManagement.Models
{
    public class Instrument: UserActivity
    {
        public int id { get; set; }

        public string InstrumentType { get; set; }

        public string InstrumentName { get; set; }

        public bool UseRopes { get; set; }
    }
}