using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronyInLegacy.WinForm
{
    using System.Threading;

    public partial class MakeSyncToAsyncWayForm : Form
    {
        public MakeSyncToAsyncWayForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));

            textBoxResult.Text = "Legacy computed result";
        }
    }
}
