using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProgWeboweIMobilneL1.Pages;

public class RegisterModel : PageModel
{
    [BindProperty]
    public RegisterInputModel RegisterInput { get; set; }

    public string SuccessMessage { get; set; }

    public void OnGet()
    {
        // Inicjalizacja strony
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Przetwarzanie rejestracji, np. zapis do bazy danych

        SuccessMessage = "Registration successful!";
        ModelState.Clear();
        return Page();
    }
}

public class RegisterInputModel
{
    [Required(ErrorMessage = "Username is required.")]
    [StringLength(20, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 20 characters.")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
    public string Password { get; set; }
}