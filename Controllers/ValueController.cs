using System.Linq;
using System.Threading.Tasks;
using AuSocialApp.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuSocialApp.Controllers
{
    [Route("/api/values")]
    public class ValueController: Controller
    {
        private readonly ApplicationDbContext _context;

        public ValueController(ApplicationDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetValuesAsync()
        {
            var values = await this._context.Values.ToListAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetValue(int id)
        {
            var value = this._context.Values.Where(v => v.Id == id);
            return Ok(value);
        }
    }
}