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
    using System.Diagnostics;
    using System.Threading;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void StartAsync_on_button_click(object sender, EventArgs e)
        {
            var tcs = new TaskCompletionSource<int>();

            var task = Task.Run(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                tcs.SetResult(42);
            });

            //await task;

            var result = await tcs.Task;
            this.lblResultAsyncWay.Text = result.ToString();
        }

        private async void StartSync_on_button_click(object sender, EventArgs e)
        {
            //var tcs = new TaskCompletionSource<int>();

            //var task = Task.Run(async () =>
            //{
            //    await Task.Delay(TimeSpan.FromSeconds(5));
            //    tcs.SetResult(42);
            //});

            ////await task;

            //var result = tcs.Task.Result;   => WILL DO BLOCKING WAITING
            //this.lblResultSyncWay.Text = result.ToString();

            var stopwatch = Stopwatch.StartNew();
            var taskCompletionSource = new TaskCompletionSource<int>();

            var cts = new CancellationTokenSource();
            var task = Task.Run(async () =>
            {
                var timeout = TimeSpan.FromMilliseconds(1);
                
                // To Cancel
                // Opt 1. Set timeout in ctor
                cts = new CancellationTokenSource(timeout);
                
                //// Opt 2. Set timeout afterward, if you wanna change
                //cts.CancelAfter(timeout);

                //// Opt 3. Register a call back
                //cts.Token.Register(() =>
                //{
                //    // Do stuff, when task is canceled.

                //    var canceled = taskCompletionSource.TrySetCanceled(cts.Token);
                //    Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}] | Task canceled? {canceled}");
                //}, useSynchronizationContext: false);


                Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}] Before delay");
                await Task.Delay(TimeSpan.FromSeconds(2), cts.Token);
                
                Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}] After delay");
                taskCompletionSource.SetResult(42);
                Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}] After Set result");

            }, cts.Token);

                //[1] Before async wait
                //[3] Before delay
                //[4] | Task canceled? True
                //[3] After delay

            try
            {
                Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}] Before async wait");
                await task;
                Console.WriteLine($"[{Thread.CurrentThread.ManagedThreadId}] After async wait");

                int result = taskCompletionSource.Task.Result;
                this.lblResultSyncWay.Text = result.ToString();

                stopwatch.Stop();
                this.lblResultSyncWay.Text = "Task Completed";
                
                lblTime.Text = stopwatch.Elapsed.ToString();
            }
            catch (TaskCanceledException exception)
            {
                stopwatch.Stop();
                this.lblResultSyncWay.Text = "Task Canceled";
                Console.WriteLine(exception);
            }

            stopwatch.Stop();
            lblTime.Text = stopwatch.Elapsed.ToString();

            cts.Dispose();
        }
    }
}
