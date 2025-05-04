using Business.Abstract;
using Business.DTO.Request.Application;
using Business.DTO.Response.BlacklistResponse;
using Repositories.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlacklistManager : IBlacklistService
    {
        public Task<CreateBlacklistResponse> CreateAsync(CreateApplicationRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<List<Blacklist>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
