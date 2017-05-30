namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            DangTins = new HashSet<DangTin>();
            Gopies = new HashSet<GopY>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string MaNguoiDung { get; set; }

        [StringLength(250)]
        public string TenNguoiDung { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string SoDienThoai { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        public int? ChucVu { get; set; }

        public int? GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDangKy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTruyCapCuoiCung { get; set; }

        public int? TrangThai { get; set; }

        public int? DaXoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangTin> DangTins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GopY> Gopies { get; set; }
    }
}
