using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace hw6 {
	public partial class Edu : DbContext {
		public Edu()
			: base("name=Edu") {
		}

		public virtual DbSet<Lecturer> Lecturers { get; set; }
		public virtual DbSet<Student> Students { get; set; }
		public virtual DbSet<StudentsSubject> StudentsSubjects { get; set; }
		public virtual DbSet<Subject> Subjects { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			modelBuilder.Entity<Lecturer>()
				.Property(e => e.Phone)
				.IsUnicode(false);

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
