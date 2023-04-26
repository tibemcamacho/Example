using OnlineStore_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BussinessLayer.Services.Interfaces
{
    public interface IUserService
    {
        Task SaveUser(Customer customer);

        Task<bool> UserValid(string email);
        Task<Customer> GetUser(string email, string password);
    }
}
