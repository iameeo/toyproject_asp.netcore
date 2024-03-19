using Microsoft.EntityFrameworkCore;
using ToyProject.Models;

namespace ToyProject.DBContext
{
    public class IameeoContext : DbContext
    {
        public IameeoContext(DbContextOptions<IameeoContext> options) : base(options) { }

        #region property
        public DbSet<Board> Boards { get; set; }
        public DbSet<Notice> Notices { get; set; }
        #endregion
    }
}
