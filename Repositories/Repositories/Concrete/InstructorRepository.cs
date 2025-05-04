using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Repositories.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories.Concrete
{
    public class InstructorRepository : EfRepositoryBase<Instructor>, IInstructorRepository
    {
        public InstructorRepository(DbContext context) : base(context) { }
    }
}
