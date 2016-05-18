using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrysalis.Core.Forms
{
    public partial class WelcomeForm : ChrysalisForm
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Resize(object sender, EventArgs e)
        {
            this.btnNext.Left = this.Size.Width - this.btnNext.Width - 32;
            this.btnNext.Top = this.Size.Height - this.btnNext.Height - 64;
        }
    }
}
