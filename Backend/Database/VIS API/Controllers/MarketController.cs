using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VIS_API.Model;
using VIS_API.Services;

namespace VIS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketController : ControllerBase
    {
        private readonly IMarketService _marketService;

        public MarketController(IMarketService marketContext)
        {
            _marketService = marketContext;
        }

        //POST: api/user
        [HttpPost]
        public async Task<ActionResult<Market>> CreateMarket([FromBody] Market market)
        {
            var CreatedMarket = await _marketService.CreateMarketAsync(market);
            return CreatedAtAction(nameof(GetMarket), new { id = CreatedMarket.MarketID });
        }

        //GET : api/market
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Market>>> GetMarkets()
        {
            var markets = await _marketService.GetAllMarketsAsync();
            return Ok(markets);
        }
        //GET: user api/market/{marketID}
        [HttpGet("{id}")]
        public async Task<ActionResult<Market>> GetMarket(int id)
        {
            var market = await _marketService.GetMarketByIDAsync(id);
            if (market == null)
            {
                return BadRequest(NotFound());
            }
            return Ok(market);
        }

        // PUT: api/user/{id}
        [HttpPut("{id}")]
        public async Task<IMarketService> UpdateMarket(int id, [FromBody] Market updatedMarket)
        {
            if (id != updatedMarket.MarketID)
            {
                return (IMarketService)BadRequest();
            }
            var isUpdated = await _marketService.UpdateMarketAsync(updatedMarket);
            if (!isUpdated)
            {
                return (IMarketService)NotFound();
            }
            return (IMarketService)NoContent();
        }


    }
}
