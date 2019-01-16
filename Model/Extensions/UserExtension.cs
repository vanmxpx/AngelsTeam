namespace AngelsTeam.Model
{
    public static class UserExtension
    {
        public static void Clone(this User user, User newUser)
        {
            user.Credential = newUser.Credential;
            user.ExpirationDate = newUser.ExpirationDate;
            user.RoleId = newUser.RoleId;
            user.Role = newUser.Role;
            user.Name = newUser.Name;
            user.Subscriptions = newUser.Subscriptions;
            user.Surname = newUser.Surname;
            user.Telegram = newUser.Telegram;                                         
        }
    }
}