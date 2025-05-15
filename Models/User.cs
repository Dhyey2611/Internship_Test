using System.ComponentModel.DataAnnotations;

namespace Internship_Test.Models
{
public class User
{
    [Key]
    public int UserId { get; set; }

    [Required]
    public string Username { get; set; } = string.Empty;

    [Required]
    public string Password { get; set; } =string.Empty;

    [Required]
    public string Role { get; set; } = string.Empty; 

    public string Name { get; set; } = string.Empty;
 
    public string Address { get; set; } = string.Empty;

    public string FavouriteItem { get; set; } = string.Empty;

    public string PreviousOrder { get; set; } = String.Empty;

    public decimal WalletAmount { get; set; }

    public string RewardInfo { get; set; } = string.Empty;

    public int RefundAmount { get; set; }

    public string BenefitInfo { get; set; } =string.Empty ;

    public float AppUpdateVersion { get; set; }
}
}
