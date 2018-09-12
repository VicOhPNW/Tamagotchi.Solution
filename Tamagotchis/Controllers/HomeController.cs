using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DigitalPet.Models;

namespace DigitalPet.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Tamagotchis> allTamagotchis = new List<Tamagotchis> {};
      return View();
    }
    [HttpPost("/Index")]
    public ActionResult PlayScreen()
    {
      Tamagotchis newTamagotchis = new Tamagotchis(Request.Query["name"]);
      // newTamagotchis.Save();
      // List<Tamagotchis> allTamagotchis = Tamagotchis.GetAll();
      // newTamagotchis.SetName.Request.Query["name"];
      // newTamagotchis.SetFood.int.Parse((Request.Query["food"]));
      // newTamagotchis.SetPlay.int.Parse((Request.Query["play"]));
      // newTamagotchis.SetSleep.int.Parse((Request.Query["sleep"]));
      return View("PlayScreen", newTamagotchis);
    }
  }
}
