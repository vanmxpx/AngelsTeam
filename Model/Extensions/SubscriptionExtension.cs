namespace AngelsTeam.Model
{
    public static class SubscriptionExtension
    {
        public static void Clone(this Subscription subscription, Subscription newSubscription)
        {
            subscription.SubscribtionType = newSubscription.SubscribtionType;
            subscription.SubscriptionTypeId = newSubscription.SubscriptionTypeId;
            subscription.User = newSubscription.User;
            subscription.UserId = newSubscription.UserId;                      
        }
    }
}