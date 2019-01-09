using AngelsTeam.Model;

namespace AngelsTeam.Services
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private AngelsDbContext context;
        private ICredentialRepository credentialRepository;
        private INewsRepository newsRepository;
        private ISignalRepository signalRepository;
        private ISubscriptionRepository subscriptionRepository;
        private ISubscriptionTypeRepository subscriptionTypeRepository;
        private IUserRepository userRepository;

        public RepositoryWrapper(AngelsDbContext context)
        {
            this.context = context;
        }
        public INewsRepository NewsRepository {get{return newsRepository ?? (newsRepository = new NewsRepository(context));}}

        public ISignalRepository SignalRepository {get{return signalRepository ?? (signalRepository = new SignalRepository(context));}}

        public ISubscriptionRepository SubscriptionRepository {get{return subscriptionRepository ?? (subscriptionRepository = new SubscriptionRepository(context));}}

        public ISubscriptionTypeRepository SubscriptionTypeRepository {get{return subscriptionTypeRepository ?? (subscriptionTypeRepository = new SubscriptionTypeRepository(context));}}

        public IUserRepository UserRepository {get { return userRepository ?? (userRepository = new UserRepository(context));}}

       public ICredentialRepository CredentialRepository {get { return credentialRepository ?? (credentialRepository = new CredentialRepository(context));}}     
    }
}