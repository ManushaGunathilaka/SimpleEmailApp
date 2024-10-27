using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleEmailApp.Services.BuyerService;

namespace SimpleEmailApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyerController : ControllerBase
    {
        private readonly IBuyerService _buyerService;
        public BuyerController(IBuyerService buyerService)
        {
            _buyerService = buyerService;
        }

        [HttpGet]
        public async Task<ActionResult<List<BuyerDto>>> GetAllBuyers()
        {
            return _buyerService.GetAllBuyers();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<BuyerDto>>> GetSingleBuyer(int id)
        {
            var result=_buyerService.GetSingleBuyer(id);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
