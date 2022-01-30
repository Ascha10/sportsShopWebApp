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
    public class PantsController : ApiController
    {
        static string stringConnection = "Data Source=.;Initial Catalog=sportsShopDB;Integrated Security=True";
        SportsShopDataContext SportsShopDB = new SportsShopDataContext(stringConnection);

        // GET: api/Pants
        public IHttpActionResult Get()
        {
            return Ok(SportsShopDB.Clothes.Where(item => item.typeOfclothe == "pant").ToList());
        }

        // GET: api/Pants/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Clothe pant = SportsShopDB.Clothes.First(item => item.typeOfclothe == "pant" && item.clothesId == id);

                if (pant != null)
                {
                    return Ok(pant);
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


        // POST: api/Pants
        public IHttpActionResult Post([FromBody] Clothe pant)
        {
            try
            {
                if (pant != null)
                {
                    SportsShopDB.Clothes.InsertOnSubmit(pant);
                    SportsShopDB.SubmitChanges();
                    return Ok("The Pant Was Added Successfully ");
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

        // PUT: api/Pants/5
        public IHttpActionResult Put(int id, [FromBody] Clothe pant)
        {
            try
            {
                Clothe pantToEdit = SportsShopDB.Clothes.First(item => item.typeOfclothe == "pant" && item.clothesId == id);

                if (pantToEdit != null)
                {
                    pantToEdit.typeOfclothe = pant.typeOfclothe;
                    pantToEdit.gender = pant.gender;
                    pantToEdit.company = pant.company;
                    pantToEdit.model = pant.model;
                    pantToEdit.price = pant.price;
                    pantToEdit.quantity = pant.quantity;
                    pantToEdit.isShort = pant.isShort;
                    pantToEdit.isDryfit = pant.isDryfit;
                    pantToEdit.imageData = pant.imageData;

                    SportsShopDB.SubmitChanges();
                    return Ok("The Pant Was Edited Successfully ");
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


        // DELETE: api/Pants/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Clothe pant = SportsShopDB.Clothes.First(item => item.typeOfclothe == "pant" && item.clothesId == id);

                if (pant != null)
                {
                    SportsShopDB.Clothes.DeleteOnSubmit(pant);
                    SportsShopDB.SubmitChanges();
                    return Ok("The Pant Was Deleted");
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
