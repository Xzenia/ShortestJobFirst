namespace ShortestJobFirst
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.arrivalTimeTextBox = new System.Windows.Forms.TextBox();
            this.burstTimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addProcessBtn = new System.Windows.Forms.Button();
            this.sjf = new System.Windows.Forms.DataGridView();
            this.generateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.simulateBtn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.ganttChart = new System.Windows.Forms.GroupBox();
            this.avgWaitingTimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.avgTurnaroundTimeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.avgResponseTimeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cpuUtilizationTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.throughputNumeratorTextBox = new System.Windows.Forms.TextBox();
            this.Throughput = new System.Windows.Forms.Label();
            this.throughputDenominatorTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sjf)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(8, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arrival Time:";
            // 
            // arrivalTimeTextBox
            // 
            this.arrivalTimeTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.arrivalTimeTextBox.ForeColor = System.Drawing.Color.Lime;
            this.arrivalTimeTextBox.Location = new System.Drawing.Point(88, 61);
            this.arrivalTimeTextBox.Name = "arrivalTimeTextBox";
            this.arrivalTimeTextBox.Size = new System.Drawing.Size(200, 20);
            this.arrivalTimeTextBox.TabIndex = 2;
            // 
            // burstTimeTextBox
            // 
            this.burstTimeTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.burstTimeTextBox.ForeColor = System.Drawing.Color.Lime;
            this.burstTimeTextBox.Location = new System.Drawing.Point(88, 118);
            this.burstTimeTextBox.Name = "burstTimeTextBox";
            this.burstTimeTextBox.Size = new System.Drawing.Size(200, 20);
            this.burstTimeTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(8, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Burst Time: ";
            // 
            // addProcessBtn
            // 
            this.addProcessBtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.addProcessBtn.ForeColor = System.Drawing.Color.Lime;
            this.addProcessBtn.Location = new System.Drawing.Point(189, 157);
            this.addProcessBtn.Name = "addProcessBtn";
            this.addProcessBtn.Size = new System.Drawing.Size(99, 26);
            this.addProcessBtn.TabIndex = 6;
            this.addProcessBtn.Text = "Add Process";
            this.addProcessBtn.UseVisualStyleBackColor = false;
            this.addProcessBtn.Click += new System.EventHandler(this.addProcessBtn_Click);
            // 
            // sjf
            // 
            this.sjf.AllowUserToAddRows = false;
            this.sjf.AllowUserToDeleteRows = false;
            this.sjf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.sjf.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sjf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sjf.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.sjf.Location = new System.Drawing.Point(304, 50);
            this.sjf.Name = "sjf";
            this.sjf.ReadOnly = true;
            this.sjf.Size = new System.Drawing.Size(595, 246);
            this.sjf.TabIndex = 7;
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.generateBtn.ForeColor = System.Drawing.Color.Lime;
            this.generateBtn.Location = new System.Drawing.Point(12, 263);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(119, 33);
            this.generateBtn.TabIndex = 8;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.clearBtn.ForeColor = System.Drawing.Color.Lime;
            this.clearBtn.Location = new System.Drawing.Point(169, 263);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(119, 33);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // simulateBtn
            // 
            this.simulateBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.simulateBtn.ForeColor = System.Drawing.Color.Lime;
            this.simulateBtn.Location = new System.Drawing.Point(11, 202);
            this.simulateBtn.Name = "simulateBtn";
            this.simulateBtn.Size = new System.Drawing.Size(277, 45);
            this.simulateBtn.TabIndex = 10;
            this.simulateBtn.Text = "Simulate";
            this.simulateBtn.UseVisualStyleBackColor = false;
            this.simulateBtn.Click += new System.EventHandler(this.simulateBtn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(10, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Gantt Chart";
            // 
            // ganttChart
            // 
            this.ganttChart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ganttChart.Location = new System.Drawing.Point(12, 455);
            this.ganttChart.Name = "ganttChart";
            this.ganttChart.Size = new System.Drawing.Size(888, 122);
            this.ganttChart.TabIndex = 13;
            this.ganttChart.TabStop = false;
            this.ganttChart.Text = "Gantt Chart";
            // 
            // avgWaitingTimeTextBox
            // 
            this.avgWaitingTimeTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.avgWaitingTimeTextBox.ForeColor = System.Drawing.Color.Lime;
            this.avgWaitingTimeTextBox.Location = new System.Drawing.Point(416, 312);
            this.avgWaitingTimeTextBox.Name = "avgWaitingTimeTextBox";
            this.avgWaitingTimeTextBox.ReadOnly = true;
            this.avgWaitingTimeTextBox.Size = new System.Drawing.Size(112, 20);
            this.avgWaitingTimeTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(301, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Avg. Waiting Time:";
            // 
            // avgTurnaroundTimeTextBox
            // 
            this.avgTurnaroundTimeTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.avgTurnaroundTimeTextBox.ForeColor = System.Drawing.Color.Lime;
            this.avgTurnaroundTimeTextBox.Location = new System.Drawing.Point(662, 312);
            this.avgTurnaroundTimeTextBox.Name = "avgTurnaroundTimeTextBox";
            this.avgTurnaroundTimeTextBox.ReadOnly = true;
            this.avgTurnaroundTimeTextBox.Size = new System.Drawing.Size(112, 20);
            this.avgTurnaroundTimeTextBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(540, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Avg. Turnaround Time:";
            // 
            // avgResponseTimeTextBox
            // 
            this.avgResponseTimeTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.avgResponseTimeTextBox.ForeColor = System.Drawing.Color.Lime;
            this.avgResponseTimeTextBox.Location = new System.Drawing.Point(416, 350);
            this.avgResponseTimeTextBox.Name = "avgResponseTimeTextBox";
            this.avgResponseTimeTextBox.ReadOnly = true;
            this.avgResponseTimeTextBox.Size = new System.Drawing.Size(112, 20);
            this.avgResponseTimeTextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(301, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Avg. Response Time:";
            // 
            // cpuUtilizationTextBox
            // 
            this.cpuUtilizationTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.cpuUtilizationTextBox.ForeColor = System.Drawing.Color.Lime;
            this.cpuUtilizationTextBox.Location = new System.Drawing.Point(662, 402);
            this.cpuUtilizationTextBox.Name = "cpuUtilizationTextBox";
            this.cpuUtilizationTextBox.ReadOnly = true;
            this.cpuUtilizationTextBox.Size = new System.Drawing.Size(112, 20);
            this.cpuUtilizationTextBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(540, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "CPU Utilization:";
            // 
            // throughputNumeratorTextBox
            // 
            this.throughputNumeratorTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.throughputNumeratorTextBox.ForeColor = System.Drawing.Color.Lime;
            this.throughputNumeratorTextBox.Location = new System.Drawing.Point(372, 391);
            this.throughputNumeratorTextBox.Name = "throughputNumeratorTextBox";
            this.throughputNumeratorTextBox.ReadOnly = true;
            this.throughputNumeratorTextBox.Size = new System.Drawing.Size(41, 20);
            this.throughputNumeratorTextBox.TabIndex = 23;
            // 
            // Throughput
            // 
            this.Throughput.AutoSize = true;
            this.Throughput.ForeColor = System.Drawing.Color.Lime;
            this.Throughput.Location = new System.Drawing.Point(301, 409);
            this.Throughput.Name = "Throughput";
            this.Throughput.Size = new System.Drawing.Size(65, 13);
            this.Throughput.TabIndex = 22;
            this.Throughput.Text = "Throughput:";
            // 
            // throughputDenominatorTextBox
            // 
            this.throughputDenominatorTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.throughputDenominatorTextBox.ForeColor = System.Drawing.Color.Lime;
            this.throughputDenominatorTextBox.Location = new System.Drawing.Point(372, 417);
            this.throughputDenominatorTextBox.Name = "throughputDenominatorTextBox";
            this.throughputDenominatorTextBox.ReadOnly = true;
            this.throughputDenominatorTextBox.Size = new System.Drawing.Size(41, 20);
            this.throughputDenominatorTextBox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(911, 589);
            this.Controls.Add(this.throughputDenominatorTextBox);
            this.Controls.Add(this.throughputNumeratorTextBox);
            this.Controls.Add(this.Throughput);
            this.Controls.Add(this.cpuUtilizationTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.avgResponseTimeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.avgTurnaroundTimeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.avgWaitingTimeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ganttChart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.simulateBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.sjf);
            this.Controls.Add(this.addProcessBtn);
            this.Controls.Add(this.burstTimeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arrivalTimeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shortest Job First";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sjf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arrivalTimeTextBox;
        private System.Windows.Forms.TextBox burstTimeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addProcessBtn;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView sjf;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button simulateBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox ganttChart;
        private System.Windows.Forms.TextBox avgWaitingTimeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox avgTurnaroundTimeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox avgResponseTimeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cpuUtilizationTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox throughputNumeratorTextBox;
        private System.Windows.Forms.Label Throughput;
        private System.Windows.Forms.TextBox throughputDenominatorTextBox;
    }
}

