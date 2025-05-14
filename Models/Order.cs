using System.ComponentModel.DataAnnotations;

namespace Internship_Test.Models
{
    public class Order
    {
        [Key]
        public int OrderId {get ; set;}
        public int Id {get ; set;}
        public string Name {get ; set;} = string.Empty;
    }
}