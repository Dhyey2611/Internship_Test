using System.ComponentModel.DataAnnotations;

namespace Internship_Test.Models
{
    public class Benefit
    {
        [Key]
        public int BenefitId { get; set; }
        public int Id  { get; set; }
        public string BenefitInfo { get; set; } = string.Empty;
    }
}