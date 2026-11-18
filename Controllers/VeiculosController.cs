using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_concessionaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private readonly VeiculosController _cursoRepository;
        private VeiculosController _Veiculosrepository;

        // Injeção de dependência: a API entrega o CursoRepository
        // (por causa do AddScoped do passo 11).
        public VeiculosController(VeiculosController veiculosController)
        {
            _Veiculosrepository = veiculosController;
        }

        public object Veiculosrepository { get; private set; }

        // GET api/curso
        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_cursoRepository.ListarTodos());   // 200 + lista em JSON
        }
    }
}