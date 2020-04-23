using CV19OrgVolunteers.Models.V1;
namespace CV19OrgVolunteers.UseCases.V1
{
    public interface ICreateOrganisationVolunteerUseCase
    {
        int InsertOrganisationVolunteerRecord(OrganisationsNeedingVolunteers data);
    }
}