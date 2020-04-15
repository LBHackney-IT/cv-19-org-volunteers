using CV19OrgVolunteers.UseCases.V1;
using CV19OrgVolunteers.Gateways.V1;
using NUnit.Framework;
using Moq;

namespace CV19OrgVolunteersTest.UseCases.V1
{
    [TestFixture]
    public class CreateOrganisationVolunteerTest
    {
        private readonly ICreateOrganisationVolunteerUseCase _classUnderTest;
        private readonly Mock<IOrganisationVolunteerGateway> _fakeGateway;

        public CreateOrganisationVolunteerTest()
        {
            _fakeGateway = new Mock<IOrganisationVolunteerGateway>();
            _classUnderTest = new CreateOrganisationVolunteerUseCase(_fakeGateway.Object);
        }
        
        [TestCase]
        public void CanCallTheDatabaseInsertFunction()
        {
            var data = "{}";
            _fakeGateway.Setup(p => p.Insert(""));
            _classUnderTest.InsertOrganisationVolunteerRecord(data);
            _fakeGateway.Verify(m => m.Insert(data), Times.Once);
        }
    }
}