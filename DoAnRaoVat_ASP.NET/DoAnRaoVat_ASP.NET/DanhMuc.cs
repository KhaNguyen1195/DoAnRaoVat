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
    
    public partial class DanhMuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMuc()
        {
            this.DangTins = new HashSet<DangTin>();
        }
    
        public int Id { get; set; }
        public Nullable<int> LoaiDanhMucId { get; set; }
        public string MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public Nullable<int> DaXoa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangTin> DangTins { get; set; }
        public virtual LoaiDanhMuc LoaiDanhMuc { get; set; }
    }
}
