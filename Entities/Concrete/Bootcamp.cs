using Entities.Concrete;
using Repositories.Repositories.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories.Concrete
{
    public class Bootcamp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InstructorId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public BootcampState BootcampState { get; set; }

        public Instructor Instructor { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}
