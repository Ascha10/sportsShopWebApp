using sportsShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sportsShopWebApp.Controllers
{
    public class PantsController : Controller
    {
        static string stringConnection = "Data Source=.;Initial Catalog=sportsShopDB;Integrated Security=True";
        SportsShopDataContext SportsShopDB = new SportsShopDataContext(stringConnection);

        public ActionResult AllPants(string selectedType)
        {
            switch (selectedType)
            {
                case "ShortPants":
                    return View(SportsShopDB.Clothes.Where(item => item.typeOfclothe == "pant" && item.isShort == true).ToList());

                case "LongPants":
                    return View(SportsShopDB.Clothes.Where(item => item.typeOfclothe == "pant" && item.isShort == false).ToList());

                case "DryfitPants":
                    return View(SportsShopDB.Clothes.Where(item => item.typeOfclothe == "pant" && item.isDryfit == true).ToList());

                case "SortedByASCOrder":
                    return View(SportsShopDB.Clothes.Where(item => item.typeOfclothe == "pant").OrderBy(item => item.price).ToList());

                case "SortedByDESOrder":
                    return View(SportsShopDB.Clothes.Where(item => item.typeOfclothe == "pant").OrderByDescending(price => price.price).ToList());
            }
            return View(SportsShopDB.Clothes.Where(item => item.typeOfclothe == "pant").ToList());
        }
    }
}