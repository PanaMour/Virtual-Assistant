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
    public partial class AutomaticFeeder : Form
    {
        bool flag = true;
        public AutomaticFeeder()
        {
            InitializeComponent();
        }

        public AutomaticFeeder(int hours)
        {
            InitializeComponent();

        }
        string roomcat = "";
        string roomdog = "";
        string dogaccident = "";
        string cataccident = "";
        private void AutomaticFeeder_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int numcat = random.Next(1, 7);
            int numdog = random.Next(1, 7);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker1.MinDate = DateTime.Now;

            switch (numcat)
            {
                case 1:
                    pictureBox8.Visible = true;
                    roomcat = "στο Σαλόνι";
                    cataccident = "Προσοχή! Η γάτα σας γρατζουνάει το καναπέ στο σαλόνι.";
                    break;
                case 2:
                    pictureBox9.Visible = true;
                    roomcat = "στην Κρεβατοκάμαρα";
                    cataccident = "Απίστευτο! Η γάτα σας έριξε την τηλεόραση στην κρεβατοκάμαρα!";
                    break;
                case 3:
                    pictureBox10.Visible = true;
                    roomcat = "στο Παιδικό Δωμάτιο";
                    cataccident = "Ωχ όχι! Η γάτα σας έσκισε τα παπλώματα στο παιδικό δωμάτιο.";
                    break;
                case 4:
                    pictureBox11.Visible = true;
                    roomcat = "στο Μπάνιο";
                    cataccident = "Προσοχή! Η γάτα σας γρατζουνάει τις κουρτίνες στο μπάνιο.";
                    break;
                case 5:
                    pictureBox12.Visible = true;
                    roomcat = "στην Κουζίνα";
                    cataccident = "Ωχ όχι! Η γάτα σας έσπασε ένα πιάτο στην Κουζίνα.";
                    break;
                case 6:
                    pictureBox13.Visible = true;
                    roomcat = "στο Γκαράζ";
                    cataccident = "Προσοχή! Η γάτα σας γρατζουνάει τις ρόδες του ποδηλάτου σας στο γκαράζ.";
                    break;
            }

            switch (numdog)
            {
                case 1:
                    pictureBox14.Visible = true;
                    roomdog = "στο Σαλόνι";
                    dogaccident = "Ωχ, όχι! Ο σκύλος σας έσπασε την λάμπα του σαλονιού.";
                    break;
                case 2:
                    pictureBox15.Visible = true;
                    roomdog = "στην Κρεβατοκάμαρα";
                    dogaccident = "Απίστευτο! Ο σκύλος σας έκανε την ανάγκη του πάνω στα σεντόνια της κρεβατοκάμαρας.";
                    break;
                case 3:
                    pictureBox16.Visible = true;
                    roomdog = "στο Παιδικό Δωμάτιο";
                    dogaccident = "Προσοχή! Ο σκύλος σας έριξε τα βιβλία της βιβλιοθήκης στο παιδικό δωμάτιο.";
                    break;
                case 4:
                    pictureBox17.Visible = true;
                    roomdog = "στο Μπάνιο";
                    dogaccident = "Απίστευτο! Ο σκύλος σας μασουλάει την οδοντόβουρτσά σας στο μπάνιο.";
                    break;
                case 5:
                    pictureBox18.Visible = true;
                    roomdog = "στην Κουζίνα";
                    dogaccident = "Ωχ, όχι! Ο σκύλος σας έφαγε το φαγητό πάνω στο τραπέζι της κουζίνας.";
                    break;
                case 6:
                    pictureBox19.Visible = true;
                    roomdog = "στο Γκαράζ";
                    dogaccident = "Προσοχή! Ο σκύλος σας γέμισε λάσπες το γκαράζ.";
                    break;
            }
            if(roomcat == roomdog)
            {
                richTextBox1.Text = "Ο σκύλος και η γάτα σας βρίσκονται " + roomcat + ".";
            }
            else
            {
                richTextBox1.Text = "Ο σκύλος σας βρίσκεται " + roomdog + " και η γάτα σας βρίσκεται " + roomcat + ".";
            }

            resetTimer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        public void TextLeave(object sender, EventArgs e)
        {
            if (flag)
            {
                panel3.MouseEnter += new EventHandler(this.panel3_MouseEnter);
                panel1.MouseEnter += new EventHandler(this.panel1_MouseEnter);
                button3.MouseEnter += new EventHandler(this.button3_MouseEnter);
                flag = false;
            }
            pictureBox7.Image = Properties.Resources.valogo;
            pictureBox7.Visible = false;
            richTextBox1.Visible = false;
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rng = new Random();
            int accidentDog = rng.Next(1, 11);
            int accidentCat = rng.Next(1, 11);
            if (accidentDog == 1 && accidentCat==1)
            {
                pictureBox7.Image = Properties.Resources.varobanxious;
                richTextBox1.Text = dogaccident + cataccident;
                pictureBox7.Visible = true;
                richTextBox1.Visible = true;
                resetTimer();
                timer2.Interval = 100000;
            }
            else if(accidentDog == 1)
            {
                pictureBox7.Image = Properties.Resources.varobanxious;
                richTextBox1.Text = dogaccident;
                pictureBox7.Visible = true;
                richTextBox1.Visible = true;
                resetTimer();
                timer2.Interval = 100000;
            }
            else if(accidentCat == 1)
            {
                pictureBox7.Image = Properties.Resources.varobanxious;
                richTextBox1.Text = cataccident;
                pictureBox7.Visible = true;
                richTextBox1.Visible = true;
                resetTimer();
                timer2.Interval = 100000;
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int numcat = random.Next(1, 7);
            int numdog = random.Next(1, 7);
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            switch (numcat)
            {
                case 1:
                    pictureBox8.Visible = true;
                    roomcat = "στο Σαλόνι";
                    cataccident = "Προσοχή! Η γάτα σας γρατζουνάει το καναπέ στο σαλόνι.";
                    break;
                case 2:
                    pictureBox9.Visible = true;
                    roomcat = "στην Κρεβατοκάμαρα";
                    cataccident = "Απίστευτο! Η γάτα σας έριξε την τηλεόραση στην κρεβατοκάμαρα!";
                    break;
                case 3:
                    pictureBox10.Visible = true;
                    roomcat = "στο Παιδικό Δωμάτιο";
                    cataccident = "Ωχ όχι! Η γάτα σας έσκισε τα παπλώματα στο παιδικό δωμάτιο.";
                    break;
                case 4:
                    pictureBox11.Visible = true;
                    roomcat = "στο Μπάνιο";
                    cataccident = "Προσοχή! Η γάτα σας γρατζουνάει τις κουρτίνες στο μπάνιο.";
                    break;
                case 5:
                    pictureBox12.Visible = true;
                    roomcat = "στην Κουζίνα";
                    cataccident = "Ωχ όχι! Η γάτα σας έσπασε ένα πιάτο στην Κουζίνα.";
                    break;
                case 6:
                    pictureBox13.Visible = true;
                    roomcat = "στο Γκαράζ";
                    cataccident = "Προσοχή! Η γάτα σας γρατζουνάει τις ρόδες του ποδηλάτου σας στο γκαράζ.";
                    break;
            }

            switch (numdog)
            {
                case 1:
                    pictureBox14.Visible = true;
                    roomdog = "στο Σαλόνι";
                    dogaccident = "Ωχ, όχι! Ο σκύλος σας έσπασε την λάμπα του σαλονιού.";
                    break;
                case 2:
                    pictureBox15.Visible = true;
                    roomdog = "στην Κρεβατοκάμαρα";
                    dogaccident = "Απίστευτο! Ο σκύλος σας έκανε την ανάγκη του πάνω στα σεντόνια της κρεβατοκάμαρας.";
                    break;
                case 3:
                    pictureBox16.Visible = true;
                    roomdog = "στο Παιδικό Δωμάτιο";
                    dogaccident = "Προσοχή! Ο σκύλος σας έριξε τα βιβλία της βιβλιοθήκης στο παιδικό δωμάτιο.";
                    break;
                case 4:
                    pictureBox17.Visible = true;
                    roomdog = "στο Μπάνιο";
                    dogaccident = "Απίστευτο! Ο σκύλος σας μασουλάει την οδοντόβουρτσά σας στο μπάνιο.";
                    break;
                case 5:
                    pictureBox18.Visible = true;
                    roomdog = "στην Κουζίνα";
                    dogaccident = "Ωχ, όχι! Ο σκύλος σας έφαγε το φαγητό πάνω στο τραπέζι της κουζίνας.";
                    break;
                case 6:
                    pictureBox19.Visible = true;
                    roomdog = "στο Γκαράζ";
                    dogaccident = "Προσοχή! Ο σκύλος σας γέμισε λάσπες το γκαράζ.";
                    break;
            }
            if (roomcat == roomdog)
            {
                richTextBox1.Text = "Ο σκύλος και η γάτα σας μεταφέρθηκαν " + roomcat + ".";
            }
            else
            {
                richTextBox1.Text = "Ο σκύλος σας μεταφέρθηκε " + roomdog + " και η γάτα σας μεταφέρθηκε " + roomcat + ".";
            }
            pictureBox7.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.MouseEnter -= new EventHandler(this.panel3_MouseEnter);
            int wdint = Int32.Parse(comboBox2.Text);
            int fdint = Int32.Parse(comboBox1.Text);
            if (progressBar1.Value >= wdint && progressBar2.Value >= fdint && (wdint != 0 || fdint !=0))
            {
                richTextBox1.Text = "Έχει προγραμματιστεί επιτυχώς το τάισμα για την ημερομηνία " + dateTimePicker1.Text + ".";
                pictureBox7.Visible = true;
                richTextBox1.Visible = true;
                resetTimer();
                progressBar1.Value -= wdint;
                progressBar2.Value -= fdint;
            }
            else if(progressBar1.Value < wdint)
            {
                richTextBox1.Text = "Το δοχείο νερού δεν περιέχει την επιλεγμένη ποσότητα νερού. Παρακαλώ επιλέξτε μία μικρότερη ποσότητα ή γεμίστε το δοχείο με νερό.";
                pictureBox7.Visible = true;
                richTextBox1.Visible = true;
                resetTimer();
            }
            else if (progressBar2.Value < fdint)
            {
                richTextBox1.Text = "Το δοχείο τροφής δεν περιέχει την επιλεγμένη ποσότητα τροφής. Παρακαλώ επιλέξτε μία μικρότερη ποσότητα ή γεμίστε το δοχείο με τροφή.";
                pictureBox7.Visible = true;
                richTextBox1.Visible = true;
                resetTimer();
            }
            else
            {
                richTextBox1.Text = "Παρακαλώ επιλέξτε τιμές για τα πεδία νερού και τροφής.";
                pictureBox7.Visible = true;
                richTextBox1.Visible = true;
                resetTimer();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

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

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να δείτε ανα πάσα στιγμή σε ποιο δωμάτιο βρίσκονται τα κατοικίδια σας.";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'Αρχικό Μενού' για να μεταβείτε στη φόρμα του αρχικού μενού.";
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να επιλέξετε την ποσότητα νερού και τροφής που θέλετε να προσφέρετε στα κατοικίδια σας με βάση την ποσότητα που έχει απομείνει στο δοχείο ανάλογα ποια ημερομηνία έχετε επιλέξει.";
        }

        private void button3_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'Αρχικό Μενού' για να μεταβείτε στη φόρμα του αρχικού μενού.";
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "virtualassistant.chm", HelpNavigator.TopicId, "110");
        }

        private void pictureBox22_MouseHover(object sender, EventArgs e)
        {
            pictureBox22.Image = Properties.Resources.virtualassistanthelppressed1;
            pictureBox7.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Πατήστε το κουμπί 'ΒΟΗΘΕΙΑ' για περισσότερες πληροφορίες πάνω στις λειτουργίες της εφαρμογής.";
        }

        private void pictureBox22_MouseLeave(object sender, EventArgs e)
        {
            pictureBox22.Image = Properties.Resources.virtualassistanthelp;
        }
    }
}
