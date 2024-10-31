namespace Project2_PTQ_2210900059.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ma_TK { get; set; }

        [Required]
        [StringLength(50)]
        public string Ten_Dang_Nhap { get; set; }

        [Required]
        [StringLength(255)]
        public string Mat_Khau { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_NV { get; set; }

        public int Ma_VT { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual VAITRO_QUYEN VAITRO_QUYEN { get; set; }
    }
}
