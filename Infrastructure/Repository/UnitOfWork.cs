using CleanArch.Core;

namespace CleanArch.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IAppUser appUser, IEmployer employer)
        {
            AppUsers = appUser;
            Employers = employer;
        }

        public IAppUser AppUsers { get; }
        public IEmployer Employers { get; }
    }
}
