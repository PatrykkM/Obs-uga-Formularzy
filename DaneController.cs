using System.Web.Mvc;

public class DaneController : Controller
{
    [HttpGet]
    public ActionResult Form()
    {
        return View(new Dane());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Form(Dane dane)
    {
        if (ModelState.IsValid)
        {
            return View("Wynik", dane);
        }
        return View(dane);
    }

    public ActionResult Wynik(Dane dane)
    {
        return View(dane);
    }
}
