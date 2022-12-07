using Models;
using System.Net;
using  System.Web.Http;
using BL;


namespace News.Controllers
{
    [RoutePrefix("api")]
    public class NewsController : ApiController
    {
        // GET: api/News

        [Route ("GetNews")]
        public IHttpActionResult Get()
        {
            NewsModel news = new NewsHandler().GetNews();

            if(news == null)
            {
                return Content(HttpStatusCode.BadRequest, news);
            }
            return Ok(new { news = news }); 
        }
    }
}
