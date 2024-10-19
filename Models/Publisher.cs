using System.ComponentModel.DataAnnotations;

namespace Colac_Catalin_Lab2.Models
{
    public class Publisher
    {
        public int Id { get; set; }


        [Display(Name = "Publisher Name")]
        public string PublisherName { get; set; }

        public ICollection<Book>? Books { get; set; }


    }
}
