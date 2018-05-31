using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3___IST_App
{
    public class Research
    {
        public List<ByInterestArea> byInterestArea { get; set; }
        public List<ByFaculty> byFaculty { get; set; }
    }

    public class ByInterestArea
    {
        public string AreaName { get; set; }
        public List<string> Citations { get; set; }
    }

    public class ByFaculty
    {
        public string FacultyName { get; set; }
        public string Username { get; set; }
        public List<string> Citations { get; set; }
    }
}
