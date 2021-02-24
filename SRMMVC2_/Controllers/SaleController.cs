using SRMMVC2_.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SRMMVC2_.Controllers
{
    [Authorize]
    public class SaleController : Controller
    {
        // GET: Sale
        private Context cn = new Context();

        private InvoiceController ınv = new InvoiceController();

        public ActionResult Index()
        {
            var ınvoices = cn.Invoices.ToList();

            return View(ınvoices);
        }

        [HttpGet]
        public ActionResult NewSale()
        {
            List<SelectListItem> val1 = (from x in cn.Products.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.ProductName,
                                             Value = x.ProductId.ToString()
                                         }
                                         ).ToList();
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
            ViewBag.val1 = val1;
            ViewBag.val2 = val2;
            ViewBag.val3 = val3;
            var ınvoiceid = TempData["a"];
            ViewBag.val4 = "aaa";
            return View();
        }

        [HttpPost]
        public ActionResult NewSale(Sale s, int invoice)
        {
            return RedirectToAction("NewSale");
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
            ViewBag.val2 = val2;
            return View();
        }

        [HttpPost]
        public ActionResult AddInvoice(Invoice d)
        {
            DateTime dt = DateTime.Now;

            d.StaffId = 1;
            d.Date = dt;
            d.TotalPrice = 0;
            ınv.AddInvoice(d);
            TempData["a"] = d.InvoiceId;
            return RedirectToAction("NewSale", d.InvoiceId);
        }

        public ActionResult GetSale(int id)
        {
            List<SelectListItem> val1 = (from x in cn.Products.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.ProductName,
                                             Value = x.ProductId.ToString()
                                         }
                ).ToList();
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
            ViewBag.val1 = val1;
            ViewBag.val2 = val2;
            ViewBag.val3 = val3;
            var s = cn.Sales.Find(id);

            return View("GetSale", s);
        }

        public ActionResult UpdateSale(Sale s)
        {
            var sale = cn.Sales.Find(s.SaleId);
            sale.Date = s.Date;
            sale.Price = s.Price;
            sale.TotalPrice = s.TotalPrice;
            sale.Clientid = s.Clientid;
            sale.Productid = s.Productid;
            sale.Staffid = s.Staffid;
            sale.Piece = s.Piece;
            cn.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}