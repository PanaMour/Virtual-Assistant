using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualAssistant
{
    public partial class ShoeCase : Form
    {
        public ShoeCase()
        {
            InitializeComponent();
        }

        string activity = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            activity = label1.Text;
            this.Hide();
            new ShoeAvailability(activity).ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            activity = label3.Text;
            this.Hide();
            new ShoeAvailability(activity).ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            activity = label4.Text;
            this.Hide();
            new ShoeAvailability(activity).ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            activity = label5.Text;
            this.Hide();
            new ShoeAvailability(activity).ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            activity = label6.Text;
            this.Hide();
            new ShoeAvailability(activity).ShowDialog();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            activity = label7.Text;
            this.Hide();
            new ShoeAvailability(activity).ShowDialog();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            activity = label8.Text;
            this.Hide();
            new ShoeAvailability(activity).ShowDialog();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            activity = "ΔΥΣΜΕΝΕΙΣ ΚΑΙΡΙΚΕΣ ΣΥΝΘΗΚΕΣ";
            this.Hide();
            new ShoeAvailability(activity).ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().ShowDialog();
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "virtualassistant.chm", HelpNavigator.TopicId, "80");
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.virtualassistanthelppressed1;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.virtualassistanthelp;
        }
    }
}
