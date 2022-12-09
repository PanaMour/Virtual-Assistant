using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualAssistant
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().ShowDialog();
            this.Close();
        }

        public void TextLeave(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            richTextBox1.Visible = false;
            timer1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Σαλόνι")
            {
                pictureBox1.Image = Properties.Resources.livingroom;
            }
            else if(comboBox1.SelectedItem.ToString() == "Κρεβατοκάμαρα")
            {
                pictureBox1.Image = Properties.Resources.bedroom;
            }
            else if (comboBox1.SelectedItem.ToString() == "Παιδικό Δωμάτιο")
            {
                pictureBox1.Image = Properties.Resources.kidsbedroom;
            }
            else if (comboBox1.SelectedItem.ToString() == "Μπάνιο")
            {
                pictureBox1.Image = Properties.Resources.bathroom;
            }
            else if (comboBox1.SelectedItem.ToString() == "Κουζίνα")
            {
                pictureBox1.Image = Properties.Resources.kitchen;
            }
            else if (comboBox1.SelectedItem.ToString() == "Γκαράζ")
            {
                pictureBox1.Image = Properties.Resources.garage;
            }
            trackBar1.Value = 4;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if(trackBar1.Value == 0)
            {
                if(comboBox1.SelectedItem.ToString() == "Σαλόνι")
                {
                    pictureBox1.Image = Properties.Resources.livingroom0;
                }
                else if (comboBox1.SelectedItem.ToString() == "Κρεβατοκάμαρα")
                {
                    pictureBox1.Image = Properties.Resources.bedroom0;
                }
                else if (comboBox1.SelectedItem.ToString() == "Παιδικό Δωμάτιο")
                {
                    pictureBox1.Image = Properties.Resources.kidsbedroom0;
                }
                else if (comboBox1.SelectedItem.ToString() == "Μπάνιο")
                {
                    pictureBox1.Image = Properties.Resources.bathroom0;
                }
                else if (comboBox1.SelectedItem.ToString() == "Κουζίνα")
                {
                    pictureBox1.Image = Properties.Resources.kitchen0;
                }
                else if (comboBox1.SelectedItem.ToString() == "Γκαράζ")
                {
                    pictureBox1.Image = Properties.Resources.garage0;
                }
            }
            else if (trackBar1.Value == 1)
            {
                if (comboBox1.SelectedItem.ToString() == "Σαλόνι")
                {
                    pictureBox1.Image = Properties.Resources.livingroom1;
                }
                else if (comboBox1.SelectedItem.ToString() == "Κρεβατοκάμαρα")
                {
                    pictureBox1.Image = Properties.Resources.bedroom1;
                }
                else if (comboBox1.SelectedItem.ToString() == "Παιδικό Δωμάτιο")
                {
                    pictureBox1.Image = Properties.Resources.kidsbedroom1;
                }
                else if (comboBox1.SelectedItem.ToString() == "Μπάνιο")
                {
                    pictureBox1.Image = Properties.Resources.bathroom1;
                }
                else if (comboBox1.SelectedItem.ToString() == "Κουζίνα")
                {
                    pictureBox1.Image = Properties.Resources.kitchen1;
                }
                else if (comboBox1.SelectedItem.ToString() == "Γκαράζ")
                {
                    pictureBox1.Image = Properties.Resources.garage1;
                }
            }
            else if (trackBar1.Value == 2)
            {
                if (comboBox1.SelectedItem.ToString() == "Σαλόνι")
                {
                    pictureBox1.Image = Properties.Resources.livingroom2;
                }
                else if (comboBox1.SelectedItem.ToString() == "Κρεβατοκάμαρα")
                {
                    pictureBox1.Image = Properties.Resources.bedroom2;
                }
                else if (comboBox1.SelectedItem.ToString() == "Παιδικό Δωμάτιο")
                {
                    pictureBox1.Image = Properties.Resources.kidsbedroom2;
                }
                else if (comboBox1.SelectedItem.ToString() == "Μπάνιο")
                {
                    pictureBox1.Image = Properties.Resources.bathroom2;
                }
                else if (comboBox1.SelectedItem.ToString() == "Κουζίνα")
                {
                    pictureBox1.Image = Properties.Resources.kitchen2;
                }
                else if (comboBox1.SelectedItem.ToString() == "Γκαράζ")
                {
                    pictureBox1.Image = Properties.Resources.garage2;
                }
            }
            else if (trackBar1.Value == 3)
            {
                if (comboBox1.SelectedItem.ToString() == "Σαλόνι")
                {
                    pictureBox1.Image = Properties.Resources.livingroom3;
                }
                else if (comboBox1.SelectedItem.ToString() == "Κρεβατοκάμαρα")
                {
                    pictureBox1.Image = Properties.Resources.bedroom30;
                }
                else if (comboBox1.SelectedItem.ToString() == "Παιδικό Δωμάτιο")
                {
                    pictureBox1.Image = Properties.Resources.kidsbedroom3;
                }
                else if (comboBox1.SelectedItem.ToString() == "Μπάνιο")
                {
                    pictureBox1.Image = Properties.Resources.bathroom3;
                }
                else if (comboBox1.SelectedItem.ToString() == "Κουζίνα")
                {
                    pictureBox1.Image = Properties.Resources.kitchen3;
                }
                else if (comboBox1.SelectedItem.ToString() == "Γκαράζ")
                {
                    pictureBox1.Image = Properties.Resources.garage3;
                }
            }
            else if (trackBar1.Value == 4)
            {
                if (comboBox1.SelectedItem.ToString() == "Σαλόνι")
                {
                    pictureBox1.Image = Properties.Resources.livingroom;
                }
                else if (comboBox1.SelectedItem.ToString() == "Κρεβατοκάμαρα")
                {
                    pictureBox1.Image = Properties.Resources.bedroom;
                }
                else if (comboBox1.SelectedItem.ToString() == "Παιδικό Δωμάτιο")
                {
                    pictureBox1.Image = Properties.Resources.kidsbedroom;
                }
                else if (comboBox1.SelectedItem.ToString() == "Μπάνιο")
                {
                    pictureBox1.Image = Properties.Resources.bathroom;
                }
                else if (comboBox1.SelectedItem.ToString() == "Κουζίνα")
                {
                    pictureBox1.Image = Properties.Resources.kitchen;
                }
                else if (comboBox1.SelectedItem.ToString() == "Γκαράζ")
                {
                    pictureBox1.Image = Properties.Resources.garage;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μετακινώντας την γραμμή κύλισης μπορείτε να μεταβάλλετε τη φωτεινότητα του δωματίου.";
        }
        private void resetTimer()
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                timer1.Start();
            }
            else
                timer1.Enabled = true;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'ON' για να ανάψει το φως του δωματίου.";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'OFF' για να σβήσει το φως του δωματίου.";
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να επιλέξετε από τη λίστα το δωμάτιο το οποίο θέλετε να επεξεργαστείτε.";
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'Αρχικό Μενού' για να μεταβείτε στη φόρμα του αρχικού μενού.";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "virtualassistant.chm", HelpNavigator.TopicId, "40");
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.virtualassistanthelppressed1;
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Πατήστε το κουμπί 'ΒΟΗΘΕΙΑ' για περισσότερες πληροφορίες πάνω στις λειτουργίες της εφαρμογής.";
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.virtualassistanthelp;
        }
    }
}
