using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookvieL.Functions
{
    public partial class BookvieContext : DbContext
    {
        public BookvieContext()
        {
        }

        public BookvieContext(DbContextOptions<BookvieContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-AC3POC8;Database=Bookvie;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BookUrl).HasMaxLength(200);

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasColumnName("ISBN")
                    .HasMaxLength(20);

                entity.Property(e => e.PublishDate).HasColumnType("date");

                entity.Property(e => e.Publisher)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Director)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Genres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MovieName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ReleaseDate).HasColumnType("date");

                entity.Property(e => e.ReleatedBookId).HasColumnName("ReleatedBookID");

                entity.HasOne(d => d.ReleatedBook)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.ReleatedBookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movies_Books");
            });
        }
    }
}
