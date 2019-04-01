using findpersonalinfo.Models;
using System.Linq;
using System.Web.Mvc;

namespace findpersonalinfo.Controllers
{
    public class FoundInformationController : Controller
    {
        private IApplicationDbContext db;

        public FoundInformationController()
        {
            db = new ApplicationDbContext();
        }
        
        public FoundInformationController(IApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        // GET: FoundInformation
        public ActionResult Index()
        {

            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public ActionResult Details()
        {
            return RedirectToAction("Index", "Home");


        }

        // GET: FoundInformation/Search/5
        //public ActionResult Search(int id)
        [HttpPost]
        public ActionResult Details(Search search)
        {
            var foundInformation = from m in db.FoundInformation
                                   where m.Username == search.SearchTerm
                                   select m;
            TempData["SearchTerm"] = search.SearchTerm;
            return PartialView("_FoundUser", foundInformation.ToList());
            //return View(foundInformation.ToList());

        }
        // GET: FoundInformation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoundInformation/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FoundInformation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FoundInformation/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FoundInformation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FoundInformation/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
