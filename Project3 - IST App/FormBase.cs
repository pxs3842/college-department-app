using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3___IST_App
{
    public class FormBase : Form
    {
        protected readonly DataService _dataService;

        public FormBase()
        {
            _dataService = new DataService();

        }
    }
}
