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
    public class ContactService : IContactService
    {
        IContactRepository _IContactRepository;
        public ContactService(IContactRepository IContactRepository)
        {
            _IContactRepository = IContactRepository;
        }
        public async Task SaveContact(Contact contact)
        {
            await _IContactRepository.SaveContact(contact);
        }
    }
}
