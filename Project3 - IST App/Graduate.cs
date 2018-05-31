using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3___IST_App
{
    public class Graduate : Undergraduate
    {
        public ICollection<string> AvailableCertificates { get; set; }
    }
}
