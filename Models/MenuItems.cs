using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Internship_Test.Models
{
    public class Menu_Items
    {
        [Key]
        public int Menu_ItemId {get; set;}
        public string Item_Name {get; set;} = string.Empty;
        public int Item_Price {get ; set;}
    }
}