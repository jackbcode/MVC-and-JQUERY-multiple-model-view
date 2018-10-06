namespace PolicyCheck.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class ProposerDetail
    {
        public int ProposerPolicyId { get; set; }
        public int ProposerId { get; set; }

        [Display(Name = "Sex:")]
        public string ProposerSex { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "DOB:")]
        public Nullable<System.DateTime> ProposerDOB { get; set; }

        [Display(Name = "Age:")]
        public string ProposerAge { get; set; }

        [Display(Name = "Employ Details>")]
        public string ProposerEmployDetails { get; set; }

        [Display(Name = "Occ 1:")]
        public string ProposerOccOne { get; set; }

        [Display(Name = "Business:")]
        public string ProposerOccBusinessOne { get; set; }

        [Display(Name = "Status:")]
        public string ProposerOccStatusOne { get; set; }

        [Display(Name = "Full/Part:")]
        public string ProposerOccFullPartOne { get; set; }

        [Display(Name = "Occ 2:")]
        public string ProposerOccTwo { get; set; }

        [Display(Name = "Business:")]
        public string ProposerOccBusinessTwo { get; set; }

        [Display(Name = "Status:")]
        public string ProposerOccStatusTwo { get; set; }

        [Display(Name = "Full/Part")]
        public string ProposerOccFullPartTwo { get; set; }

        [Display(Name = "Personal Details>")]
        public string ProposerPersonalDetails { get; set; }

        [Display(Name = "Title:")]
        public string ProposerTitle { get; set; }

        [Display(Name = "Surname:")]
        public string ProposerSurname { get; set; }

        [Display(Name = "Forenames:")]
        public string ProposerForenames { get; set; }

        [Display(Name = "Relationship:")]
        public string ProposerRelationship { get; set; }

        [Display(Name = "At Risk Address?")]
        public string ProposerAtRiskAddress { get; set; }

        [Display(Name = "First Time Buyer?")]
        public string ProposerFirstTimeBuyer { get; set; }



        public List<SelectListItem> Relationship { set; get; }
        public List<SelectListItem> YN { set; get; }
        public List<SelectListItem> Business{ set; get; }
        public List<SelectListItem> Occupation { set; get; }
        public List<SelectListItem> Status { set; get; }
        public List<SelectListItem> Time { set; get; }
        public List<SelectListItem> Sex { set; get; }
        public List<SelectListItem> Title { set; get; }


        public ProposerDetail()
        {
            Relationship = new List<SelectListItem>();
            YN = new List<SelectListItem>();
            Business = new List<SelectListItem>();
            Occupation  = new List<SelectListItem>();
            Status = new List<SelectListItem>();
            Time = new List<SelectListItem>();
            Title = new List<SelectListItem>();
            Sex = new List<SelectListItem>();

        }


        public virtual PolicyMain PolicyMain { get; set; }
    }
}