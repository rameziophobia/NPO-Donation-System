using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NPODS_Non_Profit_Organizations_Donation_System.Accounts;
using NPODS_Non_Profit_Organizations_Donation_System.controller.Login;
using NPODS_Non_Profit_Organizations_Donation_System.Controller.Registration;

namespace NPODS.Test
{
    [TestClass]
    public class LoginManagerTests
    {
        private const string DATA_DONOR_NAME = "testDonor";
        private const string DATA_DONOR_EMAIL = "Test@email.com";
        private const string DATA_DONOR_PASSWORD = "DonorPassword";
        private const string DATA_ORGANIZATION_NAME = "testOrganization";
        private const string DATA_ORGANIZATION_EMAIL = "Test@email.Organization.com";
        private const string DATA_ORGANIZATION_PASSWORD = "OrganizationPassword";

        private const string DATA_RANDOM_PASSWORD = "123123123";
        private const string DATA_RANDOM_EMAIL = "123123123@asdasd.com";

        private static LoginManager loginManager;

        [ClassInitialize]
        public static void setup(TestContext testContext)
        {
            loginManager = new LoginManager();
            Donor donor = new Donor(DATA_DONOR_EMAIL.ToLower(), DATA_DONOR_NAME);
            try
            {
                RegistrationUtil.getInstance().registerDonor(donor, DATA_DONOR_PASSWORD);
            }
            catch (EmailAlreadyExistsException x)
            {
            }

            Organization organization = new Organization(DATA_ORGANIZATION_EMAIL.ToLower(), DATA_ORGANIZATION_NAME);
            try
            {
                RegistrationUtil.getInstance().registerOrganization(organization, DATA_ORGANIZATION_PASSWORD);
            }
            catch (EmailAlreadyExistsException x)
            {
            }
        }

        [TestMethod]
        public void GetUser_DonorLogin_Successful()
        {
            LoginInfo info = loginManager.getUser(DATA_DONOR_EMAIL, DATA_DONOR_PASSWORD);
            Assert.AreEqual(DATA_DONOR_EMAIL.ToLower(), info.Email);
            Assert.AreEqual(AccountType.Donor, info.AccountType);
        }

        [TestMethod]
        public void GetUser_DonorLogin_unSuccessful()
        {
            Assert.ThrowsException<WrongPasswordException>(() =>
                loginManager.getUser(DATA_DONOR_EMAIL, DATA_RANDOM_PASSWORD));
        }

        [TestMethod]
        public void GetUser_OrganizationLogin_Successful()
        {
            LoginInfo info = loginManager.getUser(DATA_ORGANIZATION_EMAIL, DATA_ORGANIZATION_PASSWORD);
            Assert.AreEqual(DATA_ORGANIZATION_EMAIL.ToLower(), info.Email);
            Assert.AreEqual(AccountType.Organization, info.AccountType);
        }

        [TestMethod]
        public void GetUser_OrganizationLogin_Unsuccessful()
        {
            Assert.ThrowsException<WrongPasswordException>(() =>
                loginManager.getUser(DATA_ORGANIZATION_EMAIL, DATA_RANDOM_PASSWORD));
        }

        [TestMethod]
        public void GetUser_RandomMail_Unsuccessful()
        {
            Assert.ThrowsException<UserNotRegisteredException>(() =>
                loginManager.getUser(DATA_RANDOM_EMAIL, DATA_RANDOM_PASSWORD));
        }
    }
}