namespace Netlyze.Forms
{
    partial class FrmMain
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
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.ButtonAnalyze = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonParameters = new System.Windows.Forms.Button();
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.ButtonAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 419);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(680, 10);
            this.ProgressBar.TabIndex = 0;
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(12, 12);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(100, 25);
            this.ButtonOpen.TabIndex = 1;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(337, 364);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(355, 49);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(337, 364);
            this.listBox2.TabIndex = 3;
            // 
            // ButtonAnalyze
            // 
            this.ButtonAnalyze.Location = new System.Drawing.Point(224, 12);
            this.ButtonAnalyze.Name = "ButtonAnalyze";
            this.ButtonAnalyze.Size = new System.Drawing.Size(100, 25);
            this.ButtonAnalyze.TabIndex = 4;
            this.ButtonAnalyze.Text = "Analyze";
            this.ButtonAnalyze.UseVisualStyleBackColor = true;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(380, 12);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(100, 25);
            this.ButtonClear.TabIndex = 5;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            // 
            // ButtonParameters
            // 
            this.ButtonParameters.Location = new System.Drawing.Point(118, 12);
            this.ButtonParameters.Name = "ButtonParameters";
            this.ButtonParameters.Size = new System.Drawing.Size(100, 25);
            this.ButtonParameters.TabIndex = 6;
            this.ButtonParameters.Text = "Parameters";
            this.ButtonParameters.UseVisualStyleBackColor = true;
            this.ButtonParameters.Click += new System.EventHandler(this.ButtonParameters_Click);
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Location = new System.Drawing.Point(486, 12);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(100, 25);
            this.ButtonPrint.TabIndex = 7;
            this.ButtonPrint.Text = "Print";
            this.ButtonPrint.UseVisualStyleBackColor = true;
            // 
            // ButtonAbout
            // 
            this.ButtonAbout.Location = new System.Drawing.Point(592, 12);
            this.ButtonAbout.Name = "ButtonAbout";
            this.ButtonAbout.Size = new System.Drawing.Size(100, 25);
            this.ButtonAbout.TabIndex = 8;
            this.ButtonAbout.Text = "About";
            this.ButtonAbout.UseVisualStyleBackColor = true;
            this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.ButtonAbout);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.ButtonParameters);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonAnalyze);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.ProgressBar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 480);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Netlyze | Best practice analysis for .NET";
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressBar ProgressBar;
        private Button ButtonOpen;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button ButtonAnalyze;
        private Button ButtonClear;
        private Button ButtonParameters;
        private Button ButtonPrint;
        private Button ButtonAbout;
    }
}