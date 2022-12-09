using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualAssistant
{
    public partial class WashingMachine : Form
    {
        bool buttonflag = false;
        bool detergentflag = false;
        bool basketflag = false;
        bool actionflag = false;
        public WashingMachine()
        {
            InitializeComponent();
        }

        private void WashingMachine_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddDays(1);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Αδειάσατε το φόρτο του κάδου.";
            panel1.MouseEnter -= new EventHandler(this.panel1_MouseEnter);
            basketflag = true;
        }

        private void button16_Click(object sender, EventArgs e)
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
            pictureBox9.Visible = false;
            richTextBox1.Visible = false;
            timer1.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Ενεργοποιήσατε τον χρονοδιακόπτη για την ημερομηνία " + dateTimePicker1.Text + ".";
            button7.MouseEnter -= new EventHandler(this.button7_MouseEnter);
            button8.MouseEnter -= new EventHandler(this.button8_MouseEnter);
            buttonflag = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddDays(1);
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Απενεργοποιήσατε τον χρονοδιακόπτη.";
            button7.MouseEnter -= new EventHandler(this.button7_MouseEnter);
            button8.MouseEnter -= new EventHandler(this.button8_MouseEnter);
            buttonflag = true;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'ON' για να ενεργοποιήσετε τον χρονοδιακόπτη.";
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'OFF' για να απενεργοποιήσετε τον χρονοδιακόπτη.";
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μέσω του κάδου ρούχων μπορείτε να δείτε με πόσα ρούχα έχει γεμίσει το πλυντήριο. Μπορείτε να πατήσετε το κουμπί 'Άδειασμα Κάδου' για να βάλετε τα ρούχα στο καλάθι.";
        }

        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να επιλέξετε την λειτουργία του πλυντηρίου επιλέγοντας μία από τις εξής: ΒΑΜΒΑΚΕΡΑ, ΚΟΥΡΤΙΝΕΣ, ΜΑΛΛΙΝΑ, ΣΥΝΘΕΤΙΚΑ, ECO, ΕΥΑΙΣΘΗΤΑ. Στις κατηγορίες ΒΑΜΒΑΚΕΡΑ, ΜΑΛΛΙΝΑ, ΣΥΝΘΕΤΙΚΑ και ΕΥΑΙΣΘΗΤΑ μπορείτε να επιλέξετε τη θερμοκρασία του πλυντηρίου. Αφού επιλέξετε λειτουργία πατήστε το κουμπί ΕΚΚΙΝΗΣΗ.";
        }

        private void panel9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να επιλέξετε απορρυπαντικό σε μορφή σκόνης ή υγρό επιλέγοντας το αντίστοιχο κουμπί και στη συνέχεια μπορείτε να προσθέσετε μαλακτικό επιλέγοντας το κουτάκι Προσθήκη Μαλακτικού.";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Επιλέξατε το Απορρυπαντικό Σκόνης.";
            panel9.MouseEnter -= new EventHandler(this.panel9_MouseEnter);
            detergentflag = true;
            label17.Text = "Απορρυπαντικό Σκόνης";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Επιλέξατε το Υγρό Απορρυπαντικό.";
            panel9.MouseEnter -= new EventHandler(this.panel9_MouseEnter);
            detergentflag = true;
            label17.Text = "Υγρό Απορρυπαντικό";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            if (checkBox1.Checked)
            {
                richTextBox1.Text = "Προσθέσατε το μαλακτικό.";
            }
            else
            {
                richTextBox1.Text = "Αφαιρέσατε το μαλακτικό.";
            }
            panel9.MouseEnter -= new EventHandler(this.panel9_MouseEnter);
            detergentflag = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (basketflag)
            {
                panel1.MouseEnter += new EventHandler(this.panel1_MouseEnter);
                basketflag = false;
            }
            if (buttonflag)
            {
                button7.MouseEnter += new EventHandler(this.button7_MouseEnter);
                button8.MouseEnter += new EventHandler(this.button8_MouseEnter);
                buttonflag = false;
            }
            if (detergentflag)
            {
                panel9.MouseEnter += new EventHandler(this.panel9_MouseEnter);
                detergentflag = false;
            }
            if (actionflag)
            {
                panel10.MouseEnter += new EventHandler(this.panel10_MouseEnter);
                panel2.MouseEnter += new EventHandler(this.panel10_MouseEnter);
                panel8.MouseEnter += new EventHandler(this.panel10_MouseEnter);
                panel4.MouseEnter += new EventHandler(this.panel10_MouseEnter);
                panel5.MouseEnter += new EventHandler(this.panel10_MouseEnter);
                panel6.MouseEnter += new EventHandler(this.panel10_MouseEnter);
                panel7.MouseEnter += new EventHandler(this.panel10_MouseEnter);
                pictureBox1.MouseEnter += new EventHandler(this.panel10_MouseEnter);
                actionflag = false;
            }
            panel9.Enabled = true;
            panel3.Enabled = true;
            panel2.Enabled = true;
            panel4.Enabled = true;
            panel5.Enabled = true;
            panel6.Enabled = true;
            panel7.Enabled = true;
            panel8.Enabled = true;
            panel10.Enabled = true;
            button15.Enabled = true;
            pictureBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel9.Enabled = false;
            panel3.Enabled = false;
            panel2.Enabled = false;
            panel4.Enabled = false;
            panel5.Enabled = false;
            panel6.Enabled = false;
            panel7.Enabled = false;
            panel8.Enabled = false;
            panel10.Enabled = false;
            pictureBox1.Enabled = false;
            button15.Enabled = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'ON' του διακόπτη για να ενεργοποιήσετε τις λειτουργίες του πλυντηρίου.";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'OFF' του διακόπτη για να απενεργοποιήσετε τις λειτουργίες του πλυντηρίου.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.knobcotton;
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Επιλέξατε τη λειτουργία ΒΑΜΒΑΚΕΡΑ.";
            panel10.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel2.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel8.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel4.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel5.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel6.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel7.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            pictureBox1.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            actionflag = true;
            label15.Text = "Επιλεγμένη Λειτουργία: ΒΑΜΒΑΚΕΡΑ";
            trackBar3.Enabled = true;
            trackBar2.Enabled = false;
            trackBar1.Enabled = false;
            trackBar4.Enabled = false;
            label16.Visible = true;
            label16.Text = "Επιλεγμένη Θερμοκρασία: " + trackBar3.Value + "°C";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.knobcurtains;
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Επιλέξατε τη λειτουργία ΚΟΥΡΤΙΝΕΣ.";
            panel10.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel2.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel8.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel4.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel5.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel6.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel7.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            pictureBox1.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            actionflag = true;
            label15.Text = "Επιλεγμένη Λειτουργία: ΚΟΥΡΤΙΝΕΣ";
            label16.Visible = false;
            trackBar3.Enabled = false;
            trackBar2.Enabled = false;
            trackBar1.Enabled = false;
            trackBar4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.knobwool;
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Επιλέξατε τη λειτουργία ΜΑΛΛΙΝΑ.";
            panel10.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel2.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel8.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel4.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel5.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel6.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel7.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            pictureBox1.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            actionflag = true;
            label15.Text = "Επιλεγμένη Λειτουργία: ΜΑΛΛΙΝΑ";
            trackBar3.Enabled = false;
            trackBar2.Enabled = false;
            trackBar1.Enabled = true;
            trackBar4.Enabled = false;
            label16.Visible = true;
            label16.Text = "Επιλεγμένη Θερμοκρασία: " + trackBar1.Value + "°C";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.knobsynthetics;
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Επιλέξατε τη λειτουργία ΣΥΝΘΕΤΙΚΑ.";
            panel10.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel2.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel8.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel4.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel5.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel6.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel7.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            pictureBox1.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            actionflag = true;
            label15.Text = "Επιλεγμένη Λειτουργία: ΣΥΝΘΕΤΙΚΑ";
            trackBar3.Enabled = false;
            trackBar2.Enabled = false;
            trackBar1.Enabled = false;
            trackBar4.Enabled = true;
            label16.Visible = true;
            label16.Text = "Επιλεγμένη Θερμοκρασία: " + trackBar4.Value + "°C";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.knobeco;
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Επιλέξατε τη λειτουργία ECO.";
            panel10.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel2.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel8.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel4.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel5.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel6.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel7.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            pictureBox1.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            actionflag = true;
            label15.Text = "Επιλεγμένη Λειτουργία: ECO";
            label16.Visible = false;
            trackBar3.Enabled = false;
            trackBar2.Enabled = false;
            trackBar1.Enabled = false;
            trackBar4.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.knobsensitive;
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Επιλέξατε τη λειτουργία ΕΥΑΙΣΘΗΤΑ.";
            panel10.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel2.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel8.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel4.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel5.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel6.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            panel7.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            pictureBox1.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
            actionflag = true;
            label15.Text = "Επιλεγμένη Λειτουργία: ΕΥΑΙΣΘΗΤΑ";
            trackBar3.Enabled = false;
            trackBar2.Enabled = true;
            trackBar1.Enabled = false;
            trackBar4.Enabled = false;
            label16.Visible = true;
            label16.Text = "Επιλεγμένη Θερμοκρασία: " + trackBar2.Value + "°C";
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            label16.Text = "Επιλεγμένη Θερμοκρασία: " + trackBar2.Value + "°C";
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            label16.Text = "Επιλεγμένη Θερμοκρασία: " + trackBar3.Value + "°C";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label16.Text = "Επιλεγμένη Θερμοκρασία: " + trackBar1.Value + "°C";
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            label16.Text = "Επιλεγμένη Θερμοκρασία: " + trackBar4.Value + "°C";
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'Αρχικό Μενού' για να μεταβείτε στη φόρμα του αρχικού μενού.";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value == 0)
            {
                pictureBox9.Visible = true;
                richTextBox1.Visible = true;
                resetTimer();
                panel10.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
                panel2.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
                panel8.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
                panel4.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
                panel5.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
                panel6.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
                panel7.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
                pictureBox1.MouseEnter -= new EventHandler(this.panel10_MouseEnter);
                actionflag = true;
                if (label16.Visible && checkBox1.Checked)
                    richTextBox1.Text = "Το πλυντήριο ξεκινά να δουλεύει με " + label15.Text + " σε " + label16.Text + " χρησιμοποιώντας " + label17.Text + " και προσθέτοντας μαλακτικό.";
                else if (label16.Visible && !checkBox1.Checked)
                    richTextBox1.Text = "Το πλυντήριο ξεκινά να δουλεύει με " + label15.Text + " σε " + label16.Text + " χρησιμοποιώντας " + label17.Text + ".";
                else if (!label16.Visible && checkBox1.Checked)
                    richTextBox1.Text = "Το πλυντήριο ξεκινά να δουλεύει με " + label15.Text + " χρησιμοποιώντας " + label17.Text + " και προσθέτοντας μαλακτικό.";
                else
                    richTextBox1.Text = "Το πλυντήριο ξεκινά να δουλεύει με " + label15.Text + " χρησιμοποιώντας " + label17.Text + ".";
                Random random = new Random();
                progressBar1.Value = random.Next(20,100);
            }
            else
            {
                pictureBox9.Visible = true;
                richTextBox1.Visible = true;
                resetTimer();
                richTextBox1.Text = "Για να ξεκινήσει να δουλεύει το πλυντήριο πρέπει πρώτα να αδειάσετε τον κάδο των ρούχων.";
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "virtualassistant.chm", HelpNavigator.TopicId, "70");
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.virtualassistanthelppressed1;
            pictureBox9.Visible = true;
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
