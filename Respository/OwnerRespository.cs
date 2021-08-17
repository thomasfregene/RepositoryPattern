using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Respository
{
    public class OwnerRespository : RespositoryBase<Owner>, IOwnerRespository
    {
        public OwnerRespository(RespositoryContext respositoryContext)
            : base(respositoryContext)
        {

        }
    }
}
