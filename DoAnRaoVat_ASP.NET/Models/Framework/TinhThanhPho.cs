namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinhThanhPho")]
    public partial class TinhThanhPho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TinhThanhPho()
        {
            DangTins = new HashSet<DangTin>();
        }

        public int Id { get; set; }

        public int? KhuVucId { get; set; }

        [StringLength(100)]
        public string MaTinhTP { get; set; }

        [StringLength(250)]
        public string TenTinhTP { get; set; }

        public int? TrangThai { get; set; }

        public int? DaXoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangTin> DangTins { get; set; }

        public virtual KhuVuc KhuVuc { get; set; }
    }
}
