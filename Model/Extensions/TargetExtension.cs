namespace AngelsTeam.Model
{
    public static class TargetExtension
    {
        public static void Clone(this Target target, Target newTarget)
        {
            target.Buy = newTarget.Buy;
            target.Period = newTarget.Period;
            target.PeriodId = newTarget.PeriodId;
            target.Profits = newTarget.Profits;
            target.Stop = newTarget.Stop;                               
        }
    }
}