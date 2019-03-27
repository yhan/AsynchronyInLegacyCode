namespace AsynchronyInLegacy.WinForm
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class MakeSyncToAsyncWayForm : Form
    {
        public MakeSyncToAsyncWayForm()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            await WrappedLegacyCall();
            LegacyCall();
        }

        private async Task WrappedLegacyCall()
        {
            string result = string.Empty;
            await Task.Run(() =>
            {
                // For example, before refactoring, we will block UI thread
                // Now GUI won't be blocked.
                result = LegacyCall();
            });

            this.textBoxResult.Text = result;
        }

        private string LegacyCall()
        {
            // Imagine we have an I/O here

            Thread.Sleep(TimeSpan.FromSeconds(1));
            return "Legacy computed result";
        }
    }
}