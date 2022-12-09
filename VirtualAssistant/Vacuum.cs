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
    public partial class Vacuum : Form
    {
        bool buttonflag = false;
        bool dustflag = false;
        bool actionflag = false;
        public Vacuum()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Vacuum_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddDays(1);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().ShowDialog();
            this.Close();
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
            pictureBox6.Visible = false;
            richTextBox1.Visible = false;
            timer1.Enabled = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'ON' του διακόπτη για να ενεργοποιήσετε τις λειτουργίες της ηλεκτρικής σκούπας.";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'OFF' του διακόπτη για να απενεργοποιήσετε τις λειτουργίες της ηλεκτρικής σκούπας.";
        }

        private void checkedListBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να επιλέξετε από τη λίστα τα δωμάτια τα οποία θέλετε να επεξεργαστείτε.";
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'Αρχικό Μενού' για να μεταβείτε στη φόρμα του αρχικού μενού.";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddDays(1);
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Απενεργοποιήσατε τον χρονοδιακόπτη.";
            button7.MouseEnter -= new EventHandler(this.button7_MouseEnter);
            button8.MouseEnter -= new EventHandler(this.button8_MouseEnter);
            buttonflag = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Ενεργοποιήσατε τον χρονοδιακόπτη για την ημερομηνία " + dateTimePicker1.Text + ".";
            button7.MouseEnter -= new EventHandler(this.button7_MouseEnter);
            button8.MouseEnter -= new EventHandler(this.button8_MouseEnter);
            buttonflag = true;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'ON' για να ενεργοποιήσετε τον χρονοδιακόπτη.";
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'OFF' για να απενεργοποιήσετε τον χρονοδιακόπτη.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Αδειάσατε τον συλλέκτη σκόνης.";
            panel1.MouseEnter -= new EventHandler(this.panel1_MouseEnter);
            dustflag = true;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μέσω του συλλέκτη σκόνης μπορείτε να δείτε πόση σκόνη έχει συλλέξει η σκούπα. Μπορείτε να πατήσετε το κουμπί 'Άδειασμα Dust Collector' για να αδειάσετε το απόθεμα σκόνης.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dustflag)
            {
                panel1.MouseEnter += new EventHandler(this.panel1_MouseEnter);
                dustflag = false;
            }
            if (buttonflag)
            {
                button7.MouseEnter += new EventHandler(this.button7_MouseEnter);
                button8.MouseEnter += new EventHandler(this.button8_MouseEnter);
                buttonflag = false;
            }
            if (actionflag)
            {
                panel2.MouseEnter += new EventHandler(this.panel2_MouseEnter);
                actionflag = false;
            }
            checkedListBox1.Enabled = true;
            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Enabled = false;
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            pictureBox2.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            for (int i = 0; i <= 6; i++)
                checkedListBox1.SetItemChecked(i, false);
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;

            if (checkedListBox1.SelectedIndex == 0)
            {
                for (int i = 1; i <= 6; i++)
                    checkedListBox1.SetItemChecked(i, true);
            }
            else
            {
                checkedListBox1.SetItemChecked(0, false);
            }

            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                if (itemChecked.ToString() == "Σαλόνι")
                    pictureBox2.Visible = true;
                if (itemChecked.ToString() == "Κρεβατοκάμαρα")
                    pictureBox9.Visible = true;
                if (itemChecked.ToString() == "Παιδικό Δωμάτιο")
                    pictureBox10.Visible = true;
                if (itemChecked.ToString() == "Μπάνιο")
                    pictureBox11.Visible = true;
                if (itemChecked.ToString() == "Κουζίνα")
                    pictureBox12.Visible = true;
                if (itemChecked.ToString() == "Γκαράζ")
                    pictureBox13.Visible = true;
            }
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να επιλέξετε την λειτουργία της ηλεκτρικής σκούπας επιλέγοντας μία από τις εξής: AUTO CLEANING, EDGE CLEANING, MANUAL CONTROL.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Ενεργοποιήσατε την λειτουργία AUTO CLEANING.";
            panel2.MouseEnter -= new EventHandler(this.panel2_MouseEnter);
            actionflag = true;
            label15.Text = "Λειτουργία: AUTO CLEANING";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Ενεργοποιήσατε την λειτουργία EDGE CLEANING.";
            panel2.MouseEnter -= new EventHandler(this.panel2_MouseEnter);
            actionflag = true;
            label15.Text = "Λειτουργία: EDGE CLEANING";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Ενεργοποιήσατε την λειτουργία MANUAL CONTROL.";
            panel2.MouseEnter -= new EventHandler(this.panel2_MouseEnter);
            actionflag = true;
            label15.Text = "Λειτουργία: MANUAL CONTROL";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "virtualassistant.chm", HelpNavigator.TopicId, "60");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.virtualassistanthelppressed1;
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Πατήστε το κουμπί 'ΒΟΗΘΕΙΑ' για περισσότερες πληροφορίες πάνω στις λειτουργίες της εφαρμογής.";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.virtualassistanthelp;
        }
    }
}
