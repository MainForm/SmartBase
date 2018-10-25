using System;
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


        public Toilet()
        {
            InitializeComponent();
        }

        private void Toilet_Load(object sender, EventArgs e)
        {
            //CheckForIllegalCrossThreadCalls = false;
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
        }

        private void Toilet_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Toilet_Paint(object sender, PaintEventArgs e)
        {

            for (int i = 0; i < 5; i++)
            {

                //TRm[i].DrawRoom(e.Graphics, 322, 25 + (i * (TRm[i].Height + 30)));
            }

        }

        public void ExcuteCommand(string cmd)
        {
            string[] Params = cmd.Split(new char[] { ' ' });


            if (Params[0] == "OPEN")
            {
                int RoomNum = 0;
                int.TryParse(Params[1], out RoomNum);
                //                maskedTextBox1.Text = "00:00";
            }
            else if (Params[0] == "CLOSE")
            {
                int RoomNum = 0;
                int.TryParse(Params[1], out RoomNum);
                //maskedTextBox1.Text = "";
            }

            Invalidate();
        }

        public int CntUsingRoom()
        {
            int cnt = 0;

            /*
            foreach (TltRoom t in TRm)
            {
                if (t.IsDoorOpen == false)
                    cnt++;
            }
            */
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
}