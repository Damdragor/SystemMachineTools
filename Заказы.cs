namespace SystemMachineTools
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заказы
    {
        [Key]
        [Column("№_Заказа")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C__Заказа { get; set; }

        [Column("№_Станка")]
        public int C__Станка { get; set; }

        [Required]
        [StringLength(50)]
        public string Вид_ремонта { get; set; }

        [Column("№_Бригады")]
        public int C__Бригады { get; set; }

        [Column(TypeName = "date")]
        public DateTime Дата_сдачи { get; set; }

        [Column(TypeName = "date")]
        public DateTime Дата_возврата_по_плану { get; set; }

        [Column(TypeName = "date")]
        public DateTime Дата_возврата_по_факту { get; set; }

        [Required]
        [StringLength(50)]
        public string Статус_заказа { get; set; }

        public virtual Бригады Бригады { get; set; }

        public virtual Виды_ремонта Виды_ремонта { get; set; }

        public virtual Станки Станки { get; set; }
    }
}
