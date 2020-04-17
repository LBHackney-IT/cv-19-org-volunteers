using Amazon.Lambda.Core;
using CV19OrgVolunteers.Data.V1;
using System;
using Amazon.Lambda.APIGatewayEvents;
using CV19OrgVolunteers.Gateways.V1;
using CV19OrgVolunteers.Models.V1;
using CV19OrgVolunteers.UseCases.V1;
using CV19OrgVolunteers.Validators.V1;
using Newtonsoft.Json;
using NUnit.Framework;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace CV19OrgVolunteers
{
    public class Handler
    {
       public Response CreateOrganisationVolunteer(APIGatewayProxyRequest request, ILambdaContext context)
       {
           LambdaLogger.Log("CreateOrganisationVolunteer: " + JsonConvert.SerializeObject(request));
           var connectionString = Environment.GetEnvironmentVariable("CV_19_DB_CONNECTION");
           var createRequestGateway = new OrganisationVolunteerGateway(connectionString);
           var createRequestObject = new CreateOrganisationVolunteerUseCase(createRequestGateway, new OrganisationVolunteerRequestValidator());
           try
           {
               var response = createRequestObject.InsertOrganisationVolunteerRecord(JsonConvert.DeserializeObject<OrganisationsNeedingVolunteers>(request.Body));
               LambdaLogger.Log(("Create Success: " + response.ToString()));
               var resp = new Response();
               resp.statusCode = "200";
               resp.isBase64Encoded = true;
               resp.body = response.ToString();
               return resp;
           }
           catch(Exception e)
           {
               LambdaLogger.Log("Error: " + e.Message);
               var resp = new Response();
               resp.statusCode = "500";
               resp.isBase64Encoded = true;
               resp.body = "Error processing request: " + JsonConvert.SerializeObject(request)+ ". Error Details: " + e.Message + e.StackTrace;
               return resp;
           }
       }
    }

    public class Response
    {
        public bool isBase64Encoded { get; set; }
        public string statusCode { get; set; }
        public string headers { get; set; }
        public string body { get; set; }

        public Response()
        {
        }
    }
}
