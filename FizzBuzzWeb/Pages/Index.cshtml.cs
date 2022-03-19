using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzzWeb.Models;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        public bool helpBool = false;
        private readonly ILogger<IndexModel> _logger;
        [BindProperty(SupportsGet=true)]
        public string name {get; set; }

        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "User";
            }
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "User";
            }

            helpBool = true;

            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            return RedirectToPage("./Privacy");
        }

    }
}