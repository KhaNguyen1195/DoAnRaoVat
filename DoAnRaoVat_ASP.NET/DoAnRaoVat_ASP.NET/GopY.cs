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
    
    public partial class GopY
    {
        public int Id { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public Nullable<System.DateTime> NgayGopY { get; set; }
        public Nullable<int> NguoiDungId { get; set; }
    
        public virtual NguoiDung NguoiDung { get; set; }
    }
}
