using sportsShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace sportsShopWebApp.Controllers.API
{
    public class ShirtsController : ApiController
    {
        static string stringConnection = "Data Source=.;Initial Catalog=sportsShopDB;Integrated Security=True";
        SportsShopDataContext SportsShopDB = new SportsShopDataContext(stringConnection);

        // GET: api/Shirts
        public IHttpActionResult Get()
        {
            return Ok(SportsShopDB.Clothes.Where(item => item.typeOfclothe == "shirt").ToList());
        }


        // GET: api/Shirts/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Clothe shirt = SportsShopDB.Clothes.First(item => item.typeOfclothe == "shirt" && item.clothesId == id);

                if (shirt != null)
                {
                    return Ok(shirt);
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
            }
        }


        // POST: api/Shirts
        public IHttpActionResult Post([FromBody] Clothe shirt)
        {
            try
            {
                if (shirt != null)
                {
                    SportsShopDB.Clothes.InsertOnSubmit(shirt);
                    SportsShopDB.SubmitChanges();
                    return Ok("The Shirt Was Added Successfully ");
                }
                return BadRequest();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        // PUT: api/Shirts/5
        public IHttpActionResult Put(int id, [FromBody] Clothe shirt)
        {
            try
            {
                Clothe shirtToEdit = SportsShopDB.Clothes.First(item => item.typeOfclothe == "shirt" && item.clothesId == id);

                if (shirtToEdit != null)
                {
                    shirtToEdit.typeOfclothe = shirt.typeOfclothe;
                    shirtToEdit.gender = shirt.gender;
                    shirtToEdit.company = shirt.company;
                    shirtToEdit.model = shirt.model;
                    shirtToEdit.price = shirt.price;
                    shirtToEdit.quantity = shirt.quantity;
                    shirtToEdit.isShort = shirt.isShort;
                    shirtToEdit.isDryfit = shirt.isDryfit;
                    shirtToEdit.imageData = shirt.imageData;

                    SportsShopDB.SubmitChanges();
                    return Ok("The Shirt Was Edited Successfully ");
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
            }

        }


        // DELETE: api/Shirts/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Clothe shirt = SportsShopDB.Clothes.First(item => item.typeOfclothe == "shirt" && item.clothesId == id);

                if (shirt != null)
                {
                    SportsShopDB.Clothes.DeleteOnSubmit(shirt);
                    SportsShopDB.SubmitChanges();
                    return Ok("The Shirt Was Deleted");
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {

                return BadRequest(err.Message);
            }
        }
    }
}
