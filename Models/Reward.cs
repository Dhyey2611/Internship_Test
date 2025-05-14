using System.ComponentModel.DataAnnotations;

namespace Internship_Test.Models
{
    public class Reward
    {
        [Key]
        public int RewardId { get; set; }  
        public int Id {get; set;}
        public string RewardInfo {get; set;} = string.Empty;
    }
}