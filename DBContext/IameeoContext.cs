using Microsoft.EntityFrameworkCore;
using ToyProject.Models;

namespace ToyProject.DBContext
{
    public class IameeoContext : DbContext
    {
        public IameeoContext(DbContextOptions<IameeoContext> options) : base(options) { }

        #region property
        public DbSet<Board> Board { get; set; }
        #endregion
    }
}
