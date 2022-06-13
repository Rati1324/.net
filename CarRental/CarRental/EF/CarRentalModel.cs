using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CarRental.EF {
	public partial class CarRentalModel : DbContext {
		public CarRentalModel()
			: base("name=CarRentModel") {
		}

		public virtual DbSet<Car> Cars { get; set; }
		public virtual DbSet<CarBodyType> CarBodyTypes { get; set; }
		public virtual DbSet<FuelType> FuelTypes { get; set; }
		public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
		public virtual DbSet<TransmissionType> TransmissionTypes { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			modelBuilder.Entity<Car>()
				.Property(e => e.name)
				.IsUnicode(false);

			modelBuilder.Entity<Car>()
				.Property(e => e.price)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Car>()
				.Property(e => e.license_number)
				.IsUnicode(false);

			modelBuilder.Entity<CarBodyType>()
				.HasMany(e => e.Cars)
				.WithOptional(e => e.CarBodyType)
				.HasForeignKey(e => e.body_type);

			modelBuilder.Entity<FuelType>()
				.Property(e => e.name)
				.IsUnicode(false);

			modelBuilder.Entity<FuelType>()
				.HasMany(e => e.Cars)
				.WithOptional(e => e.FuelType)
				.HasForeignKey(e => e.fuel_type);

			modelBuilder.Entity<TransmissionType>()
				.Property(e => e.name)
				.IsUnicode(false);

			modelBuilder.Entity<TransmissionType>()
				.HasMany(e => e.Cars)
				.WithOptional(e => e.TransmissionType)
				.HasForeignKey(e => e.transmission_type);
		}
	}
}
