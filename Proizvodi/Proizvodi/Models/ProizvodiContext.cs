using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Proizvodi.Models
{
    public partial class ProizvodiContext : DbContext
    {
       
        public ProizvodiContext(DbContextOptions<ProizvodiContext> opcije)
            : base(opcije)
        {

        }

        public virtual DbSet<Proizvod> Proizvod { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
