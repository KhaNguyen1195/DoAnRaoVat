namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhuVuc")]
    public partial class KhuVuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhuVuc()
        {
            TinhThanhPhoes = new HashSet<TinhThanhPho>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string MaKhuVuc { get; set; }

        [StringLength(250)]
        public string TenKhuVuc { get; set; }

        public int? TrangThai { get; set; }

        public int? DaXoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TinhThanhPho> TinhThanhPhoes { get; set; }
    }
}
