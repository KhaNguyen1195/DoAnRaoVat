namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GopY")]
    public partial class GopY
    {
        public int Id { get; set; }

        [StringLength(300)]
        public string TieuDe { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDung { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayGopY { get; set; }

        public int? NguoiDungId { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
    }
}
