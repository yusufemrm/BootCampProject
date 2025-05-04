using Business.DTO.Request.Application;
using Business.DTO.Response.Application;
using Repositories.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBootcampService
    {
        Task<DTO.Response.Bootcamp.CreateBootcampResponse> CreateAsync(CreateApplicationRequest request);
        Task<List<Bootcamp>> GetAllAsync();
    }
}
