//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECommerce.DataLayer.EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDelivery
    {
        public long DeliveryID { get; set; }
        public string AirwaybillNumber { get; set; }
        public string OrderNo { get; set; }
        public string Status { get; set; }
        public Nullable<int> orderid { get; set; }
        public Nullable<System.DateTime> AddedOn { get; set; }
    
        public virtual order1 order1 { get; set; }
    }
}