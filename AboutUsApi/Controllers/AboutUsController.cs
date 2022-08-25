using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AboutUsApi.Models;
using Microsoft.AspNetCore.Routing;

namespace AboutUsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly AboutUsDBContext _context;

        public AboutUsController(AboutUsDBContext context)
        {
            _context = context;
        }

        // GET: api/AboutUs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AboutUs>>> GetAboutUs()
        {
            return await _context.AboutUs.ToListAsync();
        }

        // GET: api/AboutUs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AboutUs>> GetAboutUs(int id)
        {
            var aboutUs = await _context.AboutUs.FindAsync(id);

            if (aboutUs == null)
            {
                return NotFound();
            }

            return aboutUs;
        }

        // PUT: api/AboutUs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.

        // POST: api/AboutUs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AboutUs>> PostAboutUs(AboutUs aboutUs)
        {
            _context.AboutUs.Add(aboutUs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAboutUs", new { id = aboutUs.Id }, aboutUs);
        }

        // DELETE: api/AboutUs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AboutUs>> DeleteAboutUs(int id)
        {
            var aboutUs = await _context.AboutUs.FindAsync(id);
            if (aboutUs == null)
            {
                return NotFound();
            }

            _context.AboutUs.Remove(aboutUs);
            await _context.SaveChangesAsync();

            return aboutUs;
        }
    }
}
