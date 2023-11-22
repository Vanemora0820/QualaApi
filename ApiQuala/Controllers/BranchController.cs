using ApiQuala.Dtos;
using AutoMapper;
using DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiQuala.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly QualaContext _context;
        private readonly IMapper _mapper;

        public BranchController(QualaContext context, IMapper mapper)
        {

            _context = context;
            _mapper = mapper;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var list = await _context.Branches.ToListAsync();
                return Ok(list);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }

        }
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] CreateBranchDto branchDto)
        {
            try
            {
                //var branch = mapBranch(branchDto);
                var branch = _mapper.Map<Branch>(branchDto);
                _context.Add(branch);
                await _context.SaveChangesAsync();
                return Ok(branch);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }

        }

        //private Branch mapBranch(CreateBranchDto branch)
        //{

        //    return new Branch
        //    {

        //        Description = branch.Description,
        //        Address = branch.Address,
        //        CreationDate = branch.CreationDate,
        //        CoinId = branch.CoinId,

        //    };

        //}
      

        [HttpPut("{Id}")]
        public async Task<IActionResult> Update(int Id, [FromBody] UpdateBranchDto branchDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // buscar registro existente por su id
                var existingBranch = await _context.Branches.FindAsync(Id);

                if (existingBranch == null)
                {
                    return NotFound($"No se encontró una sucursal con Código {Id}");
                }

                _mapper.Map(branchDto, existingBranch);
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
                var existingBranch = await _context.Branches.FindAsync(Id);
                if (existingBranch == null)
                {
                    return NotFound($"No se encontró una sucursal con código {Id}");
                }
                _context.Branches.Remove(existingBranch);
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
