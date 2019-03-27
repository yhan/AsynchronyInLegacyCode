namespace AsynchronyInLegacy.WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartAsync = new System.Windows.Forms.Button();
            this.lblResultAsyncWay = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultSyncWay = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartAsync
            // 
            this.btnStartAsync.Location = new System.Drawing.Point(54, 35);
            this.btnStartAsync.Name = "btnStartAsync";
            this.btnStartAsync.Size = new System.Drawing.Size(75, 23);
            this.btnStartAsync.TabIndex = 0;
            this.btnStartAsync.Text = "Start async get";
            this.btnStartAsync.UseVisualStyleBackColor = true;
            this.btnStartAsync.Click += new System.EventHandler(this.StartAsync_on_button_click);
            // 
            // lblResultAsyncWay
            // 
            this.lblResultAsyncWay.AutoSize = true;
            this.lblResultAsyncWay.Location = new System.Drawing.Point(171, 40);
            this.lblResultAsyncWay.Name = "lblResultAsyncWay";
            this.lblResultAsyncWay.Size = new System.Drawing.Size(47, 13);
            this.lblResultAsyncWay.TabIndex = 1;
            this.lblResultAsyncWay.Text = "lblResult";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start synchronously get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StartSync_on_button_click);
            // 
            // lblResultSyncWay
            // 
            this.lblResultSyncWay.AutoSize = true;
            this.lblResultSyncWay.Location = new System.Drawing.Point(327, 87);
            this.lblResultSyncWay.Name = "lblResultSyncWay";
            this.lblResultSyncWay.Size = new System.Drawing.Size(47, 13);
            this.lblResultSyncWay.TabIndex = 1;
            this.lblResultSyncWay.Text = "lblResult";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(420, 88);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblResultSyncWay);
            this.Controls.Add(this.lblResultAsyncWay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStartAsync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartAsync;
        private System.Windows.Forms.Label lblResultAsyncWay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResultSyncWay;
        private System.Windows.Forms.Label lblTime;
    }
}

