namespace SystemMachineTools
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Авторизация
    {
        [Key]
        [Column("№_Кода_авторизации")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C__Кода_авторизации { get; set; }

        [Required]
        [StringLength(50)]
        public string Электронная_почта { get; set; }

        [Required]
        [StringLength(50)]
        public string Пароль { get; set; }

        [Required]
        [StringLength(50)]
        public string Код_доступа { get; set; }
    }
}
