namespace TurboKart.Presentation.Websites.TurboKartBookingManagement.Models.BookingCRUD
{
    public class DetailsViewModel
    {
        public int PrimaryKey { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string CustomerPhone { get; set; } = string.Empty;
        public GrandprixType GrandprixType { get; set; }
        public int DriverCount { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public DateTime DateTime => Date.ToDateTime(Time);
    }
}
