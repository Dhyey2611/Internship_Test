using System.ComponentModel.DataAnnotations;

namespace Internship_Test.Models
{
    public class Favourite
    {
        [Key]
        public int Id {get ; set;}
        public string Item_name {get ;set ;} = string.Empty;
        public int Item_id {get ; set ;}
    }
}
