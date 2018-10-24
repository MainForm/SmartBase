﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MillSuppoter
{

    public partial class Toilet : Form
    {
        private TltRoom[] TRm;
        private Timer[] Tmr;
        private DateTime[] dt;

        public Toilet()
        {
            TRm = new TltRoom[5];
            Tmr = new Timer[5];
            dt = new DateTime[5];
         
            
            for (int i = 0; i < 5; i++)
            {
                TRm[i] = new TltRoom(this);
                Tmr[i] = new Timer();
                dt[i] = new DateTime();
                dt[i] = DateTime.Parse("00:00:00");
                Tmr[i].Interval = 1000;
            }

            Tmr[0].Tick += Toilet_Tick1;
            Tmr[1].Tick += Toilet_Tick2;
            Tmr[2].Tick += Toilet_Tick3;
            Tmr[3].Tick += Toilet_Tick4;
            Tmr[4].Tick += Toilet_Tick5;

            InitializeComponent();
        }

        private void Toilet_Tick1(object sender, EventArgs e)
        {
            maskedTextBox1.Text = dt[0].ToString("mm:ss");
            dt[0].AddSeconds(1);
            
        }
        private void Toilet_Tick2(object sender, EventArgs e)
        {

        }
        private void Toilet_Tick3(object sender, EventArgs e)
        {

        }
        private void Toilet_Tick4(object sender, EventArgs e)
        {

        }
        private void Toilet_Tick5(object sender, EventArgs e)
        {

        }

        private void Toilet_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

      

        }

        private void Toilet_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Toilet_Paint(object sender, PaintEventArgs e)
        {

            for (int i = 0; i < 5; i++)
            {

                TRm[i].DrawRoom(e.Graphics, 322, 25 + (i * (TRm[i].Height + 30)));
            }

        }

        public void ExcuteCommand(string cmd)
        {
            string[] Params = cmd.Split(new char[] { ' ' });


            if (Params[0] == "OPEN")
            {
                int RoomNum = 0;
                int.TryParse(Params[1], out RoomNum);

                TRm[RoomNum].IsDoorOpen = true;
                Tmr[RoomNum].Start();
                maskedTextBox1.Text = "01:10";
            }
            else if (Params[0] == "CLOSE")
            {
                int RoomNum = 0;
                int.TryParse(Params[1], out RoomNum);

                TRm[RoomNum].IsDoorOpen = false;
            }
            

            Invalidate();
        }

        public int CntUsingRoom()
        {
            int cnt = 0;

            foreach (TltRoom t in TRm)
            {
                if (t.IsDoorOpen == false)
                    cnt++;
            }
            return cnt;
        }



        public void SetTime(DateTime dt)
        {
            this.Text = dt.ToString("mm:ss");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

    public class TltRoom
    {
        private bool DoorStatus;
        private bool WaterStatus;
        private Pen pBlue, pRed;
        private DateTime dt;
        public int Height { get { return 100; } }
        public int Width { get { return 101; } }
        Toilet t;

        public bool IsDoorOpen { get { return DoorStatus; } set { DoorStatus = value; } }
        public bool IsWaterOverflow { get { return WaterStatus; } set { WaterStatus = value; } }

        public TltRoom(Toilet T)
        {
            t = T;
            IsDoorOpen = false;
            IsWaterOverflow = false;

            pBlue = new Pen(Color.Blue);
            pRed = new Pen(Color.Red);

            dt = new DateTime();
            dt = DateTime.Parse("00:10:10");
        }

        public void DrawRoom(Graphics g, int x, int y)
        {
            Pen tPen;

            if (this.IsDoorOpen == false)
                tPen = pBlue;
            else
                tPen = pRed;

            g.DrawRectangle(tPen, new Rectangle(x - 1, y - 1, Width + 1, Height + 1));
        }
    }
}