using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;
using Systembankunipim.Bibliotecas.Session;
using Systembankunipim.Data;

namespace Systembankunipim.Controllers
{
    public class LoginController : Controller
    {
        private readonly SYSTEMBANKUNIPIMContext _context;
        private Session _session;
        public LoginController(SYSTEMBANKUNIPIMContext context, Session session)
        {
            _context = context;
            _session = session;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        // Precisa ter um método que recebe uma solicitação GET.

        [HttpPost]
        public IActionResult Index([FromForm] TbCliente cliente)
        {
            TbCliente ClienteLogin = _context.TbCliente.Where(c => c.Email == cliente.Email && c.Senha == cliente.Senha).FirstOrDefault();
            // Realiza a consulta no banco e armazena o resultado em uma variável

            if (ClienteLogin != null) // Realiza a verificação (sempre tem que ser 1)
            {
                string convert = JsonConvert.SerializeObject(ClienteLogin); // Serializa o objeto em string
                _session.Cadastrar("Login", convert); // Cria uma sessão para o objeto serializado
                return RedirectToAction("Index", "TbClientes"); // Direciona para a ação
            }
            else
            {
                ViewData["MSG_E"] = "Usuário ou senha inválidos";
                return View();
                // É melhor usar nameof que ele já identifica onde você quer ir sem precisar colocar método e controlador
            }
        }
    }
}
