using System.ComponentModel.DataAnnotations;

namespace Internship_Test.Models
{
    public class Payment{
        
        public int Id {get; set;}
        public string PaymentDetails {get; set;}=string.Empty;
        [Key]
        public int PaymentId {get; set;}
    }
}