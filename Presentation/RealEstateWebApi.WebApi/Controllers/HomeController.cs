using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Abstractions.Services;
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
        private readonly IMailService _mailService;

        public HomeController(ILocalDbContext context, IMailService mailService)
        {
            _context = context;
            _mailService = mailService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var guid = Guid.NewGuid().ToString();
            if (_context.TemporaryPass.Any())
            {
                _context.TemporaryPass.RemoveRange(_context.TemporaryPass);
                _context.SaveChanges();
            }

            _context.TemporaryPass.Add(new TemporaryPass() { Content = guid });
            _context.SaveChanges();

            return Ok(new ApiResult<object>()
            {
                Message = "Api running... See documentation.",
                InternalMessage = guid,
                Success = true
            });
        }

    }
}
