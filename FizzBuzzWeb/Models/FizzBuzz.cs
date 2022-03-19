using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {
        [Required, Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}."), CustomValidator()]

        [Display(Name = "Twoj szczesliwy numerek")]
        public int? Number { get; set; }

    }
}
