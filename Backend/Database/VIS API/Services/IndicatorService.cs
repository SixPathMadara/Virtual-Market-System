using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using VIS_API.Model;

namespace VIS_API.Services
{
    public class IndicatorService : IIndicatorService
    {
        private readonly MarketContext _context;

        public IndicatorService(MarketContext context)
        {
            _context = context;
        }
        public async Task<MarketIndicator> CreateMarketIndicatorAsync(MarketIndicator Indicator)
        {
            _context.MarketIndicators.Add(Indicator);
            await _context.SaveChangesAsync();
            return Indicator;
        }

        public async Task<bool> DeleteMarketIndicatorAsync(int id)
        {
            var Indicator = await _context.MarketIndicators.FindAsync(id);
            if (Indicator == null)
            {
                return false;
            }

            _context.MarketIndicators.Remove(Indicator);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<MarketIndicator> GetMarketIndicatorByIDAsync(int id)
        {
   
            var Indicator = await _context.MarketIndicators.FindAsync(id);
            return Indicator; 
        }




        public async Task<IEnumerable<MarketIndicator>> GetMarketIndicatorsAsync()
        {
            return await _context.MarketIndicators.ToListAsync();
        }

        public async Task<bool> UpdateMarketIndicatorAsync(MarketIndicator Indicator)
        {
            _context.Entry(Indicator).State=EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if(!await _context.MarketIndicators.AnyAsync(p=>p.IndicatorID==Indicator.IndicatorID))
                {
                    return false;
                }
                throw;
            }
               
        }
    }
}
