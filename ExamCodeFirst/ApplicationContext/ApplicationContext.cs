using ExamCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamCodeFirst.ApplicationContext
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {

        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public virtual DbSet<Albums> Albums { get; set; }
        public virtual DbSet<Albums_songs> Albums_Songs { get; set; }
        public virtual DbSet<Artists> Artists { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<Songs> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=204-1;Initial Catalog=Music;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Albums>(entity =>
            {
                entity.HasKey(e => e.Album_id);

                entity.Property(e => e.Album_id)
                    .HasColumnName("Album_id");

                entity.Property(e => e.Artist_id)
                    .HasColumnName("Artist_id");

                entity.Property(e => e.Album_year)
                    .HasColumnName("Album_year");

                entity.Property(e => e.Album_tracks)
                    .HasColumnName("Album_tracks");

                entity.HasOne(d => d.ArtistsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Artist_id);
            });
            modelBuilder.Entity<Albums_songs>(entity =>
            {
                entity.HasKey(e => new { e.Album_id, e.Song_id });

                entity.Property(e => e.Album_id)
                    .HasColumnName("Album_id");

                entity.Property(e => e.Song_id)
                    .HasColumnName("Song_id");

                entity.Property(e => e.Track_number)
                    .HasColumnName("Track_number");

                entity.HasOne(d => d.AlbumsNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.Album_id);

                entity.HasOne(d => d.SongsNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.Song_id);
            });
            modelBuilder.Entity<Artists>(entity =>
            {
                entity.HasKey(e => e.Artist_id);

                entity.Property(e => e.Artist_id)
                    .HasColumnName("Artist_id");

                entity.Property(e => e.Genre_id)
                    .HasColumnName("Genre_id");

                entity.Property(e => e.Country_id)
                    .HasColumnName("Country_id");

                entity.Property(e => e.Artist_site_url)
                    .IsUnicode(false)
                    .HasColumnName("Artist_Site_URL");

                entity.HasOne(d => d.GenresNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.Genre_id);

                entity.HasOne(d => d.CountriesNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.Country_id);
            });
            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.Country_id);

                entity.Property(e => e.Country_id)
                    .HasColumnName("Country_id");

                entity.Property(e => e.Country_name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("Country_name");

            });
            modelBuilder.Entity<Genres>(entity =>
            {
                entity.HasKey(e => e.Genre_id);

                entity.Property(e => e.Genre_id)
                    .HasColumnName("Genre_id");

                entity.Property(e => e.Genre_name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Genre_name");
            });
            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.Artist_id);

                entity.Property(e => e.Artist_id)
                    .HasColumnName("Artist_id");

                entity.Property(e => e.Group_name)
                    .HasColumnName("Group_name");

                entity.HasOne(d => d.ArtistsNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.Artist_id);
            });
            modelBuilder.Entity<Persons>(entity =>
            {
                entity.HasKey(e => e.Artist_id);

                entity.Property(e => e.Artist_id)
                    .HasColumnName("Artist_id");

                entity.Property(e => e.First_name)
                    .HasColumnName("First_name");

                entity.Property(e => e.Last_name)
                    .HasColumnName("Last_name");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("Birthday");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Sex");

                entity.HasOne(d => d.ArtistsNavigation)
                   .WithMany()
                   .HasForeignKey(d => d.Artist_id);
            });
            modelBuilder.Entity<Songs>(entity =>
            {
                entity.HasKey(e => e.Song_id);

                entity.Property(e => e.Song_id)
                    .HasColumnName("Song_id");

                entity.Property(e => e.Song_title)
                    .HasColumnName("Song_Title");

                entity.Property(e => e.Song_duration)
                    .HasColumnName("Song_Duration");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
