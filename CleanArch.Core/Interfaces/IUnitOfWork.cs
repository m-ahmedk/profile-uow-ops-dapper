using CleanArch.Core;

public interface IUnitOfWork
{
    IAppUser AppUsers { get; }
    IEmployer Employers { get; }
}