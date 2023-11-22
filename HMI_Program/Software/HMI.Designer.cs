namespace Software
{
    partial class HMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HMI));
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.CheckBox();
            this.MachineStatus = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_AxisZ_Status = new System.Windows.Forms.Label();
            this.lb_AxisY_Status = new System.Windows.Forms.Label();
            this.lb_AxisX_Status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_CycleState = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_PartSelected = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lb_CycleStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.img_WorkSpace = new System.Windows.Forms.PictureBox();
            this.lb_MouseX = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_MouseY = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_WorkSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.LightGray;
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.btn_Home.FlatAppearance.BorderSize = 2;
            this.btn_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Home.Location = new System.Drawing.Point(155, 560);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(134, 49);
            this.btn_Home.TabIndex = 569;
            this.btn_Home.Text = "Home";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Appearance = System.Windows.Forms.Appearance.Button;
            this.btn_Reset.BackColor = System.Drawing.Color.LightGray;
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Reset.FlatAppearance.BorderSize = 2;
            this.btn_Reset.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reset.Image")));
            this.btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reset.Location = new System.Drawing.Point(12, 560);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(136, 49);
            this.btn_Reset.TabIndex = 568;
            this.btn_Reset.Text = "Reset      ";
            this.btn_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.CheckedChanged += new System.EventHandler(this.btn_Reset_CheckedChanged);
            // 
            // MachineStatus
            // 
            this.MachineStatus.Interval = 50;
            this.MachineStatus.Tick += new System.EventHandler(this.MachineStatus_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_AxisZ_Status);
            this.groupBox1.Controls.Add(this.lb_AxisY_Status);
            this.groupBox1.Controls.Add(this.lb_AxisX_Status);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 145);
            this.groupBox1.TabIndex = 573;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gantry Status";
            // 
            // lb_AxisZ_Status
            // 
            this.lb_AxisZ_Status.AutoSize = true;
            this.lb_AxisZ_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_AxisZ_Status.Location = new System.Drawing.Point(140, 103);
            this.lb_AxisZ_Status.Name = "lb_AxisZ_Status";
            this.lb_AxisZ_Status.Size = new System.Drawing.Size(63, 17);
            this.lb_AxisZ_Status.TabIndex = 5;
            this.lb_AxisZ_Status.Text = "-----------";
            // 
            // lb_AxisY_Status
            // 
            this.lb_AxisY_Status.AutoSize = true;
            this.lb_AxisY_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_AxisY_Status.Location = new System.Drawing.Point(140, 72);
            this.lb_AxisY_Status.Name = "lb_AxisY_Status";
            this.lb_AxisY_Status.Size = new System.Drawing.Size(63, 17);
            this.lb_AxisY_Status.TabIndex = 4;
            this.lb_AxisY_Status.Text = "-----------";
            // 
            // lb_AxisX_Status
            // 
            this.lb_AxisX_Status.AutoSize = true;
            this.lb_AxisX_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_AxisX_Status.Location = new System.Drawing.Point(140, 43);
            this.lb_AxisX_Status.Name = "lb_AxisX_Status";
            this.lb_AxisX_Status.Size = new System.Drawing.Size(63, 17);
            this.lb_AxisX_Status.TabIndex = 3;
            this.lb_AxisX_Status.Text = "-----------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Axis Z (Tooling)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Axis Y (Controller)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Axis X (Controller)";
            // 
            // lb_CycleState
            // 
            this.lb_CycleState.AutoSize = true;
            this.lb_CycleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_CycleState.Location = new System.Drawing.Point(645, 84);
            this.lb_CycleState.Name = "lb_CycleState";
            this.lb_CycleState.Size = new System.Drawing.Size(63, 17);
            this.lb_CycleState.TabIndex = 576;
            this.lb_CycleState.Text = "-----------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(553, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 575;
            this.label8.Text = "Cycle State";
            // 
            // lb_PartSelected
            // 
            this.lb_PartSelected.AutoSize = true;
            this.lb_PartSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_PartSelected.Location = new System.Drawing.Point(645, 59);
            this.lb_PartSelected.Name = "lb_PartSelected";
            this.lb_PartSelected.Size = new System.Drawing.Size(63, 17);
            this.lb_PartSelected.TabIndex = 578;
            this.lb_PartSelected.Text = "-----------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 577;
            this.label5.Text = "Part Selected";
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.LightGray;
            this.btn_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stop.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Stop.FlatAppearance.BorderSize = 2;
            this.btn_Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_Stop.Image")));
            this.btn_Stop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Stop.Location = new System.Drawing.Point(370, 560);
            this.btn_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(176, 49);
            this.btn_Stop.TabIndex = 581;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.LightGray;
            this.btn_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Start.FlatAppearance.BorderSize = 2;
            this.btn_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Image = ((System.Drawing.Image)(resources.GetObject("btn_Start.Image")));
            this.btn_Start.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Start.Location = new System.Drawing.Point(554, 560);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(154, 49);
            this.btn_Start.TabIndex = 582;
            this.btn_Start.Text = "Start";
            this.btn_Start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lb_CycleStatus
            // 
            this.lb_CycleStatus.AutoSize = true;
            this.lb_CycleStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_CycleStatus.Location = new System.Drawing.Point(645, 115);
            this.lb_CycleStatus.Name = "lb_CycleStatus";
            this.lb_CycleStatus.Size = new System.Drawing.Size(63, 17);
            this.lb_CycleStatus.TabIndex = 584;
            this.lb_CycleStatus.Text = "-----------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 583;
            this.label7.Text = "Cycle Status";
            // 
            // img_WorkSpace
            // 
            this.img_WorkSpace.BackColor = System.Drawing.Color.White;
            this.img_WorkSpace.Image = ((System.Drawing.Image)(resources.GetObject("img_WorkSpace.Image")));
            this.img_WorkSpace.Location = new System.Drawing.Point(91, 163);
            this.img_WorkSpace.Name = "img_WorkSpace";
            this.img_WorkSpace.Size = new System.Drawing.Size(591, 390);
            this.img_WorkSpace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_WorkSpace.TabIndex = 0;
            this.img_WorkSpace.TabStop = false;
            this.img_WorkSpace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.img_WorkSpace_MouseClick);
            // 
            // lb_MouseX
            // 
            this.lb_MouseX.AutoSize = true;
            this.lb_MouseX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_MouseX.Location = new System.Drawing.Point(41, 163);
            this.lb_MouseX.Name = "lb_MouseX";
            this.lb_MouseX.Size = new System.Drawing.Size(32, 17);
            this.lb_MouseX.TabIndex = 6;
            this.lb_MouseX.Text = "000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 585;
            this.label9.Text = "Y";
            // 
            // lb_MouseY
            // 
            this.lb_MouseY.AutoSize = true;
            this.lb_MouseY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_MouseY.Location = new System.Drawing.Point(41, 181);
            this.lb_MouseY.Name = "lb_MouseY";
            this.lb_MouseY.Size = new System.Drawing.Size(32, 17);
            this.lb_MouseY.TabIndex = 586;
            this.lb_MouseY.Text = "000";
            // 
            // HMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 616);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_MouseY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_MouseX);
            this.Controls.Add(this.img_WorkSpace);
            this.Controls.Add(this.lb_CycleStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.lb_PartSelected);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_CycleState);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_Reset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tesla | Pen Gantry";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HMI_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_WorkSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.CheckBox btn_Reset;
        private System.Windows.Forms.Timer MachineStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_AxisZ_Status;
        private System.Windows.Forms.Label lb_AxisY_Status;
        private System.Windows.Forms.Label lb_AxisX_Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_CycleState;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_PartSelected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lb_CycleStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox img_WorkSpace;
        private System.Windows.Forms.Label lb_MouseX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_MouseY;
    }
}

