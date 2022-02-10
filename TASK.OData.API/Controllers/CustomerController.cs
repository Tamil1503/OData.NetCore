using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TASK.OData.API.Services;

namespace TASK.OData.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet(nameof(GetData))]
        [EnableQuery]
        public IActionResult GetData() => Ok(_customerService.GetCustomer());
    }
}
