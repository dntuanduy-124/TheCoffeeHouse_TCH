//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheCoffeeHouse_TCH.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.OrderProes = new HashSet<OrderPro>();
        }
    
        public string MAKH { get; set; }
        public string TENKH { get; set; }
        public string SDT { get; set; }
        public Nullable<int> OTP { get; set; }
        public string EMAIL { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string THANHPHO { get; set; }
        public string QUAN { get; set; }
        public string KHUVUC { get; set; }
        public string DIACHIKHACHHANG { get; set; }
        public string GIOITINH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderPro> OrderProes { get; set; }
    }
}