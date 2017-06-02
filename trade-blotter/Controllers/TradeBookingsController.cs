using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using trade_blotter.DataAccess;
using trade_blotter.Models;

namespace trade_blotter.Controllers
{
    public class TradeBookingsController : Controller
    {
        private TradeBookingContext db = new TradeBookingContext();

        // GET: TradeBookings
        public async Task<ActionResult> Index()
        {
            var tradeBookings = db.TradeBookings.Include(t => t.Trade).Include(t => t.User);
            return View(await tradeBookings.ToListAsync());
        }

        // GET: TradeBookings/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TradeBooking tradeBooking = await db.TradeBookings.FindAsync(id);
            if (tradeBooking == null)
            {
                return HttpNotFound();
            }
            return View(tradeBooking);
        }

        // GET: TradeBookings/Create
        public ActionResult Create()
        {
            ViewBag.TradeId = new SelectList(db.Trades, "TradeID", "Reference");
            ViewBag.UserId = new SelectList(db.Users, "ID", "FirstName");
            return View();
        }

        // POST: TradeBookings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "TradeBookingID,UserId,TradeId,TradeStatus")] TradeBooking tradeBooking)
        {
            if (ModelState.IsValid)
            {
                db.TradeBookings.Add(tradeBooking);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.TradeId = new SelectList(db.Trades, "TradeID", "Reference", tradeBooking.TradeId);
            ViewBag.UserId = new SelectList(db.Users, "ID", "FirstName", tradeBooking.UserId);
            return View(tradeBooking);
        }

        // GET: TradeBookings/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TradeBooking tradeBooking = await db.TradeBookings.FindAsync(id);
            if (tradeBooking == null)
            {
                return HttpNotFound();
            }
            ViewBag.TradeId = new SelectList(db.Trades, "TradeID", "Reference", tradeBooking.TradeId);
            ViewBag.UserId = new SelectList(db.Users, "ID", "FirstName", tradeBooking.UserId);
            return View(tradeBooking);
        }

        // POST: TradeBookings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "TradeBookingID,UserId,TradeId,TradeStatus")] TradeBooking tradeBooking)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tradeBooking).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.TradeId = new SelectList(db.Trades, "TradeID", "Reference", tradeBooking.TradeId);
            ViewBag.UserId = new SelectList(db.Users, "ID", "FirstName", tradeBooking.UserId);
            return View(tradeBooking);
        }

        // GET: TradeBookings/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TradeBooking tradeBooking = await db.TradeBookings.FindAsync(id);
            if (tradeBooking == null)
            {
                return HttpNotFound();
            }
            return View(tradeBooking);
        }

        // POST: TradeBookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TradeBooking tradeBooking = await db.TradeBookings.FindAsync(id);
            db.TradeBookings.Remove(tradeBooking);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
