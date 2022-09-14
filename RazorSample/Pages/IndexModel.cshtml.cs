using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorSample.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; private set; } = "PageModel in C#";

        public void OnGet()
        {
            Message = $"Message on \"onGet\" method : Server time is { DateTime.Now }";
        }
        public void OnPost()
        {
            Message = $"Post was fired { DateTime.Now }";
        }
    }
}
