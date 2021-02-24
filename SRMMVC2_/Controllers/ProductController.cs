using SRMMVC2_.Models.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SRMMVC2_.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        // GET: Product

        private Context cn = new Context();

        public ActionResult Index()
        {
            var products = cn.Products.Where(x => x.Status == true).ToList();
            return View(products);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            List<SelectListItem> cat = (from x in cn.Categorys.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.CategoryName,
                                            Value = x.CategoryId.ToString()
                                        }
                                        ).ToList();
            ViewBag.catval = cat;

            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product p)
        {
            p.Status = true;
            if(p.CategoryId != 3)
            {
                p.Kg = (p.Mt* p.Stock * p.Mkg);
                
            }
            else
            {
                p.Kg = p.Stock * 15;
            }
            if(p.CategoryId !=3 && p.CategoryId != 4)
            {
                p.Tmt = p.Mt * p.Stock;
            }
            if(p.CategoryId == 4)
            {
                p.mt2 = (p.Width/1000*p.Height/1000);
                p.Tmt = p.mt2 * p.Stock;
                p.ProductName = p.ProductName +" -" + p.Width.ToString() + "mmX -" + p.Height.ToString()+"mm  -" + p.Color;
            }
            else if(p.CategoryId==2 || p.CategoryId==5 )
            {
                if(p.Mt != 6)
                {
                    p.ProductName = p.ProductName + " -" + p.Mt.ToString() + "mt -" +p.Color;
                }
                else
                {
                    p.ProductName = p.ProductName + " -"  + p.Color;
                }
               
            }
            else
            {
                p.ProductName = p.ProductName + " -" + p.Color;
            }
           
            cn.Products.Add(p);
            cn.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult RemoveProduct(int id)
        {
            var prod = cn.Products.Find(id);
            prod.Status = false;
            cn.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetProduct(int id)
        {
            List<SelectListItem> cat = (from x in cn.Categorys.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.CategoryName,
                                            Value = x.CategoryId.ToString()
                                        }
                                       ).ToList();
            ViewBag.catval = cat;
            var prod = cn.Products.Find(id);
            return View("GetProduct", prod);
        }


        public ActionResult UpdateProduct(Product p)
        {
            var prod = cn.Products.Find(p.ProductId);
            prod.Status = p.Status;
            prod.Stock = p.Stock;
            prod.Pprice = p.Pprice;
            prod.Sprice = p.Sprice;
            prod.CategoryId = p.CategoryId;
            prod.Image = p.Image;
            prod.Mkg = p.Mkg;
            prod.Mt = p.Mt;
            prod.ProductCode = p.ProductCode;
            prod.CriticalPoint = p.CriticalPoint;
            prod.Width = p.Width;
            prod.Height = p.Height;
            prod.Color = p.Color;

            if(p.CategoryId == 4)
            {
                var name = prod.ProductName.Split('-')[0];
                prod.ProductName = name + " -" + p.Width.ToString() + "mmX -" + p.Height.ToString() + "mm  -" + p.Color;
            }else if(p.CategoryId == 2 || p.CategoryId==5)
            {
                var name = prod.ProductName.Split('-')[0];
                if (p.Mt != 6)
                {
                    prod.ProductName = name + " -" + p.Mt.ToString() + "mt -" + p.Color;
                }
                else
                {
                    prod.ProductName = name + " -" + p.Color;
                }
            }
            else
            {
                var name = prod.ProductName.Split('-')[0];
                prod.ProductName = name + " -"+ p.Color;
            }
           

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
            prod.Kg = p.Kg;
            prod.Tmt = p.Tmt;
            prod.mt2 = p.mt2;

            cn.SaveChanges();
        
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Buying()
        {
            List<SelectListItem> cat = (from x in cn.Products.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.ProductName,
                                            Value = x.ProductId.ToString()
                                        }
                                        ).ToList();
            ViewBag.catval = cat;

            return View();
        }
        [HttpPost]
        public ActionResult Buying(Product p)
        {
            var prod = cn.Products.Find(p.ProductId);
            prod.ProductName = prod.ProductName;
            prod.Status = prod.Status;
            prod.Stock = prod.Stock+ p.Stock;
            prod.Pprice = prod.Pprice;
            prod.Sprice = prod.Sprice;
            prod.CategoryId = prod.CategoryId;
            prod.Image = prod.Image;
            cn.SaveChanges();
            UpdateKg(prod);
            return RedirectToAction("Index");
        }
        public void UpdateKg(Product p)
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