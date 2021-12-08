namespace SystemMachineTools
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Станки
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Станки()
        {
            Заказы = new HashSet<Заказы>();
        }

        [Key]
        [Column("№_Станка")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C__Станка { get; set; }

        [Column("№_Клиента")]
        public int C__Клиента { get; set; }

        [Column("№_Вида_станка")]
        public int C__Вида_станка { get; set; }

        [Required]
        [StringLength(50)]
        public string Марка_станка { get; set; }

        [Column("№_Производителя")]
        public int C__Производителя { get; set; }

        public int Год_выпуска { get; set; }

        public virtual Виды_станков Виды_станков { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказы> Заказы { get; set; }

        public virtual Клиенты Клиенты { get; set; }

        public virtual Производители Производители { get; set; }
    }
}
