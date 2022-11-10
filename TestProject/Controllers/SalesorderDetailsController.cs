using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestProject.Data;
using TestProject.Models;

namespace TestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesorderDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SalesorderDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesorderDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesorderDetail>>> GetSalesorderDetail()
        {
            return await _context.SalesorderDetail.ToListAsync();
        }

        // GET: api/SalesorderDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesorderDetail>> GetSalesorderDetail(int id)
        {
            var salesorderDetail = await _context.SalesorderDetail.FindAsync(id);

            if (salesorderDetail == null)
            {
                return NotFound();
            }

            return salesorderDetail;
        }

        // PUT: api/SalesorderDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesorderDetail(int id, SalesorderDetail salesorderDetail)
        {
            if (id != salesorderDetail.SalesorderDetailId)
            {
                return BadRequest();
            }

            _context.Entry(salesorderDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesorderDetailExists(id))
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

        // POST: api/SalesorderDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SalesorderDetail>> PostSalesorderDetail(SalesorderDetail salesorderDetail)
        {
            _context.SalesorderDetail.Add(salesorderDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesorderDetail", new { id = salesorderDetail.SalesorderDetailId }, salesorderDetail);
        }

        // DELETE: api/SalesorderDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SalesorderDetail>> DeleteSalesorderDetail(int id)
        {
            var salesorderDetail = await _context.SalesorderDetail.FindAsync(id);
            if (salesorderDetail == null)
            {
                return NotFound();
            }

            _context.SalesorderDetail.Remove(salesorderDetail);
            await _context.SaveChangesAsync();

            return salesorderDetail;
        }

        private bool SalesorderDetailExists(int id)
        {
            return _context.SalesorderDetail.Any(e => e.SalesorderDetailId == id);
        }
    }
}
