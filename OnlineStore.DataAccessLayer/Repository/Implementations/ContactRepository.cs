using Microsoft.EntityFrameworkCore;
using OnlineStore.DataAccessLayer.Repository.Interfaces;
using OnlineStore_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataAccessLayer.Repository.Implementations
{
    public class ContactRepository : IContactRepository
    {
        private StoreDbConn _Context;
        public ContactRepository(StoreDbConn Context)
        {
            _Context = Context;
        }

        public async Task SaveContact(Contact contact)
        {
            _Context.Entry(contact).State = EntityState.Added;
            await _Context.SaveChangesAsync();
        }
    }
}
