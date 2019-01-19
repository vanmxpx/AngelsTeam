namespace AngelsTeam.Model
{
    public class Target
    {
        public int Id { get; set; }
        public string Buy { get; set; }
        public string Profits { get; set; }
        public string Stop { get; set; }
        public int PeriodId { get; set; }
        public Period Period { get; set; }
    }
}