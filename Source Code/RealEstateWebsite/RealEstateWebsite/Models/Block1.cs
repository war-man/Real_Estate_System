//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealEstateWebsite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Block1
    {
        public int Block_ID { get; set; }
        public string Reason { get; set; }
        public Nullable<System.DateTime> BlockDate { get; set; }
        public Nullable<System.DateTime> UnBlockDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
