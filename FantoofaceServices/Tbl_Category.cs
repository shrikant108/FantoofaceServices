//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FantoofaceServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Category
    {
        public int ID { get; set; }
        public string categoryname { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
    
        public virtual tbl_Tutorial tbl_Tutorial { get; set; }
    }
}
