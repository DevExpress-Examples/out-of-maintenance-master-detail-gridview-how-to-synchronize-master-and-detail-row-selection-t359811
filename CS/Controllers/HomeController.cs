using System.Linq;
using System.Web.Mvc;

namespace GridViewMasterDetailSelection {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult GridViewMaster() {
            var model = Enumerable.Range(0, 5).Select(i => new { ID = i, Data = "Master Data " + i });
            return PartialView(model);
        }

        public ActionResult GridViewDetail(string id) {
            ViewData["ID"] = id;
            var model = Enumerable.Range(0, 15).Select(i => new { ID = i, Data = id + " Detail Data " + i });
            return PartialView("GridViewDetail", model);
        }
    }
}