﻿using OnlineStore_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataAccessLayer.Repository.Interfaces
{
    public interface IContactRepository
    {
        Task SaveContact(Contact contact);
    }
}
