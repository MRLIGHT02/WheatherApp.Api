using Wheather.Data;
using Wheather.Models;
namespace Wheather.ServiceContract
{
    public interface IWheatherContract
    {
        Task<List<WheatherModel>> GetAllAsync();

        public Task<WheatherModel> GetWheatherByCountryCode(string countryCode);
    }
}
