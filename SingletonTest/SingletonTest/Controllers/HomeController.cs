using System.Web.Mvc;
using SingletonTest.Models;

namespace SingletonTest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var fakeDb = FakeDb.Instance;

            var contentList = fakeDb.GetAll();

            var model = new HomeViewModel { ContentList = contentList };

            return View(model);
        }

        public ActionResult AddString(string stringToAdd)
        {
            var fakeDb = FakeDb.Instance;
            fakeDb.Add(stringToAdd);
            var contentList = fakeDb.GetAll();

            var model = new HomeViewModel { ContentList = contentList };

            return View("Index", model);
        }
    }
}