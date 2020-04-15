using Amazon.Lambda.Core;
using CV19OrgVolunteers.Data.V1;
using System;
using CV19OrgVolunteers.Gateways.V1;
using CV19OrgVolunteers.Models.V1;
using CV19OrgVolunteers.UseCases.V1;
using CV19OrgVolunteers.Validators.V1;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace CV19OrgVolunteers
{
    public class Handler
    {
       public Response CreateOrganisationVolunteer(OrganisationsNeedingVolunteers request)
       {
           var connectionString = Environment.GetEnvironmentVariable("CV_19_DB_CONNECTION");
           var createRequestGateway = new OrganisationVolunteerGateway(connectionString);
           var createRequestObject = new CreateOrganisationVolunteerUseCase(createRequestGateway, new OrganisationVolunteerRequestValidator());
           var response = createRequestObject.InsertOrganisationVolunteerRecord(request);
           return new Response("Go Serverless v1.0! Your function executed successfully!", request);
       }
    }

    public class Response
    {
      public string Message {get; set;}
      public OrganisationsNeedingVolunteers Request {get; set;}

      public Response(string message, OrganisationsNeedingVolunteers request){
        Message = message;
        Request = request;
      }
    }
}
