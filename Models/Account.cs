using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internship_Test.Models
{
    public class Account
    {
        [Key]
        public int UserId{ get; set; }
        public string UserName{ get; set; }=string.Empty;
        public int PhoneNo {get; set;}
        public int UserOrders {get; set;}
        [Column("Is_deleted")]
        public bool IsDeleted {get ; set;}
    }
}