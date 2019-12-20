using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NPODS_Non_Profit_Organizations_Donation_System.controller.Login;

namespace NPODS.Test
{
    [TestClass]
    public class LoginVerificationTests
    {
        private const string TEST_USER_EMAIL = "testuser@testemail.com.test";
        private const string TEST_USER_PASSWORD = "TestPassword";

        private readonly LoginVerification loginVerification;

        [TestMethod]
        public void VerifyUser_TestUserLogin_Successful()
        {
            LoginVerification loginVerification = new LoginVerification();
            Assert.AreEqual(loginVerification.VerifyUser(TEST_USER_EMAIL, TEST_USER_PASSWORD),
                true);
        }

        [TestMethod]
        public void VerifyUser_TestUserLogin_Unsuccessful()
        {
            LoginVerification loginVerification = new LoginVerification();
            Assert.AreEqual(loginVerification.VerifyUser(TEST_USER_EMAIL, "123"),
                false);
        }

        [TestMethod]
        public void VerifyUser_RandomLogin_Successful()
        {
            LoginVerification loginVerification = new LoginVerification();
            Assert.ThrowsException<UserNotRegisteredException>(() => loginVerification.VerifyUser("123@123.123", "123"));
        }
    }
}
