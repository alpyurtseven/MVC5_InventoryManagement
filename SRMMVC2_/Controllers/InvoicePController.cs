using SRMMVC2_.Models.Classes;
using System.Collections.Generic;
using System.Web.Mvc;
using Context = SRMMVC2_.Models.Classes.Context;

namespace SRMMVC2_.Controllers
{
    [Authorize]
    public class InvoicePController : Controller
    {
        private Context cn = new Context();

        // GET: InvoiceP
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddP(FormCollection form)
        {
            Product p = new Product();
            string[] data = form[0].Split(',');
            List<InvoiceP> ınvp = new List<InvoiceP>();
            string[] productıd = new string[12];
            for (var i = 0; i < data.Length; i++)
            {
                for (var j = 0; j < form.Count; j++)
                {
                    productıd[j] = (form[j].Split(','))[i];
                }
                InvoiceP ip = new InvoiceP();
                ip.ProductId = int.Parse(productıd[0]);
                ip.InvoiceId = int.Parse(productıd[4]);
                ip.Quantity = int.Parse(productıd[1]);
                ip.UnitPrice = int.Parse(productıd[2]);
                ip.Price = ip.Quantity * ip.UnitPrice;
                ip.PDescp = "test";
                var product = cn.Products.Find(ip.ProductId);
                var invoices = cn.Invoices.Find(ip.InvoiceId);
                product.Stock = product.Stock - ip.Quantity;
                invoices.TotalPrice = invoices.TotalPrice + ip.Price;
                p = product;

                ınvp.Add(ip);
            }
            cn.InvoicePs.AddRange(ınvp);
           
            cn.SaveChanges();
            UpdateKg(p);
            return RedirectToAction("Index");
        }


        void UpdateKg(Product p)
        {
            if (p.CategoryId != 3)
            {
                p.Kg = (p.Mt * p.Stock * p.Mkg);

            }
            else
            {
                p.Kg = p.Stock * 15;
            }
            if (p.CategoryId != 3 && p.CategoryId != 4)
            {
                p.Tmt = p.Mt * p.Stock;
            }
            if (p.CategoryId == 4)
            {
                p.mt2 = (p.Width / 1000 * p.Height / 1000);
                p.Tmt = p.mt2 * p.Stock;

            }
            cn.SaveChanges();
        }
    }
}