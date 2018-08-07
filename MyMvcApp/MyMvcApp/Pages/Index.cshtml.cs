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
        public int TotalVisits { get; set; }
        public int InstanceVisits { get; set; }

        public void OnGet()
        {
            RedisDatabase.IncrementValue("TotalVisits");
            this.TotalVisits = RedisDatabase.GetIntegerValue("TotalVisits");
            InMemoryDatabase.IncrementValue();
            this.InstanceVisits = InMemoryDatabase.GetIntegerValue();
        }
    }
}
