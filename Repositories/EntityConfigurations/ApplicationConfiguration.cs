using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Repositories.Concrete;

namespace Repositories.EntityConfigurations
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Applicant).WithMany().HasForeignKey(x => x.ApplicantId);
            builder.HasOne(x => x.Bootcamp).WithMany(b => b.Applications).HasForeignKey(x => x.BootcampId);
        }
    }
}
