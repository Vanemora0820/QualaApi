using ApiQuala.Dtos;
using AutoMapper;
using DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiQuala.Controllers
{

    [Route("api/coin")]
    [ApiController]
    public class CoinController : Controller
    {

        private readonly QualaContext _context;
        private readonly IMapper _mapper;
        public CoinController(QualaContext context, IMapper mapper)
        {

            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var list = await _context.Coins.ToListAsync();
                return Ok(list);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }

        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] CreateCoinDto coinDto)
        {
            try
            {
               
                var coin = _mapper.Map<Coin>(coinDto);
                _context.Add(coin);
                await _context.SaveChangesAsync();
                return Ok(coin);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }

        }
        [HttpPut("{Id}")]
        public async Task<IActionResult> Update(int Id, [FromBody] UpdateCoinDto coinDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // buscar registro existente por su id
                var existingCoin = await _context.Coins.FindAsync(Id);

                if (existingCoin == null)
                {
                    return NotFound($"No se encontró ningun tipo de moneda  con Id {Id}");
                }

                _mapper.Map(coinDto, existingCoin);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Se actualizó el registro" });
            }
            catch (DbUpdateException ex)
            {

                return BadRequest("No se pudo actualizar el registro. Por favor, verifica los datos y vuelve a intentarlo.");
            }
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                var existingCoin = await _context.Coins.FindAsync(Id);
                if (existingCoin == null)
                {
                    return NotFound($"No se encontró ningun tipo de moneda  con Id {Id}");
                }
                _context.Coins.Remove(existingCoin);
                await _context.SaveChangesAsync();

                return Ok(new { message = "Se eliminó el registro" });
            }
            catch (DbUpdateException ex)
            {
                return BadRequest("No se pudo eliminar el registro. Por favor, verifica los datos y vuelve a intentarlo.");
            }
        }

    }
}
