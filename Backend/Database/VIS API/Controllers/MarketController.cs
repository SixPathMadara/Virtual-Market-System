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

        //POST: VIS_API/markets
        [HttpPost]
        public async Task<ActionResult<Market>> CreateMarket([FromBody] Market market)
        {
            var CreatedMarket = await _marketService.CreateMarketAsync(market);
            return CreatedAtAction(nameof(GetMarket), new { id = CreatedMarket.MarketID });
        }

        //GET : VIS_API/markets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Market>>> GetMarkets()
        {
            var markets = await _marketService.GetAllMarketsAsync();
            return Ok(markets);
        }
        //GET: VIS_API/markets/{marketID}
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

        // PUT: VIS_API/,arkets/{id}
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
