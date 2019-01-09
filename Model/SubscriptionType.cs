using System.Collections.Generic;

namespace AngelsTeam.Model
{
    public class  SubscriptionType
    {
        public int Id {get;set;}
        public string Title {get;set;}
        public int Description {get;set;}
        public float Cost {get;set;}
        //Subscription
        public List<Subscription> Subscriptions {get;set;}     
    }
}