using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GmailStatsClient.Areas.Identity.Pages.Account.Manage
{
    [AllowAnonymous]
    public class ChartModel: PageModel
    {
        [BindProperty]
        public string ReturnUrl { get; set; }


    }
}
