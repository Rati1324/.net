namespace CarRental.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? year { get; set; }

        public int? power_hp { get; set; }

        public int? transmission_type { get; set; }

        public int? fuel_type { get; set; }

        public int? body_type { get; set; }

        public int? speed { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        [StringLength(50)]
        public string license_number { get; set; }

        public virtual CarBodyType CarBodyType { get; set; }

        public virtual FuelType FuelType { get; set; }

        public virtual TransmissionType TransmissionType { get; set; }
    }
}
