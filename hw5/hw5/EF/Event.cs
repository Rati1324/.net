namespace hw5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime EventStart { get; set; }

        public DateTime EventEnd { get; set; }

        [StringLength(100)]
        public string Description { get; set; }
    }
}
