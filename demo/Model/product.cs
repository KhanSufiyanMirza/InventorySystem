//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int id { get; set; }
        public string product_name { get; set; }
        public Nullable<decimal> purchase_price { get; set; }
        public Nullable<decimal> sell_price { get; set; }
        public Nullable<double> product_quantity { get; set; }
        public string product_category { get; set; }
        public byte[] product_img { get; set; }
        public string brand { get; set; }
        public Nullable<decimal> MRP { get; set; }
        public string invoice { get; set; }
        public Nullable<double> Gst { get; set; }
        public Nullable<decimal> base_price { get; set; }
        public string Quantity_type { get; set; }
    }
}
