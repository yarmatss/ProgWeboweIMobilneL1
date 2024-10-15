using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProgWeboweIMobilneL1.Pages;

public class ContactModel : PageModel
{
    [BindProperty]
    public ContactInputModel ContactInput { get; set; }

    public bool Submitted { get; set; } = false;

    public void OnGet()
    {
        // Inicjalizacja strony
    }

    public void OnPost()
    {
        if (ModelState.IsValid)
        {
            // Przetwarzanie danych, np. zapis do bazy lub wysłanie emaila
            Submitted = true;
        }
    }
}

public class ContactInputModel
{
    [Required]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Message { get; set; }
}