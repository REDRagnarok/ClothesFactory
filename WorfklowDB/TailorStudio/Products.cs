namespace TailorStudio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            OrderedProducts = new HashSet<OrderedProducts>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pID { get; set; }

        [Required]
        [StringLength(30)]
        public string pName { get; set; }

        public double pWidth { get; set; }

        public double pLength { get; set; }

        [Column(TypeName = "image")]
        public byte[] pImage { get; set; }

        [Column(TypeName = "text")]
        public string pComment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderedProducts> OrderedProducts { get; set; }
    }
}
