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
    public partial class ChrysalisForm : Form
    {
        /// <summary>
        /// A basic Chrysalis form. Contains code common to all forms, such as pre-loading to the default size.
        /// </summary>
        internal ChrysalisForm()
        {
            InitializeComponent();
        }

        protected void ClickCancel()
        {
            this.Close();
        }

        private void ChrysalisForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Config.DefaultFormWidth, Config.DefaultFormHeight);
        }

        private void ChrysalisForm_Resize(object sender, EventArgs e)
        {
            this.btnCancel.Top = this.Size.Height - this.btnCancel.Height - 64;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel setup?", "Cancel", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.ClickCancel();
            }
        }
    }
}
