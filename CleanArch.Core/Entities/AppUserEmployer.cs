namespace Entities;

public partial class AppUserEmployer
{
    public virtual AppUser AppUser { get; set; }

    public virtual Employer Employer { get; set; }
}