using System.ComponentModel.DataAnnotations;

namespace Internship_Test.Models
{
    public class App_Update
    {
        [Key]
        public int UpdateId  { get; set; }
        public float UpdateVersion {get ; set;}
    }
}