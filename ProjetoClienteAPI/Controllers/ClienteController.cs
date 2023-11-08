using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoClienteAPI.Data.DTO;
using ProjetoClienteAPI.Dominio.Dominio;
using ProjetoClienteAPI.Servico.Servico.Interface;

namespace ProjetoClienteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteServico _clienteServico;

        public ClienteController(IClienteServico clienteServico)
        {
            _clienteServico = clienteServico;
        }

        [HttpPost]
        public ActionResult Cadastrar(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente();

            clienteDTO = new ClienteDTO()
            { 
                 NomeCliente = cliente.NomeCliente,
                 EmailCliente = cliente.EmailCliente,
                 Cpf = cliente.Cpf,
                 Sexo = cliente.Sexo
            };

            _clienteServico.AdicionarCliente(clienteDTO);

            return new JsonResult(clienteDTO);
        }

        [HttpGet]
        public IEnumerable<ClienteDTO> ListarClientes()
        {
            return _clienteServico.ListarClientes();
        }

        [HttpGet("{ListarPorNome}/{nome}")]
        public ClienteDTO ListaPorNome(string nome)
        {
            var lista = _clienteServico.ListarPorNome(nome);
            return lista;
        }

        [HttpGet("{ListarPorId}/{id}")]
        public ClienteDTO ListaPorId(int id)
        {
            return _clienteServico.ListarPorId(id);
        }

        [HttpPut]
        public ActionResult Atualizar(ClienteDTO clienteDTO)
        {
            Cliente cliente = new Cliente();

            clienteDTO = new ClienteDTO()
            {
                NomeCliente = cliente.NomeCliente,
                EmailCliente = cliente.EmailCliente,
                Cpf = cliente.Cpf,
                Sexo = cliente.Sexo
            };

            _clienteServico.Atualizar(clienteDTO);

            return new JsonResult(clienteDTO);
        }

        [HttpDelete]
        public void Deletar(int id)
        {
            _clienteServico.Deletar(id);
        }
    }
}
