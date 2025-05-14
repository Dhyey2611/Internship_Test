using System.ComponentModel.DataAnnotations;

namespace Internship_Test.Models
{
    public class Address
    {
        [Key]
        public int AddressId {get; set;}
        public string Addres{get ; set;} = string.Empty;
        public int Id {get; set;}
    }
}