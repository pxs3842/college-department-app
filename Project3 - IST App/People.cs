using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3___IST_App
{
    public class People
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public ICollection<Faculty> Faculty { get; set; }
        public ICollection<Staff> Staff { get; set; }
    }
}
