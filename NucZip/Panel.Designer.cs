
namespace NucZip
{
    partial class Panel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.startBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logBox = new System.Windows.Forms.ListBox();
            this.wordListBtn = new System.Windows.Forms.Button();
            this.zipFileBtn = new System.Windows.Forms.Button();
            this.chooseZipDialog = new System.Windows.Forms.OpenFileDialog();
            this.chooseWordlistDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputFolderBtn = new System.Windows.Forms.Button();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.delayUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(18, 387);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(363, 45);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.ItemHeight = 15;
            this.logBox.Location = new System.Drawing.Point(6, 23);
            this.logBox.Name = "logBox";
            this.logBox.ScrollAlwaysVisible = true;
            this.logBox.Size = new System.Drawing.Size(363, 199);
            this.logBox.TabIndex = 0;
            // 
            // wordListBtn
            // 
            this.wordListBtn.Location = new System.Drawing.Point(137, 12);
            this.wordListBtn.Name = "wordListBtn";
            this.wordListBtn.Size = new System.Drawing.Size(122, 40);
            this.wordListBtn.TabIndex = 2;
            this.wordListBtn.Text = "Choose Wordlist";
            this.wordListBtn.UseVisualStyleBackColor = true;
            this.wordListBtn.Click += new System.EventHandler(this.wordListBtn_Click);
            // 
            // zipFileBtn
            // 
            this.zipFileBtn.Location = new System.Drawing.Point(9, 12);
            this.zipFileBtn.Name = "zipFileBtn";
            this.zipFileBtn.Size = new System.Drawing.Size(122, 40);
            this.zipFileBtn.TabIndex = 3;
            this.zipFileBtn.Text = "Choose Zipfile";
            this.zipFileBtn.UseVisualStyleBackColor = true;
            this.zipFileBtn.Click += new System.EventHandler(this.zipFileBtn_Click);
            // 
            // chooseZipDialog
            // 
            this.chooseZipDialog.Filter = "zip file|*.zip|7zip file|*.7zip";
            // 
            // chooseWordlistDialog
            // 
            this.chooseWordlistDialog.Filter = "txt file|*.txt";
            // 
            // outputFolderBtn
            // 
            this.outputFolderBtn.Location = new System.Drawing.Point(265, 12);
            this.outputFolderBtn.Name = "outputFolderBtn";
            this.outputFolderBtn.Size = new System.Drawing.Size(122, 40);
            this.outputFolderBtn.TabIndex = 4;
            this.outputFolderBtn.Text = "Choose Output Folder";
            this.outputFolderBtn.UseVisualStyleBackColor = true;
            this.outputFolderBtn.Click += new System.EventHandler(this.outputFolderBtn_Click);
            // 
            // delayUpDown
            // 
            this.delayUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.delayUpDown.Location = new System.Drawing.Point(127, 103);
            this.delayUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delayUpDown.Name = "delayUpDown";
            this.delayUpDown.Size = new System.Drawing.Size(143, 23);
            this.delayUpDown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(137, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thread delay(ms):";
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delayUpDown);
            this.Controls.Add(this.outputFolderBtn);
            this.Controls.Add(this.zipFileBtn);
            this.Controls.Add(this.wordListBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NucZip » Panel";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delayUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button wordListBtn;
        private System.Windows.Forms.Button zipFileBtn;
        private System.Windows.Forms.OpenFileDialog chooseZipDialog;
        private System.Windows.Forms.OpenFileDialog chooseWordlistDialog;
        private System.Windows.Forms.Button outputFolderBtn;
        private System.Windows.Forms.FolderBrowserDialog outputFolderDialog;
        public System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.NumericUpDown delayUpDown;
        private System.Windows.Forms.Label label1;
    }
}

