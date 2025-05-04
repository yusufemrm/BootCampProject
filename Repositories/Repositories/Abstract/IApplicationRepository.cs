using Core.DataAccess;
using Repositories.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repositories.Repositories.Abstract
{
    public interface IApplicationRepository : IAsyncRepository<Application> { }

}
