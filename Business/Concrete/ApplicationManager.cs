using AutoMapper;
using Business.Abstract;
using Business.DTO.Request.Application;
using Business.DTO.Response.Application;
using Repositories.Repositories.Abstract;
using Repositories.Repositories.Concrete;
using Repositories.Repositories.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ApplicationManager : IApplicationService
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly IMapper _mapper;
        public ApplicationManager(IApplicationRepository applicationRepository, IMapper mapper)
        {
            _applicationRepository = applicationRepository;
            _mapper = mapper;
        }

        public async Task<CreateApplicationResponse> CreateAsync(CreateApplicationRequest request)
        {
            var entity = _mapper.Map<Application>(request);
            await _applicationRepository.AddAsync(entity);

            return _mapper.Map<CreateApplicationResponse>(entity);
        }

        public async Task<List<Application>> GetAllAsync()
        {
            return (await _applicationRepository.GetAllAsync()).ToList();
        }
    }

}
