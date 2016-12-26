using System.Web.Mvc;

namespace test.Controllers
{
    public class TestController : Controller
    {
        private static readonly object Mylock = new object();
        private const string Path = "~/Content/count.txt";
        public ActionResult Test()
        {
            ulong count;
            lock (Mylock)
            {
                var filepath = Server.MapPath(Path);
                var txt = System.IO.File.ReadAllText(filepath);
                ulong.TryParse(txt, out count);
                count++;
                System.IO.File.WriteAllText(filepath, $"{count}");
            }
            return Content($"{count}");
        }
    }
}