using SmartHotel.Models;
using System.Threading.Tasks;

namespace SmartHotel.Services.Location
{
    public interface ILocationService
    {
        Task<GeoLocation> GetPositionAsync();
    }
}