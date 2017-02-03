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
    public class MsgsController : ApiController
    {
        private petstationEntities db = new petstationEntities();
        /// <summary>
        /// 取得所有訊息
        /// </summary>
        /// <returns></returns>
        // GET: api/Msgs
        public IQueryable<Msg> GetMsg()
        {
            

            return db.Msg;
        }
        /// <summary>
        /// 取得單一筆訊息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Msgs/5
        [ResponseType(typeof(Msg))]
        public IHttpActionResult GetMsg(int id)
        {
            Msg msg = db.Msg.Find(id);
            if (msg == null)
            {
                return NotFound();
            }

            return Ok(msg);
        }
        /// <summary>
        /// 編輯需要傳送的訊息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        // PUT: api/Msgs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMsg(int id, Msg msg)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != msg.msgID)
            {
                return BadRequest();
            }

            db.Entry(msg).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MsgExists(id))
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
        /// 新增一筆要傳送的訊息
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        // POST: api/Msgs
        [ResponseType(typeof(Msg))]
        public IHttpActionResult PostMsg(Msg msg)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Msg.Add(msg);
            db.SaveChanges();

            return CreatedAtRoute("Apiv1", new { id = msg.msgID }, msg);
        }
        /// <summary>
        /// 刪除一筆訊息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE: api/Msgs/5
        [ResponseType(typeof(Msg))]
        public IHttpActionResult DeleteMsg(int id)
        {
            Msg msg = db.Msg.Find(id);
            if (msg == null)
            {
                return NotFound();
            }

            db.Msg.Remove(msg);
            db.SaveChanges();

            return Ok(msg);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MsgExists(int id)
        {
            return db.Msg.Count(e => e.msgID == id) > 0;
        }
    }
}