namespace PolicyCheck.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public partial class CAllrisksBicycle
    {
        public int BicycleId { get; set; }
        public string BicycleMake { get; set; }
        public string BicycleModel { get; set; }
        public Nullable<int> BicycleValue { get; set; }
        public string BicycleTerritory { get; set; }
        public Nullable<int> AllrisksBicyclePolicyId { get; set; }

        public List<SelectListItem> BicycleTerritory2 { set; get; }

        public CAllrisksBicycle()
        {
            BicycleTerritory2 = new List<SelectListItem>();
        }

        public virtual PolicyMain PolicyMain { get; set; }
    }
}
