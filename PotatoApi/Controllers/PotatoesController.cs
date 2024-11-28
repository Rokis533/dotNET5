using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PotatoApi.Database;
using PotatoApi.Entities;
using PotatoApi.Repositories;

namespace PotatoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PotatoesController : ControllerBase
    {
        private readonly IPotatoRepository _potatoRepository;

        private readonly ILogger<PotatoesController> _logger;
        public PotatoesController(IPotatoRepository potatoRepository, ILogger<PotatoesController> logger)
        {
            _potatoRepository = potatoRepository;
            _logger = logger;
        }

        // GET: api/Potatoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Potato>>> GetPotatoes()
        {
            _logger.LogInformation("Getting potatoes");
            _logger.LogWarning("Getting potatoes");
            _logger.LogError("Getting potatoes");

            throw new IamNotHappyException();
            Thread.Sleep(2000);

            return _potatoRepository.GetAll();
        }

        // GET: api/Potatoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Potato>> GetPotato(int id)
        {
            try
            {
                //_logger.LogInformation($"Getting potato by Id:{id} at {DateTime.UtcNow} IP:{HttpContext.Connection.RemoteIpAddress}");

                var potato = _potatoRepository.GetById(id); // gražinsi null
                if (potato.Weight > 0)
                {
                    return BadRequest();
                }

                if (potato == null)
                {
                    _logger.LogInformation($"NOT FOUND \t\t\nGetting potato by Id:{id} at {DateTime.UtcNow}");
                    return NotFound();
                }

                return potato;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message}. \t\t\nGetting potato by Id:{id} at {DateTime.UtcNow}");
                return StatusCode(500, "Unexpected error accrued");
            }
        }

        //// PUT: api/Potatoes/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutPotato(int id, Potato potato)
        //{
        //    if (id != potato.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(potato).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PotatoExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Potatoes
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Potato>> PostPotato(Potato potato)
        //{
        //    _context.Potatoes.Add(potato);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetPotato", new { id = potato.Id }, potato);
        //}

        //// DELETE: api/Potatoes/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeletePotato(int id)
        //{
        //    var potato = await _context.Potatoes.FindAsync(id);
        //    if (potato == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Potatoes.Remove(potato);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool PotatoExists(int id)
        //{
        //    return _context.Potatoes.Any(e => e.Id == id);
        //}
    }
}
