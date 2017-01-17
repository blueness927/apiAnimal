using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using apiAnimal.Models;

namespace apiAnimal.Controllers.v1
{
    public class AnimalDatasController : ApiController
    {
        private petstationEntities db = new petstationEntities();
        /// <summary>
        /// 取得所有動物資料
        /// </summary>
        /// <returns>IQueryable &lt; Animal&gt;.</returns>
        // GET: api/AnimalDatas
        [Queryable]
        public IQueryable<animalData> GetanimalData()
        {
            db.Configuration.ProxyCreationEnabled = false;
            return db.animalData;
        }
        /// <summary>
        /// 取得單筆動物資料
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <returns>IHttpActionResult.</returns>
        // GET: api/AnimalDatas/5
        [ResponseType(typeof(animalData))]
        public IHttpActionResult GetanimalData(int id)
        {
            animalData animalData = db.animalData.Find(id);
            if (animalData == null)
            {
                return NotFound();
            }

            return Ok(animalData);
        }
        /// <summary>
        /// 修改單筆動物資料
        /// </summary>
        /// <param name="id">The identifier</param>
        /// <param name="animalData">The AnimalDatas</param>
        /// <returns>IHttpActionResult.</returns>
        // PUT: api/AnimalDatas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutanimalData(int id, animalData animalData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != animalData.animalID)
            {
                return BadRequest();
            }

            db.Entry(animalData).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!animalDataExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
        /// <summary>
        /// 新增動物資料
        /// </summary>
        /// <param name="animalData">The AnimalDatas</param>
        /// <returns>IHttpActionResult.</returns>
        // POST: api/AnimalDatas
        [ResponseType(typeof(animalData))]
        public IHttpActionResult PostanimalData(animalData animalData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.animalData.Add(animalData);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = animalData.animalID }, animalData);
        }
        /// <summary>
        /// 刪除單筆動物資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns>IHttpActionResult.</returns>
        // DELETE: api/AnimalDatas/5
        [ResponseType(typeof(animalData))]
        public IHttpActionResult DeleteanimalData(int id)
        {
            animalData animalData = db.animalData.Find(id);
            if (animalData == null)
            {
                return NotFound();
            }

            db.animalData.Remove(animalData);
            db.SaveChanges();

            return Ok(animalData);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool animalDataExists(int id)
        {
            return db.animalData.Count(e => e.animalID == id) > 0;
        }
    }
}