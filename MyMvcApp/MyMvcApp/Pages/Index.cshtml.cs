using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyMvcApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Intance { get; set; }
        public int TotalVisits { get; set; }
        public int InstanceVisits { get; set; }

        public void OnGet()
        {
            this.Intance = InMemoryDatabase.Intance;
            InMemoryDatabase.IncrementValue();
            this.InstanceVisits = InMemoryDatabase.GetIntegerValue();
            this.TotalVisits = InMemoryDatabase.GetIntegerValue();
        }
    }
}
