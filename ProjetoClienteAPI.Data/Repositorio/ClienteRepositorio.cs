using ProjetoClienteAPI.Data.Contexto;
using ProjetoClienteAPI.Data.DTO;
using ProjetoClienteAPI.Data.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClienteAPI.Data.Repositorio
{
    public class ClienteRepositorio : IClienteRepositporio
    {
        private readonly BancoContexto _bancoContexto;

        public ClienteRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public void AdicionarCliente(ClienteDTO clienteDTO)
        {
            _bancoContexto.Add(clienteDTO);
        }

        public void Atualizar(ClienteDTO clienteDTO)
        {
            _bancoContexto.Update(clienteDTO);
        }

        public void Deletar(int id)
        {
            _bancoContexto.Remove(id);
        }

        public IEnumerable<ClienteDTO> ListarClientes()
        {
            return _bancoContexto.ClienteDTOs.ToList();
        }

        public ClienteDTO ListarPorId(int id)
        {
            return _bancoContexto.Set<ClienteDTO>().FirstOrDefault(x => x.IdCliente == id);
        }

        public ClienteDTO ListarPorNome(string nome)
        {
            return _bancoContexto.ClienteDTOs.FirstOrDefault(x => x.NomeCliente == nome);
        }
    }
}
