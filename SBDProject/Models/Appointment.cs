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
    
    public partial class Appointment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Appointment()
        {
            this.Game_time = new HashSet<Game_time>();
            this.RefereeSqad = new HashSet<RefereeSqad>();
            this.Squad = new HashSet<Squad>();
        }
    
        public int Id { get; set; }
        public int TeamId1 { get; set; }
        public int TeamId2 { get; set; }
        public int TournamentId { get; set; }
        public System.DateTime AppointmentDate { get; set; }
        public int LocationId { get; set; }
        public int Attendance { get; set; }
    
        public virtual Location Location { get; set; }
        public virtual Team Team { get; set; }
        public virtual Team Team1 { get; set; }
        public virtual Tournament Tournament { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Game_time> Game_time { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefereeSqad> RefereeSqad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Squad> Squad { get; set; }
    }
}