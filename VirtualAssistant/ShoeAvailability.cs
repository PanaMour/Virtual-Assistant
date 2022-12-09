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
    public partial class ShoeAvailability : Form
    {
        string activ = "";
        public ShoeAvailability()
        {
            InitializeComponent();
        }
        
        public ShoeAvailability(string activity)
        {
            activ = activity;
            InitializeComponent();
            label2.Text = "Για την δραστηριότητα " + activ + " υπάρχουν τα εξής διαθέσιμα παπούτσια:";
            switch (activity)
            {
                case "ΠΕΡΠΑΤΗΜΑ":
                    richTextBox1.Text = "";
                    pictureBox2.Image = Properties.Resources.nikeblack;
                    radioButton4.Text = "NIKE Μαύρα";
                    richTextBox1.AppendText("Παπούτσια " + radioButton4.Text + Environment.NewLine);
                    pictureBox3.Image = Properties.Resources.airforce;
                    radioButton1.Text = "Airforce1 Άσπρα";
                    richTextBox1.AppendText("Παπούτσια " + radioButton1.Text + Environment.NewLine);
                    pictureBox2.Visible = true;
                    radioButton4.Visible = true;
                    pictureBox3.Visible = true;
                    radioButton1.Visible = true;
                    pictureBox4.Visible = false;
                    radioButton2.Visible = false;
                    pictureBox5.Visible = false;
                    radioButton3.Visible = false;
                    break;
                case "ΕΡΓΑΣΙΑ":
                    richTextBox1.Text = "";
                    pictureBox2.Image = Properties.Resources.formal2;
                    radioButton4.Text = "Σκαρπίνια Μπορντό";
                    richTextBox1.AppendText(radioButton4.Text + Environment.NewLine);
                    pictureBox3.Image = Properties.Resources.formal3;
                    radioButton1.Text = "Σκαρπίνια Ταμπά";
                    richTextBox1.AppendText(radioButton1.Text + Environment.NewLine);
                    pictureBox4.Image = Properties.Resources.weather2;
                    radioButton2.Text = "Δερμάτινα Μποτάκια";
                    richTextBox1.AppendText(radioButton2.Text + Environment.NewLine);
                    pictureBox2.Visible = true;
                    radioButton4.Visible = true;
                    pictureBox3.Visible = true;
                    radioButton1.Visible = true;
                    pictureBox4.Visible = true;
                    radioButton2.Visible = true;
                    pictureBox5.Visible = false;
                    radioButton3.Visible = false;
                    break;
                case "ΓΑΜΟΣ/ΒΑΠΤΙΣΗ":
                    richTextBox1.Text = "";
                    pictureBox2.Image = Properties.Resources.formal2;
                    radioButton4.Text = "Σκαρπίνια Μπορντό";
                    richTextBox1.AppendText(radioButton4.Text + Environment.NewLine);
                    pictureBox3.Image = Properties.Resources.formal3;
                    radioButton1.Text = "Σκαρπίνια Ταμπά";
                    richTextBox1.AppendText(radioButton1.Text + Environment.NewLine);
                    pictureBox4.Image = Properties.Resources.formal4;
                    radioButton2.Text = "Κλειστά Παπούτσια Χακί";
                    richTextBox1.AppendText(radioButton2.Text + Environment.NewLine);
                    pictureBox2.Visible = true;
                    radioButton4.Visible = true;
                    pictureBox3.Visible = true;
                    radioButton1.Visible = true;
                    pictureBox4.Visible = true;
                    radioButton2.Visible = true;
                    pictureBox5.Visible = false;
                    radioButton3.Visible = false;
                    break;
                case "ΣΩΜΑΤΙΚΗ ΑΣΚΗΣΗ":
                    richTextBox1.Text = "";
                    pictureBox2.Image = Properties.Resources.nikeblack;
                    radioButton4.Text = "NIKE Μαύρο";
                    richTextBox1.AppendText("Παπούτσια "+radioButton4.Text + Environment.NewLine);
                    pictureBox3.Image = Properties.Resources.adidasredblack;
                    radioButton1.Text = "Adidas Κόκκινο/Μαύρο";
                    richTextBox1.AppendText("Παπούτσια "+ radioButton1.Text + Environment.NewLine);
                    pictureBox4.Image = Properties.Resources.asicsblue;
                    radioButton2.Text = "Asics Μπλε";
                    richTextBox1.AppendText("Παπούτσια " + radioButton2.Text + Environment.NewLine );
                    pictureBox2.Visible = true;
                    radioButton4.Visible = true;
                    pictureBox3.Visible = true;
                    radioButton1.Visible = true;
                    pictureBox4.Visible = true;
                    radioButton2.Visible = true;
                    pictureBox5.Visible = false;
                    radioButton3.Visible = false;
                    break;
                case "ΣΠΙΤΙ":
                    richTextBox1.Text = "";
                    pictureBox2.Image = Properties.Resources.slipper;
                    radioButton4.Text = "Parex Παντόφλες Γκρι";
                    richTextBox1.AppendText(radioButton4.Text + Environment.NewLine);
                    pictureBox3.Image = Properties.Resources.beach4;
                    radioButton1.Text = "Adidas Aquaslides";
                    richTextBox1.AppendText(radioButton1.Text + Environment.NewLine);
                    pictureBox4.Image = Properties.Resources.adiddasslipper;
                    radioButton2.Text = "Σαγιονάρες Μαύρες";
                    richTextBox1.AppendText(radioButton2.Text + Environment.NewLine);
                    pictureBox2.Visible = true;
                    radioButton4.Visible = true;
                    pictureBox3.Visible = true;
                    radioButton1.Visible = true;
                    pictureBox4.Visible = true;
                    radioButton2.Visible = true;
                    pictureBox5.Visible = false;
                    radioButton3.Visible = false;
                    break;
                case "ΠΑΡΑΛΙΑ":
                    richTextBox1.Text = "";
                    pictureBox2.Image = Properties.Resources.adiddasslipper;
                    radioButton4.Text = "Σαγιονάρες Μαύρες";
                    richTextBox1.AppendText(radioButton4.Text + Environment.NewLine);
                    pictureBox3.Image = Properties.Resources.beach4;
                    radioButton1.Text = "Adidas Aquaslides";
                    richTextBox1.AppendText(radioButton1.Text + Environment.NewLine);
                    pictureBox4.Image = Properties.Resources.beach2;
                    radioButton2.Text = "Crocs Navy";
                    richTextBox1.AppendText("Παπούτσια " + radioButton2.Text + Environment.NewLine);
                    pictureBox5.Image = Properties.Resources.beach3;
                    radioButton3.Text = "Crocs Μαύρα";
                    richTextBox1.AppendText("Παπούτσια " + radioButton3.Text + Environment.NewLine);
                    pictureBox2.Visible = true;
                    radioButton4.Visible = true;
                    pictureBox3.Visible = true;
                    radioButton1.Visible = true;
                    pictureBox4.Visible = true;
                    radioButton2.Visible = true;
                    pictureBox5.Visible = true;
                    radioButton3.Visible = true;
                    break;
                case "ΝΥΧΤΕΡΙΝΗ ΕΞΟΔΟΣ":
                    richTextBox1.Text = "";
                    pictureBox2.Image = Properties.Resources.airforce;
                    radioButton4.Text = "Airforce1 Άσπρα";
                    richTextBox1.AppendText("Παπούτσια " + radioButton4.Text + Environment.NewLine);
                    pictureBox3.Image = Properties.Resources.weather2;
                    radioButton1.Text = "Δερμάτινα Μποτάκια";
                    richTextBox1.AppendText(radioButton1.Text + Environment.NewLine);
                    pictureBox4.Image = Properties.Resources.yeezys;
                    radioButton2.Text = "Adidas Yeezys Γκρι";
                    richTextBox1.AppendText("Παπούτσια " + radioButton2.Text + Environment.NewLine);
                    pictureBox2.Visible = true;
                    radioButton4.Visible = true;
                    pictureBox3.Visible = true;
                    radioButton1.Visible = true;
                    pictureBox4.Visible = true;
                    radioButton2.Visible = true;
                    pictureBox5.Visible = false;
                    radioButton3.Visible = false;
                    break;
                case "ΔΥΣΜΕΝΕΙΣ ΚΑΙΡΙΚΕΣ ΣΥΝΘΗΚΕΣ":
                    richTextBox1.Text = "";
                    pictureBox2.Image = Properties.Resources.weather1;
                    radioButton4.Text = "Timberland Αρβυλάκια";
                    richTextBox1.AppendText(radioButton4.Text + Environment.NewLine);
                    pictureBox3.Image = Properties.Resources.weather2;
                    radioButton1.Text = "Δερμάτινα Μποτάκια";
                    richTextBox1.AppendText(radioButton1.Text + Environment.NewLine);
                    pictureBox4.Image = Properties.Resources.weather3;
                    radioButton2.Text = "Αρβυλάκια Μαύρα";
                    richTextBox1.AppendText(radioButton2.Text + Environment.NewLine);
                    pictureBox2.Visible = true;
                    radioButton4.Visible = true;
                    pictureBox3.Visible = true;
                    radioButton1.Visible = true;
                    pictureBox4.Visible = true;
                    radioButton2.Visible = true;
                    pictureBox5.Visible = false;
                    radioButton3.Visible = false;
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ESHOP(activ).ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().ShowDialog();
            this.Close();
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox2.Visible = true;
            resetTimer();
            richTextBox2.Text = "Μπορείτε να πατήσετε το κουμπί 'Αρχικό Μενού' για να μεταβείτε στη φόρμα του αρχικού μενού.";
        }

        public void TextLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.valogo;
            pictureBox6.Visible = false;
            richTextBox2.Visible = false;
            timer1.Enabled = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseEnter -= new EventHandler(this.pictureBox1_MouseEnter);
            pictureBox2.MouseEnter -= new EventHandler(this.pictureBox1_MouseEnter);
            pictureBox3.MouseEnter -= new EventHandler(this.pictureBox1_MouseEnter);
            pictureBox4.MouseEnter -= new EventHandler(this.pictureBox1_MouseEnter);
            pictureBox5.MouseEnter -= new EventHandler(this.pictureBox1_MouseEnter);
            button1.MouseEnter -= new EventHandler(this.button1_MouseEnter);
            label1.Visible = true;
            pictureBox6.Visible = true;
            richTextBox2.Visible = true;
            resetTimer();
            if (radioButton1.Checked) {
                richTextBox2.Text = "Επιλέξατε το ζευγάρι: " + radioButton1.Text + ".";
                label1.Text = "Επιλεγμένο Ζευγάρι:" + Environment.NewLine + radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                richTextBox2.Text = "Επιλέξατε το ζευγάρι: " + radioButton2.Text + ".";
                label1.Text = "Επιλεγμένο Ζευγάρι:" + Environment.NewLine + radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                richTextBox2.Text = "Επιλέξατε το ζευγάρι: " + radioButton3.Text + ".";
                label1.Text = "Επιλεγμένο Ζευγάρι:" + Environment.NewLine + radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                richTextBox2.Text = "Επιλέξατε το ζευγάρι: " + radioButton4.Text + ".";
                label1.Text = "Επιλεγμένο Ζευγάρι:" + Environment.NewLine + radioButton4.Text;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox2.Visible = true;
            resetTimer();
            richTextBox2.Text = "Μπορείτε να επιλέξετε το ζευγάρι που επιθυμείτε να φορέσετε μέσα από την παπουτσοθήκη.";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox2.Visible = true;
            resetTimer();
            richTextBox2.Text = "Μπορείτε να πατήσετε το κουμπί 'Επιλογή Ζευγαριού' για να επιβεβαιώσετε την επιλογή του ζευγαριού του οποίου θέλετε να φορέσετε.";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox2.Visible = true;
            resetTimer();
            richTextBox2.Text = "Μπορείτε να πατήσετε το κουμπί 'Πρόταση ΝΕΟΥ παπουτσιού' για να μεταβείτε στο E-Shop και να δείτε προτεινόμενα παπούτσια.";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "virtualassistant.chm", HelpNavigator.TopicId, "90");
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.virtualassistanthelppressed1;
            pictureBox6.Visible = true;
            richTextBox2.Visible = true;
            resetTimer();
            richTextBox2.Text = "Πατήστε το κουμπί 'ΒΟΗΘΕΙΑ' για περισσότερες πληροφορίες πάνω στις λειτουργίες της εφαρμογής.";
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.virtualassistanthelp;
        }
    }
}
