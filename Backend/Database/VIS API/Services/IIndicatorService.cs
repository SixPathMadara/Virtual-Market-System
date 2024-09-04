using System.Collections.Generic;
using System.Threading.Tasks;
using VIS_API.Model;

namespace VIS_API.Services
{
    public interface IIndicatorService
    {
        Task<MarketIndicator> CreateMarketIndicatorAsync(MarketIndicator Indicator);
        Task<IEnumerable<MarketIndicator>> GetMarketIndicatorsAsync();
        Task<MarketIndicator> GetMarketIndicatorByIDAsync(int id);
        Task<bool> UpdateMarketIndicatorAsync(MarketIndicator Indicator);
        Task<bool> DeleteMarketIndicatorAsync(int id);

    }
}
