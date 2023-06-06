namespace Clock_Ver1
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
            this.ProgBarMin = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_time = new System.Windows.Forms.TextBox();
            this.ProgBarSec = new CircularProgressBar.CircularProgressBar();
            this.ProgBarHour = new CircularProgressBar.CircularProgressBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt12 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.CdTimer = new CircularProgressBar.CircularProgressBar();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.cbMin = new System.Windows.Forms.ComboBox();
            this.cbSec = new System.Windows.Forms.ComboBox();
            this.btnStPs = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnClock = new System.Windows.Forms.Button();
            this.btnStw = new System.Windows.Forms.Button();
            this.txtCdTimer = new System.Windows.Forms.TextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.txtSWatch = new System.Windows.Forms.TextBox();
            this.ProgBarSWatch = new CircularProgressBar.CircularProgressBar();
            this.btnStpSW = new System.Windows.Forms.Button();
            this.btnSrtSW = new System.Windows.Forms.Button();
            this.txtLapList = new System.Windows.Forms.TextBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ProgBarMin
            // 
            this.ProgBarMin.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ProgBarMin.AnimationSpeed = 500;
            this.ProgBarMin.BackColor = System.Drawing.Color.Gainsboro;
            this.ProgBarMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.ProgBarMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProgBarMin.InnerColor = System.Drawing.Color.Gainsboro;
            this.ProgBarMin.InnerMargin = 2;
            this.ProgBarMin.InnerWidth = -1;
            this.ProgBarMin.Location = new System.Drawing.Point(291, 102);
            this.ProgBarMin.MarqueeAnimationSpeed = 2000;
            this.ProgBarMin.Maximum = 360;
            this.ProgBarMin.Name = "ProgBarMin";
            this.ProgBarMin.OuterColor = System.Drawing.Color.Gray;
            this.ProgBarMin.OuterMargin = -25;
            this.ProgBarMin.OuterWidth = 26;
            this.ProgBarMin.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ProgBarMin.ProgressWidth = 25;
            this.ProgBarMin.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.ProgBarMin.Size = new System.Drawing.Size(223, 223);
            this.ProgBarMin.StartAngle = 270;
            this.ProgBarMin.Step = 0;
            this.ProgBarMin.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgBarMin.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ProgBarMin.SubscriptText = ".23";
            this.ProgBarMin.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgBarMin.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ProgBarMin.SuperscriptText = "°C";
            this.ProgBarMin.TabIndex = 0;
            this.ProgBarMin.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ProgBarMin.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_time
            // 
            this.txt_time.BackColor = System.Drawing.SystemColors.Control;
            this.txt_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_time.Enabled = false;
            this.txt_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_time.Location = new System.Drawing.Point(330, 392);
            this.txt_time.Name = "txt_time";
            this.txt_time.ReadOnly = true;
            this.txt_time.Size = new System.Drawing.Size(266, 46);
            this.txt_time.TabIndex = 1;
            this.txt_time.Text = "00:00:00";
            this.txt_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProgBarSec
            // 
            this.ProgBarSec.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ProgBarSec.AnimationSpeed = 500;
            this.ProgBarSec.BackColor = System.Drawing.Color.Transparent;
            this.ProgBarSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.ProgBarSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProgBarSec.InnerColor = System.Drawing.Color.Gainsboro;
            this.ProgBarSec.InnerMargin = 2;
            this.ProgBarSec.InnerWidth = -1;
            this.ProgBarSec.Location = new System.Drawing.Point(217, 29);
            this.ProgBarSec.MarqueeAnimationSpeed = 2000;
            this.ProgBarSec.Maximum = 360;
            this.ProgBarSec.Name = "ProgBarSec";
            this.ProgBarSec.OuterColor = System.Drawing.Color.Gray;
            this.ProgBarSec.OuterMargin = -25;
            this.ProgBarSec.OuterWidth = 26;
            this.ProgBarSec.ProgressColor = System.Drawing.Color.Teal;
            this.ProgBarSec.ProgressWidth = 25;
            this.ProgBarSec.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.ProgBarSec.Size = new System.Drawing.Size(371, 371);
            this.ProgBarSec.StartAngle = 270;
            this.ProgBarSec.Step = 0;
            this.ProgBarSec.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgBarSec.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ProgBarSec.SubscriptText = ".23";
            this.ProgBarSec.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgBarSec.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ProgBarSec.SuperscriptText = "°C";
            this.ProgBarSec.TabIndex = 2;
            this.ProgBarSec.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ProgBarSec.Value = 68;
            // 
            // ProgBarHour
            // 
            this.ProgBarHour.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ProgBarHour.AnimationSpeed = 500;
            this.ProgBarHour.BackColor = System.Drawing.Color.Gainsboro;
            this.ProgBarHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.ProgBarHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProgBarHour.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProgBarHour.InnerMargin = 2;
            this.ProgBarHour.InnerWidth = -1;
            this.ProgBarHour.Location = new System.Drawing.Point(349, 160);
            this.ProgBarHour.MarqueeAnimationSpeed = 2000;
            this.ProgBarHour.Maximum = 360;
            this.ProgBarHour.Name = "ProgBarHour";
            this.ProgBarHour.OuterColor = System.Drawing.Color.Gray;
            this.ProgBarHour.OuterMargin = -25;
            this.ProgBarHour.OuterWidth = 26;
            this.ProgBarHour.ProgressColor = System.Drawing.Color.Cyan;
            this.ProgBarHour.ProgressWidth = 25;
            this.ProgBarHour.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.ProgBarHour.Size = new System.Drawing.Size(107, 107);
            this.ProgBarHour.StartAngle = 270;
            this.ProgBarHour.Step = 0;
            this.ProgBarHour.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgBarHour.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ProgBarHour.SubscriptText = ".23";
            this.ProgBarHour.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgBarHour.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ProgBarHour.SuperscriptText = "°C";
            this.ProgBarHour.TabIndex = 3;
            this.ProgBarHour.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ProgBarHour.Value = 68;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_date
            // 
            this.txt_date.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_date.Enabled = false;
            this.txt_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Location = new System.Drawing.Point(10, 62);
            this.txt_date.Name = "txt_date";
            this.txt_date.ReadOnly = true;
            this.txt_date.Size = new System.Drawing.Size(500, 46);
            this.txt_date.TabIndex = 5;
            this.txt_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt12
            // 
            this.txt12.BackColor = System.Drawing.SystemColors.Control;
            this.txt12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt12.Enabled = false;
            this.txt12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt12.Location = new System.Drawing.Point(1013, 18);
            this.txt12.Name = "txt12";
            this.txt12.ReadOnly = true;
            this.txt12.Size = new System.Drawing.Size(29, 28);
            this.txt12.TabIndex = 6;
            this.txt12.Text = "12";
            this.txt12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3
            // 
            this.txt3.BackColor = System.Drawing.SystemColors.Control;
            this.txt3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt3.Enabled = false;
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.Location = new System.Drawing.Point(1001, 74);
            this.txt3.Name = "txt3";
            this.txt3.ReadOnly = true;
            this.txt3.Size = new System.Drawing.Size(23, 28);
            this.txt3.TabIndex = 7;
            this.txt3.Text = "3";
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt6
            // 
            this.txt6.BackColor = System.Drawing.SystemColors.Control;
            this.txt6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt6.Enabled = false;
            this.txt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt6.Location = new System.Drawing.Point(1075, 100);
            this.txt6.Name = "txt6";
            this.txt6.ReadOnly = true;
            this.txt6.Size = new System.Drawing.Size(19, 28);
            this.txt6.TabIndex = 8;
            this.txt6.Text = "6";
            this.txt6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt9
            // 
            this.txt9.BackColor = System.Drawing.SystemColors.Control;
            this.txt9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt9.Enabled = false;
            this.txt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt9.Location = new System.Drawing.Point(981, 239);
            this.txt9.Name = "txt9";
            this.txt9.ReadOnly = true;
            this.txt9.Size = new System.Drawing.Size(19, 28);
            this.txt9.TabIndex = 9;
            this.txt9.Text = "9";
            this.txt9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.Control;
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt1.Enabled = false;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(1064, 247);
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(13, 46);
            this.txt1.TabIndex = 10;
            this.txt1.Text = ".";
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.SystemColors.Control;
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt2.Enabled = false;
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(1064, 160);
            this.txt2.Name = "txt2";
            this.txt2.ReadOnly = true;
            this.txt2.Size = new System.Drawing.Size(14, 46);
            this.txt2.TabIndex = 11;
            this.txt2.Text = ".";
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt4
            // 
            this.txt4.BackColor = System.Drawing.SystemColors.Control;
            this.txt4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt4.Enabled = false;
            this.txt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt4.Location = new System.Drawing.Point(1064, 160);
            this.txt4.Name = "txt4";
            this.txt4.ReadOnly = true;
            this.txt4.Size = new System.Drawing.Size(14, 46);
            this.txt4.TabIndex = 12;
            this.txt4.Text = ".";
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt5
            // 
            this.txt5.BackColor = System.Drawing.SystemColors.Control;
            this.txt5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt5.Enabled = false;
            this.txt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt5.Location = new System.Drawing.Point(1023, 251);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(10, 46);
            this.txt5.TabIndex = 13;
            this.txt5.Text = ".";
            this.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt7
            // 
            this.txt7.BackColor = System.Drawing.SystemColors.Control;
            this.txt7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt7.Enabled = false;
            this.txt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt7.Location = new System.Drawing.Point(1023, 170);
            this.txt7.Name = "txt7";
            this.txt7.ReadOnly = true;
            this.txt7.Size = new System.Drawing.Size(17, 46);
            this.txt7.TabIndex = 14;
            this.txt7.Text = ".";
            this.txt7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt8
            // 
            this.txt8.BackColor = System.Drawing.SystemColors.Control;
            this.txt8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt8.Enabled = false;
            this.txt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt8.Location = new System.Drawing.Point(1001, 170);
            this.txt8.Name = "txt8";
            this.txt8.ReadOnly = true;
            this.txt8.Size = new System.Drawing.Size(16, 46);
            this.txt8.TabIndex = 15;
            this.txt8.Text = ".";
            this.txt8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt10
            // 
            this.txt10.BackColor = System.Drawing.SystemColors.Control;
            this.txt10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt10.Enabled = false;
            this.txt10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt10.Location = new System.Drawing.Point(1013, 131);
            this.txt10.Name = "txt10";
            this.txt10.ReadOnly = true;
            this.txt10.Size = new System.Drawing.Size(29, 46);
            this.txt10.TabIndex = 16;
            this.txt10.Text = ".";
            this.txt10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt11
            // 
            this.txt11.BackColor = System.Drawing.SystemColors.Control;
            this.txt11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt11.Enabled = false;
            this.txt11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt11.Location = new System.Drawing.Point(949, 131);
            this.txt11.Name = "txt11";
            this.txt11.ReadOnly = true;
            this.txt11.Size = new System.Drawing.Size(46, 46);
            this.txt11.TabIndex = 17;
            this.txt11.Text = ".";
            this.txt11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn1.Location = new System.Drawing.Point(12, 20);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(176, 44);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "Không kim";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // CdTimer
            // 
            this.CdTimer.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CdTimer.AnimationSpeed = 500;
            this.CdTimer.BackColor = System.Drawing.Color.Transparent;
            this.CdTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CdTimer.ForeColor = System.Drawing.Color.Teal;
            this.CdTimer.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CdTimer.InnerMargin = 2;
            this.CdTimer.InnerWidth = -1;
            this.CdTimer.Location = new System.Drawing.Point(623, 74);
            this.CdTimer.MarqueeAnimationSpeed = 2000;
            this.CdTimer.Name = "CdTimer";
            this.CdTimer.OuterColor = System.Drawing.Color.Gray;
            this.CdTimer.OuterMargin = -25;
            this.CdTimer.OuterWidth = 26;
            this.CdTimer.ProgressColor = System.Drawing.Color.LimeGreen;
            this.CdTimer.ProgressWidth = 25;
            this.CdTimer.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CdTimer.Size = new System.Drawing.Size(320, 320);
            this.CdTimer.StartAngle = 270;
            this.CdTimer.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CdTimer.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CdTimer.SubscriptText = "";
            this.CdTimer.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CdTimer.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CdTimer.SuperscriptText = "";
            this.CdTimer.TabIndex = 19;
            this.CdTimer.Text = "00:00:00";
            this.CdTimer.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CdTimer.Value = 68;
            this.CdTimer.Visible = false;
            // 
            // cbHour
            // 
            this.cbHour.BackColor = System.Drawing.Color.White;
            this.cbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHour.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Location = new System.Drawing.Point(672, 403);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(84, 37);
            this.cbHour.TabIndex = 20;
            this.cbHour.Text = "Giờ";
            this.cbHour.Visible = false;
            this.cbHour.TextChanged += new System.EventHandler(this.cbHour_TextChanged);
            // 
            // cbMin
            // 
            this.cbMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMin.FormattingEnabled = true;
            this.cbMin.Location = new System.Drawing.Point(762, 403);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(84, 37);
            this.cbMin.TabIndex = 21;
            this.cbMin.Text = "Phút";
            this.cbMin.Visible = false;
            this.cbMin.TextChanged += new System.EventHandler(this.cbMin_TextChanged);
            // 
            // cbSec
            // 
            this.cbSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSec.FormattingEnabled = true;
            this.cbSec.Location = new System.Drawing.Point(852, 403);
            this.cbSec.Name = "cbSec";
            this.cbSec.Size = new System.Drawing.Size(84, 37);
            this.cbSec.TabIndex = 22;
            this.cbSec.Text = "Giây";
            this.cbSec.Visible = false;
            this.cbSec.TextChanged += new System.EventHandler(this.cbSec_TextChanged);
            // 
            // btnStPs
            // 
            this.btnStPs.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStPs.ForeColor = System.Drawing.Color.Green;
            this.btnStPs.Location = new System.Drawing.Point(944, 392);
            this.btnStPs.Name = "btnStPs";
            this.btnStPs.Size = new System.Drawing.Size(82, 54);
            this.btnStPs.TabIndex = 23;
            this.btnStPs.Text = "Start";
            this.btnStPs.UseVisualStyleBackColor = false;
            this.btnStPs.Visible = false;
            this.btnStPs.Click += new System.EventHandler(this.btnStPs_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.LightCoral;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.DarkRed;
            this.btnStop.Location = new System.Drawing.Point(584, 393);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(82, 54);
            this.btnStop.TabIndex = 24;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimer.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTimer.Location = new System.Drawing.Point(10, 142);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(184, 44);
            this.btnTimer.TabIndex = 25;
            this.btnTimer.Text = "TIMER";
            this.btnTimer.UseVisualStyleBackColor = false;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnClock
            // 
            this.btnClock.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClock.ForeColor = System.Drawing.Color.Teal;
            this.btnClock.Location = new System.Drawing.Point(12, 213);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(184, 44);
            this.btnClock.TabIndex = 26;
            this.btnClock.Text = "CLOCK";
            this.btnClock.UseVisualStyleBackColor = false;
            this.btnClock.Click += new System.EventHandler(this.btnClock_Click);
            // 
            // btnStw
            // 
            this.btnStw.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnStw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStw.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnStw.Location = new System.Drawing.Point(12, 281);
            this.btnStw.Name = "btnStw";
            this.btnStw.Size = new System.Drawing.Size(184, 44);
            this.btnStw.TabIndex = 27;
            this.btnStw.Text = "STOPWATCH";
            this.btnStw.UseVisualStyleBackColor = false;
            this.btnStw.Click += new System.EventHandler(this.btnStw_Click);
            // 
            // txtCdTimer
            // 
            this.txtCdTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCdTimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCdTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCdTimer.ForeColor = System.Drawing.Color.Teal;
            this.txtCdTimer.Location = new System.Drawing.Point(683, 213);
            this.txtCdTimer.Multiline = true;
            this.txtCdTimer.Name = "txtCdTimer";
            this.txtCdTimer.ReadOnly = true;
            this.txtCdTimer.Size = new System.Drawing.Size(208, 54);
            this.txtCdTimer.TabIndex = 28;
            this.txtCdTimer.Text = "00:00:00";
            this.txtCdTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCdTimer.Visible = false;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // txtSWatch
            // 
            this.txtSWatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSWatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSWatch.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtSWatch.Location = new System.Drawing.Point(520, 213);
            this.txtSWatch.Multiline = true;
            this.txtSWatch.Name = "txtSWatch";
            this.txtSWatch.ReadOnly = true;
            this.txtSWatch.Size = new System.Drawing.Size(208, 54);
            this.txtSWatch.TabIndex = 29;
            this.txtSWatch.Text = "00:00:00";
            this.txtSWatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSWatch.Visible = false;
            // 
            // ProgBarSWatch
            // 
            this.ProgBarSWatch.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ProgBarSWatch.AnimationSpeed = 500;
            this.ProgBarSWatch.BackColor = System.Drawing.Color.Transparent;
            this.ProgBarSWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgBarSWatch.ForeColor = System.Drawing.Color.Teal;
            this.ProgBarSWatch.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProgBarSWatch.InnerMargin = 2;
            this.ProgBarSWatch.InnerWidth = -1;
            this.ProgBarSWatch.Location = new System.Drawing.Point(462, 80);
            this.ProgBarSWatch.MarqueeAnimationSpeed = 2000;
            this.ProgBarSWatch.Name = "ProgBarSWatch";
            this.ProgBarSWatch.OuterColor = System.Drawing.Color.Gray;
            this.ProgBarSWatch.OuterMargin = -25;
            this.ProgBarSWatch.OuterWidth = 26;
            this.ProgBarSWatch.ProgressColor = System.Drawing.Color.Yellow;
            this.ProgBarSWatch.ProgressWidth = 25;
            this.ProgBarSWatch.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgBarSWatch.Size = new System.Drawing.Size(320, 320);
            this.ProgBarSWatch.StartAngle = 270;
            this.ProgBarSWatch.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgBarSWatch.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ProgBarSWatch.SubscriptText = "";
            this.ProgBarSWatch.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgBarSWatch.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ProgBarSWatch.SuperscriptText = "";
            this.ProgBarSWatch.TabIndex = 30;
            this.ProgBarSWatch.Text = "00:00:00";
            this.ProgBarSWatch.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.ProgBarSWatch.Value = 68;
            this.ProgBarSWatch.Visible = false;
            // 
            // btnStpSW
            // 
            this.btnStpSW.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnStpSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStpSW.ForeColor = System.Drawing.Color.Teal;
            this.btnStpSW.Location = new System.Drawing.Point(329, 424);
            this.btnStpSW.Name = "btnStpSW";
            this.btnStpSW.Size = new System.Drawing.Size(82, 54);
            this.btnStpSW.TabIndex = 32;
            this.btnStpSW.Text = "Lap";
            this.btnStpSW.UseVisualStyleBackColor = false;
            this.btnStpSW.Visible = false;
            this.btnStpSW.Click += new System.EventHandler(this.btnStpSW_Click);
            // 
            // btnSrtSW
            // 
            this.btnSrtSW.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSrtSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrtSW.ForeColor = System.Drawing.Color.Green;
            this.btnSrtSW.Location = new System.Drawing.Point(689, 423);
            this.btnSrtSW.Name = "btnSrtSW";
            this.btnSrtSW.Size = new System.Drawing.Size(82, 54);
            this.btnSrtSW.TabIndex = 31;
            this.btnSrtSW.Text = "Start";
            this.btnSrtSW.UseVisualStyleBackColor = false;
            this.btnSrtSW.Visible = false;
            this.btnSrtSW.Click += new System.EventHandler(this.btnSrtSW_Click);
            // 
            // txtLapList
            // 
            this.txtLapList.BackColor = System.Drawing.Color.MistyRose;
            this.txtLapList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLapList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLapList.Location = new System.Drawing.Point(728, 23);
            this.txtLapList.Multiline = true;
            this.txtLapList.Name = "txtLapList";
            this.txtLapList.ReadOnly = true;
            this.txtLapList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLapList.Size = new System.Drawing.Size(322, 332);
            this.txtLapList.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1178, 900);
            this.Controls.Add(this.txtLapList);
            this.Controls.Add(this.btnStpSW);
            this.Controls.Add(this.btnSrtSW);
            this.Controls.Add(this.txtSWatch);
            this.Controls.Add(this.ProgBarSWatch);
            this.Controls.Add(this.txtCdTimer);
            this.Controls.Add(this.btnStw);
            this.Controls.Add(this.btnClock);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStPs);
            this.Controls.Add(this.cbSec);
            this.Controls.Add(this.cbMin);
            this.Controls.Add(this.cbHour);
            this.Controls.Add(this.CdTimer);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt11);
            this.Controls.Add(this.txt10);
            this.Controls.Add(this.txt8);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt9);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt12);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.ProgBarHour);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.ProgBarMin);
            this.Controls.Add(this.ProgBarSec);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1200, 654);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar ProgBarMin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_time;
        private CircularProgressBar.CircularProgressBar ProgBarSec;
        private CircularProgressBar.CircularProgressBar ProgBarHour;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt12;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt9;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Timer timer2;
        private CircularProgressBar.CircularProgressBar CdTimer;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.ComboBox cbMin;
        private System.Windows.Forms.ComboBox cbSec;
        private System.Windows.Forms.Button btnStPs;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnClock;
        private System.Windows.Forms.Button btnStw;
        private System.Windows.Forms.TextBox txtCdTimer;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox txtSWatch;
        private CircularProgressBar.CircularProgressBar ProgBarSWatch;
        private System.Windows.Forms.Button btnStpSW;
        private System.Windows.Forms.Button btnSrtSW;
        private System.Windows.Forms.TextBox txtLapList;
        private System.Windows.Forms.Timer timer4;
    }
}

