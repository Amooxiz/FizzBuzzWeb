using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
    public class CustomValidator : ValidationAttribute
    {
        private int? helpVar = new int();
        private const int FIVE = 5;
        private const int THREE = 3;
        public override bool IsValid(object? value)
        {
            if (value == null)
            {
                return true;
            }
            helpVar = (int)value;
            if (helpVar % (FIVE * THREE) == 0)
            {
                this.ErrorMessage = "FizzBuzz";
                return false;
            }
            else if (helpVar % FIVE == 0)
            {
                this.ErrorMessage = "Buzz";
                return false;
            }
            else if (helpVar % THREE == 0)
            {
                this.ErrorMessage = "Fizz";
                return false;
            }
            else
            {
                this.ErrorMessage = $"Liczba: {helpVar} nie spełnia kryteriów FizzBuzz";
                return false;
            }
        }
    }
}
