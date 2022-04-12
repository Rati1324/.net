using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MidTerm {
	public partial class Model1 : DbContext {
		public Model1()
			: base("name=Model1") {
		}

		public virtual DbSet<Brand> Brands { get; set; }
		public virtual DbSet<SimCardType> SimCardTypes { get; set; }
		public virtual DbSet<Smartphone> Smartphones { get; set; }
		public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			modelBuilder.Entity<Brand>()
				.Property(e => e.name)
				.IsUnicode(false);

			modelBuilder.Entity<Brand>()
				.HasMany(e => e.Smartphones)
				.WithRequired(e => e.Brand)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<SimCardType>()
				.Property(e => e.name)
				.IsUnicode(false);

			modelBuilder.Entity<SimCardType>()
				.HasMany(e => e.Smartphones)
				.WithRequired(e => e.SimCardType)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Smartphone>()
				.Property(e => e.name)
				.IsUnicode(false);

			modelBuilder.Entity<Smartphone>()
				.Property(e => e.price)
				.HasPrecision(19, 4);
		}
	}
}
