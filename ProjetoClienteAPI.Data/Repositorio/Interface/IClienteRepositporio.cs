using ProjetoClienteAPI.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClienteAPI.Data.Repositorio.Interface
{
    public interface IClienteRepositporio
    {
        void AdicionarCliente(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> ListarClientes();

        ClienteDTO ListarPorId(int id);

        void Atualizar(ClienteDTO clienteDTO);

        void Deletar(int id);

        ClienteDTO ListarPorNome(string nome);
    }
}
