//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GigALoan_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CORE_Clients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CORE_Clients()
        {
            this.CHLD_ClientImages = new HashSet<CHLD_ClientImages>();
            this.CORE_GigAlerts = new HashSet<CORE_GigAlerts>();
        }
    
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateJoined { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<bool> Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHLD_ClientImages> CHLD_ClientImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CORE_GigAlerts> CORE_GigAlerts { get; set; }
    }
}