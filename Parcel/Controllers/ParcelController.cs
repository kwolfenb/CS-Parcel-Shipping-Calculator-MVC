using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System.Collections.Generic;

namespace Parcel.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/parcel")]
    public ActionResult Index()
    {
     List<ParcelInput> allItems = ParcelInput.GetAll();
      return View(allItems);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcel")]
    public ActionResult Create(int length, int height, int width, int weight)
    {
      ParcelInput myItem = new ParcelInput(length, height, width, weight);
      return RedirectToAction("Index");
    }

  }
}