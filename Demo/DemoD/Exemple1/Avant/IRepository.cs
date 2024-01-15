using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoD.Exemple1.Avant
{
    public interface IRepository
    {
        Client? GetById(int id);
        void Add(Client entity);
        void Update(Client entity);
        void Delete(Client entity);
        IEnumerable<Client> GetAll();

    }
}
