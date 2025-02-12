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
    
    public partial class order1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order1()
        {
            this.OrderDeliveries = new HashSet<OrderDelivery>();
            this.Wallets = new HashSet<Wallet>();
        }
    
        public int lorderid { get; set; }
        public Nullable<int> luserid { get; set; }
        public Nullable<System.DateTime> dentrydatetime { get; set; }
        public Nullable<byte> bdeleteflag { get; set; }
        public Nullable<byte> lorderstatusid { get; set; }
        public Nullable<int> lquantity { get; set; }
        public Nullable<int> lorderdescriptionid { get; set; }
        public Nullable<int> lpaymentmodeid { get; set; }
        public Nullable<int> lpaymenttypeid { get; set; }
        public string cremarks { get; set; }
        public Nullable<byte> bstatusreach { get; set; }
        public Nullable<int> lshippingcharges { get; set; }
        public Nullable<double> lordercharges { get; set; }
        public Nullable<byte> lgiftwrap { get; set; }
        public Nullable<int> ldiscountcouponid { get; set; }
        public Nullable<byte> bnewstatus { get; set; }
        public Nullable<decimal> discountamount { get; set; }
        public Nullable<decimal> saletax { get; set; }
        public Nullable<decimal> totalbillcharges { get; set; }
        public Nullable<bool> cancelledbyuser { get; set; }
        public Nullable<System.DateTime> userupdatedate { get; set; }
        public Nullable<int> adminid { get; set; }
        public Nullable<System.DateTime> adminupdatedate { get; set; }
        public string ipaddress { get; set; }
        public Nullable<bool> cancelledbyadmin { get; set; }
        public Nullable<bool> cancelorder_afterdeliver { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public Nullable<decimal> finalordercharges { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDelivery> OrderDeliveries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wallet> Wallets { get; set; }
    }
}
