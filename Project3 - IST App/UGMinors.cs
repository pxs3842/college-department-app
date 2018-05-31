using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3___IST_App
{
    public class UGMinors // Undergraduate Minors
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<string> Courses { get; set; }
        public string Note { get; set; }
    }
}
