using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ControleFinanceiro.BLL.Models;
using ControleFinanceiro.DAL;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoController : ControllerBase
    {
        private readonly Contexto _context;

        public TipoController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Tipo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tipo>>> GetTipos()
        {
            return await _context.Tipos.ToListAsync();
        }

        
    }
}
