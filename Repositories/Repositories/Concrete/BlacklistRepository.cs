using Core.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Repositories.Repositories.Abstract;
using Repositories.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories.Concrete
{
    public class BlacklistRepositoryRepository : EfRepositoryBase<Blacklist>, IBlacklistRepository
    {
        public BlacklistRepositoryRepository(DbContext context) : base(context) { }
    }
}
