using System.Net.Http.Json;

using TurboKart.Application.Interfaces;
using TurboKart.Domain.Entities;


namespace TurboKart.Infrastructure.Networking.Services
{
	public class CustomerService : ICustomerUseCase
	{

		private const string URL = "https://localhost:7161";

		public void Delete(Customer customer)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Customer> GetAllCustomers()
		{
			throw new NotImplementedException();
		}

		public Customer GetSingleCustomer(object id)
		{
			throw new NotImplementedException();
		}

		public async void NewCustomer(Customer customer)
		{
			using (HttpClient client = new())
			{
				client.BaseAddress = new Uri(URL);
				var result = await client.PostAsJsonAsync("/api/customer/new", customer);
			}
		}

		public void Update(Customer customer)
		{
			throw new NotImplementedException();
		}
	}
}
