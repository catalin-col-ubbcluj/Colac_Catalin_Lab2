using System.ComponentModel.DataAnnotations;

namespace Colac_Catalin_Lab2.Models
{
    public class Author
    {

        [Display(Name = "Id")]
        public int Id { get; set; }


        [Display(Name = "First Name")]
        public required string FirstName { get; set; }


        [Display(Name = "Last Name")]
        public required string LastName { get; set; }

    }
}
