namespace SystemMachineTools
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Виды_станков
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Виды_станков()
        {
            Станки = new HashSet<Станки>();
        }

        [Key]
        [Column("№_Вида_станка")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C__Вида_станка { get; set; }

        [Required]
        [StringLength(50)]
        public string Название { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Станки> Станки { get; set; }
    }
}
