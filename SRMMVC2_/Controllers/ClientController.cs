using SRMMVC2_.Models.Classes;
using System.Linq;
using System.Web.Mvc;

namespace SRMMVC2_.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {
        // GET: Client
        private Context cn = new Context();

        public ActionResult Index()
        {
            var Client = cn.Clients.Where(x => x.Status == true).ToList();

            return View(Client);
        }

        [HttpGet]
        public ActionResult AddClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddClient(Client c)
        {
            c.Status = true;
            cn.Clients.Add(c);
            cn.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RemoveClient(int id)
        {
            var cl = cn.Clients.Find(id);
            cl.Status = false;
            cn.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetClient(int id)
        {
            var gc = cn.Clients.Find(id);

            return View("GetClient", gc);
        }

        public ActionResult UpdateClient(Client c)
        {
            var Client = cn.Clients.Find(c.ClientId);
            Client.ClientName = c.ClientName;
            Client.ClientSurname = c.ClientSurname;
            Client.ClientAddress = c.ClientAddress;
            Client.ClientMail = c.ClientMail;
            Client.PhoneNumber = c.PhoneNumber;
            Client.PhoneNumber1 = c.PhoneNumber1;
            Client.PhoneNumber2 = c.PhoneNumber2;
            cn.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SalesLog(int id)
        {
            var log = cn.Invoices.Where(x => x.Clients.ClientId == id).ToList();
            var cl = cn.Clients.Where(x => x.ClientId == id).Select(y => y.ClientName + " " + y.ClientSurname).FirstOrDefault();
            ViewBag.Client = cl;
            return View(log);
        }
    }
}