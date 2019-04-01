using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCMusicStoreApplication.Models;

namespace MVCMusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {
        private MVCMusicStoreDB db = new MVCMusicStoreDB();

        // GET: /Store/Browse
        [HttpGet]
        public ActionResult Browse()
        {
            return View(db.Genres.OrderBy(a => a.Name).ToList());
        }

        [HttpGet]
        public ActionResult Index(int id)
        {
            var Albums = GetAlbums(id);

            return View("Index", Albums);
        }

        private List<Album> GetAlbums(int searchInt)
        {
            return db.Albums
            .Where(a => a.GenreId.Equals(searchInt))
            .ToList();
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            var album = db.Albums.Find(id);
            return View(album);
        }
    }
}