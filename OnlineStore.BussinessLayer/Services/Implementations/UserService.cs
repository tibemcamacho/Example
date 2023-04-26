using Microsoft.EntityFrameworkCore;
using OnlineStore.BussinessLayer.Services.Interfaces;
using OnlineStore.DataAccessLayer.Repository.Interfaces;
using OnlineStore_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BussinessLayer.Services.Implementations
{
    public class UserService : IUserService
    {
        IUserRepository _IUserRepository;
        public UserService(IUserRepository IUserRepository)
        {
            _IUserRepository = IUserRepository;
        }

        public async Task SaveUser(Customer customer)
        {
           await _IUserRepository.SaveUser(customer);
        }

        public async Task<bool> UserValid(string email)
        {
            return await _IUserRepository.UserValid(email);
        }

        public async Task<Customer> GetUser(string email, string password)
        {
            return await _IUserRepository.GetUser(email, password);
        }
    }
}
