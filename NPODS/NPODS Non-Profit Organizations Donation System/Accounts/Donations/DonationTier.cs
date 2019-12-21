namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations
{
    public class DonationTier
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }

        public DonationTier(string name, string description, float value)
        {
            Name = name;
            Description = description;
            Value = value;
        }
    }
}
