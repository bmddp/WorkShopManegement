//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Material
    {
        public int MaterialId { get; set; }
        public string MaterialDescription { get; set; }
        public string MaterialPath { get; set; }
        public int WorkShopId { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual tbl_User tbl_User { get; set; }
        public virtual tbl_WorkShop tbl_WorkShop { get; set; }
    }
}
