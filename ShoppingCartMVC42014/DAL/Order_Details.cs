//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoppingCartMVC42014.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Details
    {
        public Nullable<int> order_id { get; set; }
        public int id { get; set; }
        public Nullable<int> product_id { get; set; }
        public Nullable<double> unit_price { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<int> status { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
