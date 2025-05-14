using System.ComponentModel.DataAnnotations;

namespace Internship_Test.Models
{
    public class Wallet
    {
        [Key]
        public int WalletId { get; set; }
        public int Id { get; set; }
        public int WalletAmount { get; set; }
    }
}