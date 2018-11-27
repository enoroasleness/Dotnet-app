using Microsoft.EntityFrameworkCore;

namespace Udemy_kurs.Persistence
{
    public class KursDbContext : DbContext

    {
        public KursDbContext(DbContextOptions<KursDbContext> options)
        : base(options)  
        {

        } 
    }
}