using OnlineStore_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.BussinessLayer.Services.Interfaces
{
    public interface IContactService
    {
        Task SaveContact(Contact contact);
    }
}
