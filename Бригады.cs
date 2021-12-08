namespace SystemMachineTools
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Бригады
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Бригады()
        {
            Заказы = new HashSet<Заказы>();
        }

        [Key]
        [Column("№_Бригады")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C__Бригады { get; set; }

        [Required]
        [StringLength(50)]
        public string ФИО_бригадира { get; set; }

        [Required]
        [StringLength(50)]
        public string Фото_бригадира { get; set; }

        [Required]
        [StringLength(50)]
        public string Описание_функций_бригады { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказы> Заказы { get; set; }
    }
}
