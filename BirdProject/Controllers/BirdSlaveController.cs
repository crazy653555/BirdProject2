using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BirdProject.Models;

namespace BirdProject.Controllers
{
    [Authorize]
    public class BirdSlaveController : Controller
    {
        private BirdEntities db = new BirdEntities();

        // GET: BirdSlave
        public async Task<ActionResult> Index()
        {
            return View(await db.B鳥奴.ToListAsync());
        }

        // GET: BirdSlave/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            B鳥奴 b鳥奴 = await db.B鳥奴.FindAsync(id);
            if (b鳥奴 == null)
            {
                return HttpNotFound();
            }
            return View(b鳥奴);
        }

        // GET: BirdSlave/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BirdSlave/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Email,UserName,Tel")] B鳥奴 b鳥奴)
        {
            if (ModelState.IsValid)
            {
                db.B鳥奴.Add(b鳥奴);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(b鳥奴);
        }

        // GET: BirdSlave/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            B鳥奴 b鳥奴 = await db.B鳥奴.FindAsync(id);
            if (b鳥奴 == null)
            {
                return HttpNotFound();
            }
            return View(b鳥奴);
        }

        // POST: BirdSlave/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "UserId,Email,UserName,Tel")] B鳥奴 b鳥奴)
        {
            if (ModelState.IsValid)
            {
                db.Entry(b鳥奴).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(b鳥奴);
        }

        // GET: BirdSlave/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            B鳥奴 b鳥奴 = await db.B鳥奴.FindAsync(id);
            if (b鳥奴 == null)
            {
                return HttpNotFound();
            }
            return View(b鳥奴);
        }

        // POST: BirdSlave/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            B鳥奴 b鳥奴 = await db.B鳥奴.FindAsync(id);
            db.B鳥奴.Remove(b鳥奴);
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
