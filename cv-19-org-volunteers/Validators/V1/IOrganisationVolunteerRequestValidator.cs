using System.Collections.Generic;
using CV19OrgVolunteers.Models.V1;

namespace CV19OrgVolunteers.Validators.V1
{
    public interface IOrganisationVolunteerRequestValidator
    {
        Dictionary<string, string> Validate(OrganisationsNeedingVolunteers data);
    }
}