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
    public class ModelsController : ControllerBase
    {
        // Refactored
        private readonly IUnitOfWork _unitOfWork;

        // Refactored
        public ModelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Models
        [HttpGet]
        public async Task<IActionResult> GetModels()
        {
            // Refactored
            var Models = await _unitOfWork.Models.GetAll();
            return Ok(Models);
        }

        // GET: api/Models/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetModel(int id)
        {
            //Refactored
            var Model = await _unitOfWork.Models.Get(q => q.Id == id);

            if (Model == null)
            {
                return NotFound();
            }

            return Ok(Model);
        }

        // PUT: api/Models/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModel(int id, Model Model)
        {
            if (id != Model.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Model).State = EntityState.Modified;
            // Refactored
            _unitOfWork.Models.Update(Model);

            try
            {
                //await _context.SaveChangesAsync();
                // Refactored
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                // if (!ModelExists(id))
                // Refactored
                if (!await ModelExists(id))
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

        // POST: api/Models
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Model>> PostModel(Model Model)
        {

            //if (_context.Models == null)
            //{
            //    return Problem("Entity set 'ApplicationDbContext.Models'  is null.");
            //}
            //  _context.Models.Add(Model);
            //  await _context.SaveChangesAsync();

            await _unitOfWork.Models.Insert(Model);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetModel", new { id = Model.Id }, Model);
        }

        // DELETE: api/Models/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModel(int id)
        {
            //if (_context.Models == null)
            //{
            //    return NotFound();
            //}
            //var Model = await _context.Models.FindAsync(id);
            // Refactor
            var Model = await _unitOfWork.Models.Get(q => q.Id == id);
            if (Model == null)
            {
                return NotFound();
            }

            //_context.Models.Remove(Model);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Models.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }


        //private bool ModelExists(int id)
        // Refactored

        private async Task<bool> ModelExists(int id)
        {
            //return (_context.Models?.Any(e => e.Id == id)).GetValueOrDefault();
            // Refactor
            var Model = await _unitOfWork.Models.Get(q => q.Id == id);
            return Model != null;
        }
    }
}
