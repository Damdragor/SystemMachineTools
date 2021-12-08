namespace SystemMachineTools
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Клиенты
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Клиенты()
        {
            Станки = new HashSet<Станки>();
        }

        [Key]
        [Column("№_Клиента")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C__Клиента { get; set; }

        [Required]
        [StringLength(50)]
        public string Название_фирмы_клиента { get; set; }

        [Required]
        [StringLength(50)]
        public string Адрес_фирмы { get; set; }

        [Required]
        [StringLength(50)]
        public string ФИО_контактного_лица { get; set; }

        public int Телефон { get; set; }

        [Required]
        [StringLength(50)]
        public string Электронная_почта { get; set; }

        [Required]
        [StringLength(50)]
        public string Имя_файла_с_фото { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Станки> Станки { get; set; }
    }
}
