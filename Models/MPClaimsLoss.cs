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
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class MPClaimsLoss
    {
        public int ClaimsLossesPolicyId { get; set; }
        public int ClaimId { get; set; }

        [DataType(DataType.Date)]
        public Nullable<System.DateTime> ClaimsLossesClaimDate { get; set; }
        public string ClaimsLossesClaimType { get; set; }
        public Nullable<int> ClaimsLossesValue { get; set; }
        public string ClaimsLossesSection { get; set; }
        public string ClaimsLossesDescription { get; set; }
        public string ClaimsLossesDeleted { get; set; }
        public string ClaimsLossesClaimSettled { get; set; }

        public List<SelectListItem> CS { set; get; }
        public List<SelectListItem> ClaimsL { set; get; }
        public List<SelectListItem> YN { set; get; }

        public MPClaimsLoss()
        {
            CS = new List<SelectListItem>();
            YN = new List<SelectListItem>();
            ClaimsL = new List<SelectListItem>();
        }

        public virtual PolicyMain PolicyMain { get; set; }
    }
}
