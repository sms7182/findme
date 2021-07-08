using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRWebApi.Pages
{
    public class FindeMeModel : PageModel
    {
        private readonly ILogger<FindeMeModel> _logger;

        public FindeMeModel(ILogger<FindeMeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
