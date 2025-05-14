using System.ComponentModel.DataAnnotations;

namespace Internship_Test.Models
{
    public class Refund
    {
        [Key]
        public int RefundId { get; set; }
        public int Id { get; set; }
        public int Amount {get; set; }
    }
}