//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace digisell.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShippingDetail
    {
        public ShippingDetail()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int ShippingID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}
