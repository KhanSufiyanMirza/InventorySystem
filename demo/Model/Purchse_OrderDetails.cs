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
    
    public partial class Purchse_OrderDetails
    {
        public int id { get; set; }
        public Nullable<int> order_id { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string Qty_type { get; set; }
        public Nullable<decimal> Purchase_Price { get; set; }
        public Nullable<double> Gst { get; set; }
        public Nullable<double> discount { get; set; }
        public Nullable<decimal> BasePrice { get; set; }
    }
}