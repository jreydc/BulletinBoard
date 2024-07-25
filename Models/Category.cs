using System.ComponentModel.DataAnnotations;

namespace BulletinBoard.Models;

public class Category
{
    [Key]
    public int ID { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string UserName { get; set; }
}
