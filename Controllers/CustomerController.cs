using Assessment.IServices;
using Assessment.Model;
using Assessment.ResponseObjs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customer;
        public CustomerController(ICustomerService customer)
        {
            _customer = customer;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> PostCustomer([FromBody] CustomerReg payload)
        {
            var customer = await _customer.AddCustomer(payload);           
            return Ok(new APIResponse { IsSuccessful = true });
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customer = await _customer.GetCustomers();
            return Ok(new APIResponse<List<Customer>> { 
                IsSuccessful = true,
                Data = customer.ToList()
            
            });
        }
    }
}
