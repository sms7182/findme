using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRWebApi.Pages
{
    public class ShowLocationModel : PageModel
    {
        private readonly ILogger<ShowLocationModel> _logger;

        public ShowLocationModel(ILogger<ShowLocationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
