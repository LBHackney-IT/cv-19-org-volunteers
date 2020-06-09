using System;
using CV19OrgVolunteers.Models.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace CV19OrgVolunteers.Data.V1
{
    public partial class Cv19SupportDbContext : DbContext
    {
        private readonly string _connectionString;
        
        public Cv19SupportDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Cv19SupportDbContext(DbContextOptions<Cv19SupportDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OrganisationsNeedingVolunteers> OrganisationsNeedingVolunteers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganisationsNeedingVolunteers>(entity =>
            {
                entity.ToTable("organisations_needing_volunteers");

                entity.Property(e => e.Id).HasColumnName("id");
                
                entity.Property(e => e.OrganisationName)
                    .IsRequired()
                    .HasColumnName("organisation_name")
                    .HasColumnType("character varying");
                
                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnName("email_address")
                    .HasColumnType("character varying");
                
                entity.Property(e => e.IsCurrentlyVolunteering).HasColumnName("is_currently_volunteering");
                
                entity.Property(e => e.Wards)
                    .IsRequired()
                    .HasColumnName("wards")
                    .HasColumnType("character varying");

                entity.Property(e => e.Beneficiaries)
                    .IsRequired()
                    .HasColumnName("beneficiaries")
                    .HasColumnType("character varying");

                entity.Property(e => e.ConsentToShare).HasColumnName("consent_to_share");

                entity.Property(e => e.DbsEnhanced).HasColumnName("dbs_enhanced");

                entity.Property(e => e.DbsNotRequired).HasColumnName("dbs_not_required");

                entity.Property(e => e.DbsOther)
                    .HasColumnName("dbs_other")
                    .HasColumnType("character varying");

                entity.Property(e => e.DbsOwnChecks).HasColumnName("dbs_own_checks");

                entity.Property(e => e.DbsStandard).HasColumnName("dbs_standard");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnName("email_address")
                    .HasColumnType("character varying");

                entity.Property(e => e.HasInsurance).HasColumnName("has_insurance");

                entity.Property(e => e.HasVolunteeringPolicy).HasColumnName("has_volunteering_policy");

                entity.Property(e => e.IsCurrentlyVolunteering).HasColumnName("is_currently_volunteering");

                entity.Property(e => e.NeedsSkillBefriending).HasColumnName("needs_skill_befriending");

                entity.Property(e => e.NeedsSkillCooking).HasColumnName("needs_skill_cooking");

                entity.Property(e => e.NeedsSkillDelivering).HasColumnName("needs_skill_delivering");

                entity.Property(e => e.NeedsSkillForms).HasColumnName("needs_skill_forms");

                entity.Property(e => e.NeedsSkillHelpline).HasColumnName("needs_skill_helpline");

                entity.Property(e => e.NeedsSkillLogistics).HasColumnName("needs_skill_logistics");

                entity.Property(e => e.NeedsSkillOther)
                    .HasColumnName("needs_skill_other")
                    .HasColumnType("character varying");

                entity.Property(e => e.NeedsSkillShopping).HasColumnName("needs_skill_shopping");

                entity.Property(e => e.NeedsSkillTranslating).HasColumnName("needs_skill_translating");

                entity.Property(e => e.OrganisationName)
                    .IsRequired()
                    .HasColumnName("organisation_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.PrivacyPolicyCheck).HasColumnName("privacy_policy_check");

                entity.Property(e => e.VolunteerAdditionalInformation)
                    .HasColumnName("volunteer_additional_information")
                    .HasColumnType("character varying");

                entity.Property(e => e.VolunteerExpenseCover).HasColumnName("volunteer_expense_cover");

                entity.Property(e => e.VolunteerHasBike).HasColumnName("volunteer_has_bike");

                entity.Property(e => e.VolunteerHasDrivingLicence).HasColumnName("volunteer_has_driving_licence");

                entity.Property(e => e.VolunteerHasLicenceAndCar).HasColumnName("volunteer_has_licence_and_car");

                entity.Property(e => e.VolunteerHasLicenceAndVan).HasColumnName("volunteer_has_licence_and_van");

                entity.Property(e => e.VolunteerHasMotorcycle).HasColumnName("volunteer_has_motorcycle");

                entity.Property(e => e.VolunteerInPerson).HasColumnName("volunteer_in_person");

                entity.Property(e => e.VolunteerLanguages)
                    .HasColumnName("volunteer_languages")
                    .HasColumnType("character varying");

                entity.Property(e => e.VolunteerNeededOneDay).HasColumnName("volunteer_needed_one_day");

                entity.Property(e => e.VolunteerNeededOneMonth).HasColumnName("volunteer_needed_one_month");

                entity.Property(e => e.VolunteerNeededOneWeek).HasColumnName("volunteer_needed_one_week");

                entity.Property(e => e.VolunteerNeededOther)
                    .HasColumnName("volunteer_needed_other")
                    .HasColumnType("character varying");

                entity.Property(e => e.VolunteerNewsletter).HasColumnName("volunteer_newsletter");

                entity.Property(e => e.VolunteerRemotely).HasColumnName("volunteer_remotely");

                entity.Property(e => e.VolunteerSupportActivities)
                    .IsRequired()
                    .HasColumnName("volunteer_support_activities")
                    .HasColumnType("character varying");

                entity.Property(e => e.VolunteerTrainedBefriending).HasColumnName("volunteer_trained_befriending");

                entity.Property(e => e.VolunteerTrainedCareWork).HasColumnName("volunteer_trained_care_work");

                entity.Property(e => e.VolunteerTrainedChildcare).HasColumnName("volunteer_trained_childcare");

                entity.Property(e => e.VolunteerTrainedFirstAid).HasColumnName("volunteer_trained_first_aid");

                entity.Property(e => e.VolunteerTrainedFoodSafety).HasColumnName("volunteer_trained_food_safety");

                entity.Property(e => e.VolunteerTrainedIct).HasColumnName("volunteer_trained_ict");

                entity.Property(e => e.VolunteerTrainedMidas).HasColumnName("volunteer_trained_midas");

                entity.Property(e => e.VolunteerTrainedOther)
                    .HasColumnName("volunteer_trained_other")
                    .HasColumnType("character varying");

                entity.Property(e => e.VolunteerTrainedSocialWork).HasColumnName("volunteer_trained_social_work");

                entity.Property(e => e.VolunteeringFridayAm).HasColumnName("volunteering_friday_am");

                entity.Property(e => e.VolunteeringFridayEvening).HasColumnName("volunteering_friday_evening");

                entity.Property(e => e.VolunteeringFridayPm).HasColumnName("volunteering_friday_pm");

                entity.Property(e => e.VolunteeringMondayAm).HasColumnName("volunteering_monday_am");

                entity.Property(e => e.VolunteeringMondayEvening).HasColumnName("volunteering_monday_evening");

                entity.Property(e => e.VolunteeringMondayPm).HasColumnName("volunteering_monday_pm");

                entity.Property(e => e.VolunteeringSaturdayAm).HasColumnName("volunteering_saturday_am");

                entity.Property(e => e.VolunteeringSaturdayEvening).HasColumnName("volunteering_saturday_evening");

                entity.Property(e => e.VolunteeringSaturdayPm).HasColumnName("volunteering_saturday_pm");

                entity.Property(e => e.VolunteeringSundayAm).HasColumnName("volunteering_sunday_am");

                entity.Property(e => e.VolunteeringSundayEvening).HasColumnName("volunteering_sunday_evening");

                entity.Property(e => e.VolunteeringSundayPm).HasColumnName("volunteering_sunday_pm");

                entity.Property(e => e.VolunteeringThursdayAm).HasColumnName("volunteering_thursday_am");

                entity.Property(e => e.VolunteeringThursdayEvening).HasColumnName("volunteering_thursday_evening");

                entity.Property(e => e.VolunteeringThursdayPm).HasColumnName("volunteering_thursday_pm");

                entity.Property(e => e.VolunteeringTuesdayAm).HasColumnName("volunteering_tuesday_am");

                entity.Property(e => e.VolunteeringTuesdayEvening).HasColumnName("volunteering_tuesday_evening");

                entity.Property(e => e.VolunteeringTuesdayPm).HasColumnName("volunteering_tuesday_pm");

                entity.Property(e => e.VolunteeringWednesdayAm).HasColumnName("volunteering_wednesday_am");

                entity.Property(e => e.VolunteeringWednesdayEvening).HasColumnName("volunteering_wednesday_evening");

                entity.Property(e => e.VolunteeringWednesdayPm).HasColumnName("volunteering_wednesday_pm");

                entity.Property(e => e.VolunteersRequired).HasColumnName("volunteers_required");
                
                entity.Property(e => e.VolunteerVehicleNotRequired).HasColumnName("volunteer_driving_na");

                entity.Property(e => e.Wards)
                    .IsRequired()
                    .HasColumnName("wards")
                    .HasColumnType("character varying");
                
                entity.Property(e => e.DateTimeRecorded).HasColumnName("date_time_recorded");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
