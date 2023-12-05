using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TurboKart.Presentation.Websites.TurboKartBookingManagement.Models.BookingCRUD
{
    public class EditViewModel
    {
        public int PrimaryKey { get; set; }

        [BindProperty, Required, RegularExpression("^[a-zA-Z]+(?: [A-Za-z]+)*$", ErrorMessage = "Please enter a valid name.")]
        public string CustomerName { get; set; } = string.Empty;

        [BindProperty, Required, RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage = "Please enter a valid email address.")]
        public string CustomerEmail { get; set; } = string.Empty;

        [BindProperty, Required, RegularExpression("^(?:[0-9][- ]?){6,14}[0-9]$", ErrorMessage = "Please enter a valid phone number.")]
        public string CustomerPhone { get; set; } = string.Empty;

        [BindProperty, Required]
        public GrandprixType GrandprixType { get; set; }

        [BindProperty, Required]
        public int DriverCount { get; set; }

        public DateOnly Date => DateOnly.FromDateTime(DateTime);
        public TimeOnly Time => TimeOnly.FromDateTime(DateTime);

        [BindProperty, Required]
        public DateTime DateTime { get; set; }
    }
}
