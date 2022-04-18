//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Marys_Auto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estimate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estimate()
        {
            this.Services = new HashSet<Service>();
        }
    
        public string Estimate_ID { get; set; }
        public string CustVehicle_ID { get; set; }
        public string Assessment_ID { get; set; }
        public Nullable<decimal> PriceEstimate { get; set; }
    
        public virtual Customer_Vehicles Customer_Vehicles { get; set; }
        public virtual Work_Assessment Work_Assessment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service> Services { get; set; }
    }
}