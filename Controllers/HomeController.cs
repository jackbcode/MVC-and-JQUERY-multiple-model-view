using PolicyCheck.Helper;
using PolicyCheck.Models;
using PolicyCheck.Models.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PolicyCheck.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Create()
        {

            OpenGIABICodesEntities1 db2 = new OpenGIABICodesEntities1();

            PolicyMain db = new PolicyMain();

            List<SelectListItem> yesNo = new List<SelectListItem>();

            yesNo.Add(new SelectListItem { Text = "Yes", Value = "Yes" });
            yesNo.Add(new SelectListItem { Text = "No", Value = "No" });


            List<SelectListItem> Sex = new List<SelectListItem>();

            Sex.Add(new SelectListItem { Text = "Female", Value = " Female" });
            Sex.Add(new SelectListItem { Text = "Male", Value = "Male" });

            List<SelectListItem> Residence = new List<SelectListItem>();


            Residence.Add(new SelectListItem { Text = "Main Sole - Occupants", Value = "Main Sole - Occupants" });
            Residence.Add(new SelectListItem { Text = "Main Co - Occupants", Value = "Main Co - Occupants" });
            Residence.Add(new SelectListItem { Text = "Non-Occupant", Value = "Non-Occupant" });

            List<SelectListItem> BusinessUse = new List<SelectListItem>();
            
            BusinessUse.Add(new SelectListItem { Text = "None", Value = "None" });
            BusinessUse.Add(new SelectListItem { Text = "Full", Value = "Full" });
            BusinessUse.Add(new SelectListItem { Text = "Clerical Only", Value = "Clerical Only" });

            List<SelectListItem> Territory = new List<SelectListItem>
            {
                new SelectListItem { Text = "Europe", Value = "Europe" },
                new SelectListItem { Text = "UK", Value = "UK" },
                new SelectListItem { Text = "World-Wide", Value = "World-Wide" }
            };

            List<SelectListItem> InterestedPartyType = new List<SelectListItem>();

            InterestedPartyType.Add(new SelectListItem { Text = "Bank Vault", Value = "Bank Vault" });
            InterestedPartyType.Add(new SelectListItem { Text = "Co-Ownwer", Value = "Co-Ownwer" });
            InterestedPartyType.Add(new SelectListItem { Text = "Credit Sale", Value = "Credit Sale" });
            InterestedPartyType.Add(new SelectListItem { Text = "Debenture Holder", Value = "Debenture Holder" });
            InterestedPartyType.Add(new SelectListItem { Text = "First Mortgagee", Value = "First Mortgagee" });
            InterestedPartyType.Add(new SelectListItem { Text = "Freeholder", Value = "Freeholder" });
            InterestedPartyType.Add(new SelectListItem { Text = "Ground Landlord", Value = "Ground Landlord" });
            InterestedPartyType.Add(new SelectListItem { Text = "Heritable Creditor - Primo Loco", Value = "Heritable Creditor - Primo Loco" });
            InterestedPartyType.Add(new SelectListItem { Text = "Heritable Creditor - Secundo Loco", Value = "Heritable Creditor - Secundo Loco" });
            InterestedPartyType.Add(new SelectListItem { Text = "Heritable Creditor - Tertio Loco", Value = "Heritable Creditor - Tertio Loco" });
            InterestedPartyType.Add(new SelectListItem { Text = "Hire Purchase", Value = "Hire Purchase" });
            InterestedPartyType.Add(new SelectListItem { Text = "Hirer", Value = "Hirer" });
            InterestedPartyType.Add(new SelectListItem { Text = "Holder Of A Floating Charge", Value = "Holder Of A Floating Charge" });
            InterestedPartyType.Add(new SelectListItem { Text = "Landlord", Value = "Landlord" });
            InterestedPartyType.Add(new SelectListItem { Text = "Leaseholder", Value = "Leaseholder" });
            InterestedPartyType.Add(new SelectListItem { Text = "Lessee", Value = "Lessee" });
            InterestedPartyType.Add(new SelectListItem { Text = "Lessor", Value = "Lessor" });
            InterestedPartyType.Add(new SelectListItem { Text = "Mortgagee", Value = "Mortgagee" });
            InterestedPartyType.Add(new SelectListItem { Text = "Mortgagee Of The Leaseholder Interest", Value = "Mortgagee Of The Leaseholder Interest" });
            InterestedPartyType.Add(new SelectListItem { Text = "Mortgagor", Value = "Mortgagor" });
            InterestedPartyType.Add(new SelectListItem { Text = "Operator", Value = "Operator" });
            InterestedPartyType.Add(new SelectListItem { Text = "Other Lender", Value = "Other Lender" });
            InterestedPartyType.Add(new SelectListItem { Text = "Other Occupier", Value = "Other Occupier" });
            InterestedPartyType.Add(new SelectListItem { Text = "Owner", Value = "Owner" });
            InterestedPartyType.Add(new SelectListItem { Text = "Proprietor In Reversion", Value = "Proprietor In Reversion" });
            InterestedPartyType.Add(new SelectListItem { Text = "Registered Keeper", Value = "Registered Keeper" });
            InterestedPartyType.Add(new SelectListItem { Text = "Second Mortgagee", Value = "Second Mortgagee" });
            InterestedPartyType.Add(new SelectListItem { Text = "Standard Bank Interest", Value = "Standard Bank Interest" });
            InterestedPartyType.Add(new SelectListItem { Text = "Tenant", Value = "Tenant" });
            InterestedPartyType.Add(new SelectListItem { Text = "ZZ - Not Covered By Any Other Code", Value = "ZZ - Not Covered By Any Other Code" });


            List<SelectListItem> BuildingsCoverType = new List<SelectListItem>();

            BuildingsCoverType.Add(new SelectListItem { Text = "Accidental", Value = "Accidental" });
            BuildingsCoverType.Add(new SelectListItem { Text = "Standard", Value = "Standard" });

            List<SelectListItem> ContentsCoverType = new List<SelectListItem>();

            ContentsCoverType.Add(new SelectListItem { Text = "Accidental", Value = "Accidental" });
            ContentsCoverType.Add(new SelectListItem { Text = "New for Old", Value = "New for Old" });

            List<SelectListItem> ProofOfInsurerPayment = new List<SelectListItem>();

            ProofOfInsurerPayment.Add(new SelectListItem { Text = "Schedule", Value = "Schedule" });
            ProofOfInsurerPayment.Add(new SelectListItem { Text = "Telephone", Value = "Telephone" });
            ProofOfInsurerPayment.Add(new SelectListItem { Text = "Written", Value = "Written" });

            List<SelectListItem> Time = new List<SelectListItem>();

            Time.Add(new SelectListItem { Text = "Full", Value = "Full" });
            Time.Add(new SelectListItem { Text = "Part", Value = "Part" });

            List<SelectListItem> CaravanType = new List<SelectListItem>();

            CaravanType.Add(new SelectListItem { Text = "Holiday Home", Value = "Holiday Home" });
            CaravanType.Add(new SelectListItem { Text = "Residential Park Home", Value = "Residential Park Home" });
            CaravanType.Add(new SelectListItem { Text = "Tourer", Value = "Tourer" });
            CaravanType.Add(new SelectListItem { Text = "Trailer Tent", Value = "Trailer Tent" });

            List<SelectListItem> EngineType = new List<SelectListItem>();

            EngineType.Add(new SelectListItem { Text = "Inboard", Value = "Inboard" });
            EngineType.Add(new SelectListItem { Text = "Outboard", Value = "Outboard" });

            List<SelectListItem> BoatClass = new List<SelectListItem>();

            BoatClass.Add(new SelectListItem { Text = "Fun Boats", Value = "Fun Boats" });
            BoatClass.Add(new SelectListItem { Text = "Powered", Value = "Powered" });
            BoatClass.Add(new SelectListItem { Text = "UnPowered", Value = "UnPowered" });

            List<SelectListItem> BicycleTerritory3 = new List<SelectListItem>
            {
                new SelectListItem { Text = "Europe", Value = "Europe" },
                new SelectListItem { Text = "UK", Value = "UK" },
                new SelectListItem { Text = "World-Wide", Value = "World-Wide" }
            };

            var bicycle = new CAllrisksBicycle();

            bicycle.BicycleTerritory2 = BicycleTerritory3;

            var convictionsModel = new MPConviction();

            var CVList = new SelectList(db2.Person_ConvictionType.ToList(), "abiCode", "vtDescription").ToList();

            convictionsModel.CL = CVList;
            convictionsModel.YN = yesNo;

            var claimsModel = new MPClaimsLoss();
            var claimsList = new SelectList(db2.Home_ClaimType.ToList(), "vtCode", "vtDescription").ToList();


            List<SelectListItem> claimsSection = new List<SelectListItem>();

            claimsSection.Add(new SelectListItem { Text = "Legal Expenses", Value = "Legal Expenses" });
            claimsSection.Add(new SelectListItem { Text = "Annual Leave", Value = "Annual Leave" });
            claimsSection.Add(new SelectListItem { Text = "Buildings", Value = "Buildings" });
            claimsSection.Add(new SelectListItem { Text = "Contents", Value = "Contents" });
            claimsSection.Add(new SelectListItem { Text = "All-Risks", Value = "All-Risks" });
            claimsSection.Add(new SelectListItem { Text = "Other", Value = "Other" });
            claimsSection.Add(new SelectListItem { Text = "Small Craft", Value = "Small Craft" });
            claimsSection.Add(new SelectListItem { Text = "Caravan", Value = "Caravan" });

            claimsModel.CS = claimsSection;
            claimsModel.ClaimsL = claimsList;
            claimsModel.YN = yesNo;

            var specifiedItemsModel = new CSpecifiedItem();
            var itemCatDesc = new SelectList(db2.SpecifiedItem_Category.ToList(), "vtCode", "vtDescription").ToList();

            


            List<SelectListItem> iCover = new List<SelectListItem>();

            iCover.Add(new SelectListItem { Text = "All Risks", Value = "All Risks" });
            iCover.Add(new SelectListItem { Text = "Caravan", Value = "Caravan" });
            iCover.Add(new SelectListItem { Text = "Contents", Value = "Contents" });

            specifiedItemsModel.YN = yesNo;
            specifiedItemsModel.ICD = itemCatDesc;
            specifiedItemsModel.ItemCover = iCover;
            specifiedItemsModel.ItemTerritory = Territory;

            var proposerDetailsModel = new ProposerDetail();
            var relationshipData = new SelectList(db2.Person_RelationshipToProp
               .ToList(), "vtCode", "vtDescription").ToList();

            var BusinessType = new SelectList(db2.Person_BusinessType.ToList(), "abiCode", "vtDescription").ToList();
            var OccupationList = new SelectList(db2.Person_Occupation.ToList(), "abiCode", "vtDescription").ToList();
            var StatusList = new SelectList(db2.Person_EmpStat.ToList(), "abiCode", "vtDescription").ToList();
            var TitleList = new SelectList(db2.Person_Title.ToList(), "abiCode", "vtDescription").ToList();
            proposerDetailsModel.Relationship = relationshipData;
            proposerDetailsModel.Business = BusinessUse;
            proposerDetailsModel.Occupation = OccupationList;
            proposerDetailsModel.Status = StatusList;
            proposerDetailsModel.Time = Time;



            PolicyMain test = new PolicyMain
            {
                yesNo = yesNo,
                HouseType = new SelectList(db2.Property_HouseType.ToList(), "abiCode", "vtDescription"),
                Heating = new SelectList(db2.Property_PrimaryHeating.ToList(), "abiCode", "vtDescription"),
                Sex = Sex,
                Walls = new SelectList(db2.Property_Construction.ToList(), "abiCode", "vtDescription"),
                Roof = new SelectList(db2.Property_RoofType.ToList(), "abiCode", "vtDescription"),
                BuildingListed = new SelectList(db2.Property_Listed.ToList(), "abiCode", "vtDescription"),
                Accomodation = new SelectList(db2.Property_Accommodation.ToList(), "vtCode", "vtDescription"),
                Residence = Residence,
                Unoccupied = new SelectList(db2.Property_Unoccupancy.ToList(), "vtCode", "vtDescription"),
                BusinessUse = BusinessUse,
                AlarmType = new SelectList(db2.Alarm_Type.ToList(), "abiCode", "vtDescription"),
                AccredDetails = new SelectList(db2.Alarm_AccredDetails2.ToList(), "abiCode", "vtDescription"),
                MaintainerCompany = new SelectList(db2.Alarm_MaintenanceCompany.ToList(), "abiCode", "vtDescription"),
                InterestedParty = new SelectList(db2.Home_InterestedPartyName.ToList(), "abiCode", "vtDescription"),
                InterestedPartyType = InterestedPartyType,
                BuildingsCoverType = BuildingsCoverType,
                ContentsCoverType = ContentsCoverType,
                ProofOfInsurerPayment = ProofOfInsurerPayment,
                Time = Time,
                PreviousInsurer = new SelectList(db2.Buildings_Insurer.ToList(), "abiCode", "vtDescription"),
                BusinessType = new SelectList(db2.Person_BusinessType.ToList(), "abiCode", "vtDescription"),
                Occupation = new SelectList(db2.Person_Occupation.ToList(), "abiCode", "vtDescription"),
                Status = new SelectList(db2.Person_EmpStat.ToList(), "abiCode", "vtDescription"),
                Title = new SelectList(db2.Person_Title.ToList(), "abiCode", "vtDescription"),
                CaravanType = CaravanType,
                EngineType = EngineType,
                BoatClass = BoatClass,
                Territory = Territory,
                Bicycles = new[]
                   {
                      new CAllrisksBicycle { BicycleValue = 0, BicycleMake = "", BicycleModel = "", BicycleTerritory2 = BicycleTerritory3},

                  }.ToList(),
                Convictions = new[]
                   {
                      new MPConviction {CL = CVList, YN = yesNo},}.ToList(),
                ClaimsLosses = new[]
                   {
                      new MPClaimsLoss {CS = claimsSection, ClaimsL = claimsList, YN = yesNo},

                  }.ToList(),
                SpecifiedItems = new[]
                   {
                      new CSpecifiedItem {YN = yesNo, ICD = itemCatDesc, ItemCover = iCover,ItemTerritory = Territory},

                  }.ToList(),

                PropDetails = new[]
                   {
                      new ProposerDetail {Relationship = relationshipData, YN = yesNo, Sex = Sex, Occupation = OccupationList, Business = BusinessType, Status = StatusList, Time = Time, Title = TitleList},

                  }.ToList(),

            };








            return View(test);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PolicyMain test/*, CAllrisksBicycle bicycle*/)
        {

            PolicyCheckEntities53 db = new PolicyCheckEntities53();
            db.PolicyMains.Add(test);

            foreach (var i in test.Bicycles)
            {

                i.AllrisksBicyclePolicyId = test.id;


                db.CAllrisksBicycles.Add(i);
            }

            foreach (var i in test.Convictions)
            {

                i.ConvictionsPolicyId = test.id;


                db.MPConvictions.Add(i);
            }

            foreach (var i in test.ClaimsLosses)
            {

                i.ClaimsLossesPolicyId = test.id;


                db.MPClaimsLosses.Add(i);
            }

            foreach (var i in test.SpecifiedItems)
            {

                i.SpecifiedItemPolicyId = test.id;


                db.CSpecifiedItems.Add(i);
            }

            foreach (var i in test.PropDetails)
            {

                i.ProposerPolicyId = test.id;


                db.ProposerDetails.Add(i);
            }

            db.SaveChanges();

            return RedirectToAction("Index");

        }
        
        public ActionResult BlankEditorRow()
        {
            List<SelectListItem> BicycleTerritory3 = new List<SelectListItem>
            {
                new SelectListItem { Text = "Europe", Value = "Europe" },
                new SelectListItem { Text = "UK", Value = "UK" },
                new SelectListItem { Text = "World-Wide", Value = "World-Wide" }
            };


            var bicycle = new CAllrisksBicycle();

            bicycle.BicycleTerritory2 = BicycleTerritory3;


            return PartialView("EditorRow", bicycle);
        }

        public ActionResult ProposersRow()
        {
            OpenGIABICodesEntities1 db2 = new OpenGIABICodesEntities1();
            var ProposersModel = new ProposerDetail();

            var relationshipData = new SelectList(db2.Person_RelationshipToProp
               .ToList(), "vtCode", "vtDescription").ToList();

            List<SelectListItem> yesNo = new List<SelectListItem>();

            yesNo.Add(new SelectListItem { Text = "Yes", Value = "Yes" });
            yesNo.Add(new SelectListItem { Text = "No", Value = "No" });

            List<SelectListItem> Sex = new List<SelectListItem>();

            Sex.Add(new SelectListItem { Text = "Female", Value = " Female" });
            Sex.Add(new SelectListItem { Text = "Male", Value = "Male" });

            List<SelectListItem> BusinessUse = new List<SelectListItem>();

            BusinessUse.Add(new SelectListItem { Text = "None", Value = "None" });
            BusinessUse.Add(new SelectListItem { Text = "Full", Value = "Full" });
            BusinessUse.Add(new SelectListItem { Text = "Clerical Only", Value = "Clerical Only" });

            List<SelectListItem> Time = new List<SelectListItem>();

            Time.Add(new SelectListItem { Text = "Full", Value = "Full" });
            Time.Add(new SelectListItem { Text = "Part", Value = "Part" });

            var BusinessType = new SelectList(db2.Person_BusinessType.ToList(), "abiCode", "vtDescription").ToList();
            var OccupationList = new SelectList(db2.Person_Occupation.ToList(), "abiCode", "vtDescription").ToList();
            var StatusList = new SelectList(db2.Person_EmpStat.ToList(), "abiCode", "vtDescription").ToList();
            var TitleList = new SelectList(db2.Person_Title.ToList(), "abiCode", "vtDescription").ToList();

            ProposersModel.Relationship = relationshipData;
            ProposersModel.YN = yesNo;
            ProposersModel.Business = BusinessType;
            ProposersModel.Occupation = OccupationList;
            ProposersModel.Status = StatusList;
            ProposersModel.Time = Time;
            ProposersModel.Title = TitleList;
            ProposersModel.Sex = Sex;

            return PartialView("ProposersRow", ProposersModel);
        }

        public ActionResult ConvictionsRow()
        {
            OpenGIABICodesEntities1 db2 = new OpenGIABICodesEntities1();


            var convictionsModel = new MPConviction();

            //var CList = new SelectList(db2.Person_ConvictionType.ToList(), "abiCode", "vtDescription");



            var CVList = new SelectList(db2.Person_ConvictionType.ToList(), "abiCode", "vtDescription").ToList();

            convictionsModel.CL = CVList;

            List<SelectListItem> yesNo = new List<SelectListItem>();

            yesNo.Add(new SelectListItem { Text = "Yes", Value = "Yes" });
            yesNo.Add(new SelectListItem { Text = "No", Value = "No" });

            convictionsModel.YN = yesNo;



            //MPconvictions.CL = CList;


            return PartialView("ConvictionsRow", convictionsModel);
        }

        public ActionResult ClaimsRow()
        {
            OpenGIABICodesEntities1 db2 = new OpenGIABICodesEntities1();

            var claimsModel = new MPClaimsLoss();
            var claimsList = new SelectList(db2.Home_ClaimType.ToList(), "vtCode", "vtDescription").ToList();


            List<SelectListItem> claimsSection = new List<SelectListItem>();

            claimsSection.Add(new SelectListItem { Text = "Legal Expenses", Value = "Legal Expenses" });
            claimsSection.Add(new SelectListItem { Text = "Annual Leave", Value = "Annual Leave" });
            claimsSection.Add(new SelectListItem { Text = "Buildings", Value = "Buildings" });
            claimsSection.Add(new SelectListItem { Text = "Contents", Value = "Contents" });
            claimsSection.Add(new SelectListItem { Text = "All-Risks", Value = "All-Risks" });
            claimsSection.Add(new SelectListItem { Text = "Other", Value = "Other" });
            claimsSection.Add(new SelectListItem { Text = "Small Craft", Value = "Small Craft" });
            claimsSection.Add(new SelectListItem { Text = "Caravan", Value = "Caravan" });


            List<SelectListItem> yesNo = new List<SelectListItem>();

            yesNo.Add(new SelectListItem { Text = "Yes", Value = "Yes" });
            yesNo.Add(new SelectListItem { Text = "No", Value = "No" });

            claimsModel.YN = yesNo;
            claimsModel.CS = claimsSection;
            claimsModel.ClaimsL = claimsList;




            return PartialView("ClaimsRow", claimsModel);
        }

        public ActionResult SpecifiedItemsRow()
        {
            OpenGIABICodesEntities1 db2 = new OpenGIABICodesEntities1();

            var specifiedItemsModel = new CSpecifiedItem();
            var itemCatDesc = new SelectList(db2.SpecifiedItem_Category.ToList(), "vtCode", "vtDescription").ToList();


            List<SelectListItem> iCover = new List<SelectListItem>();

            iCover.Add(new SelectListItem { Text = "All Risks", Value = "All Risks" });
            iCover.Add(new SelectListItem { Text = "Caravan", Value = "Caravan" });
            iCover.Add(new SelectListItem { Text = "Contents", Value = "Contents" });


            List<SelectListItem> yesNo = new List<SelectListItem>();

            yesNo.Add(new SelectListItem { Text = "Yes", Value = "Yes" });
            yesNo.Add(new SelectListItem { Text = "No", Value = "No" });

            List<SelectListItem> Territory = new List<SelectListItem>
            {
                new SelectListItem { Text = "Europe", Value = "Europe" },
                new SelectListItem { Text = "UK", Value = "UK" },
                new SelectListItem { Text = "World-Wide", Value = "World-Wide" }
            };

            specifiedItemsModel.YN = yesNo;
            specifiedItemsModel.ICD = itemCatDesc;
            specifiedItemsModel.ItemCover = iCover;
            specifiedItemsModel.ItemTerritory = Territory;




            return PartialView("SpecifiedItemsRow", specifiedItemsModel);
        }




        //////////////////////////Upload Quote////////////////////////////////////////////////////////


        public ActionResult UploadQuote()
        {
            return View();
        }
        
        public ActionResult UploadQuoteDB(string clientRef)
        {

            ViewBag.Message = clientRef;

            ParagonEntities15 UploadPolicy = new ParagonEntities15();

            IEnumerable policy = UploadPolicy.PolicyCheckUploadParagon(clientRef);

            ////IEnumerable policy = UploadPolicy.ClaimsUpload(clientRef);
            
            var NumberOfPeople = UploadPolicy.PolicyCheckUploadParagon(clientRef).Select(x => x.Propforenames).Count();

            RiskQuoteBuilder.BuildQuotes(clientRef);


            return View("UploadQuoteDB", policy);
        }

        public ActionResult UploadSpecifiedItemsRow(string clientRef)
        {
            ParagonEntities15 UploadPolicy = new ParagonEntities15();

            IEnumerable UploadSpecifiedItemsModel = UploadPolicy.SpecItemUploadParagon(clientRef);

            var NumberOfSpecifiedItems = UploadPolicy.SpecItemUploadParagon(clientRef).Select(x => x.Stated_value).Count();

            return PartialView("UploadSpecifiedItemsRow", UploadSpecifiedItemsModel);

        }

        public ActionResult UploadClaimsItemsRow(string clientRef)
        {
            ParagonEntities15 UploadPolicy = new ParagonEntities15();

            IEnumerable UploadClaimsModel = UploadPolicy.ClaimsUploadParagon(clientRef);

            var NumberOfClaims = UploadPolicy.ClaimsUploadParagon(clientRef).Select(x => x.C_Value).Count();


            return PartialView("UploadClaimsItemsRow", UploadClaimsModel);

        }

        public ActionResult ProposerDetails(string clientRef, int polNo)
        {
            ViewBag.Message = clientRef;

            ViewBag.polNo = polNo;

            
            //int polNoInt = Convert.ToInt32(polNo);

            ParagonEntities15 UploadProposerDetails = new ParagonEntities15();

            IEnumerable UploadProposer = UploadProposerDetails.PCProposersParagonNo(clientRef, polNo);

            var ProposerMax = UploadProposerDetails.PCProposersParagonNo(clientRef, polNo).Max();
            var NumberOfPeople = UploadProposerDetails.PolicyCheckUploadParagon(clientRef).Select(x => x.Propforenames).Count();

            ViewBag.NumberOfProposers = NumberOfPeople;


            return PartialView("ProposerDetails", UploadProposer);

        }

        //////////////////////////Upload Policy////////////////////////////////////////////////////////


        public ActionResult UploadPolicy()
        {
            return View();
        }

        public ActionResult UploadPolicyDB(string clientRef)
        {

            ViewBag.Message = clientRef;

            ParagonEntities15 UploadPolicy = new ParagonEntities15();

            IEnumerable policy = UploadPolicy.PolicyCheckUploadParagonBD(clientRef);

            ////IEnumerable policy = UploadPolicy.ClaimsUpload(clientRef);
            RiskPolicyBuilder.BuildPolicy(clientRef);

            return View("UploadPolicyDB", policy);
        }

        public ActionResult UploadSpecifiedItemsRowBD(string clientRef)
        {
            ParagonEntities15 UploadPolicy = new ParagonEntities15();

            IEnumerable UploadSpecifiedItemsModel = UploadPolicy.SpecItemUploadParagonBD(clientRef);

            return PartialView("UploadSpecifiedItemsRowBD", UploadSpecifiedItemsModel);

        }

        public ActionResult UploadClaimsItemsRowBD(string clientRef)
        {
            ParagonEntities15 UploadPolicy = new ParagonEntities15();

            IEnumerable UploadClaimsModel = UploadPolicy.ClaimsUploadParagonBD(clientRef);

            return PartialView("UploadClaimsItemsRowBD", UploadClaimsModel);

        }

        public ActionResult ProposerDetailsPolicy(string clientRef, int polNo)
        {
            ViewBag.Message = clientRef;

            ViewBag.polNo = polNo;


            //int polNoInt = Convert.ToInt32(polNo);

            ParagonEntities15 UploadProposerDetails = new ParagonEntities15();

            IEnumerable UploadProposer = UploadProposerDetails.PCProposersParagonBDNo(clientRef, polNo);

            var ProposerMax = UploadProposerDetails.PCProposersParagonBDNo(clientRef, polNo).Max();
            var NumberOfPeople = UploadProposerDetails.PolicyCheckUploadParagonBD(clientRef).Select(x => x.Propforenames).Count();

            ViewBag.NumberOfProposers = NumberOfPeople;


            return PartialView("ProposerDetailsPolicy", UploadProposer);

        }

        ////////////////////////// SEND XML CODES ////////////////////////////////////////////////////////




    }



}