﻿using Microsoft.AspNetCore.Mvc;

namespace TurboKart.Presentation.Apis.TurboKartAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{

		private readonly ICustomerUseCase customerUseCase;

		public CustomerController(ICustomerUseCase customerUseCase)
		{
			this.customerUseCase = customerUseCase;
		}

		[HttpGet("all")]
		public ActionResult<IEnumerable<Customer>> GetAllCustomers()
		{
			return Ok(customerUseCase.GetAllCustomers());
		}

		[HttpGet("{id}")]
		public ActionResult<Customer> GetSingleCustomer(int id)
		{
			var result = customerUseCase.GetSingleCustomer(id);
			if (result == null)
				return NotFound("No customer found with that ID");

			return Ok(result);
		}

		[HttpPut("update")]
		public ActionResult Update(Customer customer)
		{
			try
			{
				customerUseCase.Update(customer);
				return Ok();
			}
			catch (Exception)
			{
				return BadRequest();

			}
		}

		[HttpDelete("delete")]
		public ActionResult Delete(Customer customer)
		{
			try
			{
				customerUseCase.Delete(customer);
				return Ok();
			}
			catch (Exception)
			{
				return BadRequest();

			}
		}

		[HttpPost("new")]
		public ActionResult<Customer> NewCustomer(Customer customer)
		{
			try
			{
				customerUseCase.NewCustomer(customer);
				return Ok(customer);
			}
			catch (Exception e)
			{
				return BadRequest();
			}
		}

	}
}
