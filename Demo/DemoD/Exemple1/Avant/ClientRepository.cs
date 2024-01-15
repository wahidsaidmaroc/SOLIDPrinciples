using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoD.Exemple1.Avant
{
    public class ClientRepository : IRepository
    {
        public void Add(Client entity) => entity

        public void Delete(Client entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public Client? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
