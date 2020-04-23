using CV19OrgVolunteers.Models.V1;
using CV19OrgVolunteers.Data.V1;

namespace CV19OrgVolunteers.Gateways.V1
{
    public class OrganisationVolunteerGateway : IOrganisationVolunteerGateway
    {
        private readonly string _connectionString;
        private readonly Cv19SupportDbContext _dbContext;
        public OrganisationVolunteerGateway(string connectionString)
        {
            _connectionString = connectionString;
            _dbContext = new Cv19SupportDbContext(_connectionString);
        }

        public int Insert(OrganisationsNeedingVolunteers data)
        {
            _dbContext.OrganisationsNeedingVolunteers.Add(data);
            int response = _dbContext.SaveChanges();
            return data.Id;
        }
    }
}