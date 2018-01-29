using Microsoft.EntityFrameworkCore;

namespace Darts.Models
{
    public class DartsContext : DbContext
    {
        public DartsContext (DbContextOptions<DartsContext> options)
            : base(options)
        {
        }

        public DbSet<Darts.Models.Player> Player { get; set; }
        public DbSet<Darts.Models.GameType> GameType { get; set; }
        //public DbSet<Darts.Models.Match> Match { get; set; }
    }
}
