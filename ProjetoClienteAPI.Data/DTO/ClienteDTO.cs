using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClienteAPI.Data.DTO
{
    public class ClienteDTO
    {
        [Key]
        public int IdCliente { get; set; }

        public string? NomeCliente { get; set; }

        public string? EmailCliente { get; set; }

        public string? Cpf { get; set; }

        public string? Sexo { get; set; }
    }
}
