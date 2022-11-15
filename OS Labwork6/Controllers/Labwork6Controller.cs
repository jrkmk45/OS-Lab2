using Microsoft.AspNetCore.Mvc;

namespace OS_Labwork6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Labwork6Controller : ControllerBase
    {

        private readonly ILogger<Labwork6Controller> _logger;

        public Labwork6Controller(ILogger<Labwork6Controller> logger)
        {
            _logger = logger;
        }

        [HttpGet("Get")]
        public ActionResult<string> Get()
        {
            string res = "Лабораторна робота №6. Виконав Кіш Роберт Робертович, студент 3 курсі ІПЗ";
            return Ok(res);
        }
    }
}
