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
    public class BootcampRepository : EfRepositoryBase<Bootcamp>, IBootcampRepository
    {
        public BootcampRepository(DbContext context) : base(context) { }
    }
}
