using System.Collections.Generic;
using System.Threading.Tasks;
using VIS_API.Model;
namespace VIS_API.Services
{
    public interface IMarketService
    {
        Task<Market> CreateMarketAsync(Market market);
        Task<Market> GetMarketByIDAsync(int id);
        Task<IEnumerable<Market>> GetAllMarketsAsync();
        Task<bool> UpdateMarketAsync(Market market);
        
    }
}
