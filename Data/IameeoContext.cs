using Microsoft.EntityFrameworkCore;
using ToyProject.Models;

namespace ToyProject.Data
{
    public class IameeoContext : DbContext
    {
        public IameeoContext(DbContextOptions<IameeoContext> options) : base(options) { }

        #region property
        public DbSet<Board> Board { get; set; }
        public DbSet<Notice> Notice { get; set; }
        #endregion
    }
}
