using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3___IST_App
{
    public class News
    {
        public List<Year> year { get; set; }
        public List<Older> older { get; set; }
    }

    public class Year
    {
        public string Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class Older : Year
    {
    }
}
