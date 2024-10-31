namespace Project2_PTQ_2210900059.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            TAIKHOANs = new HashSet<TAIKHOAN>();
        }

        [Key]
        [StringLength(10)]
        public string Ma_NV { get; set; }

        [Required]
        [StringLength(50)]
        
        public string Ho_Ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngay_Sinh { get; set; }

        public bool Gioi_Tinh { get; set; }

        [Required]
        [StringLength(10)]
        public string Ma_Phong { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Dia_Chi { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngay_Lam { get; set; }

        public int? Ma_chuc_vu { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOAN> TAIKHOANs { get; set; }
    }
}
