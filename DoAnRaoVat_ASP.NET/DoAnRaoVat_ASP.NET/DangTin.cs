//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnRaoVat_ASP.NET
{
    using System;
    using System.Collections.Generic;
    
    public partial class DangTin
    {
        public int Id { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public Nullable<decimal> Gia { get; set; }
        public Nullable<int> TinhTrang { get; set; }
        public string Image { get; set; }
        public Nullable<int> DanhMucId { get; set; }
        public Nullable<int> TinhThanhPhoId { get; set; }
        public Nullable<int> NguoiDungId { get; set; }
        public Nullable<System.DateTime> NgayDang { get; set; }
        public Nullable<System.DateTime> NgayHetHan { get; set; }
    
        public virtual DanhMuc DanhMuc { get; set; }
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual TinhThanhPho TinhThanhPho { get; set; }
    }
}
