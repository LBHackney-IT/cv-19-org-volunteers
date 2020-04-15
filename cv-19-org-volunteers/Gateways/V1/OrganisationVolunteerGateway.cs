using CV19OrgVolunteers.Models.V1;

namespace CV19OrgVolunteers.Gateways.V1
{
    public class OrganisationVolunteerGateway : IOrganisationVolunteerGateway
    {
        private readonly string _connectionString;
        public OrganisationVolunteerGateway(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int Insert(OrganisationsNeedingVolunteers data)
        {
            return 1;
        }
    }
}