using Business.DTO.Request.Application;
using Business.DTO.Response.Application;
using Business.DTO.Response.BlacklistResponse;
using Repositories.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlacklistService
    {
        Task<CreateBlacklistResponse> CreateAsync(CreateApplicationRequest request);
        Task<List<Blacklist>> GetAllAsync();
    }
}
