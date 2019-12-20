namespace NPODS_Non_Profit_Organizations_Donation_System.OrganizationUtil
{
    class NonMoneyDonation
    {
        private string formLink;
        public string Description { get; set; }
        public NonMoneyDonation(string formLink)
        {
            this.formLink = formLink;
        }

    }
}
