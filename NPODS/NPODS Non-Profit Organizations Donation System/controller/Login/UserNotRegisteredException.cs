using System;

namespace NPODS_Non_Profit_Organizations_Donation_System.controller.Login
{
    [Serializable]
    public class UserNotRegisteredException : Exception
    {
        public UserNotRegisteredException(string email)
        {
            Email = email;
        }

        public string Email { get; }
    }
}
