//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCongTy
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhongBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhongBan()
        {
            this.DuAns = new HashSet<DuAn>();
            this.NhanViens = new HashSet<NhanVien>();
        }
    
        public string MaPB { get; set; }
        public string TenPB { get; set; }
        public string MaLPB { get; set; }
        public string MaTrPhong { get; set; }
        public string ViTri { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DuAn> DuAns { get; set; }
        public virtual LoaiPhongBan LoaiPhongBan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
