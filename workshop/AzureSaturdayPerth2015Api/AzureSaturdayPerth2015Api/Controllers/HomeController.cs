using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using AzureSaturdayPerth2015Api.Domain;
using AzureSaturdayPerth2015Api.Infrastructure.Database;

namespace AzureSaturdayPerth2015Api.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            List<Entry> entries;
            using (var context = new DatabaseContext())
            {
                entries = await context.Entries
                    .OrderBy(e => e.DateAdded)
                    .ToListAsync();
            }

            return View(entries);
        }
    }
}