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
    public class UserRepository : IUserRepository
    {
        private StoreDbConn _Context;
        public UserRepository(StoreDbConn Context)
        {
            _Context = Context;
        }

        public async Task SaveUser(Customer customer)
        {
            _Context.Entry(customer).State = EntityState.Added;
            await _Context.SaveChangesAsync();
        }

        public async Task<bool> UserValid(string email)
        {
            return (await _Context.Customer.Where(x => x.Email == email).FirstOrDefaultAsync() == null ? true : false);
        }

        public async Task<Customer> GetUser(string email, string password)
        {
            return await _Context.Customer.Where(x => x.Email == email && x.Password == password).FirstAsync();
        }
        
    }
}
