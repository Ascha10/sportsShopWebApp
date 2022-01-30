using sportsShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sportsShopWebApp.Controllers
{
    public class ShirtsController : Controller
    {
        static string stringConnection = "Data Source=.;Initial Catalog=sportsShopDB;Integrated Security=True";
        SportsShopDataContext SportsShopDB = new SportsShopDataContext(stringConnection);


        public ActionResult AllShirts(string selectedType)
        {
            switch (selectedType)
            {
                case "ShortSleeves":
                    return View(SportsShopDB.Clothes.Where(item => item.typeOfclothe == "shirt" && item.isShort == true).ToList());

                case "LongSleeves":
                    return View(SportsShopDB.Clothes.Where(item => item.typeOfclothe == "shirt" && item.isShort == false).ToList());

                case "DryfitShirts":
                    return View(SportsShopDB.Clothes.Where(item => item.typeOfclothe == "shirt" && item.isDryfit == true).ToList());


                case "SortedByASCOrder":
                    return View(SportsShopDB.Clothes.Where(item => item.typeOfclothe == "shirt").OrderBy(item => item.price).ToList());

                case "SortedByDESOrder":
                    return View(SportsShopDB.Clothes.Where(item => item.typeOfclothe == "shirt").OrderByDescending(price => price.price).ToList());
            }
            return View(SportsShopDB.Clothes.Where(item => item.typeOfclothe == "shirt").ToList());
        }

    }
}
