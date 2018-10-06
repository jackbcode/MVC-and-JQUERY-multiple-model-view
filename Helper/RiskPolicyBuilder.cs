using PolicyCheck.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace PolicyCheck.Helper
{

    public class RiskPolicyBuilder
    {
        public static void BuildPolicy(string clientRef)
        {
            ParagonEntities15 UploadPolicy = new ParagonEntities15();

            IEnumerable policyUpload = UploadPolicy.PolicyCheckUploadParagonBD(clientRef);

            var NumberOfPeople = UploadPolicy.PolicyCheckUploadParagonBD(clientRef).Select(x => x.Propforenames).Count();

            var policyUploadDS = UploadPolicy.PolicyCheckUploadParagonBD(clientRef).ToList();

            IEnumerable SpecItems = UploadPolicy.SpecItemUploadParagonBD(clientRef);

            var SpecItemsList = UploadPolicy.SpecItemUploadParagonBD(clientRef).ToList();

            var NumberOfSpecItems = UploadPolicy.SpecItemUploadParagonBD(clientRef).Select(x => x.amount).Count();

            IEnumerable UploadClaimsModel = UploadPolicy.ClaimsUploadParagonBD(clientRef);

            var NumberOfClaims = UploadPolicy.ClaimsUploadParagonBD(clientRef).Select(x => x.C_Value).Count();

            var ClaimsuploadDS = UploadPolicy.ClaimsUploadParagonBD(clientRef).ToList();

            var UploadProposer = UploadPolicy.PCProposersParagonBD1(clientRef).ToList();





            OpenGIABICodesEntities1 abi = new OpenGIABICodesEntities1();

            var loadPolicy_MotorPolicyInsurer_AbiCodes =
                abi.Policy_MotorPolicyInsurer
                    .Select(p => new { p.abiCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.abiCode, kvp => kvp.vtDescription);

            var loadPerson_MaritalStatus_AbiCodes =
                abi.Person_MaritalStatus
                    .Select(p => new { p.abiCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.abiCode, kvp => kvp.vtDescription);

            var loadPerson_EmpStat_AbiCodes =
                abi.Person_EmpStat
                    .Select(p => new { p.abiCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.abiCode, kvp => kvp.vtDescription);

            var loadPerson_OccType_AbiCodes =
                abi.Person_Occupation
                    .Select(p => new { p.abiCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.abiCode, kvp => kvp.vtDescription);

            var loadPerson_BusType_AbiCodes =
                abi.Person_BusinessType
                    .Select(p => new { p.abiCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.abiCode, kvp => kvp.vtDescription);

            var loadProperty_HouseType_AbiCodes =
                abi.Property_HouseType
                    .Select(p => new { p.abiCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.abiCode, kvp => kvp.vtDescription);

            var loadProperty_PrimaryHeating_AbiCodes =
                abi.Property_PrimaryHeating
                    .Select(p => new { p.abiCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.abiCode, kvp => kvp.vtDescription);

            var loadProperty_Construction_AbiCodes =
                abi.Property_Construction
                    .Select(p => new { p.abiCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.abiCode, kvp => kvp.vtDescription);

            var loadProperty_Listed_AbiCodes =
                abi.Property_Listed
                    .Select(p => new { p.abiCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.abiCode, kvp => kvp.vtDescription);

            var loadProperty_RoofType_AbiCodes =
                abi.Property_RoofType
                    .Select(p => new { p.abiCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.abiCode, kvp => kvp.vtDescription);

            var loadAlarm_Type_AbiCodes =
                abi.Alarm_Type
                    .Select(p => new { p.abiCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.abiCode, kvp => kvp.vtDescription);

            var loadAlarm_MaintenanceCompany_AbiCodes =
                abi.Alarm_MaintenanceCompany
                    .Select(p => new { p.abiCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.abiCode, kvp => kvp.vtDescription);

            var loadAlarm_AccredDetails2_AbiCodes =
                abi.Alarm_AccredDetails2
                    .Select(p => new { p.abiCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.abiCode, kvp => kvp.vtDescription);

            var loadSpecifiedItem_Category_AbiCodes =
                abi.SpecifiedItem_Category
                    .Select(p => new { p.abiCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.abiCode, kvp => kvp.vtDescription);

            var loadBuildings_Insurer_AbiCodes =
                abi.Buildings_Insurer
                    .Select(p => new { p.abiCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.abiCode, kvp => kvp.vtDescription);

            var loadContents_Insurer_AbiCodes =
                abi.Contents_Insurer
                    .Select(p => new { p.abiCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.abiCode, kvp => kvp.vtDescription);

            var loadProperty_Unoccupancy_AbiCodes =
                abi.Property_Unoccupancy
                    .Select(p => new { p.vtCode, p.vtDescription })
                    .AsEnumerable()
                    .ToDictionary(kvp => kvp.vtCode, kvp => kvp.vtDescription);

            XmlDocument doc = new XmlDocument();
            // Root element
            XmlElement risk = doc.CreateElement("Risk");
            doc.AppendChild(risk);
            // Create Policy
            XmlElement policy = doc.CreateElement("Policy");
            risk.AppendChild(policy);
            XmlElement quoteAndBuy = doc.CreateElement("QuoteAndBuy");
            quoteAndBuy.InnerText = "Y";
            XmlElement cover = doc.CreateElement("Cover");

            if (policyUploadDS[0].Buildingssi > 0 && policyUploadDS[0].Contentssi > 0)
            {
                var coverData = "BC";
                cover.InnerText = coverData;
                policy.AppendChild(cover);
            }

            else if (policyUploadDS[0].Buildingssi > 0)
            {
                var coverData = "B";
                cover.InnerText = coverData;
                policy.AppendChild(cover);
            }

            else
            {
                var coverData = "C";
                cover.InnerText = coverData;
                policy.AppendChild(cover);

            }


            XmlElement legal = doc.CreateElement("LegalExpensesRequired");
            XmlAttribute abiCode1 = doc.CreateAttribute("abiCode");
            abiCode1.Value = "N";
            legal.Attributes.Append(abiCode1);
            XmlElement coverDate = doc.CreateElement("CoverDate");

            coverDate.InnerText = Convert.ToString(policyUploadDS[0].Coverdate);
            XmlElement coverTime = doc.CreateElement("CoverTime");
            coverTime.InnerText = "00:01";

            XmlElement numberOfPeople = doc.CreateElement("NumberOfPeople");
            numberOfPeople.InnerText = NumberOfPeople.ToString();
            XmlElement bankrupt = doc.CreateElement("Bankrupt");
            XmlAttribute abiCode2 = doc.CreateAttribute("abiCode");
            abiCode2.Value = (policyUploadDS[0].Bankrupt == "No" || policyUploadDS[0].Bankrupt == null) ? "N" : "Y";
            bankrupt.Attributes.Append(abiCode2);

            XmlElement currentMotorPolicy = doc.CreateElement("CurrentMotorPolicy");
            XmlAttribute abiCode3 = doc.CreateAttribute("abiCode");
            abiCode3.Value = (policyUploadDS[0].Currentmotorpolicy == "No" || policyUploadDS[0].Currentmotorpolicy == null) ? "N" : "Y";
            currentMotorPolicy.Attributes.Append(abiCode3);
            XmlElement insuranceRefused = doc.CreateElement("InsRefused");
            XmlAttribute abiCode4 = doc.CreateAttribute("abiCode");
            abiCode4.Value = (policyUploadDS[0].Refused == "No" || policyUploadDS[0].Refused == null) ? "N" : "Y";
            insuranceRefused.Attributes.Append(abiCode4);
            XmlElement motorPolicyInsurer = doc.CreateElement("MotorPolicyInsurer");
            XmlAttribute abiCode5 = doc.CreateAttribute("abiCode");
            abiCode5.Value = loadPolicy_MotorPolicyInsurer_AbiCodes.ContainsValue(policyUploadDS[0].MotorInsurer) ? loadPolicy_MotorPolicyInsurer_AbiCodes.FindKeyByValue(policyUploadDS[0].MotorInsurer).Trim() : "997";
            motorPolicyInsurer.Attributes.Append(abiCode5);
            XmlElement numberOfClaims = doc.CreateElement("NumberOfClaims");
            numberOfClaims.InnerText = NumberOfClaims.ToString();
            XmlElement smokers = doc.CreateElement("Smokers");
            XmlAttribute abiCode6 = doc.CreateAttribute("abiCode");
            abiCode6.Value = (policyUploadDS[0].Smokers == "No" || policyUploadDS[0].Smokers == null) ? "N" : "Y";
            smokers.Attributes.Append(abiCode6);
            XmlElement numberOfSpecifiedItems = doc.CreateElement("NumberOfSpecifiedItems");
            numberOfSpecifiedItems.InnerText = NumberOfSpecItems.ToString();
            XmlElement specifiedItemsCover = doc.CreateElement("SpecifiedItemsCover");
            XmlAttribute abiCode7 = doc.CreateAttribute("abiCode");
            abiCode7.Value = NumberOfSpecItems > 0 ? "Y" : "N";
            specifiedItemsCover.Attributes.Append(abiCode7);

            policy.AppendChild(quoteAndBuy);

            policy.AppendChild(legal);
            policy.AppendChild(coverDate);
            policy.AppendChild(coverTime);
            policy.AppendChild(numberOfPeople);
            policy.AppendChild(bankrupt);
            policy.AppendChild(currentMotorPolicy);
            policy.AppendChild(insuranceRefused);
            policy.AppendChild(motorPolicyInsurer);
            policy.AppendChild(numberOfClaims);
            policy.AppendChild(smokers);
            policy.AppendChild(numberOfSpecifiedItems);
            policy.AppendChild(specifiedItemsCover);

            foreach (var p in UploadProposer)
            {
                // Create Person
                XmlElement person = doc.CreateElement("Person");
                risk.AppendChild(person);
                XmlElement title = doc.CreateElement("Title");
                title.InnerText = p.Title == "Dr" ? "Doctor" : p.Title;
                XmlElement firstName = doc.CreateElement("FirstName");
                firstName.InnerText = p.Propforenames;
                XmlElement surname = doc.CreateElement("Surname");
                surname.InnerText = p.Propsurname;


                if (p.Propatrisk == "Yes")
                {
                    XmlElement postcode = doc.CreateElement("PostCode");
                    postcode.InnerText = p.Riskpcode;
                    XmlElement address1 = doc.CreateElement("Address1");
                    address1.InnerText = p.Riskaddr1;
                    XmlElement address2 = doc.CreateElement("Address2");
                    address2.InnerText = p.Riskaddr2;
                    XmlElement address3 = doc.CreateElement("Address3");
                    address3.InnerText = p.Riskaddr3;
                    XmlElement address4 = doc.CreateElement("Address4");
                    address4.InnerText = p.Riskaddr4;
                    person.AppendChild(postcode);
                    person.AppendChild(address1);
                    person.AppendChild(address2);
                    person.AppendChild(address3);
                    person.AppendChild(address4);

                }

                else
                {
                    XmlElement postcode = doc.CreateElement("PostCode");
                    postcode.InnerText = p.Commpcode;
                    XmlElement address1 = doc.CreateElement("Address1");
                    address1.InnerText = p.Commaddr1;
                    XmlElement address2 = doc.CreateElement("Address2");
                    address2.InnerText = p.Commaddr2;
                    XmlElement address3 = doc.CreateElement("Address3");
                    address3.InnerText = p.Commaddr3;
                    XmlElement address4 = doc.CreateElement("Address4");
                    address4.InnerText = p.Commaddr4;
                    person.AppendChild(postcode);
                    person.AppendChild(address1);
                    person.AppendChild(address2);
                    person.AppendChild(address3);
                    person.AppendChild(address4);

                }

                //XmlElement contactTelephone = doc.CreateElement("ContactTelephone");
                //contactTelephone.InnerText = p.ContactTelephone;
                //XmlElement contactEmail = doc.CreateElement("ContactEmail");
                //contactEmail.InnerText = p.ContactEmail;


                XmlAttribute abiCode8 = doc.CreateAttribute("abiCode");
                XmlElement firstTimeBuyer = doc.CreateElement("FirstTimeBuyer");
                abiCode8.Value = (p.Firsttime == "No" || p.Firsttime == null) ? "N" : "Y";
                firstTimeBuyer.Attributes.Append(abiCode8);
                XmlElement fullName = doc.CreateElement("FullName");
                fullName.InnerText = p.Title == "Dr" ? "Doctor" : p.Title + " " + p.Propforenames + " " + p.Propsurname;
                XmlAttribute abiCode9 = doc.CreateAttribute("abiCode");
                XmlElement proposerAtRiskAddress = doc.CreateElement("ProposerAtRiskAddress");
                abiCode9.Value = (p.Propatrisk == "No" || p.Propatrisk == null) ? "N" : "Y";
                proposerAtRiskAddress.Attributes.Append(abiCode9);
                XmlAttribute abiCode10 = doc.CreateAttribute("abiCode");
                XmlElement gender = doc.CreateElement("Gender");
                abiCode10.Value = p.Sex == "Male" ? "M" : "F";
                gender.Attributes.Append(abiCode10);
                XmlElement dob = doc.CreateElement("DateOfBirth");
                dob.InnerText = p.Propdob.ToString();
                //XmlElement maritalStatus = doc.CreateElement("MaritalStatus");
                //XmlAttribute abiCode11 = doc.CreateAttribute("abiCode");
                //abiCode11.Value = loadPerson_MaritalStatus_AbiCodes.ContainsValue() ? loadPerson_MaritalStatus_AbiCodes.FindKeyByValue().Trim() : "S";
                //maritalStatus.Attributes.Append(abiCode11);
                XmlAttribute abiCode12 = doc.CreateAttribute("abiCode");
                XmlElement hasClaim = doc.CreateElement("HasClaims");
                abiCode12.Value = numberOfClaims == null ? "N" : "Y";
                hasClaim.Attributes.Append(abiCode12);
                XmlAttribute abiCode13 = doc.CreateAttribute("abiCode");
                XmlElement hasConviction = doc.CreateElement("HasConvictions");
                abiCode13.Value = p.ConvType == null ? "N" : "Y";
                hasConviction.Attributes.Append(abiCode13);

                if (p.ConvType != null)
                {
                    var numberOfConvictions3 = 1;
                    XmlElement numberOfConvictions = doc.CreateElement("NumberOfConvictions");
                    numberOfConvictions.InnerText = numberOfConvictions3.ToString();
                    person.AppendChild(numberOfConvictions);
                }
                if (p.ConvType != null && p.ConvType1 != null)
                {
                    var numberOfConvictions3 = 2;
                    XmlElement numberOfConvictions = doc.CreateElement("NumberOfConvictions");
                    numberOfConvictions.InnerText = numberOfConvictions3.ToString();
                    person.AppendChild(numberOfConvictions);
                }
                if (p.ConvType != null && p.ConvType1 != null && p.ConvType2 != null)
                {
                    var numberOfConvictions3 = 3;
                    XmlElement numberOfConvictions = doc.CreateElement("NumberOfConvictions");
                    numberOfConvictions.InnerText = numberOfConvictions3.ToString();
                    person.AppendChild(numberOfConvictions);
                }
                if (p.ConvType != null && p.ConvType1 != null && p.ConvType2 != null && p.ConvType3 != null)
                {
                    var numberOfConvictions3 = 4;
                    XmlElement numberOfConvictions = doc.CreateElement("NumberOfConvictions");
                    numberOfConvictions.InnerText = numberOfConvictions3.ToString();
                    person.AppendChild(numberOfConvictions);
                }

                else
                {
                    var numberOfConvictions3 = 0;
                    XmlElement numberOfConvictions = doc.CreateElement("NumberOfConvictions");
                    numberOfConvictions.InnerText = numberOfConvictions3.ToString();
                    person.AppendChild(numberOfConvictions);

                }


                XmlElement recordedAgeForQuote = doc.CreateElement("RecordedAgeForQuote");
                recordedAgeForQuote.InnerText = p.Propage.ToString();
                //XmlElement resPeriod = doc.CreateElement("ResPeriod");
                //resPeriod.InnerText = p.ResPeriod.ToString();
                //XmlElement resUnit = doc.CreateElement("ResUnit");
                //resUnit.InnerText = "Y";
                // Occupation
                XmlElement occupation = doc.CreateElement("Occupation");
                person.AppendChild(occupation);
                XmlElement empStat = doc.CreateElement("EmpStat");
                XmlAttribute abiCode15 = doc.CreateAttribute("abiCode");
                abiCode15.Value = loadPerson_EmpStat_AbiCodes.ContainsValue(p.EmpStatus1) ? loadPerson_EmpStat_AbiCodes.FindKeyByValue(p.EmpStatus1).Trim() : "U";
                empStat.Attributes.Append(abiCode15);
                XmlElement occType = doc.CreateElement("OccType");
                XmlAttribute abiCode16 = doc.CreateAttribute("abiCode");
                abiCode16.Value = loadPerson_OccType_AbiCodes.ContainsValue(p.OccType1) ? loadPerson_OccType_AbiCodes.FindKeyByValue(p.OccType1).Trim() : "U03";
                occType.Attributes.Append(abiCode16);
                XmlElement fullPart = doc.CreateElement("FullPart");
                fullPart.InnerText = (p.Fullpart1 == "Full" || p.Fullpart1 == null) ? "F" : "P";
                XmlElement busType = doc.CreateElement("BusType");
                XmlAttribute abiCode17 = doc.CreateAttribute("abiCode");
                abiCode17.Value = loadPerson_BusType_AbiCodes.ContainsValue(p.BusType1) ? loadPerson_BusType_AbiCodes.FindKeyByValue(p.BusType1).Trim() : "747";
                busType.Attributes.Append(abiCode17);
                XmlElement relationshipToProp = doc.CreateElement("RelationshipToProp");
                relationshipToProp.InnerText = p.Relationship;

                occupation.AppendChild(title);
                occupation.AppendChild(empStat);
                occupation.AppendChild(occType);
                occupation.AppendChild(fullPart);
                occupation.AppendChild(busType);
                person.AppendChild(title);
                person.AppendChild(firstName);
                person.AppendChild(surname);
                person.AppendChild(firstTimeBuyer);
                person.AppendChild(fullName);
                person.AppendChild(proposerAtRiskAddress);
                person.AppendChild(gender);
                person.AppendChild(dob);
                //person.AppendChild(maritalStatus);
                person.AppendChild(hasClaim);
                person.AppendChild(hasConviction);
                person.AppendChild(recordedAgeForQuote);
                //person.AppendChild(resPeriod);
                //person.AppendChild(resUnit);
                person.AppendChild(occupation);
                person.AppendChild(relationshipToProp);

            }

            // Create Property
            XmlElement property = doc.CreateElement("Property");
            risk.AppendChild(property);
            // Address
            XmlElement propAddress = doc.CreateElement("Address");
            XmlElement propPostcode = doc.CreateElement("PostCode");
            propPostcode.InnerText = policyUploadDS[0].Riskpcode;
            XmlElement propaddress1 = doc.CreateElement("AddrLine1");
            propaddress1.InnerText = policyUploadDS[0].Riskaddr1;
            XmlElement propaddress2 = doc.CreateElement("AddrLine2");
            propaddress2.InnerText = policyUploadDS[0].Riskaddr2;
            XmlElement propaddress3 = doc.CreateElement("AddrLine3");
            propaddress3.InnerText = policyUploadDS[0].Riskaddr3;
            XmlElement propaddress4 = doc.CreateElement("AddrLine4");
            propaddress4.InnerText = policyUploadDS[0].Riskaddr4;
            XmlElement houseType = doc.CreateElement("HouseType");
            XmlAttribute abiCode18 = doc.CreateAttribute("abiCode");
            abiCode18.Value = loadProperty_HouseType_AbiCodes.ContainsValue(policyUploadDS[0].HouseType) ? loadProperty_HouseType_AbiCodes.FindKeyByValue(policyUploadDS[0].HouseType).Trim() : "98";
            houseType.Attributes.Append(abiCode18);
            XmlAttribute abiCode19 = doc.CreateAttribute("abiCode");
            XmlElement selfContained = doc.CreateElement("SelfContained");
            abiCode19.Value = (policyUploadDS[0].Self_contained == "No" || policyUploadDS[0].Self_contained == null) ? "N" : "Y";
            selfContained.Attributes.Append(abiCode19);
            XmlElement floors = doc.CreateElement("Floors");
            floors.InnerText = policyUploadDS[0].Floors.ToString();
            XmlElement bedrooms = doc.CreateElement("Bedrooms");
            bedrooms.InnerText = policyUploadDS[0].Bedrooms.ToString();
            XmlElement rooms = doc.CreateElement("Rooms");
            rooms.InnerText = policyUploadDS[0].Rooms.ToString();
            XmlElement primaryHeating = doc.CreateElement("PrimaryHeating");
            XmlAttribute abiCode20 = doc.CreateAttribute("abiCode");
            abiCode20.Value = loadProperty_PrimaryHeating_AbiCodes.ContainsValue(policyUploadDS[0].PrimaryHeating) ? loadProperty_PrimaryHeating_AbiCodes.FindKeyByValue(policyUploadDS[0].PrimaryHeating).Trim() : "016";
            primaryHeating.Attributes.Append(abiCode20);
            XmlAttribute abiCode21 = doc.CreateAttribute("abiCode");
            XmlElement smokeAlarm = doc.CreateElement("SmokeAlarm");
            abiCode21.Value = (policyUploadDS[0].Smokealarm == "No" || policyUploadDS[0].Smokealarm == null) ? "N" : "Y";
            smokeAlarm.Attributes.Append(abiCode21);
            XmlAttribute abiCode22 = doc.CreateAttribute("abiCode");
            XmlElement homeWatch = doc.CreateElement("HomeWatch");
            abiCode22.Value = (policyUploadDS[0].Nhood_watch == "No" || policyUploadDS[0].Nhood_watch == null) ? "N" : "Y";
            homeWatch.Attributes.Append(abiCode22);
            XmlAttribute abiCode23 = doc.CreateAttribute("abiCode");
            XmlElement holidayHome = doc.CreateElement("HolidayHome");
            abiCode23.Value = (policyUploadDS[0].Holidayhome == "No" || policyUploadDS[0].Holidayhome == null) ? "N" : "Y";
            holidayHome.Attributes.Append(abiCode23);
            XmlAttribute abiCode24 = doc.CreateAttribute("abiCode");
            XmlElement alarmQ = doc.CreateElement("AlarmQ");
            abiCode24.Value = (policyUploadDS[0].Alarm == "No" || policyUploadDS[0].Alarm == null) ? "N" : "Y";
            alarmQ.Attributes.Append(abiCode24);
            XmlElement businessUse = doc.CreateElement("BusinessUse");
            switch (policyUploadDS[0].Businessuse)
            {
                case "Full":
                    businessUse.InnerText = "F";
                    break;
                case "Clerical Only":
                    businessUse.InnerText = "C";
                    break;
                case "None":
                    businessUse.InnerText = "N";
                    break;
                default:
                    businessUse.InnerText = "N";
                    break;
            }
            XmlElement stock = doc.CreateElement("Stock");
            stock.InnerText = policyUploadDS[0].Stock.ToString();
            XmlElement equipment = doc.CreateElement("Equipment");
            equipment.InnerText = policyUploadDS[0].Equipment.ToString();
            XmlElement construction = doc.CreateElement("Construction");
            XmlAttribute abiCode25 = doc.CreateAttribute("abiCode");
            abiCode25.Value = loadProperty_Construction_AbiCodes.ContainsValue(policyUploadDS[0].Walls) ? loadProperty_Construction_AbiCodes.FindKeyByValue(policyUploadDS[0].Walls).Trim() : "02";
            construction.Attributes.Append(abiCode25);
            XmlAttribute abiCode26 = doc.CreateAttribute("abiCode");
            XmlElement extended = doc.CreateElement("Extended");
            abiCode26.Value = (policyUploadDS[0].Extended == "No" || policyUploadDS[0].Extended == null) ? "N" : "Y";
            extended.Attributes.Append(abiCode26);
            XmlAttribute abiCode27 = doc.CreateAttribute("abiCode");
            XmlElement NHBC = doc.CreateElement("NHBC");
            abiCode27.Value = (policyUploadDS[0].Nhbc_proof == "No" || policyUploadDS[0].Nhbc_proof == null) ? "N" : "Y";
            NHBC.Attributes.Append(abiCode27);
            XmlElement listed = doc.CreateElement("Listed");
            XmlAttribute abiCode28 = doc.CreateAttribute("abiCode");
            abiCode28.Value = loadProperty_Listed_AbiCodes.ContainsValue(policyUploadDS[0].BuildingListed) ? loadProperty_Listed_AbiCodes.FindKeyByValue(policyUploadDS[0].BuildingListed).Trim() : "3";
            listed.Attributes.Append(abiCode28);
            XmlElement roofType = doc.CreateElement("RoofType");
            XmlAttribute abiCode29 = doc.CreateAttribute("abiCode");
            abiCode29.Value = loadProperty_RoofType_AbiCodes.ContainsValue(policyUploadDS[0].Roof) ? loadProperty_RoofType_AbiCodes.FindKeyByValue(policyUploadDS[0].Roof).Trim() : "15";
            roofType.Attributes.Append(abiCode29);
            XmlElement flatRoofPercent = doc.CreateElement("FlatRoofPercent");
            flatRoofPercent.InnerText = policyUploadDS[0].Flatroofpc.ToString();
            XmlElement goodRepair = doc.CreateElement("GoodRepair");
            goodRepair.InnerText = (policyUploadDS[0].Goodrepair == "No" || policyUploadDS[0].Goodrepair == null) ? "N" : "Y";
            XmlElement yearBuilt = doc.CreateElement("YearBuilt");
            yearBuilt.InnerText = policyUploadDS[0].Year_blt.ToString();
            XmlAttribute abiCode30 = doc.CreateAttribute("abiCode");
            XmlElement underpinned = doc.CreateElement("Underpinned");
            abiCode30.Value = (policyUploadDS[0].Underpinned == "No" || policyUploadDS[0].Underpinned == null) ? "N" : "Y";
            underpinned.Attributes.Append(abiCode30);
            XmlAttribute abiCode31 = doc.CreateAttribute("abiCode");
            XmlElement repaired = doc.CreateElement("Repaired");
            abiCode31.Value = (policyUploadDS[0].Repaired == "No" || policyUploadDS[0].Repaired == null) ? "N" : "Y";
            repaired.Attributes.Append(abiCode31);
            XmlAttribute abiCode32 = doc.CreateAttribute("abiCode");
            XmlElement valSurvey = doc.CreateElement("ValSurvey");
            abiCode32.Value = (policyUploadDS[0].Survey == "No" || policyUploadDS[0].Survey == null) ? "N" : "Y";
            valSurvey.Attributes.Append(abiCode32);
            XmlAttribute abiCode33 = doc.CreateAttribute("abiCode");
            XmlElement structReport = doc.CreateElement("StructReport");
            abiCode33.Value = (policyUploadDS[0].Structural == "No" || policyUploadDS[0].Structural == null) ? "N" : "Y";
            structReport.Attributes.Append(abiCode33);
            XmlElement structName = doc.CreateElement("StructName");
            structName.InnerText = policyUploadDS[0].Structural_name;
            XmlElement unoccupancy = doc.CreateElement("Unoccupancy");
            if (policyUploadDS[0].OccupancyUnoccupied != null)
            {
                unoccupancy.InnerText =
                    loadProperty_Unoccupancy_AbiCodes.ContainsValue(policyUploadDS[0].OccupancyUnoccupied)
                        ? loadProperty_Unoccupancy_AbiCodes.FindKeyByValue(policyUploadDS[0].OccupancyUnoccupied).Trim()
                        : "N";
            }
            else
            {
                unoccupancy.InnerText = "N";
            }
            XmlElement residence = doc.CreateElement("Residence");
            residence.InnerText = policyUploadDS[0].Residence;
            XmlElement accommodation = doc.CreateElement("Accommodation");
            accommodation.InnerText = policyUploadDS[0].OccupancyAccomodation;
            XmlElement adults = doc.CreateElement("Adults");
            adults.InnerText = policyUploadDS[0].Adults.ToString();
            XmlElement children = doc.CreateElement("Children");
            children.InnerText = policyUploadDS[0].C_Children.ToString();
            XmlElement payingGuestNo = doc.CreateElement("PayingGuestNo");
            payingGuestNo.InnerText = policyUploadDS[0].Payingguestno.ToString();
            XmlElement floorFlatOn = doc.CreateElement("FloorFlatOn");
            floorFlatOn.InnerText = policyUploadDS[0].Floorno.ToString();
            XmlElement nHBCExpires = doc.CreateElement("NHBCExpires");
            nHBCExpires.InnerText = policyUploadDS[0].Nhbc_proof_expires.ToString();
            XmlElement payingGuests = doc.CreateElement("PayingGuests");
            payingGuests.InnerText = policyUploadDS[0].Paying_guests;
            XmlElement yearExtended = doc.CreateElement("YearExtended");
            yearExtended.InnerText = policyUploadDS[0].Yearextended.ToString();

            property.AppendChild(houseType);
            property.AppendChild(selfContained);
            property.AppendChild(floors);
            property.AppendChild(bedrooms);
            property.AppendChild(rooms);
            property.AppendChild(primaryHeating);
            property.AppendChild(smokeAlarm);
            property.AppendChild(homeWatch);
            property.AppendChild(holidayHome);
            property.AppendChild(alarmQ);
            property.AppendChild(businessUse);
            property.AppendChild(stock);
            property.AppendChild(equipment);
            property.AppendChild(construction);
            property.AppendChild(extended);
            property.AppendChild(NHBC);
            property.AppendChild(listed);
            property.AppendChild(roofType);
            property.AppendChild(flatRoofPercent);
            property.AppendChild(goodRepair);
            property.AppendChild(yearBuilt);
            property.AppendChild(underpinned);
            property.AppendChild(repaired);
            property.AppendChild(valSurvey);
            property.AppendChild(structName);
            property.AppendChild(structReport);
            property.AppendChild(unoccupancy);
            property.AppendChild(residence);
            property.AppendChild(accommodation);
            property.AppendChild(adults);
            property.AppendChild(children);
            property.AppendChild(payingGuestNo);
            property.AppendChild(floorFlatOn);
            property.AppendChild(nHBCExpires);
            property.AppendChild(payingGuests);
            property.AppendChild(yearExtended);

            // Create Locks
            XmlElement locks = doc.CreateElement("Locks");
            risk.AppendChild(locks);
            XmlAttribute abiCode34 = doc.CreateAttribute("abiCode");
            XmlElement windowLocks = doc.CreateElement("WindowLocks");
            abiCode34.Value = (policyUploadDS[0].Windows == "No" || policyUploadDS[0].Windows == null) ? "N" : "Y";
            windowLocks.Attributes.Append(abiCode34);
            XmlElement frenchDoor = doc.CreateElement("FrenchDoor");
            frenchDoor.InnerText = (policyUploadDS[0].French_door == "N/A" || policyUploadDS[0].French_door == null) ? "NA" : "Y";
            XmlAttribute abiCode35 = doc.CreateAttribute("abiCode");
            XmlElement mainDoor = doc.CreateElement("MainDoor");
            abiCode35.Value = (policyUploadDS[0].Main_door == "No" || policyUploadDS[0].Main_door == null) ? "N" : "Y";
            mainDoor.Attributes.Append(abiCode35);
            XmlElement otherDoor = doc.CreateElement("OtherDoor");
            otherDoor.InnerText = (policyUploadDS[0].Other_door == "No" || policyUploadDS[0].Other_door == null) ? "N" : "Y";

            locks.AppendChild(windowLocks);
            locks.AppendChild(frenchDoor);
            locks.AppendChild(mainDoor);
            locks.AppendChild(otherDoor);

            if (!String.IsNullOrEmpty(policyUploadDS[0].Alarm_type))
            {
                // Create Alarm
                XmlElement alarm = doc.CreateElement("Alarm");
                risk.AppendChild(alarm);
                XmlElement atype = doc.CreateElement("Type");
                XmlAttribute abiCode36 = doc.CreateAttribute("abiCode");
                abiCode36.Value = loadAlarm_Type_AbiCodes.ContainsValue(policyUploadDS[0].Alarm_type)
                                      ? loadAlarm_Type_AbiCodes.FindKeyByValue(policyUploadDS[0].Alarm_type).Trim()
                                      : "8";
                atype.Attributes.Append(abiCode36);
                XmlElement maintenanceCompany = doc.CreateElement("MaintenanceCompany");
                XmlAttribute abiCode37 = doc.CreateAttribute("abiCode");
                abiCode37.Value =
                    loadAlarm_MaintenanceCompany_AbiCodes.ContainsValue(policyUploadDS[0].AlarmMaintainceCompany)
                        ? loadAlarm_MaintenanceCompany_AbiCodes.FindKeyByValue(policyUploadDS[0].AlarmMaintainceCompany).
                              Trim()
                        : "9999";
                maintenanceCompany.Attributes.Append(abiCode37);
                XmlElement accredDetails1 = doc.CreateElement("AccredDetails1");
                XmlAttribute abiCode38 = doc.CreateAttribute("abiCode");
                abiCode38.Value = loadAlarm_AccredDetails2_AbiCodes.ContainsValue(policyUploadDS[0].AlarmAccredDetails1)
                                      ? loadAlarm_AccredDetails2_AbiCodes.FindKeyByValue(
                                          policyUploadDS[0].AlarmAccredDetails1).Trim()
                                      : "997";
                accredDetails1.Attributes.Append(abiCode38);
                XmlElement accredDetailsText1 = doc.CreateElement("AccredDetailsText1");
                accredDetailsText1.InnerText = policyUploadDS[0].Ftx_accreddetails1;
                XmlElement installDate = doc.CreateElement("InstallDate");
                installDate.InnerText = policyUploadDS[0].Alarm_install.ToString();



                alarm.AppendChild(atype);
                alarm.AppendChild(maintenanceCompany);
                alarm.AppendChild(accredDetails1);
                alarm.AppendChild(accredDetailsText1);
                alarm.AppendChild(installDate);
            }

            // Create Hazard
            XmlElement hazard = doc.CreateElement("Hazard");
            risk.AppendChild(hazard);
            XmlAttribute abiCode39 = doc.CreateAttribute("abiCode");
            XmlElement groundHeave = doc.CreateElement("GroundHeave");
            abiCode39.Value = (policyUploadDS[0].Groundheave == "No" || policyUploadDS[0].Groundheave == null) ? "N" : "Y";
            groundHeave.Attributes.Append(abiCode39);
            XmlAttribute abiCode40 = doc.CreateAttribute("abiCode");
            XmlElement landslip = doc.CreateElement("Landslip");
            abiCode40.Value = (policyUploadDS[0].Landslip == "No" || policyUploadDS[0].Landslip == null) ? "N" : "Y";
            landslip.Attributes.Append(abiCode40);
            XmlAttribute abiCode41 = doc.CreateAttribute("abiCode");
            XmlElement subsidence = doc.CreateElement("Subsidence");
            abiCode41.Value = (policyUploadDS[0].Subsidence == "No" || policyUploadDS[0].Subsidence == null) ? "N" : "Y";
            subsidence.Attributes.Append(abiCode41);
            XmlAttribute abiCode42 = doc.CreateAttribute("abiCode");
            XmlElement storm = doc.CreateElement("Storm");
            abiCode42.Value = (policyUploadDS[0].Storm == "No" || policyUploadDS[0].Storm == null) ? "N" : "Y";
            storm.Attributes.Append(abiCode42);
            XmlElement riverDistance = doc.CreateElement("RiverDistance");
            riverDistance.InnerText = policyUploadDS[0].Riverdistance.ToString();
            XmlAttribute abiCode43 = doc.CreateAttribute("abiCode");
            XmlElement riverQuarry = doc.CreateElement("RiverQuarry");
            abiCode43.Value = (policyUploadDS[0].Riverquarry == "No" || policyUploadDS[0].Riverquarry == null) ? "N" : "Y";
            riverQuarry.Attributes.Append(abiCode43);

            hazard.AppendChild(groundHeave);
            hazard.AppendChild(landslip);
            hazard.AppendChild(subsidence);
            hazard.AppendChild(storm);
            hazard.AppendChild(riverDistance);
            hazard.AppendChild(riverQuarry);



            foreach (var item in SpecItemsList)
            {
                if (item.amount != null)
                {
                    // Create Specified Item
                    XmlElement specifiedItem = doc.CreateElement("SpecifiedItem");
                    risk.AppendChild(specifiedItem);
                    XmlElement category = doc.CreateElement("Category");
                    XmlAttribute abiCode44 = doc.CreateAttribute("abiCode");
                    abiCode44.Value = loadSpecifiedItem_Category_AbiCodes.ContainsValue(item.Category) ? loadSpecifiedItem_Category_AbiCodes.FindKeyByValue(item.Category).Trim() : "Z99";
                    category.Attributes.Append(abiCode44);
                    XmlElement description = doc.CreateElement("Description");
                    description.InnerText = item.Description1;
                    XmlElement coverType = doc.CreateElement("CoverType");
                    coverType.InnerText = item.Covertype;
                    XmlElement territory = doc.CreateElement("Territory");
                    territory.InnerText = item.Territory;
                    XmlElement value = doc.CreateElement("Value");
                    value.InnerText = item.amount.ToString();

                    specifiedItem.AppendChild(category);
                    specifiedItem.AppendChild(description);
                    specifiedItem.AppendChild(coverType);
                    specifiedItem.AppendChild(territory);
                    specifiedItem.AppendChild(value);
                }
            }

            // Create Un-Specified Items
            XmlElement unspecifiedItem = doc.CreateElement("UnspecifiedItems");
            risk.AppendChild(unspecifiedItem);


            if (policyUploadDS[0].Arphoto != null)
            {
                XmlElement photoValue = doc.CreateElement("PhotoValue");
                photoValue.InnerText = policyUploadDS[0].Arphoto.ToString();
                XmlElement photoItem = doc.CreateElement("PhotoItem");
                photoItem.InnerText = policyUploadDS[0].Arphotoitem.ToString();
                XmlElement photoTerritory = doc.CreateElement("PhotoTerritory");
                photoTerritory.InnerText = "UK";
                unspecifiedItem.AppendChild(photoValue);
                unspecifiedItem.AppendChild(photoItem);
                unspecifiedItem.AppendChild(photoTerritory);

            }


            ///// DO ABOVE FOR BELOW FIELDS /////////////////////////

            if (policyUploadDS[0].Arsport != null)
            {

                XmlElement sportsValue = doc.CreateElement("SportValue");
                sportsValue.InnerText = policyUploadDS[0].Arsport.ToString();
                XmlElement sportsItem = doc.CreateElement("SportItem");
                sportsItem.InnerText = policyUploadDS[0].Arsportitem.ToString();
                XmlElement sportsTerritory = doc.CreateElement("SportTerritory");
                sportsTerritory.InnerText = "UK";
                unspecifiedItem.AppendChild(sportsTerritory);
                unspecifiedItem.AppendChild(sportsValue);
                unspecifiedItem.AppendChild(sportsItem);

            }


            if (policyUploadDS[0].C_Money != null)
            {

                XmlElement moneyValue = doc.CreateElement("MoneyValue");
                moneyValue.InnerText = policyUploadDS[0].C_Money.ToString();
                XmlElement moneyTerritory = doc.CreateElement("MoneyTerritory");
                moneyTerritory.InnerText = "UK";
                unspecifiedItem.AppendChild(moneyValue);
                unspecifiedItem.AppendChild(moneyTerritory);

            }


            if (policyUploadDS[0].Creditcards != null)
            {

                XmlElement creditCardsValue = doc.CreateElement("CreditCardsValue");
                creditCardsValue.InnerText = policyUploadDS[0].Creditcards.ToString();
                XmlElement creditCardsTerritory = doc.CreateElement("CreditCardsTerritory");
                creditCardsTerritory.InnerText = "UK";
                unspecifiedItem.AppendChild(creditCardsValue);
                unspecifiedItem.AppendChild(creditCardsTerritory);

            }


            if (policyUploadDS[0].Freezertotal != null)
            {

                XmlElement freezerTotal = doc.CreateElement("FreezerTotal");
                freezerTotal.InnerText = policyUploadDS[0].Freezertotal.ToString();
                XmlElement freezerOldestAge = doc.CreateElement("FreezerOldestAge");
                freezerOldestAge.InnerText = policyUploadDS[0].Freezerage.ToString();
                unspecifiedItem.AppendChild(freezerTotal);
                unspecifiedItem.AppendChild(freezerOldestAge);

            }



            if (policyUploadDS[0].Areffects != null)
            {

                XmlElement allRisksEffectsValue = doc.CreateElement("AllRisksEffectsValue");
                allRisksEffectsValue.InnerText = policyUploadDS[0].Areffects.ToString();
                XmlElement allRisksEffectsItem = doc.CreateElement("AllRisksEffectsItem");
                allRisksEffectsItem.InnerText = policyUploadDS[0].Areffectsitem.ToString();
                XmlElement allRisksEffectsTerritory = doc.CreateElement("AllRisksEffectsTerritory");
                allRisksEffectsTerritory.InnerText = "UK";
                unspecifiedItem.AppendChild(allRisksEffectsValue);
                unspecifiedItem.AppendChild(allRisksEffectsItem);
                unspecifiedItem.AppendChild(allRisksEffectsTerritory);

            }
            if (policyUploadDS[0].Arvaluables != null)
            {

                XmlElement allRisksValuablesValue = doc.CreateElement("AllRisksValuablesValue");
                allRisksValuablesValue.InnerText = policyUploadDS[0].Arvaluables.ToString();
                XmlElement allRisksValuablesItem = doc.CreateElement("AllRisksValuablesItem");
                allRisksValuablesItem.InnerText = policyUploadDS[0].Arvaluablesitem.ToString();
                XmlElement allRisksValuablesTerritory = doc.CreateElement("AllRisksValuablesTerritory");
                allRisksValuablesTerritory.InnerText = "UK";
                unspecifiedItem.AppendChild(allRisksValuablesValue);
                unspecifiedItem.AppendChild(allRisksValuablesItem);
                unspecifiedItem.AppendChild(allRisksValuablesTerritory);

            }








            if (policyUploadDS[0].Reqbuildcover > 0)
            {
                // Create Buildings
                XmlElement buildings = doc.CreateElement("Buildings");
                risk.AppendChild(buildings);
                XmlElement sumInsured = doc.CreateElement("SumInsured");
                sumInsured.InnerText = policyUploadDS[0].Reqbuildcover.ToString();
                XmlElement buldingCoverType = doc.CreateElement("CoverType");
                buldingCoverType.InnerText = policyUploadDS[0].Buildingscover;
                XmlElement buildVolXS = doc.CreateElement("BuildVolXS");
                buildVolXS.InnerText = policyUploadDS[0].Buildvolxs.ToString();
                XmlElement dateLapsed = doc.CreateElement("DateLapsed");
                dateLapsed.InnerText = policyUploadDS[0].Bdate_lapsed.ToString();
                XmlElement yearsNCB = doc.CreateElement("YearsNCB");
                yearsNCB.InnerText = policyUploadDS[0].Bncb_years.ToString();
                XmlElement yearsInsured = doc.CreateElement("YearsInsured");
                yearsInsured.InnerText = policyUploadDS[0].Byearsinsured.ToString();
                XmlElement insurer = doc.CreateElement("Insurer");
                XmlAttribute abiCode45 = doc.CreateAttribute("abiCode");
                abiCode45.Value = loadBuildings_Insurer_AbiCodes.ContainsValue(policyUploadDS[0].BuildInsName) ? loadBuildings_Insurer_AbiCodes.FindKeyByValue(policyUploadDS[0].BuildInsName).Trim() : "997";
                insurer.Attributes.Append(abiCode45);

                XmlElement NCBProof = doc.CreateElement("NCBProof");
                NCBProof.InnerText = policyUploadDS[0].Bncb_proof;

                buildings.AppendChild(sumInsured);
                buildings.AppendChild(buldingCoverType);
                buildings.AppendChild(buildVolXS);
                buildings.AppendChild(dateLapsed);
                buildings.AppendChild(yearsNCB);
                buildings.AppendChild(yearsInsured);
                buildings.AppendChild(insurer);

                if (policyUploadDS[0].Binsurername != null)
                {

                    XmlElement insurerName = doc.CreateElement("InsurerName");
                    insurerName.InnerText = policyUploadDS[0].Binsurername;
                    buildings.AppendChild(insurerName);

                }

                buildings.AppendChild(NCBProof);
            }

            if (policyUploadDS[0].Contsgoods > 0)
            {
                // Create Contents
                XmlElement contents = doc.CreateElement("Contents");
                risk.AppendChild(contents);
                XmlElement contentssumInsured = doc.CreateElement("SumInsured");
                contentssumInsured.InnerText = policyUploadDS[0].Contsgoods.ToString();
                XmlElement contentsCoverType = doc.CreateElement("CoverType");
                contentsCoverType.InnerText = policyUploadDS[0].Contentscover;
                XmlElement voluntaryExcess = doc.CreateElement("VoluntaryExcess");
                voluntaryExcess.InnerText = policyUploadDS[0].Contsvolxs.ToString();
                XmlElement dateLapsedc = doc.CreateElement("DateLapsed");
                dateLapsedc.InnerText = policyUploadDS[0].Cdate_lapsed.ToString();
                XmlElement singleItemLimit = doc.CreateElement("SingleItemLimit");
                singleItemLimit.InnerText = policyUploadDS[0].Contsgoodslimit.ToString();
                XmlElement contentyearsNCB = doc.CreateElement("YearsNCB");
                contentyearsNCB.InnerText = policyUploadDS[0].Cncb_years.ToString();
                XmlElement contentyearsInsured = doc.CreateElement("YearsInsured");
                contentyearsInsured.InnerText = policyUploadDS[0].Cyearsinsured.ToString();
                XmlElement contentsinsurer = doc.CreateElement("Insurer");
                XmlAttribute abiCode46 = doc.CreateAttribute("abiCode");
                abiCode46.Value = loadContents_Insurer_AbiCodes.ContainsValue(policyUploadDS[0].ContentInsName)
                                      ? loadContents_Insurer_AbiCodes.FindKeyByValue(policyUploadDS[0].ContentInsName).
                                            Trim()
                                      : "997";
                contentsinsurer.Attributes.Append(abiCode46);
                XmlElement cinsurerName = doc.CreateElement("InsurerName");
                cinsurerName.InnerText = policyUploadDS[0].Cinsurername;
                XmlElement cNCBProof = doc.CreateElement("NCBProof");
                cNCBProof.InnerText = policyUploadDS[0].Cncb_proof;
                XmlElement vals = doc.CreateElement("Vals");
                vals.InnerText = policyUploadDS[0].Contsvals.ToString();
                XmlElement valsLimit = doc.CreateElement("ValsLimit");
                valsLimit.InnerText = policyUploadDS[0].Contsvalslimit.ToString();

                contents.AppendChild(contentssumInsured);
                contents.AppendChild(contentsCoverType);
                contents.AppendChild(voluntaryExcess);
                contents.AppendChild(singleItemLimit);
                contents.AppendChild(dateLapsedc);
                contents.AppendChild(contentyearsNCB);
                contents.AppendChild(contentyearsInsured);
                contents.AppendChild(contentsinsurer);
                contents.AppendChild(valsLimit);
                contents.AppendChild(cinsurerName);
                contents.AppendChild(cNCBProof);
                contents.AppendChild(vals);
            }





            if (policyUploadDS[0].Cycleval1 > 0)
            {
                // Create Bikes
                XmlElement bike = doc.CreateElement("Bicycle");
                risk.AppendChild(bike);
                XmlElement bicycleMake = doc.CreateElement("Make");
                bicycleMake.InnerText = policyUploadDS[0].Cyclemake1;
                XmlElement bicycleModel = doc.CreateElement("Model");
                bicycleModel.InnerText = policyUploadDS[0].Cycledesc1;
                XmlElement bicycleTerritory = doc.CreateElement("Territory");
                bicycleTerritory.InnerText = policyUploadDS[0].Cycle1territory;
                XmlElement bicycleValue = doc.CreateElement("Value");
                bicycleValue.InnerText = policyUploadDS[0].Cycleval1.ToString();

                bike.AppendChild(bicycleMake);
                bike.AppendChild(bicycleModel);
                bike.AppendChild(bicycleTerritory);
                bike.AppendChild(bicycleValue);
            }

            if (policyUploadDS[0].Cycleval2 > 0)
            {
                // Create Bikes
                XmlElement bike = doc.CreateElement("Bicycle");
                risk.AppendChild(bike);
                XmlElement bicycleMake = doc.CreateElement("Make");
                bicycleMake.InnerText = policyUploadDS[0].Cyclemake2;
                XmlElement bicycleModel = doc.CreateElement("Model");
                bicycleModel.InnerText = policyUploadDS[0].Cycledesc2;
                XmlElement bicycleTerritory = doc.CreateElement("Territory");
                bicycleTerritory.InnerText = policyUploadDS[0].Cycle2territory;
                XmlElement bicycleValue = doc.CreateElement("Value");
                bicycleValue.InnerText = policyUploadDS[0].Cycleval2.ToString();

                bike.AppendChild(bicycleMake);
                bike.AppendChild(bicycleModel);
                bike.AppendChild(bicycleTerritory);
                bike.AppendChild(bicycleValue);
            }

            if (policyUploadDS[0].Cycleval3 > 0)
            {
                // Create Bikes
                XmlElement bike = doc.CreateElement("Bicycle");
                risk.AppendChild(bike);
                XmlElement bicycleMake = doc.CreateElement("Make");
                bicycleMake.InnerText = policyUploadDS[0].Cyclemake3;
                XmlElement bicycleModel = doc.CreateElement("Model");
                bicycleModel.InnerText = policyUploadDS[0].Cycledesc3;
                XmlElement bicycleTerritory = doc.CreateElement("Territory");
                bicycleTerritory.InnerText = policyUploadDS[0].Cycle3territory;
                XmlElement bicycleValue = doc.CreateElement("Value");
                bicycleValue.InnerText = policyUploadDS[0].Cycleval3.ToString();

                bike.AppendChild(bicycleMake);
                bike.AppendChild(bicycleModel);
                bike.AppendChild(bicycleTerritory);
                bike.AppendChild(bicycleValue);
            }

            if (policyUploadDS[0].Cycleval4 > 0)
            {
                // Create Bikes
                XmlElement bike = doc.CreateElement("Bicycle");
                risk.AppendChild(bike);
                XmlElement bicycleMake = doc.CreateElement("Make");
                bicycleMake.InnerText = policyUploadDS[0].Cyclemake4;
                XmlElement bicycleModel = doc.CreateElement("Model");
                bicycleModel.InnerText = policyUploadDS[0].Cycledesc4;
                XmlElement bicycleTerritory = doc.CreateElement("Territory");
                bicycleTerritory.InnerText = policyUploadDS[0].Cycle4territory;
                XmlElement bicycleValue = doc.CreateElement("Value");
                bicycleValue.InnerText = policyUploadDS[0].Cycleval4.ToString();

                bike.AppendChild(bicycleMake);
                bike.AppendChild(bicycleModel);
                bike.AppendChild(bicycleTerritory);
                bike.AppendChild(bicycleValue);
            }

            if (policyUploadDS[0].Cycleval5 > 0)
            {
                // Create Bikes
                XmlElement bike = doc.CreateElement("Bicycle");
                risk.AppendChild(bike);
                XmlElement bicycleMake = doc.CreateElement("Make");
                bicycleMake.InnerText = policyUploadDS[0].Cyclemake5;
                XmlElement bicycleModel = doc.CreateElement("Model");
                bicycleModel.InnerText = policyUploadDS[0].Cycledesc5;
                XmlElement bicycleTerritory = doc.CreateElement("Territory");
                bicycleTerritory.InnerText = policyUploadDS[0].Cycle5territory;
                XmlElement bicycleValue = doc.CreateElement("Value");
                bicycleValue.InnerText = policyUploadDS[0].Cycleval5.ToString();

                bike.AppendChild(bicycleMake);
                bike.AppendChild(bicycleModel);
                bike.AppendChild(bicycleTerritory);
                bike.AppendChild(bicycleValue);
            }

            if (policyUploadDS[0].Cycleval6 > 0)
            {
                // Create Bikes
                XmlElement bike = doc.CreateElement("Bicycle");
                risk.AppendChild(bike);
                XmlElement bicycleMake = doc.CreateElement("Make");
                bicycleMake.InnerText = policyUploadDS[0].Cyclemake6;
                XmlElement bicycleModel = doc.CreateElement("Model");
                bicycleModel.InnerText = policyUploadDS[0].Cycledesc6;
                XmlElement bicycleTerritory = doc.CreateElement("Territory");
                bicycleTerritory.InnerText = policyUploadDS[0].Cycle6territory;
                XmlElement bicycleValue = doc.CreateElement("Value");
                bicycleValue.InnerText = policyUploadDS[0].Cycleval5.ToString();

                bike.AppendChild(bicycleMake);
                bike.AppendChild(bicycleModel);
                bike.AppendChild(bicycleTerritory);
                bike.AppendChild(bicycleValue);
            }

            if (policyUploadDS[0].InterestedPartyName != null)
            {
                // Interested Party
                XmlElement interestedParty = doc.CreateElement("InterestedParty");
                risk.AppendChild(interestedParty);
                XmlElement ipName = doc.CreateElement("Name");
                ipName.InnerText = policyUploadDS[0].InterestedPartyName;
                XmlElement ipNumber = doc.CreateElement("Number");
                ipNumber.InnerText = policyUploadDS[0].Interestaddr1;
                XmlElement ipReference = doc.CreateElement("Reference");
                ipReference.InnerText = policyUploadDS[0].Reference;
                XmlElement ipType = doc.CreateElement("Type");
                ipType.InnerText = policyUploadDS[0].InterestedPartyType;

                XmlElement ipUnlisted = doc.CreateElement("Unlisted");
                //ipUnlisted.InnerText = policyUploadDS[0]Interestunlist;

                interestedParty.AppendChild(ipName);
                interestedParty.AppendChild(ipNumber);
                interestedParty.AppendChild(ipReference);
                interestedParty.AppendChild(ipType);
                interestedParty.AppendChild(ipUnlisted);
            }

            if (ClaimsuploadDS != null)
            {


                foreach (var cl in ClaimsuploadDS)
                {
                    // Create Claims
                    XmlElement claim = doc.CreateElement("Claim");
                    risk.AppendChild(claim);
                    XmlElement claimDate = doc.CreateElement("Date");
                    claimDate.InnerText = ClaimsuploadDS[0].ClaimDate.ToString();
                    XmlElement claimDescription = doc.CreateElement("Description");
                    claimDescription.InnerText = ClaimsuploadDS[0].Desc1 + "" + ClaimsuploadDS[0].Desc2;
                    XmlElement claimNumber = doc.CreateElement("Number");
                    claimNumber.InnerText = ClaimsuploadDS[0].C_Number.ToString();
                    XmlElement claimSection = doc.CreateElement("Section");
                    claimSection.InnerText = ClaimsuploadDS[0].C_Section;
                    XmlElement claimSettled = doc.CreateElement("Settled");
                    claimSettled.InnerText = ClaimsuploadDS[0].Claimsettled;
                    XmlElement claimType = doc.CreateElement("Type");
                    claimType.InnerText = ClaimsuploadDS[0].Type;
                    XmlElement claimValue = doc.CreateElement("Value");
                    claimValue.InnerText = ClaimsuploadDS[0].C_Value.ToString();

                    claim.AppendChild(claimDate);
                    claim.AppendChild(claimDescription);
                    claim.AppendChild(claimNumber);
                    claim.AppendChild(claimSection);
                    claim.AppendChild(claimSettled);
                    claim.AppendChild(claimType);
                    claim.AppendChild(claimValue);

                }

                string fileLoc = @"C:\Users\Jack\source\repos\PolicyCheck\test.xml";
                doc.Save(fileLoc);

            }


        }





    }



}
