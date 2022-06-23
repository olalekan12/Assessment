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
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : Controller
    {
        private readonly IBankService _bankService;
        public BankController(IBankService bankService)
        {
            _bankService = bankService ?? throw new ArgumentNullException(nameof(bankService));
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<APIResponse<Bank>> GetBank([FromHeader(Name = "x-CustomHeader2")] string header)
        {
            APIResponse<Bank> result = new APIResponse<Bank>();
            try
            {
                result.Data = await _bankService.GetBank();
                result.IsSuccessful = true;
               
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
               
            }
            return result;
        }
    }
}
