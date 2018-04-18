using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;

namespace Tamagotchi.Controllers
{
    public class HomeController : Controllers
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Pet> allPets =Pets.GetAll();
        return View(allPets)
      }
      [HttpPost("/pets")]
      public ActionResult Create()
      {
        Place newPlace = new Place (Request.Form["new-place"], Request.Form["new-landmark"], Request.Form["new-url"]);
        List<Place> allPlaces = Place.GetAll();
        return View("Index", allPlaces);
      }

      [HttpGet("/pets/new")]
      public ActionResult Create()
      {
        Pet newPet = new Pet (Request.Form["new-pet"])
      }
