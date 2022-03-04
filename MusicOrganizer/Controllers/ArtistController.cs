using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Text.RegularExpressions;

namespace MusicOrganizer.Controllers
{
  public class ArtistController : Controller
  {

    [HttpGet("/artists")]
    public ActionResult Index()
    {
      List<Artist> allArtists = Artist.GetAll();
      return View(allArtists);
    }

    [HttpGet("/artists/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/artists")]
    public ActionResult Create(string artistName)
    {
      Artist newArtist = new Artist(artistName);
      return RedirectToAction("Index");
    }

    [HttpGet("/artists/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist selectedArtist = Artist.Find(id);
      List<Record> artistRecords = selectedArtist.Records;
      model.Add("artist", selectedArtist);
      model.Add("records", artistRecords);
      return View(model);
    }

    // This one creates new Items within a given Category, not new Categories:
    [HttpPost("/artists/{artistId}/records")]
    public ActionResult Create(int artistId, string recordTitle)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist foundArtist = Artist.Find(artistId);
      Record newRecord = new Record(recordTitle);
      foundArtist.AddRecord(newRecord);
      List<Record> artistRecords = foundArtist.Records;
      model.Add("records", artistRecords);
      model.Add("artist", foundArtist);
      return View("Show", model);
    }

    [HttpGet("/artists/showSearch")]
        public ActionResult ShowSearch(string artistSearch)
    {
    List<Artist> artistSearchList = Artist.Search(artistSearch);
      return View(artistSearchList);
    }

  }
}
