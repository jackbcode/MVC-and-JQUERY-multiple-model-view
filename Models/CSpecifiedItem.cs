namespace PolicyCheck.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class CSpecifiedItem
    {
        public int SpecifiedItemPolicyId { get; set; }
        public int SpecifiedItemId { get; set; }
        public string SpecifiedItemItemCategory { get; set; }
        public string SpecifiedItemItemDescription { get; set; }
        public Nullable<int> SpecifiedItemItemValue { get; set; }
        public string SpecifiedItemCover { get; set; }
        public string SpecifiedItemDeleted { get; set; }
        public Nullable<int> SpecifiedItemValuationAmount { get; set; }

        [DataType(DataType.Date)]
        public Nullable<System.DateTime> SpecifiedItemDate { get; set; }

        public string SpecifiedItemTerritory { get; set; }

        public List<SelectListItem> ICD { set; get; }
        public List<SelectListItem> ItemCover { set; get; }
        public List<SelectListItem> YN { set; get; }
        public List<SelectListItem> ItemTerritory { set; get; }

        public CSpecifiedItem()
        {
            ICD = new List<SelectListItem>();
            ItemCover = new List<SelectListItem>();
            YN = new List<SelectListItem>();
            ItemTerritory = new List<SelectListItem>();
        }






        public virtual PolicyMain PolicyMain { get; set; }
    }
}
