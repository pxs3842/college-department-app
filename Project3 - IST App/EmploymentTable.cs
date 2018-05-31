using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3___IST_App
{
    public class EmploymentTable
    {
        public string Title { get; set; }
        public List<ProfessionalEmploymentInformation> ProfessionalEmploymentInformation { get; set; }
    }

    public class ProfessionalEmploymentInformation
    {
        public string Employer { get; set; }
        public string Degree { get; set; }
        public string City { get; set; }
        public string Title { get; set; }
        public string StartDate { get; set; }
    }
}
