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
    public class ClothesController : ApiController
    {
        static string stringConnection = "Data Source=.;Initial Catalog=sportsShopDB;Integrated Security=True";
        SportsShopDataContext SportsShopDB = new SportsShopDataContext(stringConnection);

        // GET: api/Clothes
        public IHttpActionResult Get()
        {
            return Ok(SportsShopDB.Clothes.ToList());
        }

        // GET: api/Clothes/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Clothe clothe = SportsShopDB.Clothes.First(item => item.clothesId == id);

                if (clothe != null)
                {
                    return Ok(clothe);
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

        // POST: api/Clothes
        public IHttpActionResult Post([FromBody]Clothe clothe)
        {
            try
            {
                if (clothe != null)
                {
                    SportsShopDB.Clothes.InsertOnSubmit(clothe);
                    SportsShopDB.SubmitChanges();
                    return Ok("The Cloth Was Added Successfully ");
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

        // PUT: api/Clothes/5
        public IHttpActionResult Put(int id, [FromBody] Clothe clothe)
        {
            try
            {
                Clothe clotheToEdit = SportsShopDB.Clothes.First(item => item.clothesId == id);

                if (clothe != null)
                {
                    clotheToEdit.typeOfclothe = clothe.typeOfclothe;
                    clotheToEdit.gender = clothe.gender;
                    clotheToEdit.company = clothe.company;
                    clotheToEdit.model = clothe.model;
                    clotheToEdit.price = clothe.price;
                    clotheToEdit.quantity = clothe.quantity;
                    clotheToEdit.isShort = clothe.isShort;
                    clotheToEdit.isDryfit = clothe.isDryfit;
                    clotheToEdit.imageData = clothe.imageData;

                    SportsShopDB.SubmitChanges();
                    return Ok("The Cloth Was Edited Successfully ");
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

        // DELETE: api/Clothes/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Clothe clothe = SportsShopDB.Clothes.First(item => item.clothesId == id);

                if (clothe != null)
                {
                    SportsShopDB.Clothes.DeleteOnSubmit(clothe);
                    SportsShopDB.SubmitChanges();
                    return Ok("The Cloth Was Deleted");
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
