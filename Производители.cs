namespace SystemMachineTools
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Производители
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Производители()
        {
            Станки = new HashSet<Станки>();
        }

        [Key]
        [Column("№_Производителя")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C__Производителя { get; set; }

        [Required]
        [StringLength(50)]
        public string Название { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Станки> Станки { get; set; }
    }
}
