using Microsoft.VisualStudio.TestTools.UnitTesting;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts;

namespace NPODS.Test
{
    [TestClass]
    public class EditOrganizationTests
    {
        private const string TEST_EMAIL = "TEST.EMAIL@TEST.DOMAIN.com";
        private const string TEST_NAME = "TEST NAME";
        
        private  const string TEST_STRING = "testing";
        
        [TestMethod]
        public void OrganizationProperties_SetDescription_Successful()
        {
            Organization organization = new Organization(TEST_EMAIL, TEST_NAME) {Description = TEST_STRING};

            Assert.AreEqual(TEST_STRING, organization.Description);
            Assert.AreNotEqual(TEST_STRING, organization.Name);
            Assert.AreNotEqual(TEST_STRING, organization.LogoFilePath);
            Assert.AreNotEqual(TEST_STRING, organization.Email);
            Assert.AreNotEqual(TEST_STRING, organization.OrganizationUrl);
        }
        
        [TestMethod]
        public void OrganizationProperties_SetEmail_Successful()
        {
            Organization organization = new Organization(TEST_EMAIL, TEST_NAME);
            organization.Email = TEST_STRING;

            Assert.AreNotEqual(TEST_STRING, organization.Description);
            Assert.AreNotEqual(TEST_STRING, organization.Name);
            Assert.AreNotEqual(TEST_STRING, organization.LogoFilePath);
            Assert.AreEqual(TEST_STRING, organization.Email);
            Assert.AreNotEqual(TEST_STRING, organization.OrganizationUrl);
        }
        
        [TestMethod]
        public void OrganizationProperties_SetName_Successful()
        {
            Organization organization = new Organization(TEST_EMAIL, TEST_NAME);
            organization.Name = TEST_STRING;

            Assert.AreNotEqual(TEST_STRING, organization.Description);
            Assert.AreEqual(TEST_STRING, organization.Name);
            Assert.AreNotEqual(TEST_STRING, organization.LogoFilePath);
            Assert.AreNotEqual(TEST_STRING, organization.Email);
            Assert.AreNotEqual(TEST_STRING, organization.OrganizationUrl);
        }
        
        [TestMethod]
        public void OrganizationProperties_SetLogoFilePath_Successful()
        {
            Organization organization = new Organization(TEST_EMAIL, TEST_NAME) {LogoFilePath = TEST_STRING};

            Assert.AreNotEqual(TEST_STRING, organization.Description);
            Assert.AreNotEqual(TEST_STRING, organization.Name);
            Assert.AreEqual(TEST_STRING, organization.LogoFilePath);
            Assert.AreNotEqual(TEST_STRING, organization.Email);
            Assert.AreNotEqual(TEST_STRING, organization.OrganizationUrl);
        }        
        [TestMethod]
        public void OrganizationProperties_SetOrganizationUrl_Successful()
        {
            Organization organization = new Organization(TEST_EMAIL, TEST_NAME) {OrganizationUrl = TEST_STRING};

            Assert.AreNotEqual(TEST_STRING, organization.Description);
            Assert.AreNotEqual(TEST_STRING, organization.Name);
            Assert.AreNotEqual(TEST_STRING, organization.LogoFilePath);
            Assert.AreNotEqual(TEST_STRING, organization.Email);
            Assert.AreEqual(TEST_STRING, organization.OrganizationUrl);
        }
    }
}