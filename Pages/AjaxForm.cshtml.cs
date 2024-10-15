using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProgWeboweIMobilneL1.Pages;

public class AjaxForm : PageModel
{
    public void OnGet()
    {
        
    }

    public IActionResult OnPostGetAjax(string name)
    {
        return new JsonResult("Cześć, " + name);
    }
}