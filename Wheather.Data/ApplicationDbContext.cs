using Microsoft.EntityFrameworkCore;
using Wheather.Models;

namespace Wheather.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<WheatherModel> WheatherModels { get; set; }
    }

}
