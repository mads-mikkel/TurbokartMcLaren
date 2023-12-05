namespace TurboKart.Presentation.Websites.TurboKartBookingManagement.Models.BookingCRUD
{
    public class MockBooking
    {
        public MockBooking(int primaryKey, string customerName, string customerEmail, string customerPhone, GrandprixType grandprixType, int driverCount, DateOnly date, TimeOnly time)
        {
            PrimaryKey = primaryKey;
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            CustomerPhone = customerPhone;
            GrandprixType = grandprixType;
            DriverCount = driverCount;
            Date = date;
            Time = time;
        }

        public int PrimaryKey { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string CustomerPhone { get; set; } = string.Empty;
        public GrandprixType GrandprixType { get; set; }
        public int DriverCount { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
    }
    public enum GrandprixType
    {
		Enkelt_Grandprix,
		Dobbelt_Grandprix
    }
}
