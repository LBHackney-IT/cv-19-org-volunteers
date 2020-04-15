using System.Collections.Generic;
using CV19OrgVolunteers.UseCases.V1;
using CV19OrgVolunteers.Gateways.V1;
using CV19OrgVolunteers.Models.V1;
using CV19OrgVolunteers.Validators.V1;
using NUnit.Framework;
using Moq;

namespace CV19OrgVolunteersTest.UseCases.V1
{
    [TestFixture]
    public class CreateOrganisationVolunteerTest
    {
        private readonly ICreateOrganisationVolunteerUseCase _classUnderTest;
        private readonly Mock<IOrganisationVolunteerGateway> _fakeGateway;
        private readonly Mock<IOrganisationVolunteerRequestValidator> _fakeValidator;

        public CreateOrganisationVolunteerTest()
        {
            _fakeGateway = new Mock<IOrganisationVolunteerGateway>();
            _fakeValidator = new Mock<IOrganisationVolunteerRequestValidator>();
            _classUnderTest = new CreateOrganisationVolunteerUseCase(_fakeGateway.Object, _fakeValidator.Object);
        }
        
        [TestCase]
        public void CanCallTheDatabaseInsertMethod()
        {
            var data = new OrganisationsNeedingVolunteers();
            _fakeGateway.Setup(p => p.Insert(data)); 
            _fakeValidator.Setup(p => p.Validate(data)).Returns(new Dictionary<string, string>());
            _classUnderTest.InsertOrganisationVolunteerRecord(data);
            _fakeGateway.Verify(m => m.Insert(data), Times.Once);
        }
        
        [TestCase]
        public void CanCallTheRequestValidationMethod()
        {
            var data = new OrganisationsNeedingVolunteers();
            _fakeGateway.Setup(p => p.Insert(data));
            _fakeValidator.Setup(p => p.Validate(data)).Returns(new Dictionary<string, string>());
            _classUnderTest.InsertOrganisationVolunteerRecord(data);
            _fakeValidator.Verify(m => m.Validate(data), Times.Once);
        }

        [TestCase]
        public void GivenAValidRequestItCanAddRecordToDB()
        {
            var data = new OrganisationsNeedingVolunteers();
            _fakeValidator.Setup(p => p.Validate(data)).Returns(new Dictionary<string, string>());
            _classUnderTest.InsertOrganisationVolunteerRecord(data);
            _fakeGateway.Verify(m => m.Insert(data), Times.Once);
        }
    }
}