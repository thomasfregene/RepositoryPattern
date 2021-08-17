using Contracts;
using Entities;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Respository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext respositoryContext)
            : base(respositoryContext)
        {

        }
    }
}
