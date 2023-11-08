using Microsoft.EntityFrameworkCore;
using ProjetoClienteAPI.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClienteAPI.Data.Contexto
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<ClienteDTO> ClienteDTOs { get; set; }

        internal ClienteDTO Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
