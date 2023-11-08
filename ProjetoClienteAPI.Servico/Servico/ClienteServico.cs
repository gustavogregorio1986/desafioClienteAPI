using ProjetoClienteAPI.Data.DTO;
using ProjetoClienteAPI.Data.Repositorio.Interface;
using ProjetoClienteAPI.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClienteAPI.Servico.Servico
{
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepositporio _clienteRepositorio;

        public ClienteServico(IClienteRepositporio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public void AdicionarCliente(ClienteDTO clienteDTO)
        {
            _clienteRepositorio.AdicionarCliente(clienteDTO);
        }

        public void Atualizar(ClienteDTO clienteDTO)
        {
            _clienteRepositorio.Atualizar(clienteDTO);
        }

        public void Deletar(int id)
        {
            _clienteRepositorio.ListarPorId(id);
        }

        public IEnumerable<ClienteDTO> ListarClientes()
        {
           return _clienteRepositorio.ListarClientes();
        }

        public ClienteDTO ListarPorId(int id)
        {
            return _clienteRepositorio.ListarPorId(id);
        }

        public ClienteDTO ListarPorNome(string nome)
        {
            return _clienteRepositorio.ListarPorNome(nome);
        }
    }
}
