using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Heroes3WebApp.DbModels
{
    public partial class Heroes3DBContext : DbContext
    {
        public Heroes3DBContext()
        {
        }

        public Heroes3DBContext(DbContextOptions<Heroes3DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Building> Buildings { get; set; } = null!;
        public virtual DbSet<Cost> Costs { get; set; } = null!;
        public virtual DbSet<Hero> Heroes { get; set; } = null!;
        public virtual DbSet<HeroStat> HeroStats { get; set; } = null!;
        public virtual DbSet<HeroesSpell> HeroesSpells { get; set; } = null!;
        public virtual DbSet<Landscape> Landscapes { get; set; } = null!;
        public virtual DbSet<Monster> Monsters { get; set; } = null!;
        public virtual DbSet<Spell> Spells { get; set; } = null!;
        public virtual DbSet<Town> Towns { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-OFKJRQO\\SQLEXPRESS;Database=Heroes3DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Building>(entity =>
            {
                entity.Property(e => e.Discription).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(25);

                entity.Property(e => e.Picture).HasMaxLength(1);

                entity.HasOne(d => d.Cost)
                    .WithMany(p => p.Buildings)
                    .HasForeignKey(d => d.CostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Building_CostId");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Buildings)
                    .HasForeignKey(d => d.TownId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Building_TownId");
            });

            modelBuilder.Entity<Hero>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(25);

                entity.Property(e => e.Picture).HasMaxLength(1);

                entity.HasOne(d => d.Cost)
                    .WithMany(p => p.Heroes)
                    .HasForeignKey(d => d.CostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hero_CostId");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Heroes)
                    .HasForeignKey(d => d.TownId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hero_TownId");
            });

            modelBuilder.Entity<HeroStat>(entity =>
            {
                entity.HasOne(d => d.Town)
                    .WithMany(p => p.HeroStats)
                    .HasForeignKey(d => d.TownId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HeroStats_TownId");
            });

            modelBuilder.Entity<HeroesSpell>(entity =>
            {
                entity.ToTable("Heroes_Spells");

                entity.HasOne(d => d.Hero)
                    .WithMany(p => p.HeroesSpells)
                    .HasForeignKey(d => d.HeroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HeroSpell_HeroId");

                entity.HasOne(d => d.Spell)
                    .WithMany(p => p.HeroesSpells)
                    .HasForeignKey(d => d.SpellId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HeroSpell_SpellId");
            });

            modelBuilder.Entity<Landscape>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(25);
            });

            modelBuilder.Entity<Monster>(entity =>
            {
                entity.Property(e => e.Discription).HasMaxLength(100);

                entity.Property(e => e.Hp).HasColumnName("HP");

                entity.Property(e => e.Name).HasMaxLength(25);

                entity.Property(e => e.Picture).HasMaxLength(1);

                entity.HasOne(d => d.Cost)
                    .WithMany(p => p.Monsters)
                    .HasForeignKey(d => d.CostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Monster_CostId");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Monsters)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_Monster_TownId");
            });

            modelBuilder.Entity<Spell>(entity =>
            {
                entity.Property(e => e.Discription).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(25);

                entity.Property(e => e.Picture).HasMaxLength(1);
            });

            modelBuilder.Entity<Town>(entity =>
            {
                entity.Property(e => e.Discription).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(25);

                entity.Property(e => e.Picture).HasMaxLength(1);

                entity.HasOne(d => d.Landscape)
                    .WithMany(p => p.Towns)
                    .HasForeignKey(d => d.LandscapeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Town_LandscapeId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
