using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3___IST_App
{
    public class CoopTable
    {
        public string Title { get; set; }
        public List<CoopInformation> CoopInformation { get; set; }
    }

    public class CoopInformation
    {
        public string Employer { get; set; }
        public string Degree { get; set; }
        public string City { get; set; }
        public string Term { get; set; }
    }
}
