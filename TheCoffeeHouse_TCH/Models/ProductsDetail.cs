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
    
    public partial class ProductsDetail
    {
        public int ID { get; set; }
        public string MALOAIHANG { get; set; }
        public string MASP { get; set; }
        public Nullable<decimal> GIA { get; set; }
        public Nullable<bool> KICHCO { get; set; }
        public string TOPPING { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}