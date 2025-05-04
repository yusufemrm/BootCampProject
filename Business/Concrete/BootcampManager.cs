using Business.Abstract;
using Business.DTO.Request.Application;
using Business.DTO.Response.Bootcamp;
using Repositories.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BootcampManager : IBootcampService
    {
        public Task<CreateBootcampResponse> CreateAsync(CreateApplicationRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<List<Bootcamp>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
