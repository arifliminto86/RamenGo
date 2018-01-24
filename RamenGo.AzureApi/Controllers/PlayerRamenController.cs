using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using RamenGo.AzureApi.DataObjects;
using RamenGo.AzureApi.Models;

namespace RamenGo.AzureApi.Controllers
{
    public class PlayerRamenController : TableController<RamenPlayer>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<RamenPlayer>(context, Request);
        }

        // GET tables/RamenPlayer
        public IQueryable<RamenPlayer> GetAllTodoItems()
        {
            
            return Query();
        }

        // GET tables/RamenPlayer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<RamenPlayer> GetTodoItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/RamenPlayer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<RamenPlayer> PatchTodoItem(string id, Delta<RamenPlayer> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/RamenPlayer
        public async Task<IHttpActionResult> PostTodoItem(RamenPlayer player)
        {
            RamenPlayer current = await InsertAsync(player);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/RamenPlayer/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteTodoItem(string id)
        {
            return DeleteAsync(id);
        }
    }
}