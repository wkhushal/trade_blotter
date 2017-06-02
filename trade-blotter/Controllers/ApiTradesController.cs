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
using trade_blotter.DataAccess;
using trade_blotter.Models;

namespace trade_blotter.Controllers
{
    public class ApiTradesController : ApiController
    {
        private TradeBookingContext db = new TradeBookingContext();

        // GET: api/Trades
        public IQueryable<Trade> GetTrades()
        {
            return db.Trades;
        }

        // GET: api/Trades/5
        [ResponseType(typeof(Trade))]
        public IHttpActionResult GetTrade(int id)
        {
            Trade trade = db.Trades.Find(id);
            if (trade == null)
            {
                return NotFound();
            }

            return Ok(trade);
        }

        // PUT: api/Trades/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTrade(int id, Trade trade)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != trade.TradeId)
            {
                return BadRequest();
            }

            db.Entry(trade).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TradeExists(id))
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

        // POST: api/Trades
        [ResponseType(typeof(Trade))]
        public IHttpActionResult PostTrade(Trade trade)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Trades.Add(trade);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = trade.TradeId }, trade);
        }

        // DELETE: api/Trades/5
        [ResponseType(typeof(Trade))]
        public IHttpActionResult DeleteTrade(int id)
        {
            Trade trade = db.Trades.Find(id);
            if (trade == null)
            {
                return NotFound();
            }

            db.Trades.Remove(trade);
            db.SaveChanges();

            return Ok(trade);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TradeExists(int id)
        {
            return db.Trades.Count(e => e.TradeId == id) > 0;
        }
    }
}