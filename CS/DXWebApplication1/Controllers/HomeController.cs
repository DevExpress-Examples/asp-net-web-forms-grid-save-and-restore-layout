using System;
using System.Linq;
using System.Web.Mvc;

namespace DXWebApplication1.Controllers {
    public class HomeController: Controller {
        public ActionResult Index() {
            return View();
        }
        public ActionResult GridViewPartial() {
            return GridViewPartialCore();
        }
        public ActionResult GridViewPartialCustom(string layoutToApply) {
            ViewData["Layout"] = layoutToApply;
            return GridViewPartialCore();
        }
        public ActionResult GridViewPartialCore() {
            return PartialView("GridViewPartial", GetModel());
        }
        private object GetModel() {
            return Enumerable.Range(1, 100).Select(i => new MyModel { ID = i, Text = "Text - " + i });
        }
    }
    public class MyModel {
        public int ID { get; set; }
        public string Text { get; set; }
    }
}