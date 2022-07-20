using Microsoft.EntityFrameworkCore;

namespace ImageHandler.Models
{
    public class ImageHandlerDbContext : DbContext
    {
        public ImageHandlerDbContext(DbContextOptions<ImageHandlerDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().ToTable("Images");
            modelBuilder.Entity<Image>().HasKey(x => x.Id);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Image> Images { get; set; }
    }
}
