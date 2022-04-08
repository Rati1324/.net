using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace hw5 {
	public partial class Model1 : DbContext {
		public Model1()
			: base("name=Model1") {
		}

		public virtual DbSet<Event> Events { get; set; }
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<UserEvent> UserEvents { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			modelBuilder.Entity<Event>()
				.Property(e => e.Description)
				.IsFixedLength();
		}
	}
}
