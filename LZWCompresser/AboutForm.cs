using System;
using System.Windows.Forms;

namespace LZWCompresser
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void abouttxt_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
