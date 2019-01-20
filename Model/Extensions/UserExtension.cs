namespace AngelsTeam.Model
{
    public static class UserExtension
    {
        public static void Clone(this User user, User newUser)
        {
            user.Credential = newUser.Credential;
            user.ExpirationDate = newUser.ExpirationDate;
            user.UserTypeId = newUser.UserTypeId;
            user.UserType = newUser.UserType;
            user.Name = newUser.Name;
            user.Subscriptions = newUser.Subscriptions;
            user.Surname = newUser.Surname;
            user.Telegram = newUser.Telegram;                                         
        }
    }
}