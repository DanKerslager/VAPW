using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAPW
{
    public partial class Form2 : Form
    {
        public bool UseTimer { get { return Timer.Checked; } }

        public Form2()
        {
            InitializeComponent();
        }
    }
}
