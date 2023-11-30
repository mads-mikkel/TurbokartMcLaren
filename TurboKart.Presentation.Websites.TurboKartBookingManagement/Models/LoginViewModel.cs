using System.ComponentModel.DataAnnotations;

namespace TurboKart.Presentation.Websites.TurboKartBookingManagement.Models
{
	public class LoginViewModel
	{
		[Required]
		public string Username { get; set; }

		[Required]
		public string Password { get; set; }

	}
}
