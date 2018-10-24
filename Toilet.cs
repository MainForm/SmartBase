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
        private Pen pBlue, pRed;
        private TltRoom[] TRm;

        public Toilet()
        {
            TRm = new TltRoom[5];

            for (int i = 0; i < 5; i++)
                TRm[i] = new TltRoom();

            InitializeComponent();
        }

        private void Toilet_Load(object sender, EventArgs e)
        {
            pBlue = new Pen(Color.Blue);
            pRed = new Pen(Color.Red);

        }

        private void Toilet_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Toilet_Paint(object sender, PaintEventArgs e)
        {
            const int RectWitdh = 100;
            const int RectHeight = 120;

            Pen pTemp;
            for (int i = 0; i < 5; i++)
            {
                if (TRm[i].IsDoorOpen == false)
                    pTemp = pBlue;
                else
                    pTemp = pRed;

                e.Graphics.DrawRectangle(pTemp, new Rectangle(10 + (i * (RectWitdh + 10)), 40, RectWitdh, RectHeight));
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
            }
            else if(Params[0] == "CLOSE")
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

            foreach(TltRoom t in TRm)
            {
                if (t.IsDoorOpen == false)
                    cnt++;
            }
            return cnt;
        }
           
    }

    public class TltRoom
    {
        private bool DoorStatus;
        private bool WaterStatus;

        public bool IsDoorOpen { get { return DoorStatus; } set { DoorStatus = value; } }
        public bool IsWaterOverflow { get { return WaterStatus; } set { WaterStatus = value; } }

        public TltRoom()
        {
            IsDoorOpen = false;
            IsWaterOverflow = false;
        }
        

    }
}
