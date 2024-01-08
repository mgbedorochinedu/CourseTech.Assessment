using CourseTech.API.Services.CalculateScoreService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseTech.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculateScoreController : ControllerBase
    {
        private readonly ICalculateScoreService _calculateScoreService;

        public CalculateScoreController(ICalculateScoreService calculateScoreService)
        {
            _calculateScoreService = calculateScoreService;
        }

        [HttpGet]
        public  IActionResult CalculateScore([FromQuery] int[] numbers)
        {
            var response = _calculateScoreService.CalculateScore(numbers);
            return Ok(response);
        }


    }
}
