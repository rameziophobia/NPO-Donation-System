namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts
{
    class Donor : Account
    {
        public string Gender { set; get; }
        public System.DateTime Birthday { set; get; }
        public Donor(string email, string name) : base(email, name)
        {
        }
    }
}
