using Microsoft.EntityFrameworkCore;
using VIS_API.Model;

namespace VIS_API.Services
{
    public class MarketService : IMarketService
    {
        private readonly MarketContext _context;

        public MarketService(MarketContext context)
        {
            _context = context;
        }

        public async Task<Market> CreateMarketAsync(Market market)
        {
            _context.Markets.Add(market);
            await _context.SaveChangesAsync();
            return market;
        }

        public async Task<IEnumerable<Market>> GetAllMarketsAsync()
        {
            return await _context.Markets.ToListAsync();
        }

        public async Task<Market> GetMarketByIDAsync(int id)
        {
            var Market = await _context.Markets.FindAsync(id);
            return Market;
        }

        public async Task<bool> UpdateMarketAsync(Market market)
        {
            _context.Entry(market).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _context.Markets.AnyAsync(p => p.MarketID == market.MarketID))
                {
                    return false;
                }
                throw;
            }
        }
    }
}
