using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace WindowsFormsApplication2
{
    public partial class ErrorForm : CCSkinMain
    { 
        public ErrorForm(string message)
        {
            InitializeComponent();
            Label.Text = message;
        }
    }
}
