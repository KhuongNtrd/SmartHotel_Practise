using System.Threading.Tasks;
using SmartHotel.Models;

namespace SmartHotel.Services.Location
{
    public class FakeLocationService : ILocationService
    {
        public async Task<GeoLocation> GetPositionAsync()
        {
            await Task.Delay(500);

            return GeoLocation.Parse(AppSettings.DefaultFallbackMapsLocation);
        }
    }
}