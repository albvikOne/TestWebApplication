//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWebApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public int customerID { get; set; }
        public string customerName { get; set; }
        public string customerSurname { get; set; }
        public string customerAddress { get; set; }
        public int customerPhone { get; set; }
        public int customerAccNo { get; set; }
        public int accountID { get; set; }
        public int bankID { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Bank Bank { get; set; }
    }
}