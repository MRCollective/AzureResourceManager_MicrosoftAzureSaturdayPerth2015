using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using AzureSaturdayPerth2015Api.Domain;
using AzureSaturdayPerth2015Api.Infrastructure.Database;

namespace AzureSaturdayPerth2015Api.Controllers
{
    [Route("api/entry")]
    public class EntryController : ApiController
    {
        public async Task<IHttpActionResult> Post(CreateEntryRequest request)
        {
            using (var context = new DatabaseContext())
            {
                if (!await context.Entries.AnyAsync(e => e.Id == request.Id))
                {
                    context.Entries.Add(new Entry(request.Id));
                    await context.SaveChangesAsync();
                    return StatusCode(HttpStatusCode.Created);
                }

                return StatusCode(HttpStatusCode.OK);
            }
        }
    }

    public class CreateEntryRequest
    {
        public string Id { get; set; }
    }
}