//using AutoMapper;
//using DB;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace ApiQuala.Controllers
//{

//    [Route("api/controller")]
//    [ApiController]
//    public class CoinController : Controller
//    {

//        private readonly QualaContext _context;
//        private readonly IMapper _mapper;
//        public CoinController(QualaContext context, IMapper mapper)
//        {

//            _context = context;
//            _mapper = mapper;
//        }

//        [HttpGet]
//        public async Task<IActionResult> Get()
//        {
//            try
//            {
//                var list = await _context.Coins.ToListAsync();
//                return Ok(list);

//            }
//            catch (Exception e)
//            {
//                return BadRequest(e.Message);

//            }

//        }



//    }
//}
