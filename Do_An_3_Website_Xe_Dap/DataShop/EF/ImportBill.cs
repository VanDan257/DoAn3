//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataShop.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ImportBill
    {
        public long ImpID { get; set; }
        public Nullable<System.DateTime> ImpDate { get; set; }
        public Nullable<long> PrvID { get; set; }
        public Nullable<long> UserID { get; set; }
        public Nullable<long> TotalPay { get; set; }
    
        public virtual Provider Provider { get; set; }
        public virtual User User { get; set; }
        public virtual ImportBillDetail ImportBillDetail { get; set; }
    }
}
