﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        // Refactored
        private readonly IUnitOfWork _unitOfWork;

        // Refactored
        public BookingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Bookings
        [HttpGet]
        public async Task<IActionResult> GetBookings()
        {
            // Refactored
            var Bookings = await _unitOfWork.Bookings.GetAll();
            return Ok(Bookings);
        }

        // GET: api/Bookings/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBooking(int id)
        {
            //Refactored
            var Booking = await _unitOfWork.Bookings.Get(q => q.Id == id);

            if (Booking == null)
            {
                return NotFound();
            }

            return Ok(Booking);
        }

        // PUT: api/Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking Booking)
        {
            if (id != Booking.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Booking).State = EntityState.Modified;
            // Refactored
            _unitOfWork.Bookings.Update(Booking);

            try
            {
                //await _context.SaveChangesAsync();
                // Refactored
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // if (!BookingExists(id))
                // Refactored
                if (!await BookingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Bookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(Booking Booking)
        {

            //if (_context.Bookings == null)
            //{
            //    return Problem("Entity set 'ApplicationDbContext.Bookings'  is null.");
            //}
            //  _context.Bookings.Add(Booking);
            //  await _context.SaveChangesAsync();

            await _unitOfWork.Bookings.Insert(Booking);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetBooking", new { id = Booking.Id }, Booking);
        }

        // DELETE: api/Bookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            //if (_context.Bookings == null)
            //{
            //    return NotFound();
            //}
            //var Booking = await _context.Bookings.FindAsync(id);
            // Refactor
            var Booking = await _unitOfWork.Bookings.Get(q => q.Id == id);
            if (Booking == null)
            {
                return NotFound();
            }

            //_context.Bookings.Remove(Booking);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Bookings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }


        //private bool BookingExists(int id)
        // Refactored

        private async Task<bool> BookingExists(int id)
        {
            //return (_context.Bookings?.Any(e => e.Id == id)).GetValueOrDefault();
            // Refactor
            var Booking = await _unitOfWork.Bookings.Get(q => q.Id == id);
            return Booking != null;
        }
    }
}
