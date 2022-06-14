using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        private int elapsedTime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbStatus_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                btnStart.Text = "시작";
            }
            else
            {
                timer1.Enabled = true;
                btnStart.Text = "멈춤";
            }
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           

            this.elapsedTime++;
            this.lablStatus.Text = this.elapsedTime + "초 경과";
            this.tbStatus.Text = this.elapsedTime + "초 경과";
            this.toolStripProgressBar1.Value = this.elapsedTime;
            if(toolStripProgressBar1.Maximum == toolStripProgressBar1.Value)
            {
                timer1.Enabled=false;
            }
        }

      
    }
}
