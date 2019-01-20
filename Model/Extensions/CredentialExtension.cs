namespace AngelsTeam.Model
{
    public static class CredentialExtension
    {
        public static void Clone(this Credential credential, Credential newCredential)
        {
            credential.Email = newCredential.Email;
            credential.Password = newCredential.Password;
            credential.User = newCredential.User;
            credential.UserId = newCredential.UserId;            
        }
    }
}