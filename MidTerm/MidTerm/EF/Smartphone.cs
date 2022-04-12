namespace MidTerm
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Smartphone")]
    public partial class Smartphone
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int brandId { get; set; }

        [Column(TypeName = "money")]
        public decimal price { get; set; }

        public int RAM { get; set; }

        public double CpuSpeed { get; set; }

        public int simCardTypeId { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual SimCardType SimCardType { get; set; }
    }
}
