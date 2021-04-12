using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesFirstSamples.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public int Ergebnis { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }



        //MVC Vergleich -> Controller -> Action-Methode Index
        public void OnGet()
        {
            Ergebnis = 0;
        }

        public void OnGetHannes()
        {
            Ergebnis = 42;
        }


        //Formular wird ausgewertet
        public void OnPostPlus()
        {
            int eins = int.Parse(Request.Form["eins"].FirstOrDefault());
            int zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());

            Ergebnis = eins + zwei;
        }

        public void OnPostMinus()
        {
            int eins = int.Parse(Request.Form["eins"].FirstOrDefault());
            int zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());

            Ergebnis = eins - zwei;
        }
    }
}
