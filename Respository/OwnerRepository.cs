using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Respository
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext respositoryContext)
            : base(respositoryContext)
        {

        }
    }
}
