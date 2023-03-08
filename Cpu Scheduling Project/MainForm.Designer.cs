namespace Cpu_Scheduling_Project
{
    partial class MainForm
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
            this.nump = new System.Windows.Forms.Label();
            this.textp = new System.Windows.Forms.TextBox();
            this.buttonstart = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonfcfs = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textw = new System.Windows.Forms.TextBox();
            this.textb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mysign = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nump
            // 
            this.nump.AutoSize = true;
            this.nump.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nump.Location = new System.Drawing.Point(12, 18);
            this.nump.Name = "nump";
            this.nump.Size = new System.Drawing.Size(207, 20);
            this.nump.TabIndex = 0;
            this.nump.Text = "Enter Number Of Processes";
            // 
            // textp
            // 
            this.textp.Location = new System.Drawing.Point(27, 57);
            this.textp.Name = "textp";
            this.textp.Size = new System.Drawing.Size(108, 20);
            this.textp.TabIndex = 1;
            // 
            // buttonstart
            // 
            this.buttonstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonstart.Location = new System.Drawing.Point(223, 45);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(75, 40);
            this.buttonstart.TabIndex = 2;
            this.buttonstart.Text = "Start";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(54, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(395, 157);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(271, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Avg Waiting Time";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonfcfs
            // 
            this.buttonfcfs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfcfs.Location = new System.Drawing.Point(27, 289);
            this.buttonfcfs.Name = "buttonfcfs";
            this.buttonfcfs.Size = new System.Drawing.Size(75, 30);
            this.buttonfcfs.TabIndex = 5;
            this.buttonfcfs.Text = "FCFS";
            this.buttonfcfs.UseVisualStyleBackColor = true;
            this.buttonfcfs.Click += new System.EventHandler(this.buttonfcfs_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonReset.Location = new System.Drawing.Point(150, 289);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 30);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textw
            // 
            this.textw.Location = new System.Drawing.Point(395, 323);
            this.textw.Name = "textw";
            this.textw.Size = new System.Drawing.Size(100, 20);
            this.textw.TabIndex = 7;
            this.textw.TextChanged += new System.EventHandler(this.textw_TextChanged);
            // 
            // textb
            // 
            this.textb.Location = new System.Drawing.Point(395, 289);
            this.textb.Name = "textb";
            this.textb.Size = new System.Drawing.Size(100, 20);
            this.textb.TabIndex = 7;
            this.textb.TextChanged += new System.EventHandler(this.textw_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(285, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Avg Burst Time";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // mysign
            // 
            this.mysign.AutoSize = true;
            this.mysign.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.mysign.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mysign.Location = new System.Drawing.Point(164, 373);
            this.mysign.Name = "mysign";
            this.mysign.Size = new System.Drawing.Size(246, 19);
            this.mysign.TabIndex = 9;
            this.mysign.Text = "Name: Ali Sayed Abd alrhman Eissa";
            this.mysign.Click += new System.EventHandler(this.mysign_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(208, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Code: C1900263";
            this.label3.Click += new System.EventHandler(this.mysign_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mysign);
            this.Controls.Add(this.textb);
            this.Controls.Add(this.textw);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonfcfs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.textp);
            this.Controls.Add(this.nump);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Cpu Scheduling";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nump;
        private System.Windows.Forms.TextBox textp;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonfcfs;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textw;
        private System.Windows.Forms.TextBox textb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mysign;
        private System.Windows.Forms.Label label3;
    }
}

