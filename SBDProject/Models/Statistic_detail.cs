//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SBDProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Statistic_detail
    {
        public int Id { get; set; }
        public int StatisticId { get; set; }
        public Nullable<System.TimeSpan> Time { get; set; }
        public int PlayerId { get; set; }
    
        public virtual Player Player { get; set; }
        public virtual Statistic Statistic { get; set; }
    }
}
