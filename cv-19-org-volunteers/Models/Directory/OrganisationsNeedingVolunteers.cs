using System;
using System.Collections.Generic;

namespace CV19OrgVolunteers.Models.V1
{
    public partial class OrganisationsNeedingVolunteers
    {
        public int Id { get; set; }
        public string OrganisationName { get; set; }
        public string EmailAddress { get; set; }
        public bool? IsCurrentlyVolunteering { get; set; }
        public string Wards { get; set; }
        public string Beneficiaries { get; set; }
        public bool HasVolunteeringPolicy { get; set; }
        public bool? HasInsurance { get; set; }
        public bool? VolunteerExpenseCover { get; set; }
        public bool? NeedsSkillCooking { get; set; }
        public bool? NeedsSkillLogistics { get; set; }
        public bool? NeedsSkillDelivering { get; set; }
        public bool? NeedsSkillBefriending { get; set; }
        public bool? NeedsSkillHelpline { get; set; }
        public bool? NeedsSkillShopping { get; set; }
        public bool? NeedsSkillForms { get; set; }
        public bool? NeedsSkillTranslating { get; set; }
        public string NeedsSkillOther { get; set; }
        public string VolunteerSupportActivities { get; set; }
        public bool VolunteersRequired { get; set; }
        public bool? VolunteeringMondayAm { get; set; }
        public bool? VolunteeringMondayPm { get; set; }
        public bool? VolunteeringMondayEvening { get; set; }
        public bool? VolunteeringTuesdayAm { get; set; }
        public bool? VolunteeringTuesdayPm { get; set; }
        public bool? VolunteeringTuesdayEvening { get; set; }
        public bool? VolunteeringWednesdayAm { get; set; }
        public bool? VolunteeringWednesdayPm { get; set; }
        public bool? VolunteeringWednesdayEvening { get; set; }
        public bool? VolunteeringThursdayAm { get; set; }
        public bool? VolunteeringThursdayPm { get; set; }
        public bool? VolunteeringThursdayEvening { get; set; }
        public bool? VolunteeringFridayAm { get; set; }
        public bool? VolunteeringFridayPm { get; set; }
        public bool? VolunteeringFridayEvening { get; set; }
        public bool? VolunteeringSaturdayAm { get; set; }
        public bool? VolunteeringSaturdayPm { get; set; }
        public bool? VolunteeringSaturdayEvening { get; set; }
        public bool? VolunteeringSundayAm { get; set; }
        public bool? VolunteeringSundayPm { get; set; }
        public bool? VolunteeringSundayEvening { get; set; }
        public bool? VolunteerNeededOneDay { get; set; }
        public bool? VolunteerNeededOneWeek { get; set; }
        public bool? VolunteerNeededOneMonth { get; set; }
        public string VolunteerNeededOther { get; set; }
        public bool? VolunteerInPerson { get; set; }
        public bool? VolunteerRemotely { get; set; }
        public string VolunteerLanguages { get; set; }
        public bool? VolunteerTrainedFoodSafety { get; set; }
        public bool? VolunteerTrainedChildcare { get; set; }
        public bool? VolunteerTrainedMidas { get; set; }
        public bool? VolunteerTrainedIct { get; set; }
        public bool? VolunteerTrainedSocialWork { get; set; }
        public bool? VolunteerTrainedCareWork { get; set; }
        public bool? VolunteerTrainedBefriending { get; set; }
        public bool? VolunteerTrainedFirstAid { get; set; }
        public string VolunteerTrainedOther { get; set; }
        public bool? VolunteerHasDrivingLicence { get; set; }
        public bool? VolunteerHasLicenceAndCar { get; set; }
        public bool? VolunteerHasLicenceAndVan { get; set; }
        public bool? VolunteerHasMotorcycle { get; set; }
        public bool? VolunteerHasBike { get; set; }
        public bool? DbsStandard { get; set; }
        public bool? DbsEnhanced { get; set; }
        public bool? DbsNotRequired { get; set; }
        public bool? DbsOwnChecks { get; set; }
        public string DbsOther { get; set; }
        public string VolunteerAdditionalInformation { get; set; }
        public bool ConsentToShare { get; set; }
        public bool? VolunteerNewsletter { get; set; }
        public bool PrivacyPolicyCheck { get; set; }
    }
}
