namespace PolicyCheck.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class MPConviction
    {
        public int ConvictionsPolicyId { get; set; }
        public int ConvictionId { get; set; }

        [DataType(DataType.Date)]
        public Nullable<System.DateTime> ConvictionDate { get; set; }
        public string Pending { get; set; }
        public string ConvictionType { get; set; }

        public IEnumerable<SelectListItem> ConvictionList { set; get; }

        public List<SelectListItem> CL { set; get; }
        public List<SelectListItem> YN { set; get; }

        public MPConviction()
        {
            CL = new List<SelectListItem>();
            YN = new List<SelectListItem>();
        }

        public virtual PolicyMain PolicyMain { get; set; }
    }
}
