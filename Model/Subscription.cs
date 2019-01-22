namespace AngelsTeam.Model
{
    public class Subscription
    {
        public int Id {get;set;}

        //SubscriptionType
        public int SubscriptionTypeId {get;set;}
        public Profit SubscribtionType {get;set;}
    //User
    public int UserId {get;set;}
    public User User {get;set;}
    }
}