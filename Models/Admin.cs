using System.ComponentModel.DataAnnotations;

namespace Internship_Test.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public int CustomerId { get; set ;}
        public bool InitiateReward {get ; set;}
        public bool InitiateRefund {get ; set;}
        public bool InitiateBenefit {get ; set ;}
    }
}