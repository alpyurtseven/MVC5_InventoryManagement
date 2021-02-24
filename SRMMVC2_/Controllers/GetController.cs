using SRMMVC2_.Models.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SRMMVC2_.Controllers
{
    [Authorize]
    public class GetController : ApiController
    {
        private Context cn = new Context();

        public List<Product> Get()
        {
            cn.Configuration.ProxyCreationEnabled = false;
            var client = cn.Products.ToList();

            return client;
        }
    }
}