using SRMMVC2_.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SRMMVC2_.Controllers
{
    [Authorize]
    public class InvoiceController : Controller
    {
        // GET: Invoice
        private Context cn = new Context();

        public ActionResult Index()
        {
            var ınv = cn.Invoices.ToList();

            return View(ınv);
        }

        [HttpGet]
        public ActionResult AddInvoice()
        {
            List<SelectListItem> val2 = (from x in cn.Clients.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.ClientName,
                                             Value = x.ClientId.ToString()
                                         }
                ).ToList();
            List<SelectListItem> val3 = (from x in cn.Staffs.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.StaffName,
                                             Value = x.StaffId.ToString()
                                         }
                ).ToList();
            ViewBag.val2 = val2;
            ViewBag.val3 = val3;

            return View();
        }

        [HttpPost]
        public ActionResult AddInvoice(Invoice i)
        {
            DateTime dt = DateTime.Now;
            i.Date = dt;
            i.StaffId = 1;
            i.TotalPrice = 0;

            cn.Invoices.Add(i);
            cn.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult GetInvoice(int id)
        {
            List<SelectListItem> val2 = (from x in cn.Clients.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.ClientName,
                                             Value = x.ClientId.ToString()
                                         }
                ).ToList();
            List<SelectListItem> val3 = (from x in cn.Staffs.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.StaffName,
                                             Value = x.StaffId.ToString()
                                         }
                ).ToList();
            ViewBag.val2 = val2;
            ViewBag.val3 = val3;
            var ınv = cn.Invoices.Find(id);

            return (View(ınv));
        }

        public ActionResult UpdateInvoice(Invoice i)
        {
            var inv = cn.Invoices.Find(i.InvoiceId);
            inv.Date = i.Date;
            inv.StaffId = i.StaffId;
            inv.ClientId = i.ClientId;
            i.TotalPrice = i.TotalPrice;
            cn.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DetailInvoice(int id)

        {
            var invp = cn.InvoicePs.Where(x => x.InvoiceId == id).ToList();

            return (View(invp));
        }
    }
}