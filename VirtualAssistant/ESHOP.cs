using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualAssistant
{
    public partial class ESHOP : Form
    {
        string store = "Shoe City";
        double price1 = 0;
        double price2 = 0;
        double price3 = 0;
        double totalprice = 0;
        string model1 = "";
        string model2 = "";
        string model3 = "";
        string activ = "";
        bool flag1 = false;
        bool flag2 = false;
        bool flag3 = false;
        string totalmodel = "";
        public ESHOP()
        {
            InitializeComponent();
        }

        public void TextChange(string activity)
        {
            switch (activity)
            {
                case "ΠΕΡΠΑΤΗΜΑ":
                    if (!flag1)
                    {
                        pictureBox1.Image = Properties.Resources.rebookblackwhiteshoes;
                        model1 = "Reebok Ασπρόμαυρα";
                        if (store == "Shoe City")
                            price1 = 43.99;
                        else if (store == "Chris' Shoes")
                            price1 = 68.00;
                        else if (store == "Real Shoes")
                            price1 = 59.99;
                        radioButton1.Text = model1 + " " + price1.ToString() + "€";
                    }
                    if (!flag2)
                    {
                        pictureBox2.Image = Properties.Resources.filashoes;
                        model2 = "Αθλητικά FILA";
                        if (store == "Shoe City")
                            price2 = 55.00;
                        else if (store == "Chris' Shoes")
                            price2 = 65.00;
                        else if (store == "Real Shoes")
                            price2 = 51.99;
                        radioButton4.Text = model2 + " " + price2.ToString() + "€";
                    }
                    if (!flag3)
                    {
                        pictureBox3.Image = Properties.Resources.leathershoes;
                        model3 = "Δερμάτινα Παπούτσια";
                        if (store == "Shoe City")
                            price3 = 75.99;
                        else if (store == "Chris' Shoes")
                            price3 = 69.99;
                        else if (store == "Real Shoes")
                            price3 = 72.99;
                        radioButton2.Text = model3 + " " + price3.ToString() + "€";
                    }
                    break;
                case "ΕΡΓΑΣΙΑ":
                    if (!flag1)
                    {
                        pictureBox1.Image = Properties.Resources.sneakerbw;
                        model1 = "Sneaker Ασπρόμαυρα";
                        if (store == "Shoe City")
                            price1 = 109.99;
                        else if (store == "Chris' Shoes")
                            price1 = 98.00;
                        else if (store == "Real Shoes")
                            price1 = 101.99;
                        radioButton1.Text = model1 + " " + price1.ToString() + "€";
                    }
                    if (!flag2)
                    {
                        pictureBox2.Image = Properties.Resources.chukkaboots;
                        model2 = "Δερμάτινες Καφέ Μπότες";
                        price2 = 120.00;
                        if (store == "Shoe City")
                            price2 = 120.00;
                        else if (store == "Chris' Shoes")
                            price2 = 119.00;
                        else if (store == "Real Shoes")
                            price2 = 108.90;
                        radioButton4.Text = model2 + " " + price2.ToString() + "€";
                    }
                    if (!flag3)
                    {
                        pictureBox3.Image = Properties.Resources.blackshoes;
                        model3 = "Eberdon Μαύρα Παπούτσια";
                        if (store == "Shoe City")
                            price3 = 117.39;
                        else if (store == "Chris' Shoes")
                            price3 = 113.00;
                        else if (store == "Real Shoes")
                            price3 = 127.00;
                        radioButton2.Text = model3 + " " + price3.ToString() + "€";
                    }
                    break;
                case "ΓΑΜΟΣ/ΒΑΠΤΙΣΗ":
                    if (!flag1)
                    {
                        pictureBox1.Image = Properties.Resources.blackshoes;
                        model1 = "Eberdon Μαύρα Παπούτσια";
                        if (store == "Shoe City")
                            price1 = 117.39;
                        else if (store == "Chris' Shoes")
                            price1 = 113.00;
                        else if (store == "Real Shoes")
                            price1 = 127.00;
                        radioButton1.Text = model1 + " " + price1.ToString() + "€";
                    }
                    if (!flag2)
                    {
                        pictureBox2.Image = Properties.Resources.formalshoes;
                        model2 = "Επίσημα Μαύρα Παπούτσια";
                        if (store == "Shoe City")
                            price2 = 90.00;
                        else if (store == "Chris' Shoes")
                            price2 = 98.00;
                        else if (store == "Real Shoes")
                            price2 = 103.00;
                        radioButton4.Text = model2 + " " + price2.ToString() + "€";
                    }
                    if (!flag3)
                    {
                        pictureBox3.Image = Properties.Resources.oxfordshoes;
                        model3 = "Oxford Μαύρα";
                        if (store == "Shoe City")
                            price3 = 70.00;
                        else if (store == "Chris' Shoes")
                            price3 = 67.99;
                        else if (store == "Real Shoes")
                            price3 = 69.30;
                        radioButton2.Text = model3 + " " + price3.ToString() + "€";
                    }
                    break;
                case "ΣΩΜΑΤΙΚΗ ΑΣΚΗΣΗ":
                    if (!flag1)
                    {
                        pictureBox1.Image = Properties.Resources.anthrakishoes;
                        model1 = "Αθλητικά σε Ανθρακί";
                        if (store == "Shoe City")
                            price1 = 28.99;
                        else if (store == "Chris' Shoes")
                            price1 = 30.00;
                        else if (store == "Real Shoes")
                            price1 = 32.99;
                        radioButton1.Text = model1 + " " + price1.ToString() + "€";
                    }
                    if (!flag2)
                    {
                        pictureBox2.Image = Properties.Resources.filashoes;
                        model2 = "Αθλητικά FILA";
                        if (store == "Shoe City")
                            price2 = 55.00;
                        else if (store == "Chris' Shoes")
                            price2 = 65.00;
                        else if (store == "Real Shoes")
                            price2 = 51.99;
                        radioButton4.Text = model2 + " " + price2.ToString() + "€";
                    }
                    if (!flag3)
                    {
                        pictureBox3.Image = Properties.Resources.jordansshoes;
                        model3 = "Nike Jordan Max Aura 3";
                        if (store == "Shoe City")
                            price3 = 86.39;
                        else if (store == "Chris' Shoes")
                            price3 = 90.99;
                        else if (store == "Real Shoes")
                            price3 = 86.90;
                        radioButton2.Text = model3 + " " + price3.ToString() + "€";
                    }
                    break;
                case "ΣΠΙΤΙ":
                    if (!flag1)
                    {
                        pictureBox1.Image = Properties.Resources.uggslipper;
                        model1 = "UGG Παντόφλες";
                        if (store == "Shoe City")
                            price1 = 59.99;
                        else if (store == "Chris' Shoes")
                            price1 = 70.00;
                        else if (store == "Real Shoes")
                            price1 = 65.99;
                        radioButton1.Text = model1 + " " + price1.ToString() + "€";
                    }
                    if (!flag2)
                    {
                        pictureBox2.Image = Properties.Resources.guccislippers;
                        model2 = "Gucci Παντόφλες";
                        if (store == "Shoe City")
                            price2 = 199.00;
                        else if (store == "Chris' Shoes")
                            price2 = 200.00;
                        else if (store == "Real Shoes")
                            price2 = 189.99;
                        radioButton4.Text = model2 + " " + price2.ToString() + "€";
                    }
                    if (!flag3)
                    {
                        pictureBox3.Image = Properties.Resources.gucciflipflops;
                        model3 = "Gucci Σαγιονάρες";
                        if (store == "Shoe City")
                            price3 = 360.99;
                        else if (store == "Chris' Shoes")
                            price3 = 358.00;
                        else if (store == "Real Shoes")
                            price3 = 364.99;
                        radioButton2.Text = model3 + " " + price3.ToString() + "€";
                    }
                    break;
                case "ΠΑΡΑΛΙΑ":
                    if (!flag1)
                    {
                        pictureBox1.Image = Properties.Resources.aquabeach;
                        model1 = "Racqua Water Shoes";
                        if (store == "Shoe City")
                            price1 = 35.99;
                        else if (store == "Chris' Shoes")
                            price1 = 39.00;
                        else if (store == "Real Shoes")
                            price1 = 31.99;
                        radioButton1.Text = model1 + " " + price1.ToString() + "€";
                    }
                    if (!flag2)
                    {
                        pictureBox2.Image = Properties.Resources.flipflop;
                        model2 = "Under Armour Άσπρα";
                        if (store == "Shoe City")
                            price2 = 35.00;
                        else if (store == "Chris' Shoes")
                            price2 = 38.90;
                        else if (store == "Real Shoes")
                            price2 = 29.99;
                        radioButton4.Text = model2 + " " + price2.ToString() + "€";
                    }
                    if (!flag3)
                    {
                        pictureBox3.Image = Properties.Resources.nikeflipflop;
                        model3 = "Nike Σαγιονάρες";
                        if (store == "Shoe City")
                            price3 = 40.00;
                        else if (store == "Chris' Shoes")
                            price3 = 42.00;
                        else if (store == "Real Shoes")
                            price3 = 38.99;
                        radioButton2.Text = model3 + " " + price3.ToString() + "€";
                    }
                    break;
                case "ΝΥΧΤΕΡΙΝΗ ΕΞΟΔΟΣ":
                    if (!flag1)
                    {
                        pictureBox1.Image = Properties.Resources.oxfordshoes;
                        model1 = "Oxford Μαύρα";
                        if (store == "Shoe City")
                            price1 = 70.00;
                        else if (store == "Chris' Shoes")
                            price1 = 74.00;
                        else if (store == "Real Shoes")
                            price1 = 67.99;
                        radioButton1.Text = model1 + " " + price1.ToString() + "€";
                    }
                    if (!flag2)
                    {
                        pictureBox2.Image = Properties.Resources.partyshoes;
                        model2 = "Πορτοκαλί Παπούτσια";
                        if (store == "Shoe City")
                            price2 = 27.99;
                        else if (store == "Chris' Shoes")
                            price2 = 35.90;
                        else if (store == "Real Shoes")
                            price2 = 25.99;
                        radioButton4.Text = model2 + " " + price2.ToString() + "€";
                    }
                    if (!flag3)
                    {
                        pictureBox3.Image = Properties.Resources.jordansshoes;
                        model3 = "Nike Jordan Max Aura 3";
                        if (store == "Shoe City")
                            price3 = 86.39;
                        else if (store == "Chris' Shoes")
                            price3 = 90.99;
                        else if (store == "Real Shoes")
                            price3 = 86.90;
                        radioButton2.Text = model3 + " " + price3.ToString() + "€";
                    }
                    break;
                case "ΔΥΣΜΕΝΕΙΣ ΚΑΙΡΙΚΕΣ ΣΥΝΘΗΚΕΣ":
                    if (!flag1)
                    {
                        pictureBox1.Image = Properties.Resources.hikingshoes;
                        model1 = "Quechua Μαύρα";
                        if (store == "Shoe City")
                            price1 = 55.79;
                        else if (store == "Chris' Shoes")
                            price1 = 57.90;
                        else if (store == "Real Shoes")
                            price1 = 51.99;
                        radioButton1.Text = model1 + " " + price1.ToString() + "€";
                    }
                    if (!flag2)
                    {
                        pictureBox2.Image = Properties.Resources.watershoes;
                        model2 = "Αδιάβροχες Μπότες";
                        if (store == "Shoe City")
                            price2 = 30.00;
                        else if (store == "Chris' Shoes")
                            price2 = 34.99;
                        else if (store == "Real Shoes")
                            price2 = 28.99;
                        radioButton4.Text = model2 + " " + price2.ToString() + "€";
                    }
                    if (!flag3)
                    {
                        pictureBox3.Image = Properties.Resources.chukkaboots;
                        model3 = "Δερμάτινες Καφέ Μπότες";
                        if (store == "Shoe City")
                            price3 = 120.00;
                        else if (store == "Chris' Shoes")
                            price3 = 117.00;
                        else if (store == "Real Shoes")
                            price3 = 126.99;
                        radioButton2.Text = model3 + " " + price3.ToString() + "€";
                    }
                        break;
            }
        }

        public ESHOP(string activity)
        {
            InitializeComponent();
            activ = activity;
            label3.Text = "Κατηγορία: " + activ;
            TextChange(activ);
            pictureBox6.Visible = true;
            richTextBox2.Visible = true;
            resetTimer();
            richTextBox2.Text = "Εδώ μπορείτε να αγοράσετε κάποια παπούτσια ανάλογα με την δραστηριότητα που επιλέξατε. Αρχικά, επιλέξτε το κατάστημα από το οποίο επιθυμείτε να αγοράσετε και στη συνέχεια εισάγετε τα στοιχεία της κάρτας σας (Αριθμός Κάρτας, CVV) στα αντίστοιχα πεδία της φόρμας. Έπειτα, πατήστε το κουμπί ΑΓΟΡΑ όταν βρείτε ένα παπούτσι της αρεσκείας σας.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            store = "Shoe City";
            label1.Text = "Παπούτσια καταστήματος " + store + ":";
            TextChange(activ);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            store = "Chris' Shoes";
            label1.Text = "Παπούτσια καταστήματος " + store + ":";
            TextChange(activ);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            store = "Real Shoes";
            label1.Text = "Παπούτσια καταστήματος " + store + ":";
            TextChange(activ);
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

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox2.Visible = true;
            resetTimer();

            if ((textBox1.TextLength == 16 && Regex.Match(textBox1.Text, "^[0-9]+$").Success) && ((textBox2.TextLength == 3 || textBox2.TextLength == 4) && Regex.Match(textBox2.Text, "^[0-9]+$").Success))
            {
                if (radioButton1.Checked)
                {
                    totalprice += price1;
                    if (totalmodel != "")
                    {
                        richTextBox2.Text = "Παραγγείλατε επιτυχώς τα: " + totalmodel + " και προσθέθηκαν τα " + model1 + " από το κατάστημα " + store + " με συνολικό κόστος " + totalprice.ToString() + "€";
                        totalmodel = totalmodel + ", " + model1;
                    }
                    else
                    {
                        totalmodel = model1;
                        richTextBox2.Text = "Παραγγείλατε επιτυχώς τα: " + totalmodel + " από το κατάστημα " + store + " με συνολικό κόστος " + totalprice.ToString() + "€";
                    }
                    radioButton1.Checked = false;
                    radioButton1.Enabled = false;
                    radioButton1.Text = "OUT OF STOCK";
                    flag1 = true;
                    if (!flag2)
                    {
                        radioButton4.Checked = true;
                    }
                    else if (!flag3)
                    {
                        radioButton2.Checked = true;
                    }
                }
                else if (radioButton4.Checked)
                {
                    totalprice += price2;
                    if (totalmodel != "")
                    {
                        richTextBox2.Text = "Παραγγείλατε επιτυχώς τα: " + totalmodel + " και προσθέθηκαν τα " + model2 + " από το κατάστημα " + store + " με συνολικό κόστος " + totalprice.ToString() + "€";
                        totalmodel = totalmodel + ", " + model2;
                    }
                    else
                    {
                        totalmodel = model2;
                        richTextBox2.Text = "Παραγγείλατε επιτυχώς τα: " + totalmodel + " από το κατάστημα " + store + " με συνολικό κόστος " + totalprice.ToString() + "€";
                    }
                    radioButton4.Checked = false;
                    radioButton4.Enabled = false;
                    radioButton4.Text = "OUT OF STOCK";
                    flag2 = true;
                    if (!flag1)
                    {
                        radioButton1.Checked = true;
                    }
                    else if (!flag3)
                    {
                        radioButton2.Checked = true;
                    }
                }
                else if (radioButton2.Checked)
                {
                    totalprice += price3;
                    if (totalmodel != "")
                    {
                        richTextBox2.Text = "Παραγγείλατε επιτυχώς τα: " + totalmodel + " και προσθέθηκαν τα " + model3 + " από το κατάστημα " + store + " με συνολικό κόστος " + totalprice.ToString() + "€";
                        totalmodel = totalmodel + ", " + model3;
                    }
                    else
                    {
                        totalmodel = model3;
                        richTextBox2.Text = "Παραγγείλατε επιτυχώς τα: " + totalmodel + " από το κατάστημα " + store + " με συνολικό κόστος " + totalprice.ToString() + "€";
                    }
                    radioButton2.Checked = false;
                    radioButton2.Enabled = false;
                    radioButton2.Text = "OUT OF STOCK";
                    flag3 = true;
                    if (!flag1)
                    {
                        radioButton1.Checked = true;
                    }
                    else if (!flag2)
                    {
                        radioButton4.Checked = true;
                    }
                }
            }
            else
            {
                pictureBox6.Visible = true;
                richTextBox2.Visible = true;
                resetTimer();
                richTextBox2.Text = "Πρέπει να συμπληρώσετε τα κατάλληλα στοιχεία της κάρτας σας για να αγοράσετε ένα ζευγάρι παπούτσια.";
            }

            if (flag1 && flag2 && flag3)
                {
                    button1.MouseEnter -= new EventHandler(this.button1_MouseEnter);
                    button2.MouseEnter -= new EventHandler(this.button1_MouseEnter);
                    button3.MouseEnter -= new EventHandler(this.button1_MouseEnter);
                    button4.Enabled = false;
                }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            richTextBox2.Visible = true;
            resetTimer();
            richTextBox2.Text = "Εδώ μπορείτε να αγοράσετε κάποια παπούτσια ανάλογα με την δραστηριότητα που επιλέξατε. Αρχικά, επιλέξτε το κατάστημα από το οποίο επιθυμείτε να αγοράσετε και στη συνέχεια πατήστε το κουμπί ΑΓΟΡΑ όταν βρείτε ένα παπούτσι της αρεσκείας σας.";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "virtualassistant.chm", HelpNavigator.TopicId, "100");
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
