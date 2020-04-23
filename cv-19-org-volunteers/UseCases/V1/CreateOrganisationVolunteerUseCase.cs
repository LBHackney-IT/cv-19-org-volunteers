using System;
using CV19OrgVolunteers.Gateways.V1;
using CV19OrgVolunteers.Models.V1;
using CV19OrgVolunteers.Validators.V1;
using Amazon.Lambda.Core;
using Newtonsoft.Json;

namespace CV19OrgVolunteers.UseCases.V1
{
    public class CreateOrganisationVolunteerUseCase : ICreateOrganisationVolunteerUseCase
    {
        private readonly IOrganisationVolunteerGateway _organisationVolunteerGatewayGateway;
        private readonly IOrganisationVolunteerRequestValidator _validator;

        public CreateOrganisationVolunteerUseCase(IOrganisationVolunteerGateway organisationVolunteerGatewayGateway, IOrganisationVolunteerRequestValidator validator)
        {
            _organisationVolunteerGatewayGateway = organisationVolunteerGatewayGateway;
            _validator = validator;
        }

        public int InsertOrganisationVolunteerRecord(OrganisationsNeedingVolunteers data)
        {
            Console.WriteLine("CreateOrganisationVolunteer: " + JsonConvert.SerializeObject(data));
            var validationResponse = _validator.Validate(data);
            if (validationResponse.Count > 0)
            {
                throw new Exception();
            }
            else
            {
               return _organisationVolunteerGatewayGateway.Insert(data);
            }
        }
    }
}