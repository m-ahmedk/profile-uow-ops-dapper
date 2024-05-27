using Entities;
using System.ComponentModel.DataAnnotations;

public class AppUser
{
    [Display(Name = "ID")]
    public int UserID { get; set; }
    
    [Display(Name = "First name")]
    public string FirstName { get; set; }

    [Display(Name = "Last name")]
    public string LastName { get; set; }

    [Display(Name = "Birth date")]
    public DateTime? BirthDate { get; set; }

    public string Email { get; set; }

    [Display(Name = "Phone number")]
    public string Phone { get; set; }

    [Display(Name = "Zip code")]
    public string Zipcode { get; set; }

    [Display(Name = "Created At")]
    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<AppUserEmployer> AppUserEmployers { get; set; } = new List<AppUserEmployer>();
}