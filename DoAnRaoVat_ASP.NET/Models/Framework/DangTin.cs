namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangTin")]
    public partial class DangTin
    {
        public int Id { get; set; }

        [StringLength(300)]
        public string TieuDe { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDung { get; set; }

        public decimal? Gia { get; set; }

        public int? TinhTrang { get; set; }

        [StringLength(300)]
        public string Image { get; set; }

        public int? DanhMucId { get; set; }

        public int? TinhThanhPhoId { get; set; }

        public int? NguoiDungId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDang { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHetHan { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        public virtual TinhThanhPho TinhThanhPho { get; set; }
    }
}
