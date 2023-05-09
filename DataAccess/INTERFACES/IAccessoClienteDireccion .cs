using DataAccess.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.INTERFACES
{
    public interface IAccessoClienteDireccion
    {
        Task<IEnumerable<ClientesMod>> GetClienteDireccion(int _IdCliente);
    }
}
