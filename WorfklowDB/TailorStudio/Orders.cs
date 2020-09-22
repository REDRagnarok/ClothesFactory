namespace TailorStudio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ordNum { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime ordDate { get; set; }

        [Required]
        [StringLength(15)]
        public string ordStage { get; set; }

        [StringLength(30)]
        public string customer { get; set; }

        [Column(TypeName = "money")]
        public decimal? price { get; set; }

        [StringLength(30)]
        public string manager { get; set; }
    }
}
