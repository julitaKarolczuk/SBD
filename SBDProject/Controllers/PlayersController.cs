﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SBDProject.Models;

namespace SBDProject.Controllers
{
    public class PlayersController : Controller
    {
        private Entities db = new Entities();

        // GET: Players
        public ActionResult Index()
        {
            var player = db.Player.Include(p => p.Position).Include(p => p.Team);
            return View(player.ToList());
        }

        // GET: Players/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Player.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // GET: Players/Create
        public ActionResult Create()
        {
            ViewBag.PositionId = new SelectList(db.Position, "Id", "Name");
            ViewBag.TeamId = new SelectList(db.Team, "Id", "Name");
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,TeamId,PositionId,PlayingFrom,PlayingTo")] Player player)
        {
            if (ModelState.IsValid)
            {
                db.Player.Add(player);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PositionId = new SelectList(db.Position, "Id", "Name", player.PositionId);
            ViewBag.TeamId = new SelectList(db.Team, "Id", "Name", player.TeamId);
            return View(player);
        }

        // GET: Players/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Player.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            ViewBag.PositionId = new SelectList(db.Position, "Id", "Name", player.PositionId);
            ViewBag.TeamId = new SelectList(db.Team, "Id", "Name", player.TeamId);
            return View(player);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,TeamId,PositionId,PlayingFrom,PlayingTo")] Player player)
        {
            if (ModelState.IsValid)
            {
                db.Entry(player).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PositionId = new SelectList(db.Position, "Id", "Name", player.PositionId);
            ViewBag.TeamId = new SelectList(db.Team, "Id", "Name", player.TeamId);
            return View(player);
        }

        // GET: Players/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Player.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Player player = db.Player.Find(id);
            db.Player.Remove(player);
            db.SaveChanges();
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
