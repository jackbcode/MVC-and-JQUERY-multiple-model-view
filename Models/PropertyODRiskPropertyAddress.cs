//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PolicyCheck.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PropertyODRiskPropertyAddress
    {
        public int RiskPropertyAddressPolicyId { get; set; }
        public string RPNumberName { get; set; }
        public string RPStreet { get; set; }
        public string RPTown { get; set; }
        public string RPCounty { get; set; }
        public string RPPostCode { get; set; }
    
        public virtual PolicyMain PolicyMain { get; set; }
    }
}
