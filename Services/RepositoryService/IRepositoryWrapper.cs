namespace AngelsTeam.Services
{
    public interface IRepositoryWrapper
    {
        ICredentialRepository CredentialRepository { get; }
        INewsRepository NewsRepository { get; }
        ISignalRepository SignalRepository { get; }
        ISubscriptionRepository SubscriptionRepository { get; }
        ISubscriptionTypeRepository SubscriptionTypeRepository { get; }
        IUserRepository UserRepository { get; }
    }
}