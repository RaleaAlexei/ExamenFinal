using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Varianta7.Classes
{
    internal class SalonContext : DbContext
    {
        public DbSet<Programari> Programari { get; set; } = null!;
        public DbSet<Serviciu> Servicii { get; set; } = null!;

        public SalonContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Salon.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Programari>().HasKey(p => p.CodProgramare);
            modelBuilder.Entity<Programari>().Property(p => p.DataProgramarii).HasColumnType("datetime2");
            modelBuilder.Entity<Programari>().Property(p => p.OraProgramarii).HasColumnType("time");
            modelBuilder.Entity<Serviciu>().HasKey(s => s.CodServiciu);
            modelBuilder.Entity<Serviciu>().Property(Serviciu => Serviciu.Pret).HasPrecision(12, 10);
            modelBuilder.Entity<Programari>()
                .HasOne(p => p.Serviciu)
                .WithMany()
                .HasForeignKey(p => p.CodServiciu)
                .IsRequired();
            base.OnModelCreating(modelBuilder);
        }
    }
}
