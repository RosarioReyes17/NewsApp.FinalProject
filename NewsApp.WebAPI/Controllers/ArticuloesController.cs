using System;
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
    public class ArticuloesController : ControllerBase
    {
        private readonly NewsApppContext _context;

        public ArticuloesController(NewsApppContext context)
        {
            _context = context;
        }

        // GET: api/Articuloes
        [HttpGet]
        [AllowAnonymous]

        public ActionResult GetArticles()
        {

            var query = _context.Articulos.AsQueryable();

            var articuloss = query.Select(articuloss => new ArtDto
            {
                Titulo = articuloss.Titulo,
                ImagenURL= articuloss.ImagenUrl,
                Contenido = articuloss.Contenido,
                NombreCompleto = articuloss.IdAutorNavigation.NombreCompleto,
                FechaPublicacion = articuloss.FechaPublicacion,
                ArticuloURL = articuloss.ArticuloUrl,

                
            }).ToArray();

            return Ok(articuloss);
        }


        [HttpGet("{search}")]
        [AllowAnonymous]
        public async Task<ActionResult<Articulo>> GetArticle(String search)
        {
            var query = _context.Articulos.AsQueryable().Where(a => a.Contenido.Contains(search));

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(a => a.Contenido.Contains(search));
                var articles = query.Select(articuloss => new ArtDto
                {
                    Titulo = articuloss.Titulo,
                    ImagenURL = articuloss.ImagenUrl,
                    Contenido = articuloss.Contenido,
                    NombreCompleto = articuloss.IdAutorNavigation.NombreCompleto,
                    FechaPublicacion = articuloss.FechaPublicacion,
                    ArticuloURL = articuloss.ArticuloUrl,
                }).ToArray();

                return Ok(articles);

            }
            return NotFound();

        }
        //public async Task<ActionResult<IEnumerable<Articulo>>> GetArticulos()
        //{
        //    return await _context.Articulos.Select(item => new Articulo
        //    {

        //        IdArticulo = item.IdArticulo,
        //        Titulo = item.Titulo,
        //        Descripcion = item.Descripcion,
        //        ArticuloUrl = item.ArticuloUrl,
        //        ImagenUrl = item.ImagenUrl,
        //        FechaPublicacion = item.FechaPublicacion,
        //        Contenido = item.Contenido,
        //        IdCategoria = item.IdCategoria,
        //        IdPais = item.IdPais,
        //        IdFuente = item.IdFuente,
        //        IdAutor = item.IdAutor


        //    }).ToListAsync();
        //}

        // GET: api/Articuloes/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Articulo>> GetArticulo(int id)
        //{
        //    var articulo = await _context.Articulos.FindAsync(id);

        //    if (articulo == null)
        //    {
        //        return NotFound();
        //    }

        //    return articulo;
        //}

        // PUT: api/Articuloes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticulo(int id, Articulo articulo)
        {
            if (id != articulo.IdArticulo)
            {
                return BadRequest();
            }

            _context.Entry(articulo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticuloExists(id))
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

        // POST: api/Articuloes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Articulo>> PostArticulo(Articulo articulo)
        {
            _context.Articulos.Add(articulo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArticulo", new { id = articulo.IdArticulo }, articulo);
        }

        // DELETE: api/Articuloes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticulo(int id)
        {
            var articulo = await _context.Articulos.FindAsync(id);
            if (articulo == null)
            {
                return NotFound();
            }

            _context.Articulos.Remove(articulo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArticuloExists(int id)
        {
            return _context.Articulos.Any(e => e.IdArticulo == id);
        }
    }
}
