//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlatShare.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Outlay
    {
        public int RowID { get; set; }
        public decimal PayMoney { get; set; }
        public int PayItemID { get; set; }
        public System.DateTime PayDate { get; set; }
        public int ShareID { get; set; }
        public string Remark { get; set; }
        public Nullable<bool> LogicalDelete { get; set; }
        public int LastUpdatedBy { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public Nullable<int> PayUserID { get; set; }
    }
}
