using CV19OrgVolunteers.Models.V1;
namespace CV19OrgVolunteers.Gateways.V1
{
    public interface IOrganisationVolunteerGateway
    {
        int Insert(OrganisationsNeedingVolunteers data);
    }
}