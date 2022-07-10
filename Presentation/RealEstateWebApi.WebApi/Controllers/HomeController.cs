using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Application.Results;
using RealEstateWebApi.Domain.Entities.LocalDb;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {
        private readonly ILocalDbContext _context;

        public HomeController(ILocalDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var guid = Guid.NewGuid().ToString();
            if(_context.TemporaryPass.Any())
                _context.TemporaryPass.RemoveRange(_context.TemporaryPass);

            _context.TemporaryPass.Add(new TemporaryPass(){ Content= guid });
            _context.SaveChanges();
            return Ok(new ApiResult<object>()
            {
                Message ="Api running... See documentation.",
                InternalMessage = guid,
                Success = true
            });
        }
    }
}
