using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Capstone.WebApi.Models;
using Capstone.WebApi.Services;
using System.Text.Json;
using Microsoft.Extensions.Logging.Abstractions;

namespace Capstone.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderSubstitutionController : ControllerBase
    {
  
        private readonly ILogger _logger;
        private readonly IOrderSubstitutionService _service;

   

        public OrderSubstitutionController(IOrderSubstitutionService service, ILogger<OrderSubstitutionController> logger)
        {

            _service = service;
            _logger = logger;

        }



        [HttpPost(Name = "OrderSub")]
        public async Task<ActionResult<SmartSubsReturn[]>> Post(DTOOrder[] order)
        {
            if(order == null)
            {
                UnprocessableEntity();
            }
                _logger.Log(LogLevel.Information, new EventId(), null, "Finding the subsitution for order  " + order, null);
                SmartSubsReturn[] response = await _service.GetSubstitutionOfOrder(order);
                return response;


        }

        [HttpGet]
        public async Task<string> Get()
        {

            return "HelloWorld";
         }
    }
}