using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FirstWcfService.EF {
	public partial class Model1 : DbContext {
		public Model1()
			: base("name=Model1") {
		}

		public virtual DbSet<Student> Students { get; set; }
		public virtual DbSet<StudentsSubject> StudentsSubjects { get; set; }
		public virtual DbSet<Subject> Subjects { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			modelBuilder.Entity<Student>()
				.HasMany(e => e.StudentsSubjects)
				.WithRequired(e => e.Student)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Subject>()
				.HasMany(e => e.StudentsSubjects)
				.WithRequired(e => e.Subject)
				.WillCascadeOnDelete(false);
		}
	}
}
