using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;
namespace MusicOrganizer.Controllers
{
  public class HomeController : Controller
  {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
        [Route("/favorite_photos")]
  public ActionResult FavoritePhotos()
  {
    return View();
  }
  }
}