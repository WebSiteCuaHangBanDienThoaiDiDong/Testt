//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSite_CuaHangDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_ProductImage
    {
        public int ProductImageId { get; set; }
        public int ProductsId { get; set; }
        public string Image { get; set; }
        public bool IsDefault { get; set; }
    
        public virtual tb_Products tb_Products { get; set; }
    }
}