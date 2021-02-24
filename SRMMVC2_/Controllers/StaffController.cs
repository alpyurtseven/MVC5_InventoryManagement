using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SRMMVC2_.Models.Classes;

namespace SRMMVC2_.Controllers
{
    [Authorize]
    public class StaffController : Controller
    {
        // GET: Staff
        private Context cn = new Context();

        public ActionResult Index()
        {
            var staff = cn.Staffs.Where(x => x.Status == true).ToList();

            return View(staff);
        }

        [HttpGet]
        public ActionResult AddStaff()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStaff(Staff s)
        {
            s.Status = true;
            cn.Staffs.Add(s);
            cn.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RemoveStaff(int id)
        {
            var staf = cn.Staffs.Find(id);
            staf.Status = false;
            cn.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetStaff(int id)
        {
            var gs = cn.Staffs.Find(id);

            return View("GetStaff", gs);
        }

        public ActionResult UpdateStaff(Staff s)
        {
            var staff = cn.Staffs.Find(s.StaffId);
            staff.StaffName = s.StaffName;
            staff.StaffSurname = s.StaffSurname;
            cn.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SalesLog(int id)
        {
            var log = cn.Invoices.Where(x => x.Staffs.StaffId == id).ToList();
            var st = cn.Staffs.Where(x => x.StaffId == id).Select(y => y.StaffName + " " + y.StaffSurname).FirstOrDefault();
            ViewBag.staff = st;
            return View(log);
        }
    }
}