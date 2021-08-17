using Contracts;
using Entities;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Respository
{
    public class AccountRespository : RespositoryBase<Account>, IAccountRespository
    {
        public AccountRespository(RespositoryContext respositoryContext)
            : base(respositoryContext)
        {

        }
    }
}
