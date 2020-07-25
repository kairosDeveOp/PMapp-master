﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PMApp.Data;
using PMApp.Models;
using PMApp.ViewModels;

namespace PMApp.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VehiclesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Vehicles
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Vehicle.Include(v => v.Tenant);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Vehicles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .Include(v => v.Tenant)
                .FirstOrDefaultAsync(m => m.VID == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicles/Create
        public IActionResult Create(int TID)
        {
            var tenants = from t in _context.Tenant where t.TID == TID select t;

            ViewData["TenantTID"] = new SelectList(tenants, "TID", "Last_name");
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VID,License_plate,Model,Make,Year,Color,stall_number,TenantTID")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Tenants", new { id = vehicle.TenantTID });
            }
            ViewData["TenantTID"] = new SelectList(_context.Tenant, "TID", "Last_name", vehicle.TenantTID);
            return View(vehicle);
        }

        // GET: Vehicles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }

            var tenants = from t in _context.Tenant where t.TID == vehicle.TenantTID select t;

            ViewData["TenantTID"] = new SelectList(tenants, "TID", "Last_name");
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VID,License_plate,Model,Make,Year,Color,stall_number,TenantTID")] Vehicle vehicle)
        {
            if (id != vehicle.VID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(vehicle.VID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Tenants", new { id = vehicle.TenantTID });
            }
            ViewData["TenantTID"] = new SelectList(_context.Tenant, "TID", "Last_name", vehicle.TenantTID);
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .Include(v => v.Tenant)
                .FirstOrDefaultAsync(m => m.VID == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicle = await _context.Vehicle.FindAsync(id);
            _context.Vehicle.Remove(vehicle);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Tenants", new { id = vehicle.TenantTID });
        }

        private bool VehicleExists(int id)
        {
            return _context.Vehicle.Any(e => e.VID == id);
        }

        public async Task<IActionResult> getVehicles(long BuildingId)
        {
            var applicationDbContext = from v in _context.Vehicle.Include(v => v.Tenant)
                                       where v.Tenant.Current.Equals("Yes")
                                       join r in _context.Move_in on v.TenantTID equals r.TenantTID into temp
                                       from lj in temp.DefaultIfEmpty()
                                       join u in _context.Unit on lj.UnitUID equals u.UID into temp2
                                       from lj2 in temp2.DefaultIfEmpty()
                                       join b in _context.Buildings 
                                       on lj2.BuildingId equals b.BuildingId into temp3
                                       from lj3 in temp3.DefaultIfEmpty()
                                       where lj3.BuildingId == BuildingId
                                       select new VehicleViewModel
                                       {
                                           VID = v.VID,
                                           Last_name = v.Tenant.Last_name,
                                           First_name = v.Tenant.First_name,
                                           Lease_start_date = v.Tenant.Lease_start_date,
                                           Lease_end_date = v.Tenant.Lease_end_date,
                                           Property = lj3.Org_name,
                                           Unit = lj2.Unit_Number,
                                           License_plate = v.License_plate,
                                           Make = v.Make,
                                           Model = v.Model,
                                           Year = v.Year,
                                           Color = v.Color,
                                           stall_number = v.stall_number
                                       };

            ViewBag.Building = BuildingId;

            return View(await applicationDbContext.ToListAsync());
        }
    }
}
