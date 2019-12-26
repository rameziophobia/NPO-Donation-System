namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donations
{
    public class DonationGoal
    {
        public bool isMonthlyGoal { get; set; }
        public float CurrentProgress { get; set; }
        public float Target { get; set; }

        public DonationGoal(bool isMonthlyGoal, float currentProgress, float target)
        {
            this.isMonthlyGoal = isMonthlyGoal;
            CurrentProgress = currentProgress;
            Target = target;
        }

        public void OnMonthly()
        {
            if (isMonthlyGoal)
                CurrentProgress = 0;
        }
    }
}
