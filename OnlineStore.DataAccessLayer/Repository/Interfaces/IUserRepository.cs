using OnlineStore_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataAccessLayer.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task SaveUser(Customer customer);
        Task<bool> UserValid(string email);
        Task<Customer> GetUser(string email, string password);
    }
}
