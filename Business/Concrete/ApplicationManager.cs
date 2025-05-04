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

        public ApplicationManager(IApplicationRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }

        public async Task<CreateApplicationResponse> CreateAsync(CreateApplicationRequest request)
        {
            var entity = new Application
            {
                ApplicantId = request.ApplicantId,
                BootcampId = request.BootcampId,
                ApplicationState = ApplicationState.PENDING
            };

            await _applicationRepository.AddAsync(entity);

            return new CreateApplicationResponse
            {
                Id = entity.Id,
                Status = entity.ApplicationState.ToString()
            };
        }

        public async Task<List<Application>> GetAllAsync()
        {
            return (await _applicationRepository.GetAllAsync()).ToList();
        }
    }

}
