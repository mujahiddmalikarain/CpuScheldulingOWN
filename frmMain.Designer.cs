namespace CpuScheduling
{
    partial class frmMain
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
            this.exeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.ioTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.quantumBox = new System.Windows.Forms.NumericUpDown();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.avgWtLabel = new System.Windows.Forms.Label();
            this.avgTatLabel = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bustTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.io = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantumBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exeBtn
            // 
            this.exeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.exeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exeBtn.Location = new System.Drawing.Point(620, 290);
            this.exeBtn.Name = "exeBtn";
            this.exeBtn.Size = new System.Drawing.Size(137, 30);
            this.exeBtn.TabIndex = 8;
            this.exeBtn.Text = "Start Execution";
            this.exeBtn.UseVisualStyleBackColor = false;
            this.exeBtn.Click += new System.EventHandler(this.exeBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveBtn.Location = new System.Drawing.Point(95, 256);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 30);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // ioTextBox
            // 
            this.ioTextBox.Location = new System.Drawing.Point(95, 198);
            this.ioTextBox.Name = "ioTextBox";
            this.ioTextBox.Size = new System.Drawing.Size(158, 25);
            this.ioTextBox.TabIndex = 4;
            this.ioTextBox.Text = "2";
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(95, 165);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(158, 25);
            this.timeTextBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(95, 132);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(158, 25);
            this.idTextBox.TabIndex = 2;
            this.idTextBox.Text = "1";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(95, 99);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(158, 25);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(24, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "I/O:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(24, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bust Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(24, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Process";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ioTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.timeTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 326);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.exeBtn);
            this.panel2.Controls.Add(this.quantumBox);
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.avgTatLabel);
            this.panel2.Controls.Add(this.avgWtLabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(310, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 326);
            this.panel2.TabIndex = 18;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.bustTime,
            this.io,
            this.ct,
            this.wt,
            this.tt,
            this.status});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 4;
            this.dataGridView.Size = new System.Drawing.Size(767, 284);
            this.dataGridView.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(478, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quantum:";
            // 
            // quantumBox
            // 
            this.quantumBox.Location = new System.Drawing.Point(548, 293);
            this.quantumBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantumBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantumBox.Name = "quantumBox";
            this.quantumBox.Size = new System.Drawing.Size(61, 25);
            this.quantumBox.TabIndex = 7;
            this.quantumBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(67)))), ((int)(((byte)(53)))));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetBtn.Location = new System.Drawing.Point(178, 256);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 30);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(12, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Average Waiting Time : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(218, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Average Turn Around Time : ";
            // 
            // avgWtLabel
            // 
            this.avgWtLabel.AutoSize = true;
            this.avgWtLabel.BackColor = System.Drawing.Color.Transparent;
            this.avgWtLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.avgWtLabel.Location = new System.Drawing.Point(159, 297);
            this.avgWtLabel.Name = "avgWtLabel";
            this.avgWtLabel.Size = new System.Drawing.Size(22, 17);
            this.avgWtLabel.TabIndex = 9;
            this.avgWtLabel.Text = "00";
            // 
            // avgTatLabel
            // 
            this.avgTatLabel.AutoSize = true;
            this.avgTatLabel.BackColor = System.Drawing.Color.Transparent;
            this.avgTatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.avgTatLabel.Location = new System.Drawing.Point(395, 297);
            this.avgTatLabel.Name = "avgTatLabel";
            this.avgTatLabel.Size = new System.Drawing.Size(22, 17);
            this.avgTatLabel.TabIndex = 9;
            this.avgTatLabel.Text = "00";
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // bustTime
            // 
            this.bustTime.HeaderText = "Bust Time";
            this.bustTime.Name = "bustTime";
            this.bustTime.ReadOnly = true;
            // 
            // io
            // 
            this.io.HeaderText = "I/O";
            this.io.Name = "io";
            this.io.ReadOnly = true;
            // 
            // ct
            // 
            this.ct.HeaderText = "Completion Time";
            this.ct.Name = "ct";
            this.ct.ReadOnly = true;
            // 
            // wt
            // 
            this.wt.HeaderText = "Waiting Time";
            this.wt.Name = "wt";
            this.wt.ReadOnly = true;
            // 
            // tt
            // 
            this.tt.HeaderText = "Turnaround Time";
            this.tt.Name = "tt";
            this.tt.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CpuScheduling.Properties.Resources.light_gray_background;
            this.ClientSize = new System.Drawing.Size(1089, 350);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU Scheduling";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantumBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exeBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox ioTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.NumericUpDown quantumBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label avgTatLabel;
        private System.Windows.Forms.Label avgWtLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bustTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn io;
        private System.Windows.Forms.DataGridViewTextBoxColumn ct;
        private System.Windows.Forms.DataGridViewTextBoxColumn wt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}

