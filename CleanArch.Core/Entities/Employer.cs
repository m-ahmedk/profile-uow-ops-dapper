using Entities;

public class Employer
{
    public int EmployerId { get; set; }
    public string Name { get; set; }
    public DateTime? CreatedOn { get; set; }
    public virtual ICollection<AppUserEmployer> AppUserEmployers { get; set; } = new List<AppUserEmployer>();

}