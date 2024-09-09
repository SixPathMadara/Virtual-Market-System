using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VIS_API.Model;
using VIS_API.Services;

namespace VIS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndicatorController : ControllerBase
    {
        private readonly IIndicatorService _indicatorService;

        public IndicatorController(IIndicatorService indicatorContext)
        {
            _indicatorService = indicatorContext;
        }

        //POST: VIS_API/indicators
        [HttpPost]
        public async Task<ActionResult<MarketIndicator>> CreateMarket([FromBody] MarketIndicator indicator)
        {
            var CreatedIndicator = await _indicatorService.CreateMarketIndicatorAsync(indicator);
            return CreatedAtAction(nameof(GetIndicator), new { id = CreatedIndicator.IndicatorID });
        }

        //GET : VIS_API/indicators
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MarketIndicator>>> GetIndicators()
        {
            var indicators = await _indicatorService.GetMarketIndicatorsAsync();
            return Ok(indicators);
        }
        //GET: VIS_API/indicators/{marketID}
        [HttpGet("{id}")]
        public async Task<ActionResult<MarketIndicator>> GetIndicator(int id)
        {
            var indicator = await _indicatorService.GetMarketIndicatorByIDAsync(id);
            if (indicator == null)
            {
                return BadRequest(NotFound());
            }
            return Ok(indicator);
        }

        // PUT: VIS_API/indicators/{id}
        [HttpPut("{id}")]
        public async Task<IIndicatorService> UpdateIndicator(int id, [FromBody] MarketIndicator updatedIndicator)
        {
            if (id != updatedIndicator.IndicatorID)
            {
                return (IIndicatorService)BadRequest();
            }
            var isUpdated = await _indicatorService.UpdateMarketIndicatorAsync(updatedIndicator);
            if (!isUpdated)
            {
                return (IIndicatorService)NotFound();
            }
            return (IIndicatorService)NoContent();
        }

        //DELETE: VIS_API/indicators/{id}
        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteIndicator(int id)
        {
            var isDeleted = await _indicatorService.DeleteMarketIndicatorAsync(id);
            if(!isDeleted)
            {
                return (IActionResult)NotFound();
            }
            return (IActionResult)NoContent();
        }
    }
}
