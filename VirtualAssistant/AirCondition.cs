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
    public partial class AirCondition : Form
    {
        bool buttonflag = false;
        bool actionflag = false;
        bool flowflag = false;
        public AirCondition()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label8.Text = trackBar1.Value.ToString() + " °C";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AirCondition_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddDays(1);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker1.MinDate = DateTime.Now;
            comboBox1.SelectedIndex = 0;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonflag)
            {
                button3.MouseEnter += new EventHandler(this.button3_MouseEnter);
                button4.MouseEnter += new EventHandler(this.button4_MouseEnter);
                buttonflag = false;
            }
            if (actionflag)
            {
                panel5.MouseEnter += new EventHandler(this.panel5_MouseEnter);
                actionflag = false;
            }
            if (flowflag)
            {
                panel1.MouseEnter += new EventHandler(this.panel1_MouseEnter);
                flowflag = false;
            }
            panel1.Enabled = true;
            panel4.Enabled = true;
            panel5.Enabled = true;
            trackBar1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            dateTimePicker1.Enabled = true;            
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
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
        public void TextLeave(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            richTextBox1.Visible = false;
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel5.Enabled = false;
            trackBar1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            dateTimePicker1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να επιλέξετε από τη λίστα το δωμάτιο το οποίο θέλετε να επεξεργαστείτε.";
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'Αρχικό Μενού' για να μεταβείτε στη φόρμα του αρχικού μενού.";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μετακινώντας την γραμμή κύλισης μπορείτε να μεταβάλλετε τη θερμοκρασία του δωματίου.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Ενεργοποιήσατε τον χρονοδιακόπτη για την ημερομηνία "+dateTimePicker1.Text + ".";
            button3.MouseEnter -= new EventHandler(this.button3_MouseEnter);
            button4.MouseEnter -= new EventHandler(this.button4_MouseEnter);
            buttonflag = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddDays(1);
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Απενεργοποιήσατε τον χρονοδιακόπτη.";
            button3.MouseEnter -= new EventHandler(this.button3_MouseEnter);
            button4.MouseEnter -= new EventHandler(this.button4_MouseEnter);
            buttonflag = true;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Ενεργοποιήσατε την λειτουργία ΘΕΡΜΑΝΣΗ.";
            panel5.MouseEnter -= new EventHandler(this.panel5_MouseEnter);
            actionflag = true;

        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Ενεργοποιήσατε την λειτουργία ΨΥΞΗ.";
            panel5.MouseEnter -= new EventHandler(this.panel5_MouseEnter);
            actionflag = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Ενεργοποιήσατε την λειτουργία ΑΦΥΓΡΑΝΣΗ.";
            panel5.MouseEnter -= new EventHandler(this.panel5_MouseEnter);
            actionflag = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Ενεργοποιήσατε την λειτουργία ΑΥΤΟΜΑΤΗ.";
            panel5.MouseEnter -= new EventHandler(this.panel5_MouseEnter);
            actionflag = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Ενεργοποιήσατε την λειτουργία ΡΟΗ ΑΕΡΑ ΚΑΘΕΤΑ.";
            panel1.MouseEnter -= new EventHandler(this.panel1_MouseEnter);
            flowflag = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Ενεργοποιήσατε την λειτουργία ΡΟΗ ΑΕΡΑ ΟΡΙΖΟΝΤΙΑ.";
            panel1.MouseEnter -= new EventHandler(this.panel1_MouseEnter);
            flowflag = true;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να επιλέξετε την ροή αέρα του κλιματιστικού επιλέγοντας είτε την κάθετη είτε την οριζόντια.";
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να επιλέξετε την λειτουργία του κλιματιστικού επιλέγοντας μία από τις εξής: ΘΕΡΜΑΝΣΗ, ΨΥΞΗ, ΑΦΥΓΡΑΝΣΗ, ΑΥΤΟΜΑΤΗ.";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().ShowDialog();
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'ON' του τηλεχειριστηρίου για να ενεργοποιήσετε τις λειτουργίες του κλιματιστικού.";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'OFF' του τηλεχειριστηρίου για να απενεργοποιήσετε τις λειτουργίες του κλιματιστικού.";
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'ON' για να ενεργοποιήσετε τον χρονοδιακόπτη.";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'OFF' του τηλεχειριστηρίου για να απενεργοποιήσετε τον χρονοδιακόπτη.";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "virtualassistant.chm", HelpNavigator.TopicId, "50");
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.virtualassistanthelppressed1;
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Πατήστε το κουμπί 'ΒΟΗΘΕΙΑ' για περισσότερες πληροφορίες πάνω στις λειτουργίες της εφαρμογής.";
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.virtualassistanthelp;
        }
    }
}
