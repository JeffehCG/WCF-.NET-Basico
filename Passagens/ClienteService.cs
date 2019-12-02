using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Implementação da interface IClientService (Contratos)
namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public bool Add(Cliente cliente)
        {
            Cliente c = new Cliente();
            c.Nome = cliente.Nome;
            c.Cpf = cliente.Cpf;
            ClienteDao dao = new ClienteDao();
            dao.Add(c);
            return true;
        }

        public Cliente Buscar(string nome)
        {
            ClienteDao dao = new ClienteDao();
            return dao.Buscar(nome);

        }

        public List<Cliente> GetClientes()
        {
            return ClienteDao.clientes;
        }
    }
}
