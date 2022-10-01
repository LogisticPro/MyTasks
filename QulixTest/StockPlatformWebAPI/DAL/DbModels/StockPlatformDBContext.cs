using Microsoft.EntityFrameworkCore;

namespace DAL.DbModels
{
    public partial class StockPlatformDBContext : DbContext
    {
        public StockPlatformDBContext()
        {
        }

        public StockPlatformDBContext(DbContextOptions<StockPlatformDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Photo> Photos { get; set; } = null!;
        public virtual DbSet<Text> Texts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-OFKJRQO\\SQLEXPRESS;Database=StockPlatformDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("Author");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DateOfRegistration).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(30);

                entity.Property(e => e.LastName).HasMaxLength(30);

                entity.Property(e => e.Nickname).HasMaxLength(30);
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.ToTable("Photo");

                entity.Property(e => e.Cost).HasMaxLength(10);

                entity.Property(e => e.DateOfCreation).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Photos)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_AuthorId");
            });

            modelBuilder.Entity<Text>(entity =>
            {
                entity.ToTable("Text");

                entity.Property(e => e.Cost).HasMaxLength(10);

                entity.Property(e => e.DateOfCreation).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.Text1).HasColumnName("Text");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Texts)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Text_AuthorId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
