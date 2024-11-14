using System.ComponentModel.DataAnnotations;

namespace Gestionnaire_contacts.Models;

public class Contact
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string FirstName { get; set; }
    
    [Required]
    public string Surname { get; set; }
    
    [Phone]
    public string PhoneNumber { get; set; }
    
    [EmailAddress]
    public string Email { get; set; }
}