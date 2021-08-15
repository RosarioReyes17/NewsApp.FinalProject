﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsApp.WebAPI.Data;
using NewsApp.WebAPI.Models;

namespace NewsApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly NewsApppContext _context;

        public PaisesController(NewsApppContext context)
        {
            _context = context;
        }

        // GET: api/Paises
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Paise>>> GetPaises()
        {
            return await _context.Paises.ToListAsync();
        }

        // GET: api/Paises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Paise>> GetPaise(int id)
        {
            var paise = await _context.Paises.FindAsync(id);

            if (paise == null)
            {
                return NotFound();
            }

            return paise;
        }

        // PUT: api/Paises/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaise(int id, Paise paise)
        {
            if (id != paise.IdPais)
            {
                return BadRequest();
            }

            _context.Entry(paise).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaiseExists(id))
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

        // POST: api/Paises
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Paise>> PostPaise(Paise paise)
        {
            _context.Paises.Add(paise);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPaise", new { id = paise.IdPais }, paise);
        }

        // DELETE: api/Paises/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaise(int id)
        {
            var paise = await _context.Paises.FindAsync(id);
            if (paise == null)
            {
                return NotFound();
            }

            _context.Paises.Remove(paise);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PaiseExists(int id)
        {
            return _context.Paises.Any(e => e.IdPais == id);
        }
    }
}
