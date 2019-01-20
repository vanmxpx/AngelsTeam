using System.Collections.Generic;

namespace AngelsTeam.Model
{
    public class SubscriptionType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Duration { get; set;}
        //Subscription
        public List<Subscription> Subscriptions { get; set; }
    }
}