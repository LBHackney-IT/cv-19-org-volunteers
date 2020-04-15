using CV19OrgVolunteers.Gateways.V1;

namespace CV19OrgVolunteers.UseCases.V1
{
    public class CreateOrganisationVolunteerUseCase : ICreateOrganisationVolunteerUseCase
    {
        private readonly IOrganisationVolunteerGateway _organisationVolunteerGatewayGateway;

        public CreateOrganisationVolunteerUseCase(IOrganisationVolunteerGateway organisationVolunteerGatewayGateway)
        {
            _organisationVolunteerGatewayGateway = organisationVolunteerGatewayGateway;
        }

        public void InsertOrganisationVolunteerRecord(string data)
        {
            _organisationVolunteerGatewayGateway.Insert(data);
            // implement something
        }
    }
}