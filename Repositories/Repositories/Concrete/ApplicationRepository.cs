using Core.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Repositories.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories.Concrete
{
    public class ApplicationRepository : EfRepositoryBase<Application>, IApplicationRepository
    {
        public ApplicationRepository(DbContext context) : base(context) { }
    }
}
