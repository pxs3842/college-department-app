using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3___IST_App
{
    public class Employment
    {
        public Introduction introduction { get; set; }
        public DegreeStatistics degreeStatistics { get; set; }
        public Employers employers { get; set; }
        public Careers careers { get; set; }
        public EmploymentTable employmentTable { get; set; }
        public CoopTable coopTable { get; set; }
    }
}
