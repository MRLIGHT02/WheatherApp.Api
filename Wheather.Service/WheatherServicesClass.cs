using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using Wheather.Data;
using Wheather.Models;
using Wheather.ServiceContract;

namespace Wheather.Service
{
    public class WheatherServicesClass : IWheatherContract
    {
        private readonly ApplicationDbContext _context;
        public WheatherServicesClass(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<WheatherModel>> GetAllAsync()
        {
            var result = await _context.WheatherModels.ToListAsync();

            return result;
        }

        public Task<WheatherModel> GetWheatherByCountryCode(string countryCode)
        {
            var result = _context.WheatherModels
                .FirstOrDefaultAsync(x => x.CityUniqueCode == countryCode);
            return result;


        }

    }
}
