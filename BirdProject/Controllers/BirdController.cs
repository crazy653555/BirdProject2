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
    public class BirdController : Controller
    {
        private BirdEntities db = new BirdEntities();

        // GET: Bird
        public async Task<ActionResult> Index()
        {
            var b鳥 = db.B鳥.Include(b => b.B狀態).Include(b => b.B鳥奴).Include(b => b.B學名);
            return View(await b鳥.ToListAsync());
        }

        // GET: Bird/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            B鳥 b鳥 = await db.B鳥.FindAsync(id);
            if (b鳥 == null)
            {
                return HttpNotFound();
            }
            return View(b鳥);
        }

        // GET: Bird/Create
        public ActionResult Create()
        {
            ViewBag.StatusId = new SelectList(db.B狀態, "StatusId", "Type");
            ViewBag.UserId = new SelectList(db.B鳥奴, "UserId", "Email");
            ViewBag.Bird學名Id = new SelectList(db.B學名, "Bird學名Id", "Bird學名");
            return View();
        }

        // POST: Bird/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "UserId,VerificationId,BirdName,BirdGender,Bird學名Id,RegisteredTime,StatusId")] B鳥 b鳥)
        {
            if (ModelState.IsValid)
            {
                db.B鳥.Add(b鳥);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.StatusId = new SelectList(db.B狀態, "StatusId", "Type", b鳥.StatusId);
            ViewBag.UserId = new SelectList(db.B鳥奴, "UserId", "Email", b鳥.UserId);
            ViewBag.Bird學名Id = new SelectList(db.B學名, "Bird學名Id", "Bird學名", b鳥.Bird學名Id);
            return View(b鳥);
        }

        // GET: Bird/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            B鳥 b鳥 = await db.B鳥.FindAsync(id);
            if (b鳥 == null)
            {
                return HttpNotFound();
            }
            ViewBag.StatusId = new SelectList(db.B狀態, "StatusId", "Type", b鳥.StatusId);
            ViewBag.UserId = new SelectList(db.B鳥奴, "UserId", "Email", b鳥.UserId);
            ViewBag.Bird學名Id = new SelectList(db.B學名, "Bird學名Id", "Bird學名", b鳥.Bird學名Id);
            return View(b鳥);
        }

        // POST: Bird/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "UserId,VerificationId,BirdName,BirdGender,Bird學名Id,RegisteredTime,StatusId")] B鳥 b鳥)
        {
            if (ModelState.IsValid)
            {
                db.Entry(b鳥).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.StatusId = new SelectList(db.B狀態, "StatusId", "Type", b鳥.StatusId);
            ViewBag.UserId = new SelectList(db.B鳥奴, "UserId", "Email", b鳥.UserId);
            ViewBag.Bird學名Id = new SelectList(db.B學名, "Bird學名Id", "Bird學名", b鳥.Bird學名Id);
            return View(b鳥);
        }

        // GET: Bird/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            B鳥 b鳥 = await db.B鳥.FindAsync(id);
            if (b鳥 == null)
            {
                return HttpNotFound();
            }
            return View(b鳥);
        }

        // POST: Bird/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            B鳥 b鳥 = await db.B鳥.FindAsync(id);
            db.B鳥.Remove(b鳥);
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
