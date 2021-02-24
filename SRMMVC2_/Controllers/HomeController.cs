using HtmlAgilityPack;
using SRMMVC2_.AKCurrency;
using SRMMVC2_.Models.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SRMMVC2_.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private Context cn = new Context();

        public ActionResult Index()
        {
            var cstock = cn.Products.Where(x => x.Stock < x.CriticalPoint).Count();
            ViewBag.sd = cstock;
            string[] dolar = GetCurrencyNode();

            var kurlar = new Currencies() { Name = "USD" };
            var kur = new List<Currency>()
            {
                new Currency(){Name = dolar[0],Alis = dolar[1],Satis =dolar[2],Tarih = dolar[3]},
                new Currency(){Name = dolar[4],Alis = dolar[5],Satis =dolar[6],Tarih = dolar[7]}
            };
            var model = new CurrencyDetail() { Degerler = kur, İsimler = kurlar };
            return View(model);
        }

        [HttpGet]
        public string[] GetCurrencyNode()
        {
            AKCurrency.DataServiceSoapClient clien = new DataServiceSoapClient();
            AuthHeader ahd = new AuthHeader();
            ahd.Username = "AltinkaynakWebServis";
            ahd.Password = "AltinkaynakWebServis";
            var currency = clien.GetMain(ahd);
            HtmlDocument result = new HtmlDocument();
            result.LoadHtml(currency);
            HtmlNodeCollection name = result.DocumentNode.SelectNodes("//kod");
            HtmlNodeCollection purchase = result.DocumentNode.SelectNodes("//alis");
            HtmlNodeCollection sales = result.DocumentNode.SelectNodes("//satis");
            HtmlNodeCollection date = result.DocumentNode.SelectNodes("//guncellenmezamani");
            string[] usd = new string[8];
            usd[0] = name[0].InnerText;
            usd[1] = purchase[0].InnerText;
            usd[2] = sales[0].InnerText;
            usd[3] = date[0].InnerText;
            usd[4] = name[1].InnerText;
            usd[5] = purchase[1].InnerText;
            usd[6] = sales[1].InnerText;
            usd[7] = date[1].InnerText;
            return usd;
        }
    }
}