using System.Collections.Generic;
using CV19OrgVolunteers.Models.V1;

namespace CV19OrgVolunteers.Validators.V1
{
    public class OrganisationVolunteerRequestValidator : IOrganisationVolunteerRequestValidator
    {
        public Dictionary<string, string> Validate(OrganisationsNeedingVolunteers data)
        {
            Dictionary<string, string> validationResponse = new Dictionary<string, string>();
            return validationResponse;
        }
    }
}