//LABEL can be used instead of TEXTBOX

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Clock_Ver1
{
    public partial class Form1 : Form
    {
        int sec, min, hour, lastSec = -1, lastMin = -1, lastHour = -1;
        int rClock = 240;
        string time, AmPm;
        Bitmap canvas;
        Graphics g;
        Pen pSec = new Pen(Color.Red, 2), pMin = new Pen(Color.DarkGoldenrod, 3), pHour = new Pen(Color.DarkBlue, 4), pFrame = new Pen(Color.DarkGray, 5);
        Point center;
        int mode = 1, clockMode = 1;
        string cdtHour = "00", cdtMin = "00", cdtSec = "00", numCdtHour = "", numCdtMin = "", numCdtSec = "";
        int swSec = 0, swMin = 0, swHour = 0;
        String swhs = "00", swms = "00", swss = "00";

        public Form1()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                ShowProgBars();
                btn1.Text = "Clockhands";
            }
            else
            {
                while (DateTime.Now.Second == lastSec)
                {
                    Thread.Sleep(10);
                }
                HideProgBars();
                btn1.Text = "No clockhands";
            }
            mode = 1 - mode;
            addNumbers();
        }

        void changeNumCol1()
        {
            //can be omitted if label is used
            txt1.BackColor = this.BackColor;
            txt2.BackColor = this.BackColor;
            txt3.BackColor = this.BackColor;
            txt4.BackColor = this.BackColor;
            txt5.BackColor = this.BackColor;
            txt6.BackColor = this.BackColor;
            txt7.BackColor = this.BackColor;
            txt8.BackColor = this.BackColor;
            txt9.BackColor = this.BackColor;
            txt10.BackColor = this.BackColor;
            txt11.BackColor = this.BackColor;
            txt12.BackColor = this.BackColor;
        }

        void changeNumCol2()
        {
            //can be omitted if label is used
            txt1.BackColor = Color.Gainsboro;
            txt2.BackColor = Color.Gainsboro;
            txt3.BackColor = Color.Gainsboro;
            txt4.BackColor = Color.Gainsboro;
            txt5.BackColor = Color.Gainsboro;
            txt6.BackColor = Color.Gainsboro;
            txt7.BackColor = Color.Gainsboro;
            txt8.BackColor = Color.Gainsboro;
            txt9.BackColor = Color.Gainsboro;
            txt10.BackColor = Color.Gainsboro;
            txt11.BackColor = Color.Gainsboro;
            txt12.BackColor = Color.Gainsboro;
        }

        void HideSWatch ()
        {
            ProgBarSWatch.Hide();
            txtSWatch.Hide();
            btnStpSW.Visible = false;
            btnSrtSW.Visible = false;
            txtLapList.Visible = false;
            {
                swHour = 0;
                swMin = 0;
                swSec = 0;
                txtSWatch.Text = "00:00:00";
                btnStpSW.Enabled = false;
                btnStpSW.Text = "Lap";
                btnStpSW.ForeColor = Color.Gray;
                btnStpSW.BackColor = Color.Gainsboro;
                txtLapList.Text = "";
                lapCnt = 0;
                timer3.Stop();
                btnClock.Enabled = true; btnTimer.Enabled = true;
            }
        }

        void HideTimer()
        {
            CdTimer.Visible = false;
            btnStPs.Visible = false; btnStop.Visible = false;
            cbSec.Visible = false; cbMin.Visible = false; cbHour.Visible = false;
            btn1.Visible = true;
            txtCdTimer.Visible = false;
        }

        void HideProgBars()
        {
            //hiding progress bars
            ProgBarHour.Visible = false;
            ProgBarMin.Visible = false;
            ProgBarSec.Visible = false;
        }

        void ShowProgBars()
        {
            //hiding progress bars
            ProgBarHour.Visible = true;
            ProgBarMin.Visible = true;
            ProgBarSec.Visible = true;
        }
        void ShowSWatch()
        {
            txtSWatch.Visible = true;
            ProgBarSWatch.Value = 100;
            ProgBarSWatch.Visible = true;
            btnSrtSW.Visible= true;
            btnStpSW.Visible= true;
            btnStpSW.ForeColor = Color.Gray;
            btnStpSW.BackColor = Color.Gainsboro;
            btnStpSW.Enabled = false;
            txtLapList.Size = new Size(this.Width / 5, this.Height);
            txtLapList.Location = new Point(ProgBarSWatch.Location.X + ProgBarSWatch.Width + 50, 0);
            txtLapList.Visible = true;
        }

        void addNumbers()
        {
            //adding numbers
            if (mode == 1)
            {
                changeNumCol1();
                txt1.Location = ptPos(1);
                txt2.Location = ptPos(2);
                txt3.Location = ptPos(3);
                txt4.Location = ptPos(4);
                txt5.Location = ptPos(5);
                txt6.Location = ptPos(6);
                txt7.Location = ptPos(7);
                txt8.Location = ptPos(8);
                txt9.Location = ptPos(9);
                txt10.Location = ptPos(10);
                txt11.Location = ptPos(11);
                txt12.Location = ptPos(12);
            }
            else
            {
                changeNumCol2();
                txt1.Location = ptPos2(1);
                txt2.Location = ptPos2(2);
                txt3.Location = ptPos2(3);
                txt4.Location = ptPos2(4);
                txt5.Location = ptPos2(5);
                txt6.Location = ptPos2(6);
                txt7.Location = ptPos2(7);
                txt8.Location = ptPos2(8);
                txt9.Location = ptPos2(9);
                txt10.Location = ptPos2(10);
                txt11.Location = ptPos2(11);
                txt12.Location = ptPos2(12);
            }
        }

        void relocate()
        {
            //CLOCK
            {
                txt_time.Location = new Point(this.Width / 2 - txt_time.Width / 2, this.Height / 2 - ProgBarSec.Height / 2 - 50);
                txt_date.Location = new Point(this.Width / 2 - txt_date.Width / 2, txt_time.Location.Y - 50);
                ProgBarHour.Location = new Point(this.Width / 2 - ProgBarHour.Width / 2, this.Height / 2 - ProgBarHour.Height / 2);
                ProgBarMin.Location = new Point(this.Width / 2 - ProgBarMin.Width / 2, this.Height / 2 - ProgBarMin.Height / 2);
                ProgBarSec.Location = new Point(this.Width / 2 - ProgBarSec.Width / 2, this.Height / 2 - ProgBarSec.Height / 2);
                addNumbers();
                btn1.Location = new Point(txt3.Location.X + 75, this.Height / 2 - btn1.Height / 2);
            }
            //TIMER
            {
                CdTimer.Location = new Point(this.Width / 2 - CdTimer.Width / 2, this.Height / 2 - CdTimer.Height / 2);
                cbMin.Location = new Point(this.Width / 2 - cbMin.Width / 2, 45);
                cbHour.Location = new Point(cbMin.Location.X - 50 - cbHour.Width / 2, cbMin.Location.Y);
                cbSec.Location = new Point(cbMin.Location.X + 50 + cbSec.Width / 2, cbMin.Location.Y);
                btnStPs.Location = new Point(cbHour.Location.X - 60 - btnStPs.Width / 2, cbMin.Location.Y - 20);
                btnStop.Location = new Point(cbSec.Location.X + 50 + btnStop.Width / 2, cbMin.Location.Y - 20);
                txtCdTimer.Location = new Point(this.Width/2-txtCdTimer.Width/2, this.Height/2-txtCdTimer.Height/2);
            }
            //STOPWATCH
            {
                ProgBarSWatch.Location = new Point(this.Width / 2 - ProgBarSWatch.Width / 2, this.Height / 2 - ProgBarSWatch.Height / 2);
                btnSrtSW.Location = new Point(this.Width/2 - 50 - btnSrtSW.Width, 45);
                btnStpSW.Location = new Point(this.Width/2 + 50, 45);
                txtSWatch.Location = new Point(this.Width / 2 - txtSWatch.Width / 2, this.Height / 2 - txtSWatch.Height / 2);
                txtLapList.Location = new Point(ProgBarSWatch.Location.X + ProgBarSWatch.Width + 50, 0);
            }
        }

        void clearCanvas()
        {
            Graphics g = Graphics.FromImage(canvas);
            g = this.CreateGraphics();
            this.Refresh();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            relocate();
            center = new Point(this.Width / 2, this.Height / 2);
            g.DrawEllipse(new Pen(BackColor, pFrame.Width), center.X - rClock, center.Y - rClock + 2, 2 * rClock, 2 * rClock);
            ResizeCanvas(); clearCanvas();
            if (mode == 1) if (canvas != null)
                    DrawClock();
            addNumbers();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = this.CreateGraphics();
            g.DrawEllipse(pFrame, center.X - rClock, center.Y - rClock + 2, 2 * rClock, 2 * rClock);
        }

        void AddTimeItems()
        {
            for (int i = 0; i < 24; i++)
                cbHour.Items.Add(i);
            for (int i = 0; i < 60; i++)
            {
                cbMin.Items.Add(i); cbSec.Items.Add(i);
            }
        }

        void updateCdTimerText()
        {
            if (cdtSec.Length > 0 && cdtMin.Length > 0 && cdtHour.Length > 0)
            {
                string tmp = cdtHour + ":" + cdtMin + ":" + cdtSec;
                txtCdTimer.Text = tmp;
            }
        }

        private void cbHour_TextChanged(object sender, EventArgs e)
        {
            if (cbHour.SelectedIndex <= -1)
            {
                if (cdtHour.Length > 0)
                {
                    cbHour.Text = numCdtHour.ToString();
                }
                else cbHour.Text = "Hour";
            }
            else
            {
                numCdtHour = cbHour.SelectedItem.ToString();
                cdtHour = cbHour.SelectedItem.ToString();
                if (cdtHour.Length == 1) cdtHour = "0" + cdtHour;
            }
            updateCdTimerText();
        }

        private void btnStw_Click(object sender, EventArgs e)
        {
            if (clockMode != 3)
            {
                HideProgBars();
                HideTimer();
                btn1.Visible = false;
                txt_time.Visible = false; txt_date.Visible = false;
                ProgBarSWatch.Size = ProgBarSec.Size;
                txtSWatch.Size = new Size(CdTimer.Width - 100, CdTimer.Height / 5);
                ProgBarSWatch.Location = new Point(this.Width / 2 - CdTimer.Width / 2, this.Height / 2 - CdTimer.Height / 2);
                txtSWatch.Location = new Point(this.Width / 2 - txtCdTimer.Width / 2, this.Height / 2 - txtCdTimer.Height / 2);
                ShowSWatch();
                clockMode = 3;
            }
        }

        int StPs = 0, timerHour = 0, timerMin = 0, timerSec = 0, timerTime = 0, passedTime = 0; //1 = start, 0 = paused

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
        }

        int lapCnt = 0;

        private void btnStpSW_Click(object sender, EventArgs e)
        {
            if (btnStpSW.Text == "Reset")
            {
                swHour = 0;
                swMin = 0;
                swSec = 0;
                txtSWatch.Text = "00:00:00";
                btnStpSW.Enabled = false;
                btnStpSW.Text = "Lap";
                btnStpSW.ForeColor = Color.Gray;
                btnStpSW.BackColor = Color.Gainsboro;
                txtLapList.Text = "";
                lapCnt = 0;
                timer3.Stop();
                btnClock.Enabled = true; btnTimer.Enabled = true;
            }
            else
            {
                lapCnt++;
                string tmp = "Lap " + lapCnt.ToString() + ": " + txtSWatch.Text;
                txtLapList.Text = tmp + "\r\n\r\n" + txtLapList.Text;
            }
        }

        private void btnSrtSW_Click(object sender, EventArgs e)
        {
            if (btnSrtSW.Text=="Start")
            {
                btnStpSW.Enabled = true;
                timer3.Start();
                btnSrtSW.Text = "Stop";
                btnSrtSW.ForeColor = Color.DarkRed;
                btnSrtSW.BackColor = Color.LightCoral;
                btnStpSW.Text = "Lap";
                btnStpSW.ForeColor = Color.Teal;
                btnStpSW.BackColor = Color.PaleTurquoise;
                btnClock.Enabled = false; btnTimer.Enabled = false;
            } else
            {
                timer3.Stop();
                btnSrtSW.Text = "Start";
                btnSrtSW.ForeColor = Color.Green;
                btnSrtSW.BackColor = Color.PaleGreen;
                btnStpSW.Text = "Reset";
                btnStpSW.ForeColor = Color.OrangeRed;
                btnStpSW.BackColor = Color.Cornsilk;
                btnClock.Enabled = true; btnTimer.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            swSec++;
            if (swSec == 60)
            {
                swSec = 0;
                swMin++;
            }
            if (swMin==60)
            {
                swMin = 0;
                swHour++;
            }
            swhs=swHour.ToString();
            if (swhs.Length == 1) swhs = "0" + swhs;
            swms=swMin.ToString();
            if (swms.Length == 1) swms= "0" + swms;
            swss=swSec.ToString();
            if (swss.Length == 1) swss= "0" + swss;
            txtSWatch.Text= swhs+":"+swms+":"+swss;
        }

        private void btnStPs_Click(object sender, EventArgs e)
        {
            if (StPs == 0) //switch from paused/nothing to start
            {
                if (timerHour == 0 && timerMin == 0 && timerSec == 0)
                {
                    btnClock.Enabled = false; btnTimer.Enabled = false; btnStw.Enabled = false;
                    cbHour.Enabled = false; cbMin.Enabled = false; cbSec.Enabled = false;
                    for (int i = 0; i < cdtHour.Length; i++)
                        timerHour = timerHour * 10 + (cdtHour[i] - '0');
                    for (int i = 0; i < cdtMin.Length; i++)
                        timerMin = timerMin * 10 + (cdtMin[i] - '0');
                    for (int i = 0; i < cdtSec.Length; i++)
                        timerSec = timerSec * 10 + (cdtSec[i] - '0');
                    if (cbHour.Text == "Hour") cbHour.Text = "0"; if (cbMin.Text == "Minute") cbMin.Text = "0"; if (cbSec.Text == "Second") cbSec.Text = "0";
                    timerTime = timerSec + timerHour * 3600 + timerMin * 60;
                    CdTimer.Maximum = timerTime;
                    CdTimer.Value = CdTimer.Maximum;
                }
                btnStPs.Text = "Pause";
                timer2.Start();
            }
            else
            {
                timer2.Stop();
                btnStPs.Text = "Play";
            }
            StPs = 1 - StPs;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerTime = timerSec + timerHour * 3600 + timerMin * 60;
            CdTimer.Value = CdTimer.Maximum;
            timer2.Stop();
            btnClock.Enabled = true; btnTimer.Enabled = true; btnStw.Enabled = true;
            cbHour.Enabled = true; cbMin.Enabled = true; cbSec.Enabled = true;
            timerHour = 0; timerMin = 0; timerSec = 0;
            StPs = 0; btnStPs.Text = "Start";
            updateCdTimerText();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            CdTimer.Value--;
            string tmpSec = "", tmpMin = "", tmpHour = "";
            if (timerSec > 0)
            {
                timerSec--;
                tmpSec = timerSec.ToString();
                if (tmpSec.Length == 1) tmpSec = "0" + tmpSec;
                tmpMin = timerMin.ToString();
                if (tmpMin.Length == 1) tmpMin = "0" + tmpMin;
                tmpHour = timerHour.ToString();
                if (tmpHour.Length == 1) tmpHour = "0" + tmpHour;
            }
            else
            {
                if (timerMin > 0)
                {
                    timerMin--;
                    tmpMin = timerMin.ToString();
                    tmpHour = timerHour.ToString();
                    if (tmpHour.Length == 1) tmpHour = "0" + tmpHour;
                    if (tmpMin.Length == 1) tmpMin = "0" + tmpMin;
                    timerSec = 59;
                    tmpSec = timerSec.ToString();
                    if (tmpSec.Length == 1) tmpSec = "0" + tmpSec;
                }
                else
                {
                    if (timerHour > 0)
                    {
                        timerHour--;
                        tmpHour = timerHour.ToString();
                        if (tmpHour.Length == 1) tmpHour = "0" + tmpHour;
                        timerMin = 59;
                        tmpMin = timerMin.ToString();
                        if (tmpMin.Length == 1) tmpMin = "0" + tmpMin;
                        timerSec = 59;
                        tmpSec = timerSec.ToString();
                        if (tmpSec.Length == 1) tmpSec = "0" + tmpSec;
                    }
                }
            }
            txtCdTimer.Text = tmpHour + ":" + tmpMin + ":" + tmpSec;
            if (timerHour == 0 && timerMin == 0 && timerSec == 0)
            {
                { 
                    if (tmpSec.Length == 1) tmpSec = "0" + tmpSec;
                    tmpMin = timerMin.ToString();
                    if (tmpMin.Length == 1) tmpMin = "0" + tmpMin;
                    tmpHour = timerHour.ToString();
                    if (tmpHour.Length == 1) tmpHour = "0" + tmpHour;
                }
                timer2.Stop();
                btnStPs.Text = "Start";
                SystemSounds.Beep.Play();
                MessageBox.Show("        TIME'S UP!!!        ");
                btnClock.Enabled = true; btnTimer.Enabled = true; btnStw.Enabled = true;
                cbHour.Enabled = true; cbMin.Enabled = true; cbSec.Enabled = true;
                StPs = 0;
            }
        }

        private void cbMin_TextChanged(object sender, EventArgs e)
        {
            if (cbMin.SelectedIndex <= -1)
            {
                if (cdtMin.Length > 0)
                {
                    cbMin.Text = numCdtMin.ToString();
                }
                else cbMin.Text = "Minute";
            }
            else
            {
                numCdtMin = cbMin.SelectedItem.ToString();
                cdtMin = cbMin.SelectedItem.ToString();
                if (cdtMin.Length == 1) cdtMin = "0" + cdtMin;
            }
            updateCdTimerText();
        }

        private void cbSec_TextChanged(object sender, EventArgs e)
        {
            if (cbSec.SelectedIndex <= -1)
            {
                if (cdtSec.Length > 0)
                {
                    cbSec.Text = numCdtSec.ToString();
                }
                else cbSec.Text = "Second";
            }
            else
            {
                numCdtSec = cbSec.SelectedItem.ToString();
                cdtSec = cbSec.SelectedItem.ToString();
                if (cdtSec.Length == 1) cdtSec = "0" + cdtSec;
            }
            updateCdTimerText();
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            if (clockMode == 1) return;
            while (DateTime.Now.Second == lastSec)
            {
                Thread.Sleep(10);
            }
            Thread.Sleep(100);
            HideProgBars();
            HideSWatch();
            txt_time.Visible = true; txt_date.Visible = true;
            HideTimer();
            clockMode = 1;
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            CdTimer.Value = 0;
            cdtHour = ""; cdtMin = ""; cdtSec = ""; numCdtHour = ""; numCdtMin = ""; numCdtSec = "";
            cbSec.SelectedIndex = -1; cbMin.SelectedIndex = -1; cbHour.SelectedIndex = -1;
            cbSec.Text = "Second"; cbMin.Text = "Minute"; cbHour.Text = "Hour";
            txtCdTimer.Text = "00:00:00";
            HideProgBars();
            HideSWatch();
            CdTimer.Visible = true;
            btnStPs.Visible = true; btnStop.Visible = true;
            cbSec.Visible= true; cbMin.Visible= true; cbHour.Visible= true;
            btn1.Visible = false;
            txt_time.Visible = false; txt_date.Visible = false;
            txtCdTimer.Visible = true;
            clockMode = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            double angleSec = sec * 6, angleMin = min * 6 + 1.0 * angleSec / 60, angleHour = hour % 12 * 30 + 1.0 * angleMin / 12;
            ProgBarHour.Value = (int)(angleSec);
            ProgBarMin.Value = (int)(angleMin);
            ProgBarSec.Value = (int)(angleHour);
            timer1.Stop(); timer2.Stop();
            HideSWatch();

            //form sizes
            this.Location = new Point(0, 0);
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            //setting Numbers' texts
            {
                txt1.Text = "1"; txt1.Font = txt3.Font;
                txt2.Text = "2"; txt2.Font = txt3.Font;
                txt3.Text = "3";
                txt4.Text = "4"; txt4.Font = txt3.Font;
                txt5.Text = "5"; txt5.Font = txt3.Font;
                txt6.Text = "6";
                txt7.Text = "7"; txt7.Font = txt3.Font;
                txt8.Text = "8"; txt8.Font = txt3.Font;
                txt9.Text = "9";
                txt10.Text = "10"; txt10.Font = txt3.Font;
                txt11.Text = "11"; txt11.Font = txt3.Font;
                txt12.Text = "12";
            }

            //drawing clockhand layer
            ResizeCanvas();

            //time-related settings
            timer1.Start();
            ProgBarHour.Size = new Size(150, 150);
            ProgBarMin.Size = new Size(300, 300);
            ProgBarSec.Size = new Size(500, 500);
            txt_date.Text = DateTime.Now.Date.ToLongDateString();

            if (mode == 1)
            {
                HideProgBars();
            }

            //buttons
            btn1.Text = "No clockhands";
            btn1.Location = new Point(txt3.Location.X+75, this.Height/2 - btn1.Height/2);

            //TIMER SECTION
            CdTimer.Size = ProgBarSec.Size;
            btnStop.Size = new Size(90, 60); btnStPs.Size = new Size(90, 60);
            cbSec.Size = new Size(80, 60); cbMin.Size = new Size(80, 60);  cbHour.Size = new Size(80, 60);
            txtCdTimer.Size = new Size(CdTimer.Width-100, CdTimer.Height/5);
            AddTimeItems();
            

            //RELOCATION
            relocate();
        }

        private void ResizeCanvas()
        {
            Bitmap tmp = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(tmp))
            {
                g.Clear(BackColor);
                if (canvas != null)
                {
                    g.DrawImage(canvas, 0, 0);
                    canvas.Dispose();
                }
            }
            canvas = tmp;
        }

        Point ptSec(int sec)
        {
            double alpha = 2.0 * Math.PI / 60 * sec;
            double radius = 180;
            int w = (int)(Math.Sin(alpha) * radius);
            int h = (int)(Math.Cos(alpha) * radius);
            return new Point(this.Width/2 + w, this.Height/2 - h);
        }

        Point ptMin(int min)
        {
            double alpha = 2.0 * Math.PI / 60 * min + (2.0*Math.PI/60*sec)/60;
            double radius = 140;
            int w = (int)(Math.Sin(alpha) * radius);
            int h = (int)(Math.Cos(alpha) * radius);
            return new Point(this.Width / 2 + w, this.Height / 2 - h);
        }

        Point ptMinErase(int min)
        {
            double alpha = 2.0 * Math.PI / 60 * min + (2.0 * Math.PI / 60 * sec) / 60;
            double radius = 145;
            int w = (int)(Math.Sin(alpha) * radius);
            int h = (int)(Math.Cos(alpha) * radius);
            return new Point(this.Width / 2 + w, this.Height / 2 - h);
        }

        Point ptHour(int hour)
        {
            double alpha = 2.0 * Math.PI / 12 * hour + (2.0 * Math.PI / 60 * min + (2.0 * Math.PI / 60 * sec) / 60)/12;
            double radius = 100;
            int w = (int)(Math.Sin(alpha) * radius);
            int h = (int)(Math.Cos(alpha) * radius);
            return new Point(this.Width / 2 + w, this.Height / 2 - h);
        }

        Point ptHourErase(int hour)
        {
            double alpha = 2.0 * Math.PI / 12 * hour + (2.0 * Math.PI / 60 * min + (2.0 * Math.PI / 60 * sec) / 60) / 12;
            double radius = 105;
            int w = (int)(Math.Sin(alpha) * radius);
            int h = (int)(Math.Cos(alpha) * radius);
            return new Point(this.Width / 2 + w, this.Height / 2 - h);
        }

        Point ptPos(int hour)
        {
            double alpha = 2.0 * Math.PI / 12 * hour;
            double radius = 220;
            int w = (int)(Math.Sin(alpha) * radius);
            int h = (int)(Math.Cos(alpha) * radius);
            if (hour%3 == 0)
                return new Point(this.Width / 2 + w - txt3.Width/2, this.Height / 2 - h - txt3.Height/2);
            else
                return new Point(this.Width / 2 + w - txt1.Width / 2, this.Height / 2 - h - txt1.Height / 2);
        }

        Point ptPos2(int hour)
        {
            double alpha = 2.0 * Math.PI / 12 * hour;
            double radius = 200;
            int w = (int)(Math.Sin(alpha) * radius);
            int h = (int)(Math.Cos(alpha) * radius);
            if (hour % 3 == 0)
                return new Point(this.Width / 2 + w - txt3.Width / 2, this.Height / 2 - h - txt3.Height / 2);
            else
                return new Point(this.Width / 2 + w - txt1.Width / 2, this.Height / 2 - h - txt1.Height / 2);
        }

        void DrawClock()
        {
            Graphics g = Graphics.FromImage(canvas);
            g = this.CreateGraphics();
            Pen p;
            if (lastSec != -1)
            {
                p = new Pen(BackColor, pSec.Width); g.DrawLine(p, center, ptSec(lastSec));
            }
            if (lastHour != -1)
            {
                p = new Pen(BackColor, pHour.Width + 3);
                g.DrawLine(p, center, ptHourErase(lastHour));
            }
            g.DrawLine(pHour, center, ptHour(hour));
            if (lastMin != -1)
            {
                p = new Pen(BackColor, pMin.Width + 3); g.DrawLine(p, center, ptMinErase(lastMin));
            }
            g.DrawLine(pMin, center, ptMin(min));
            g.DrawLine(pSec, center, ptSec(sec));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec = DateTime.Now.Second; min = DateTime.Now.Minute; hour = DateTime.Now.Hour;

            if (sec != lastSec || min != lastMin || hour != lastHour)
            {
                //set time
                time = DateTime.Now.ToString("hh:mm:ss");
                AmPm = DateTime.Now.ToString("tt");
                txt_time.Text = time + ' ' + AmPm;
                double angleSec = sec * 6, angleMin = min * 6 + 1.0 * angleSec / 60, angleHour = hour%12 * 30 + 1.0 * angleMin / 12;
                ProgBarHour.Value = (int)(angleHour);
                ProgBarMin.Value = (int)(angleMin);
                ProgBarSec.Value = (int)(angleSec);

                DrawClock();

                //save new time
                lastSec = sec; lastMin = min; lastHour = hour;
            }
        }
    }
}
