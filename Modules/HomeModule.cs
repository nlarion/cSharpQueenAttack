using Nancy;
using System.Collections.Generic;

namespace QueenAttack
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        var newQueen = new Queen(Request.Form["x1"], Request.Form["y1"]);
        return View["index.cshtml",newQueen.CanAttack(Request.Form["x2"],Request.Form["y2"])];
      };
    }
  }
}
