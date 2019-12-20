namespace NPODS_Non_Profit_Organizations_Donation_System.Accounts.Donation
{
    public class DonationGoal
    {
        public bool isMontlyGoal { get; set; }
        public float CurrentProgress { get; set; }
        public float Target { get; set; }

        public DonationGoal(bool isMontlyGoal, float currentProgress, float target)
        {
            this.isMontlyGoal = isMontlyGoal;
            CurrentProgress = currentProgress;
            Target = target;
        }

        public void OnMonthly()
        {
            if (isMontlyGoal)
                CurrentProgress = 0;
        }
    }
}
