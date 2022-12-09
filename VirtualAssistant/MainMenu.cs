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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.virtualassistant;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.virtualassistantrob;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Καλωσόρισες χρήστη, είμαι ο Rob το ρομπότ και ο προσωπικός σου έξυπνος βοηθός!";
        }

        public void TextLeave(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            richTextBox1.Visible = false;
            timer1.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
            this.Close();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μέσω του Πλάνου Ημέρας μπορείτε να οργανώσετε τις δραστηριότητες της ημέρας σας με τη βοήθειά μου και να δείτε αναλυτικές διαδρομές για τις μετακινήσεις σας.";
        }
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να επιλέξετε με ποια έξυπνη ηλεκτρική συσκευή θέλετε να αλληλεπιδράσετε (Φώτα, Κλιματιστικό, Ηλεκτρική Σκούπα, Πλυντήριο) και να μεταβείτε στην αντίστοιχη φόρμα ώστε να ρυθμίσετε τις λειτουργίες της.";
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μέσω της Έξυπνης Παπουτσοθήκης μπορείτε να δείτε τα διαθέσιμα παπούτσια που έχετε στην παπουτσοθήκη σας ανάλογα την δραστηριότητα που επιλέξετε. Σε περίπτωση που δεν σας επαρκούν τα ήδη υπάρχοντα παπούτσια σας μπορείτε να μεταβείτε στο ESHOP και να αγοράσετε άλλα προτεινόμενα.";
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μέσω της Αυτόματης Ταΐστρας μπορείτε να εντοπίσετε την θέση των κατοικιδίων σας μέσα στο σπίτι και να προγραμματίσετε τάισμα για όποια ημερομηνία επιθυμείτε.";
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new ShoeCase().ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new AutomaticFeeder().ShowDialog();
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

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            new DailyPlan().ShowDialog();
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.virtualassistanthelppressed1;
            pictureBox6.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Πατήστε το κουμπί 'ΒΟΗΘΕΙΑ' για περισσότερες πληροφορίες πάνω στις λειτουργίες της εφαρμογής.";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory +"virtualassistant.chm", HelpNavigator.TopicId,"10");
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.virtualassistanthelp;
        }
    }
}
