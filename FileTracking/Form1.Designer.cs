
namespace FileTracking
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnStart;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtFolderpath = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            fileMon = new System.IO.FileSystemWatcher();
            this.btnStop = new System.Windows.Forms.Button();
            this.chcRecursive = new System.Windows.Forms.CheckBox();
            this.folderB = new System.Windows.Forms.FolderBrowserDialog();
            this.numFreq = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(fileMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnStart.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            btnStart.Location = new System.Drawing.Point(305, 311);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(35, 25);
            btnStart.TabIndex = 4;
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContent.ForeColor = System.Drawing.Color.Green;
            this.txtContent.Location = new System.Drawing.Point(1, 2);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(653, 80);
            this.txtContent.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelect.Location = new System.Drawing.Point(621, 258);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(33, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtFolderpath
            // 
            this.txtFolderpath.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtFolderpath.ForeColor = System.Drawing.Color.Green;
            this.txtFolderpath.Location = new System.Drawing.Point(145, 258);
            this.txtFolderpath.Multiline = true;
            this.txtFolderpath.Name = "txtFolderpath";
            this.txtFolderpath.Size = new System.Drawing.Size(470, 23);
            this.txtFolderpath.TabIndex = 2;
            this.txtFolderpath.TextChanged += new System.EventHandler(this.txtFolderpath_TextChanged);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolder.ForeColor = System.Drawing.Color.Green;
            this.lblFolder.Location = new System.Drawing.Point(5, 259);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(134, 15);
            this.lblFolder.TabIndex = 3;
            this.lblFolder.Text = "Folder Path to Monitor :";
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.ForeColor = System.Drawing.Color.Green;
            this.btnClear.Location = new System.Drawing.Point(387, 311);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(35, 25);
            this.btnClear.TabIndex = 5;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // fileMon
            // 
           fileMon.SynchronizingObject = this;
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Green;
            this.btnStop.Location = new System.Drawing.Point(346, 311);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(35, 25);
            this.btnStop.TabIndex = 6;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // chcRecursive
            // 
            this.chcRecursive.AutoSize = true;
            this.chcRecursive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chcRecursive.ForeColor = System.Drawing.Color.Green;
            this.chcRecursive.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chcRecursive.Location = new System.Drawing.Point(5, 311);
            this.chcRecursive.Name = "chcRecursive";
            this.chcRecursive.Size = new System.Drawing.Size(74, 17);
            this.chcRecursive.TabIndex = 7;
            this.chcRecursive.Text = "Recursive";
            this.chcRecursive.UseVisualStyleBackColor = true;
            this.chcRecursive.CheckedChanged += new System.EventHandler(this.chcRecursive_CheckedChanged);
            // 
            // numFreq
            // 
            this.numFreq.BackColor = System.Drawing.SystemColors.MenuText;
            this.numFreq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numFreq.ForeColor = System.Drawing.Color.Green;
            this.numFreq.Location = new System.Drawing.Point(80, 291);
            this.numFreq.Name = "numFreq";
            this.numFreq.Size = new System.Drawing.Size(49, 16);
            this.numFreq.TabIndex = 8;
            this.numFreq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(5, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Frequency :";
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(1, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 157);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(658, 385);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numFreq);
            this.Controls.Add(this.chcRecursive);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(btnStart);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.txtFolderpath);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtContent);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(fileMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtFolderpath;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox chcRecursive;
        private System.Windows.Forms.FolderBrowserDialog folderB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numFreq;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        public static System.IO.FileSystemWatcher fileMon;
    }
}

