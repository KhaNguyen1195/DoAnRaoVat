namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiDanhMuc")]
    public partial class LoaiDanhMuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiDanhMuc()
        {
            DanhMucs = new HashSet<DanhMuc>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string MaLoaiDanhMuc { get; set; }

        [StringLength(250)]
        public string TenLoaiDanhMuc { get; set; }

        public int? TrangThai { get; set; }

        public int? DaXoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhMuc> DanhMucs { get; set; }
    }
}
