using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesFirstSamples.Pages.Haribo
{
    public class AttributeRoutingTestModel : PageModel
    {

        //{year?}/{month}/{day}/{title}
        public void OnGet(int year, int month, int day, string title)
        {

        }
    }
}
