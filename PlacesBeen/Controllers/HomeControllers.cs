using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;

namespace PlacesBeen.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Place> allPlaces = Place.GetAll();
        return View(allPlaces);
      }

      [HttpGet("/places/new")]
      public ActionResult CreateForm()
      {
        return View();
      }

      [HttpPost("/places")]
      public ActionResult Create()
      {
        Place newPlace = new Place (Request.Form["new-place"], Request.Form["new-landmark"], Request.Form["new-url"]);
        List<Place> allPlaces = Place.GetAll();
        return View("Index", allPlaces);
      }

      [HttpGet("/places/{id}")]
      public ActionResult Details(int id)
      {
          Place place = Place.Find(id);
          return View(place);
      }
      
    }


}
