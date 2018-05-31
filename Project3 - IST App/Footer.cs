using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3___IST_App
{
    public class Footer
    {
        public Social social { get; set; }
        public List<QuickLinks> quickLinks { get; set; }
        public Copyright copyright { get; set; }
        public string news { get; set; }
    }

    public class Social
    {
        public string Title { get; set; }
        public string Tweet { get; set; }
        public string By { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
    }

    public class QuickLinks
    {
        public string Title { get; set; }
        public string Href { get; set; }
    }

    public class Copyright
    {
        public string Title { get; set; }
        public string html { get; set; }
    }
}
