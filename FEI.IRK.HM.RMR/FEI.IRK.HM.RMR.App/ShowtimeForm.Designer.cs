﻿namespace FEI.IRK.HM.RMR.App
{
    partial class ShowtimeForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupTask1 = new System.Windows.Forms.GroupBox();
            this.Task1ScanListBox = new System.Windows.Forms.ListBox();
            this.lblTask1LastScanMm = new System.Windows.Forms.Label();
            this.lblTask1LastScan = new System.Windows.Forms.Label();
            this.lblTask1LastSensorMm = new System.Windows.Forms.Label();
            this.Task1LastScanTextBox = new System.Windows.Forms.TextBox();
            this.Task1SensorListBox = new System.Windows.Forms.ListBox();
            this.lblTask1LastSensor = new System.Windows.Forms.Label();
            this.Task1LastSensorTextBox = new System.Windows.Forms.TextBox();
            this.lblTask1VelocityMms = new System.Windows.Forms.Label();
            this.lblTask1Velocity = new System.Windows.Forms.Label();
            this.Task1VelocityTextBox = new System.Windows.Forms.TextBox();
            this.lblTask1AngleDegree = new System.Windows.Forms.Label();
            this.lblTask1Angle = new System.Windows.Forms.Label();
            this.Task1AngleTextBox = new System.Windows.Forms.TextBox();
            this.lblTask1PosYMm = new System.Windows.Forms.Label();
            this.lblTask1PosY = new System.Windows.Forms.Label();
            this.Task1PosYTextBox = new System.Windows.Forms.TextBox();
            this.lblTask1PosXMm = new System.Windows.Forms.Label();
            this.lblTask1PosX = new System.Windows.Forms.Label();
            this.Task1PosXTextBox = new System.Windows.Forms.TextBox();
            this.lblTask1TimeSec = new System.Windows.Forms.Label();
            this.lblTask1Time = new System.Windows.Forms.Label();
            this.Task1TimeTextBox = new System.Windows.Forms.TextBox();
            this.lblTask1Frame = new System.Windows.Forms.Label();
            this.Task1FrameTextBox = new System.Windows.Forms.TextBox();
            this.Task1ImageBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TimeTrackBar = new System.Windows.Forms.TrackBar();
            this.btnMediaLast = new System.Windows.Forms.Button();
            this.btnMediaNext = new System.Windows.Forms.Button();
            this.btnMediaStop = new System.Windows.Forms.Button();
            this.btnMediaPlay = new System.Windows.Forms.Button();
            this.btnMediaPrevious = new System.Windows.Forms.Button();
            this.btnMediaFirst = new System.Windows.Forms.Button();
            this.groupTaskSetAll = new System.Windows.Forms.GroupBox();
            this.lblTaskAllMm = new System.Windows.Forms.Label();
            this.RobotDiameterNumericBox = new System.Windows.Forms.NumericUpDown();
            this.lblTaskAllAverage = new System.Windows.Forms.Label();
            this.groupTaskSet3 = new System.Windows.Forms.GroupBox();
            this.ShowMapCheckBox = new System.Windows.Forms.CheckBox();
            this.groupTaskSet4 = new System.Windows.Forms.GroupBox();
            this.lblTask4Mm = new System.Windows.Forms.Label();
            this.MapQuantisationNumBox = new System.Windows.Forms.NumericUpDown();
            this.lblTask4Quant = new System.Windows.Forms.Label();
            this.TimeNumericBox = new System.Windows.Forms.NumericUpDown();
            this.PlayerTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupTask1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Task1ImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrackBar)).BeginInit();
            this.groupTaskSetAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RobotDiameterNumericBox)).BeginInit();
            this.groupTaskSet3.SuspendLayout();
            this.groupTaskSet4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapQuantisationNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1229, 527);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupTask1);
            this.tabPage1.Controls.Add(this.Task1ImageBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1221, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Úloha 1: Lokalizácia a polohovanie robota v prostredí";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupTask1
            // 
            this.groupTask1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTask1.Controls.Add(this.Task1ScanListBox);
            this.groupTask1.Controls.Add(this.lblTask1LastScanMm);
            this.groupTask1.Controls.Add(this.lblTask1LastScan);
            this.groupTask1.Controls.Add(this.lblTask1LastSensorMm);
            this.groupTask1.Controls.Add(this.Task1LastScanTextBox);
            this.groupTask1.Controls.Add(this.Task1SensorListBox);
            this.groupTask1.Controls.Add(this.lblTask1LastSensor);
            this.groupTask1.Controls.Add(this.Task1LastSensorTextBox);
            this.groupTask1.Controls.Add(this.lblTask1VelocityMms);
            this.groupTask1.Controls.Add(this.lblTask1Velocity);
            this.groupTask1.Controls.Add(this.Task1VelocityTextBox);
            this.groupTask1.Controls.Add(this.lblTask1AngleDegree);
            this.groupTask1.Controls.Add(this.lblTask1Angle);
            this.groupTask1.Controls.Add(this.Task1AngleTextBox);
            this.groupTask1.Controls.Add(this.lblTask1PosYMm);
            this.groupTask1.Controls.Add(this.lblTask1PosY);
            this.groupTask1.Controls.Add(this.Task1PosYTextBox);
            this.groupTask1.Controls.Add(this.lblTask1PosXMm);
            this.groupTask1.Controls.Add(this.lblTask1PosX);
            this.groupTask1.Controls.Add(this.Task1PosXTextBox);
            this.groupTask1.Controls.Add(this.lblTask1TimeSec);
            this.groupTask1.Controls.Add(this.lblTask1Time);
            this.groupTask1.Controls.Add(this.Task1TimeTextBox);
            this.groupTask1.Controls.Add(this.lblTask1Frame);
            this.groupTask1.Controls.Add(this.Task1FrameTextBox);
            this.groupTask1.Location = new System.Drawing.Point(839, 6);
            this.groupTask1.Name = "groupTask1";
            this.groupTask1.Size = new System.Drawing.Size(376, 492);
            this.groupTask1.TabIndex = 1;
            this.groupTask1.TabStop = false;
            this.groupTask1.Text = "Úloha 1: Detaily";
            // 
            // Task1ScanListBox
            // 
            this.Task1ScanListBox.FormattingEnabled = true;
            this.Task1ScanListBox.Location = new System.Drawing.Point(58, 379);
            this.Task1ScanListBox.Name = "Task1ScanListBox";
            this.Task1ScanListBox.Size = new System.Drawing.Size(270, 95);
            this.Task1ScanListBox.TabIndex = 24;
            this.Task1ScanListBox.SelectedIndexChanged += new System.EventHandler(this.Task1ScanListBox_SelectedIndexChanged);
            // 
            // lblTask1LastScanMm
            // 
            this.lblTask1LastScanMm.AutoSize = true;
            this.lblTask1LastScanMm.Location = new System.Drawing.Point(286, 356);
            this.lblTask1LastScanMm.Name = "lblTask1LastScanMm";
            this.lblTask1LastScanMm.Size = new System.Drawing.Size(58, 13);
            this.lblTask1LastScanMm.TabIndex = 23;
            this.lblTask1LastScanMm.Text = "sekundami";
            // 
            // lblTask1LastScan
            // 
            this.lblTask1LastScan.AutoSize = true;
            this.lblTask1LastScan.Location = new System.Drawing.Point(19, 356);
            this.lblTask1LastScan.Name = "lblTask1LastScan";
            this.lblTask1LastScan.Size = new System.Drawing.Size(155, 13);
            this.lblTask1LastScan.TabIndex = 22;
            this.lblTask1LastScan.Text = "Posledný údaj zo skenera pred:";
            // 
            // lblTask1LastSensorMm
            // 
            this.lblTask1LastSensorMm.AutoSize = true;
            this.lblTask1LastSensorMm.Location = new System.Drawing.Point(286, 214);
            this.lblTask1LastSensorMm.Name = "lblTask1LastSensorMm";
            this.lblTask1LastSensorMm.Size = new System.Drawing.Size(58, 13);
            this.lblTask1LastSensorMm.TabIndex = 21;
            this.lblTask1LastSensorMm.Text = "sekundami";
            // 
            // Task1LastScanTextBox
            // 
            this.Task1LastScanTextBox.Location = new System.Drawing.Point(180, 353);
            this.Task1LastScanTextBox.Name = "Task1LastScanTextBox";
            this.Task1LastScanTextBox.ReadOnly = true;
            this.Task1LastScanTextBox.Size = new System.Drawing.Size(100, 20);
            this.Task1LastScanTextBox.TabIndex = 20;
            this.Task1LastScanTextBox.Text = "0";
            this.Task1LastScanTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Task1SensorListBox
            // 
            this.Task1SensorListBox.FormattingEnabled = true;
            this.Task1SensorListBox.Location = new System.Drawing.Point(58, 237);
            this.Task1SensorListBox.Name = "Task1SensorListBox";
            this.Task1SensorListBox.Size = new System.Drawing.Size(270, 95);
            this.Task1SensorListBox.TabIndex = 19;
            this.Task1SensorListBox.SelectedIndexChanged += new System.EventHandler(this.Task1SensorListBox_SelectedIndexChanged);
            // 
            // lblTask1LastSensor
            // 
            this.lblTask1LastSensor.AutoSize = true;
            this.lblTask1LastSensor.Location = new System.Drawing.Point(14, 214);
            this.lblTask1LastSensor.Name = "lblTask1LastSensor";
            this.lblTask1LastSensor.Size = new System.Drawing.Size(160, 13);
            this.lblTask1LastSensor.TabIndex = 18;
            this.lblTask1LastSensor.Text = "Posledný údaj zo senzorov pred:";
            // 
            // Task1LastSensorTextBox
            // 
            this.Task1LastSensorTextBox.Location = new System.Drawing.Point(180, 211);
            this.Task1LastSensorTextBox.Name = "Task1LastSensorTextBox";
            this.Task1LastSensorTextBox.ReadOnly = true;
            this.Task1LastSensorTextBox.Size = new System.Drawing.Size(100, 20);
            this.Task1LastSensorTextBox.TabIndex = 17;
            this.Task1LastSensorTextBox.Text = "0";
            this.Task1LastSensorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTask1VelocityMms
            // 
            this.lblTask1VelocityMms.AutoSize = true;
            this.lblTask1VelocityMms.Location = new System.Drawing.Point(286, 172);
            this.lblTask1VelocityMms.Name = "lblTask1VelocityMms";
            this.lblTask1VelocityMms.Size = new System.Drawing.Size(51, 13);
            this.lblTask1VelocityMms.TabIndex = 16;
            this.lblTask1VelocityMms.Text = "mm / sec";
            // 
            // lblTask1Velocity
            // 
            this.lblTask1Velocity.AutoSize = true;
            this.lblTask1Velocity.Location = new System.Drawing.Point(122, 172);
            this.lblTask1Velocity.Name = "lblTask1Velocity";
            this.lblTask1Velocity.Size = new System.Drawing.Size(52, 13);
            this.lblTask1Velocity.TabIndex = 15;
            this.lblTask1Velocity.Text = "Rýchlosť:";
            // 
            // Task1VelocityTextBox
            // 
            this.Task1VelocityTextBox.Location = new System.Drawing.Point(180, 169);
            this.Task1VelocityTextBox.Name = "Task1VelocityTextBox";
            this.Task1VelocityTextBox.ReadOnly = true;
            this.Task1VelocityTextBox.Size = new System.Drawing.Size(100, 20);
            this.Task1VelocityTextBox.TabIndex = 14;
            this.Task1VelocityTextBox.Text = "0";
            this.Task1VelocityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTask1AngleDegree
            // 
            this.lblTask1AngleDegree.AutoSize = true;
            this.lblTask1AngleDegree.Location = new System.Drawing.Point(286, 145);
            this.lblTask1AngleDegree.Name = "lblTask1AngleDegree";
            this.lblTask1AngleDegree.Size = new System.Drawing.Size(11, 13);
            this.lblTask1AngleDegree.TabIndex = 13;
            this.lblTask1AngleDegree.Text = "°";
            // 
            // lblTask1Angle
            // 
            this.lblTask1Angle.AutoSize = true;
            this.lblTask1Angle.Location = new System.Drawing.Point(142, 145);
            this.lblTask1Angle.Name = "lblTask1Angle";
            this.lblTask1Angle.Size = new System.Drawing.Size(32, 13);
            this.lblTask1Angle.TabIndex = 12;
            this.lblTask1Angle.Text = "Uhol:";
            // 
            // Task1AngleTextBox
            // 
            this.Task1AngleTextBox.Location = new System.Drawing.Point(180, 142);
            this.Task1AngleTextBox.Name = "Task1AngleTextBox";
            this.Task1AngleTextBox.ReadOnly = true;
            this.Task1AngleTextBox.Size = new System.Drawing.Size(100, 20);
            this.Task1AngleTextBox.TabIndex = 11;
            this.Task1AngleTextBox.Text = "0";
            this.Task1AngleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTask1PosYMm
            // 
            this.lblTask1PosYMm.AutoSize = true;
            this.lblTask1PosYMm.Location = new System.Drawing.Point(286, 118);
            this.lblTask1PosYMm.Name = "lblTask1PosYMm";
            this.lblTask1PosYMm.Size = new System.Drawing.Size(23, 13);
            this.lblTask1PosYMm.TabIndex = 10;
            this.lblTask1PosYMm.Text = "mm";
            // 
            // lblTask1PosY
            // 
            this.lblTask1PosY.AutoSize = true;
            this.lblTask1PosY.Location = new System.Drawing.Point(118, 118);
            this.lblTask1PosY.Name = "lblTask1PosY";
            this.lblTask1PosY.Size = new System.Drawing.Size(56, 13);
            this.lblTask1PosY.TabIndex = 9;
            this.lblTask1PosY.Text = "Pozícia Y:";
            // 
            // Task1PosYTextBox
            // 
            this.Task1PosYTextBox.Location = new System.Drawing.Point(180, 115);
            this.Task1PosYTextBox.Name = "Task1PosYTextBox";
            this.Task1PosYTextBox.ReadOnly = true;
            this.Task1PosYTextBox.Size = new System.Drawing.Size(100, 20);
            this.Task1PosYTextBox.TabIndex = 8;
            this.Task1PosYTextBox.Text = "0";
            this.Task1PosYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTask1PosXMm
            // 
            this.lblTask1PosXMm.AutoSize = true;
            this.lblTask1PosXMm.Location = new System.Drawing.Point(286, 91);
            this.lblTask1PosXMm.Name = "lblTask1PosXMm";
            this.lblTask1PosXMm.Size = new System.Drawing.Size(23, 13);
            this.lblTask1PosXMm.TabIndex = 7;
            this.lblTask1PosXMm.Text = "mm";
            // 
            // lblTask1PosX
            // 
            this.lblTask1PosX.AutoSize = true;
            this.lblTask1PosX.Location = new System.Drawing.Point(118, 91);
            this.lblTask1PosX.Name = "lblTask1PosX";
            this.lblTask1PosX.Size = new System.Drawing.Size(56, 13);
            this.lblTask1PosX.TabIndex = 6;
            this.lblTask1PosX.Text = "Pozícia X:";
            // 
            // Task1PosXTextBox
            // 
            this.Task1PosXTextBox.Location = new System.Drawing.Point(180, 88);
            this.Task1PosXTextBox.Name = "Task1PosXTextBox";
            this.Task1PosXTextBox.ReadOnly = true;
            this.Task1PosXTextBox.Size = new System.Drawing.Size(100, 20);
            this.Task1PosXTextBox.TabIndex = 5;
            this.Task1PosXTextBox.Text = "0";
            this.Task1PosXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTask1TimeSec
            // 
            this.lblTask1TimeSec.AutoSize = true;
            this.lblTask1TimeSec.Location = new System.Drawing.Point(286, 49);
            this.lblTask1TimeSec.Name = "lblTask1TimeSec";
            this.lblTask1TimeSec.Size = new System.Drawing.Size(42, 13);
            this.lblTask1TimeSec.TabIndex = 4;
            this.lblTask1TimeSec.Text = "sekúnd";
            // 
            // lblTask1Time
            // 
            this.lblTask1Time.AutoSize = true;
            this.lblTask1Time.Location = new System.Drawing.Point(146, 49);
            this.lblTask1Time.Name = "lblTask1Time";
            this.lblTask1Time.Size = new System.Drawing.Size(28, 13);
            this.lblTask1Time.TabIndex = 3;
            this.lblTask1Time.Text = "Čas:";
            // 
            // Task1TimeTextBox
            // 
            this.Task1TimeTextBox.Location = new System.Drawing.Point(180, 46);
            this.Task1TimeTextBox.Name = "Task1TimeTextBox";
            this.Task1TimeTextBox.ReadOnly = true;
            this.Task1TimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.Task1TimeTextBox.TabIndex = 2;
            this.Task1TimeTextBox.Text = "0";
            this.Task1TimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTask1Frame
            // 
            this.lblTask1Frame.AutoSize = true;
            this.lblTask1Frame.Location = new System.Drawing.Point(127, 22);
            this.lblTask1Frame.Name = "lblTask1Frame";
            this.lblTask1Frame.Size = new System.Drawing.Size(47, 13);
            this.lblTask1Frame.TabIndex = 1;
            this.lblTask1Frame.Text = "Snímok:";
            // 
            // Task1FrameTextBox
            // 
            this.Task1FrameTextBox.Location = new System.Drawing.Point(180, 19);
            this.Task1FrameTextBox.Name = "Task1FrameTextBox";
            this.Task1FrameTextBox.ReadOnly = true;
            this.Task1FrameTextBox.Size = new System.Drawing.Size(100, 20);
            this.Task1FrameTextBox.TabIndex = 0;
            this.Task1FrameTextBox.Text = "0";
            this.Task1FrameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Task1ImageBox
            // 
            this.Task1ImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Task1ImageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Task1ImageBox.Location = new System.Drawing.Point(6, 6);
            this.Task1ImageBox.Name = "Task1ImageBox";
            this.Task1ImageBox.Size = new System.Drawing.Size(827, 492);
            this.Task1ImageBox.TabIndex = 0;
            this.Task1ImageBox.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1221, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Úloha 2: Navigácia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1221, 501);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Úloha 3: Mapovanie";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1221, 501);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Úloha 4: Plánovanie trajektórie";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // TimeTrackBar
            // 
            this.TimeTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeTrackBar.LargeChange = 100;
            this.TimeTrackBar.Location = new System.Drawing.Point(12, 546);
            this.TimeTrackBar.Maximum = 11000;
            this.TimeTrackBar.Name = "TimeTrackBar";
            this.TimeTrackBar.Size = new System.Drawing.Size(1100, 45);
            this.TimeTrackBar.TabIndex = 1;
            this.TimeTrackBar.Scroll += new System.EventHandler(this.TimeTrackBar_Scroll);
            this.TimeTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeTrackBar_MouseDown);
            this.TimeTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TimeTrackBar_MouseUp);
            // 
            // btnMediaLast
            // 
            this.btnMediaLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMediaLast.Image = global::FEI.IRK.HM.RMR.App.Resources.ico_last;
            this.btnMediaLast.Location = new System.Drawing.Point(1172, 599);
            this.btnMediaLast.Name = "btnMediaLast";
            this.btnMediaLast.Size = new System.Drawing.Size(70, 60);
            this.btnMediaLast.TabIndex = 3;
            this.btnMediaLast.UseVisualStyleBackColor = true;
            this.btnMediaLast.Click += new System.EventHandler(this.btnMediaLast_Click);
            // 
            // btnMediaNext
            // 
            this.btnMediaNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMediaNext.Image = global::FEI.IRK.HM.RMR.App.Resources.ico_next;
            this.btnMediaNext.Location = new System.Drawing.Point(1096, 599);
            this.btnMediaNext.Name = "btnMediaNext";
            this.btnMediaNext.Size = new System.Drawing.Size(70, 60);
            this.btnMediaNext.TabIndex = 4;
            this.btnMediaNext.UseVisualStyleBackColor = true;
            this.btnMediaNext.Click += new System.EventHandler(this.btnMediaNext_Click);
            // 
            // btnMediaStop
            // 
            this.btnMediaStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMediaStop.Enabled = false;
            this.btnMediaStop.Image = global::FEI.IRK.HM.RMR.App.Resources.ico_stop;
            this.btnMediaStop.Location = new System.Drawing.Point(1020, 599);
            this.btnMediaStop.Name = "btnMediaStop";
            this.btnMediaStop.Size = new System.Drawing.Size(70, 60);
            this.btnMediaStop.TabIndex = 5;
            this.btnMediaStop.UseVisualStyleBackColor = true;
            this.btnMediaStop.Click += new System.EventHandler(this.btnMediaStop_Click);
            // 
            // btnMediaPlay
            // 
            this.btnMediaPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMediaPlay.Image = global::FEI.IRK.HM.RMR.App.Resources.ico_play;
            this.btnMediaPlay.Location = new System.Drawing.Point(874, 599);
            this.btnMediaPlay.Name = "btnMediaPlay";
            this.btnMediaPlay.Size = new System.Drawing.Size(140, 60);
            this.btnMediaPlay.TabIndex = 6;
            this.btnMediaPlay.UseVisualStyleBackColor = true;
            this.btnMediaPlay.Click += new System.EventHandler(this.btnMediaPlay_Click);
            // 
            // btnMediaPrevious
            // 
            this.btnMediaPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMediaPrevious.Image = global::FEI.IRK.HM.RMR.App.Resources.ico_prev;
            this.btnMediaPrevious.Location = new System.Drawing.Point(798, 599);
            this.btnMediaPrevious.Name = "btnMediaPrevious";
            this.btnMediaPrevious.Size = new System.Drawing.Size(70, 60);
            this.btnMediaPrevious.TabIndex = 7;
            this.btnMediaPrevious.UseVisualStyleBackColor = true;
            this.btnMediaPrevious.Click += new System.EventHandler(this.btnMediaPrevious_Click);
            // 
            // btnMediaFirst
            // 
            this.btnMediaFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMediaFirst.Image = global::FEI.IRK.HM.RMR.App.Resources.ico_first;
            this.btnMediaFirst.Location = new System.Drawing.Point(722, 599);
            this.btnMediaFirst.Name = "btnMediaFirst";
            this.btnMediaFirst.Size = new System.Drawing.Size(70, 60);
            this.btnMediaFirst.TabIndex = 8;
            this.btnMediaFirst.UseVisualStyleBackColor = true;
            this.btnMediaFirst.Click += new System.EventHandler(this.btnMediaFirst_Click);
            // 
            // groupTaskSetAll
            // 
            this.groupTaskSetAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupTaskSetAll.Controls.Add(this.lblTaskAllMm);
            this.groupTaskSetAll.Controls.Add(this.RobotDiameterNumericBox);
            this.groupTaskSetAll.Controls.Add(this.lblTaskAllAverage);
            this.groupTaskSetAll.Location = new System.Drawing.Point(12, 593);
            this.groupTaskSetAll.Name = "groupTaskSetAll";
            this.groupTaskSetAll.Size = new System.Drawing.Size(220, 66);
            this.groupTaskSetAll.TabIndex = 9;
            this.groupTaskSetAll.TabStop = false;
            this.groupTaskSetAll.Text = "Všetky úlohy";
            // 
            // lblTaskAllMm
            // 
            this.lblTaskAllMm.AutoSize = true;
            this.lblTaskAllMm.Location = new System.Drawing.Point(163, 28);
            this.lblTaskAllMm.Name = "lblTaskAllMm";
            this.lblTaskAllMm.Size = new System.Drawing.Size(23, 13);
            this.lblTaskAllMm.TabIndex = 2;
            this.lblTaskAllMm.Text = "mm";
            // 
            // RobotDiameterNumericBox
            // 
            this.RobotDiameterNumericBox.Location = new System.Drawing.Point(107, 26);
            this.RobotDiameterNumericBox.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.RobotDiameterNumericBox.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.RobotDiameterNumericBox.Name = "RobotDiameterNumericBox";
            this.RobotDiameterNumericBox.Size = new System.Drawing.Size(50, 20);
            this.RobotDiameterNumericBox.TabIndex = 1;
            this.RobotDiameterNumericBox.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblTaskAllAverage
            // 
            this.lblTaskAllAverage.AutoSize = true;
            this.lblTaskAllAverage.Location = new System.Drawing.Point(23, 30);
            this.lblTaskAllAverage.Name = "lblTaskAllAverage";
            this.lblTaskAllAverage.Size = new System.Drawing.Size(78, 13);
            this.lblTaskAllAverage.TabIndex = 0;
            this.lblTaskAllAverage.Text = "Priemer robota:";
            // 
            // groupTaskSet3
            // 
            this.groupTaskSet3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupTaskSet3.Controls.Add(this.ShowMapCheckBox);
            this.groupTaskSet3.Location = new System.Drawing.Point(238, 593);
            this.groupTaskSet3.Name = "groupTaskSet3";
            this.groupTaskSet3.Size = new System.Drawing.Size(220, 66);
            this.groupTaskSet3.TabIndex = 10;
            this.groupTaskSet3.TabStop = false;
            this.groupTaskSet3.Text = "Úloha 3: Mapovanie";
            // 
            // ShowMapCheckBox
            // 
            this.ShowMapCheckBox.AutoSize = true;
            this.ShowMapCheckBox.Location = new System.Drawing.Point(53, 27);
            this.ShowMapCheckBox.Name = "ShowMapCheckBox";
            this.ShowMapCheckBox.Size = new System.Drawing.Size(117, 17);
            this.ShowMapCheckBox.TabIndex = 0;
            this.ShowMapCheckBox.Text = "Zobraziť celú mapu";
            this.ShowMapCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupTaskSet4
            // 
            this.groupTaskSet4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupTaskSet4.Controls.Add(this.lblTask4Mm);
            this.groupTaskSet4.Controls.Add(this.MapQuantisationNumBox);
            this.groupTaskSet4.Controls.Add(this.lblTask4Quant);
            this.groupTaskSet4.Location = new System.Drawing.Point(464, 593);
            this.groupTaskSet4.Name = "groupTaskSet4";
            this.groupTaskSet4.Size = new System.Drawing.Size(220, 66);
            this.groupTaskSet4.TabIndex = 11;
            this.groupTaskSet4.TabStop = false;
            this.groupTaskSet4.Text = "Úloha 4: Plánovanie trajektórie";
            // 
            // lblTask4Mm
            // 
            this.lblTask4Mm.AutoSize = true;
            this.lblTask4Mm.Location = new System.Drawing.Point(159, 28);
            this.lblTask4Mm.Name = "lblTask4Mm";
            this.lblTask4Mm.Size = new System.Drawing.Size(23, 13);
            this.lblTask4Mm.TabIndex = 2;
            this.lblTask4Mm.Text = "mm";
            // 
            // MapQuantisationNumBox
            // 
            this.MapQuantisationNumBox.Location = new System.Drawing.Point(95, 26);
            this.MapQuantisationNumBox.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MapQuantisationNumBox.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MapQuantisationNumBox.Name = "MapQuantisationNumBox";
            this.MapQuantisationNumBox.Size = new System.Drawing.Size(58, 20);
            this.MapQuantisationNumBox.TabIndex = 1;
            this.MapQuantisationNumBox.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblTask4Quant
            // 
            this.lblTask4Quant.AutoSize = true;
            this.lblTask4Quant.Location = new System.Drawing.Point(24, 28);
            this.lblTask4Quant.Name = "lblTask4Quant";
            this.lblTask4Quant.Size = new System.Drawing.Size(65, 13);
            this.lblTask4Quant.TabIndex = 0;
            this.lblTask4Quant.Text = "Kvantizácia:";
            // 
            // TimeNumericBox
            // 
            this.TimeNumericBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeNumericBox.DecimalPlaces = 2;
            this.TimeNumericBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimeNumericBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.TimeNumericBox.Location = new System.Drawing.Point(1120, 546);
            this.TimeNumericBox.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.TimeNumericBox.Name = "TimeNumericBox";
            this.TimeNumericBox.Size = new System.Drawing.Size(122, 45);
            this.TimeNumericBox.TabIndex = 12;
            this.TimeNumericBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeNumericBox.ValueChanged += new System.EventHandler(this.TimeNumericBox_ValueChanged);
            // 
            // PlayerTimer
            // 
            this.PlayerTimer.Tick += new System.EventHandler(this.PlayerTimer_Tick);
            // 
            // ShowtimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 671);
            this.Controls.Add(this.TimeNumericBox);
            this.Controls.Add(this.groupTaskSet4);
            this.Controls.Add(this.groupTaskSet3);
            this.Controls.Add(this.groupTaskSetAll);
            this.Controls.Add(this.btnMediaFirst);
            this.Controls.Add(this.btnMediaPrevious);
            this.Controls.Add(this.btnMediaPlay);
            this.Controls.Add(this.btnMediaStop);
            this.Controls.Add(this.btnMediaNext);
            this.Controls.Add(this.btnMediaLast);
            this.Controls.Add(this.TimeTrackBar);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(1270, 710);
            this.Name = "ShowtimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[I-RMR] Riadenie mobilných robotov (Martin Heteš)";
            this.Shown += new System.EventHandler(this.ShowtimeForm_Shown);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupTask1.ResumeLayout(false);
            this.groupTask1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Task1ImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrackBar)).EndInit();
            this.groupTaskSetAll.ResumeLayout(false);
            this.groupTaskSetAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RobotDiameterNumericBox)).EndInit();
            this.groupTaskSet3.ResumeLayout(false);
            this.groupTaskSet3.PerformLayout();
            this.groupTaskSet4.ResumeLayout(false);
            this.groupTaskSet4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapQuantisationNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TrackBar TimeTrackBar;
        private System.Windows.Forms.Button btnMediaLast;
        private System.Windows.Forms.Button btnMediaNext;
        private System.Windows.Forms.Button btnMediaStop;
        private System.Windows.Forms.Button btnMediaPlay;
        private System.Windows.Forms.Button btnMediaPrevious;
        private System.Windows.Forms.Button btnMediaFirst;
        private System.Windows.Forms.PictureBox Task1ImageBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupTask1;
        private System.Windows.Forms.GroupBox groupTaskSetAll;
        private System.Windows.Forms.GroupBox groupTaskSet3;
        private System.Windows.Forms.GroupBox groupTaskSet4;
        private System.Windows.Forms.Label lblTaskAllMm;
        private System.Windows.Forms.NumericUpDown RobotDiameterNumericBox;
        private System.Windows.Forms.Label lblTaskAllAverage;
        private System.Windows.Forms.CheckBox ShowMapCheckBox;
        private System.Windows.Forms.NumericUpDown MapQuantisationNumBox;
        private System.Windows.Forms.Label lblTask4Quant;
        private System.Windows.Forms.Label lblTask4Mm;
        private System.Windows.Forms.NumericUpDown TimeNumericBox;
        private System.Windows.Forms.TextBox Task1FrameTextBox;
        private System.Windows.Forms.TextBox Task1TimeTextBox;
        private System.Windows.Forms.Label lblTask1Frame;
        private System.Windows.Forms.Label lblTask1TimeSec;
        private System.Windows.Forms.Label lblTask1Time;
        private System.Windows.Forms.TextBox Task1PosXTextBox;
        private System.Windows.Forms.Label lblTask1PosXMm;
        private System.Windows.Forms.Label lblTask1PosX;
        private System.Windows.Forms.TextBox Task1PosYTextBox;
        private System.Windows.Forms.Label lblTask1PosYMm;
        private System.Windows.Forms.Label lblTask1PosY;
        private System.Windows.Forms.TextBox Task1AngleTextBox;
        private System.Windows.Forms.Label lblTask1Angle;
        private System.Windows.Forms.Label lblTask1AngleDegree;
        private System.Windows.Forms.TextBox Task1VelocityTextBox;
        private System.Windows.Forms.Label lblTask1Velocity;
        private System.Windows.Forms.Label lblTask1VelocityMms;
        private System.Windows.Forms.TextBox Task1LastSensorTextBox;
        private System.Windows.Forms.Label lblTask1LastSensor;
        private System.Windows.Forms.ListBox Task1SensorListBox;
        private System.Windows.Forms.Label lblTask1LastSensorMm;
        private System.Windows.Forms.TextBox Task1LastScanTextBox;
        private System.Windows.Forms.Label lblTask1LastScanMm;
        private System.Windows.Forms.Label lblTask1LastScan;
        private System.Windows.Forms.ListBox Task1ScanListBox;
        private System.Windows.Forms.Timer PlayerTimer;
    }
}