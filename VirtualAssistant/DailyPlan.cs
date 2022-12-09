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
    public partial class DailyPlan : Form
    {
        string destination = "";
        string mins = "";
        string startTime = "";
        string endTime = "";
        string transport = "Αυτοκίνητο";
        Image route;
        int routeTime = 0;
        public DailyPlan()
        {
            InitializeComponent();
        }

        private void DailyPlan_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox7.CheckedItems.Count >= 2)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }
        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox6.CheckedItems.Count >= 2)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }
        private void checkedListBox3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox5.CheckedItems.Count >= 2)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }
        private void checkedListBox4_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox8.CheckedItems.Count >= 2)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            int time;

            if (checkedListBox7.CheckedItems.Count > 0 && checkedListBox6.CheckedItems.Count > 0 && checkedListBox5.CheckedItems.Count > 0 && checkedListBox8.CheckedItems.Count > 0)
            {
                comboBox1.Enabled = true;
                button1.Enabled = true;
                checkBox1.Enabled = true;
                richTextBox2.Text = "";
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                comboBox1.Items.Clear();
                time = 8;
                foreach (object itemChecked in checkedListBox7.CheckedItems)
                {
                    if (checkedListBox7.CheckedItems.Count == 2)
                    {                        
                        richTextBox2.AppendText(itemChecked + " στις " + time.ToString() + " π.μ." + Environment.NewLine);
                        comboBox1.Items.Add(itemChecked + " στις " + time.ToString() + " π.μ.");
                        time += 2;
                    }
                    else if (checkedListBox7.CheckedItems.Count == 1)
                    {
                        richTextBox2.AppendText(itemChecked + " στις 10 π.μ." + Environment.NewLine);
                        comboBox1.Items.Add(itemChecked + " στις 10 π.μ.");
                    }
                }
                time = 12;
                foreach (object itemChecked in checkedListBox6.CheckedItems)
                {
                    if (checkedListBox6.CheckedItems.Count == 2)
                    {
                        richTextBox2.AppendText(itemChecked + " στις " + time.ToString() + " μ.μ." + Environment.NewLine);
                        comboBox1.Items.Add(itemChecked + " στις " + time.ToString() + " μ.μ.");
                        time -= 10;                        
                    }
                    else if (checkedListBox6.CheckedItems.Count == 1)
                    {
                        richTextBox2.AppendText(itemChecked + " στις 2 μ.μ." + Environment.NewLine);
                        comboBox1.Items.Add(itemChecked + " στις 2 μ.μ.");
                    }
                }
                time = 4;
                foreach (object itemChecked in checkedListBox5.CheckedItems)
                {
                    if (checkedListBox5.CheckedItems.Count == 2)
                    {
                        richTextBox2.AppendText(itemChecked + " στις " + time.ToString() + " μ.μ." + Environment.NewLine);
                        comboBox1.Items.Add(itemChecked + " στις " + time.ToString() + " μ.μ.");
                        time += 2;                        
                    }
                    else if (checkedListBox5.CheckedItems.Count == 1)
                    {
                        richTextBox2.AppendText(itemChecked + " στις 6 μ.μ." + Environment.NewLine);
                        comboBox1.Items.Add(itemChecked + " στις 6 μ.μ.");
                    }
                }

                time = 8;
                foreach (object itemChecked in checkedListBox8.CheckedItems)
                {
                    if (checkedListBox8.CheckedItems.Count == 2)
                    {
                        richTextBox2.AppendText(itemChecked + " στις " + time.ToString() + " μ.μ." + Environment.NewLine);
                        comboBox1.Items.Add(itemChecked + " στις " + time.ToString() + " μ.μ.");
                        time += 2;                        
                    }
                    else if (checkedListBox8.CheckedItems.Count == 1)
                    {
                        richTextBox2.AppendText(itemChecked + " στις 8 μ.μ." + Environment.NewLine);
                        comboBox1.Items.Add(itemChecked + " στις 8 μ.μ.");
                    }
                }

                comboBox1.SelectedIndex = 0;
                int count = 0;
                foreach(string activities in comboBox1.Items)
                {
                    if (activities.Split(' ').First() != "Σπίτι")
                    {
                        count++;
                    }
                }
                if(count > 4)
                {
                    pictureBox7.Image = Properties.Resources.varobanxious;
                    richTextBox1.Text = "Παρατηρώ ότι έχετε επιλέξει πολλές δραστηριότητες για σήμερα. Θα σας πρότεινα να προγραμματίσετε τάισμα των κατοικιδίων σας πηγαίνοντας στην Αυτόματη Ταΐστρα από το Αρχικό Μενού.";
                    pictureBox7.Visible = true;
                    richTextBox1.Visible = true;
                    resetTimer();
                }
            }
            else
            {
                richTextBox1.Text = "Παρακαλώ επιλέξτε μέχρι 2 δραστηριότητες σε κάθε διάστημα της ημέρας.";
                pictureBox7.Visible = true;
                richTextBox1.Visible = true;
                resetTimer();
            }
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
            pictureBox7.Image = Properties.Resources.valogo;
            pictureBox7.Visible = false;
            richTextBox1.Visible = false;
            timer1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            checkBox1.Checked = false;
            if (comboBox1.SelectedItem.ToString().Split(' ').First() == "Γυμναστήριο")
            {
                destination = comboBox1.SelectedItem.ToString().Split(' ').First();
                label5.Text = "Προς " + comboBox1.SelectedItem.ToString().Split(' ').First();
                label6.Text = "Επιλογή Τρόπου Μετακίνησης:";
                radioButton1.Text = "Πόδια";
                radioButton2.Text = "Αυτοκίνητο";
                if (radioButton2.Text == "Αυτοκίνητο")
                {
                    pictureBox1.Image = Properties.Resources.caricon;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                }
                if (radioButton1.Text == "Πόδια")
                {
                    pictureBox2.Image = Properties.Resources.walking2;
                }
                else if (radioButton1.Text == "Τραμ")
                {
                    pictureBox2.Image = Properties.Resources.tramicon;
                }
                routeTime = 20;
                
                if (routeTime > 50)
                {
                    mins = "0" + (60 - routeTime).ToString();
                }
                else
                {
                    mins = (60 - routeTime).ToString();
                }
                switch (comboBox1.SelectedItem.ToString().Split(' ')[2])
                {
                    case "2":
                        startTime = "1:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "2:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "4":
                        startTime = "3:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "4:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "6":
                        startTime = "5:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "6:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "8":
                        startTime = "7:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "8:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "10":
                        startTime = "9:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "10:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "12":
                        startTime = "11:" + mins + " π.μ";
                        endTime = "12:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                }
            }
            else if (comboBox1.SelectedItem.ToString().Split(' ').First() == "Μάθημα")
            {
                label5.Text = "Προς Μάθημα Πιάνου";
                label6.Text = "Επιλογή Τρόπου Μετακίνησης:";
                destination = "Μάθημα Πιάνο";
                radioButton1.Text = "Τραμ";
                radioButton2.Text = "Αυτοκίνητο";
                if (radioButton2.Text == "Αυτοκίνητο")
                {
                    pictureBox1.Image = Properties.Resources.caricon;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                }
                if (radioButton1.Text == "Πόδια")
                {
                    pictureBox2.Image = Properties.Resources.walking2;
                }
                else if (radioButton1.Text == "Τραμ")
                {
                    pictureBox2.Image = Properties.Resources.tramicon;
                }
                routeTime = 45;
                if (routeTime > 50)
                {
                    mins = "0" + (60 - routeTime).ToString();
                }
                else
                {
                    mins = (60 - routeTime).ToString();
                }
                switch (comboBox1.SelectedItem.ToString().Split(' ')[3])
                {
                    case "2":
                        startTime = "1:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "2:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "4":
                        startTime = "3:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "4:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "6":
                        startTime = "5:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "6:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "8":
                        startTime = "7:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "8:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "10":
                        startTime = "9:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "10:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "12":
                        startTime = "11:" + mins + " π.μ";
                        endTime = "12:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                }
            }
            else if (comboBox1.SelectedItem.ToString().Split(' ').First() == "Εμπορικό")
            {
                label5.Text = "Προς Εμπορικό Κέντρο";
                label6.Text = "Επιλογή Τρόπου Μετακίνησης:";
                destination = "Εμπορικό Κέντρο";
                radioButton1.Text = "Πόδια";
                radioButton2.Text = "Αυτοκίνητο";
                if (radioButton2.Text == "Αυτοκίνητο")
                {
                    pictureBox1.Image = Properties.Resources.caricon;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                }
                if (radioButton1.Text == "Πόδια")
                {
                    pictureBox2.Image = Properties.Resources.walking2;
                }
                else if (radioButton1.Text == "Τραμ")
                {
                    pictureBox2.Image = Properties.Resources.tramicon;
                }
                routeTime = 24;
                if (routeTime > 50)
                {
                    mins = "0" + (60 - routeTime).ToString();
                }
                else
                {
                    mins = (60 - routeTime).ToString();
                }
                switch (comboBox1.SelectedItem.ToString().Split(' ')[3])
                {
                    case "2":
                        startTime = "1:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "2:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "4":
                        startTime = "3:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "4:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "6":
                        startTime = "5:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "6:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "8":
                        startTime = "7:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "8:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "10":
                        startTime = "9:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "10:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "12":
                        startTime = "11:" + mins + " π.μ";
                        endTime = "12:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                }
            }
            else if (comboBox1.SelectedItem.ToString().Split(' ').First() == "Πανεπιστήμιο")
            {
                destination = comboBox1.SelectedItem.ToString().Split(' ').First();
                label5.Text = "Προς " + comboBox1.SelectedItem.ToString().Split(' ').First();
                label6.Text = "Επιλογή Τρόπου Μετακίνησης:";
                radioButton1.Text = "Πόδια";
                radioButton2.Text = "Αυτοκίνητο";
                if (radioButton2.Text == "Αυτοκίνητο")
                {
                    pictureBox1.Image = Properties.Resources.caricon;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                }
                if (radioButton1.Text == "Πόδια")
                {
                    pictureBox2.Image = Properties.Resources.walking2;
                }
                else if (radioButton1.Text == "Τραμ")
                {
                    pictureBox2.Image = Properties.Resources.tramicon;
                }
                routeTime = 7;

                if (routeTime > 50)
                {
                    mins = "0" + (60 - routeTime).ToString();
                }
                else
                {
                    mins = (60 - routeTime).ToString();
                }
                switch (comboBox1.SelectedItem.ToString().Split(' ')[2])
                {
                    case "2":
                        startTime = "1:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "2:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "4":
                        startTime = "3:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "4:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "6":
                        startTime = "5:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "6:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "8":
                        startTime = "7:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "8:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "10":
                        startTime = "9:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "10:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "12":
                        startTime = "11:" + mins + " π.μ";
                        endTime = "12:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                }
            }
            else if (comboBox1.SelectedItem.ToString().Split(' ').First() == "Καφετέρια")
            {
                destination = comboBox1.SelectedItem.ToString().Split(' ').First();
                label5.Text = "Προς " + comboBox1.SelectedItem.ToString().Split(' ').First();
                label6.Text = "Επιλογή Τρόπου Μετακίνησης:";
                radioButton1.Text = "Τραμ";
                radioButton2.Text = "Αυτοκίνητο";
                if (radioButton2.Text == "Αυτοκίνητο")
                {
                    pictureBox1.Image = Properties.Resources.caricon;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                }
                if (radioButton1.Text == "Πόδια")
                {
                    pictureBox2.Image = Properties.Resources.walking2;
                }
                else if (radioButton1.Text == "Τραμ")
                {
                    pictureBox2.Image = Properties.Resources.tramicon;
                }
                routeTime = 21;

                if (routeTime > 50)
                {
                    mins = "0" + (60 - routeTime).ToString();
                }
                else
                {
                    mins = (60 - routeTime).ToString();
                }
                switch (comboBox1.SelectedItem.ToString().Split(' ')[2])
                {
                    case "2":
                        startTime = "1:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "2:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "4":
                        startTime = "3:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "4:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "6":
                        startTime = "5:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "6:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "8":
                        startTime = "7:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "8:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "10":
                        startTime = "9:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "10:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "12":
                        startTime = "11:" + mins + " π.μ";
                        endTime = "12:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                }
            }
            else if (comboBox1.SelectedItem.ToString().Split(' ').First() == "Σουπερμάρκετ")
            {
                destination = comboBox1.SelectedItem.ToString().Split(' ').First();
                label5.Text = "Προς " + comboBox1.SelectedItem.ToString().Split(' ').First();
                label6.Text = "Επιλογή Τρόπου Μετακίνησης:";
                radioButton1.Text = "Τραμ";
                radioButton2.Text = "Αυτοκίνητο";
                if (radioButton2.Text == "Αυτοκίνητο")
                {
                    pictureBox1.Image = Properties.Resources.caricon;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                }
                if (radioButton1.Text == "Πόδια")
                {
                    pictureBox2.Image = Properties.Resources.walking2;
                }
                else if (radioButton1.Text == "Τραμ")
                {
                    pictureBox2.Image = Properties.Resources.tramicon;
                }
                routeTime = 28;

                if (routeTime > 50)
                {
                    mins = "0" + (60 - routeTime).ToString();
                }
                else
                {
                    mins = (60 - routeTime).ToString();
                }
                switch (comboBox1.SelectedItem.ToString().Split(' ')[2])
                {
                    case "2":
                        startTime = "1:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "2:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "4":
                        startTime = "3:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "4:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "6":
                        startTime = "5:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "6:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "8":
                        startTime = "7:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "8:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "10":
                        startTime = "9:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "10:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "12":
                        startTime = "11:" + mins + " π.μ";
                        endTime = "12:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                }
            }
            else if (comboBox1.SelectedItem.ToString().Split(' ').First() == "Εστιατόριο")
            {
                destination = comboBox1.SelectedItem.ToString().Split(' ').First();
                label5.Text = "Προς " + comboBox1.SelectedItem.ToString().Split(' ').First();
                label6.Text = "Επιλογή Τρόπου Μετακίνησης:";
                radioButton1.Text = "Τραμ";
                radioButton2.Text = "Αυτοκίνητο";
                if (radioButton2.Text == "Αυτοκίνητο")
                {
                    pictureBox1.Image = Properties.Resources.caricon;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                }
                if (radioButton1.Text == "Πόδια")
                {
                    pictureBox2.Image = Properties.Resources.walking2;
                }
                else if (radioButton1.Text == "Τραμ")
                {
                    pictureBox2.Image = Properties.Resources.tramicon;
                }
                routeTime = 31;

                if (routeTime > 50)
                {
                    mins = "0" + (60 - routeTime).ToString();
                }
                else
                {
                    mins = (60 - routeTime).ToString();
                }
                switch (comboBox1.SelectedItem.ToString().Split(' ')[2])
                {
                    case "2":
                        startTime = "1:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "2:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "4":
                        startTime = "3:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "4:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "6":
                        startTime = "5:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "6:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "8":
                        startTime = "7:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "8:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "10":
                        startTime = "9:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "10:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "12":
                        startTime = "11:" + mins + " π.μ";
                        endTime = "12:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                }
            }
            else if (comboBox1.SelectedItem.ToString().Split(' ').First() == "Βιβλιοθήκη")
            {
                destination = comboBox1.SelectedItem.ToString().Split(' ').First();
                label5.Text = "Προς " + comboBox1.SelectedItem.ToString().Split(' ').First();
                label6.Text = "Επιλογή Τρόπου Μετακίνησης:";
                radioButton1.Text = "Πόδια";
                radioButton2.Text = "Αυτοκίνητο";

                if (radioButton2.Text == "Αυτοκίνητο")
                {
                    pictureBox1.Image = Properties.Resources.caricon;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                }
                if (radioButton1.Text == "Πόδια")
                {
                    pictureBox2.Image = Properties.Resources.walking2;
                }
                else if (radioButton1.Text == "Τραμ")
                {
                    pictureBox2.Image = Properties.Resources.tramicon;
                }
                routeTime = 17;

                if (routeTime > 50)
                {
                    mins = "0" + (60 - routeTime).ToString();
                }
                else
                {
                    mins = (60 - routeTime).ToString();
                }
                switch (comboBox1.SelectedItem.ToString().Split(' ')[2])
                {
                    case "2":
                        startTime = "1:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "2:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "4":
                        startTime = "3:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "4:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "6":
                        startTime = "5:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "6:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "8":
                        startTime = "7:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "8:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "10":
                        startTime = "9:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "10:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "12":
                        startTime = "11:" + mins + " π.μ";
                        endTime = "12:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                }
            }
            else if (comboBox1.SelectedItem.ToString().Split(' ').First() == "Παραλία")
            {
                destination = comboBox1.SelectedItem.ToString().Split(' ').First();
                label5.Text = "Προς " + comboBox1.SelectedItem.ToString().Split(' ').First();
                label6.Text = "Επιλογή Τρόπου Μετακίνησης:";
                radioButton1.Text = "Πόδια";
                radioButton2.Text = "Αυτοκίνητο";
                if (radioButton2.Text == "Αυτοκίνητο")
                {
                    pictureBox1.Image = Properties.Resources.caricon;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                }
                if (radioButton1.Text == "Πόδια")
                {
                    pictureBox2.Image = Properties.Resources.walking2;
                }
                else if (radioButton1.Text == "Τραμ")
                {
                    pictureBox2.Image = Properties.Resources.tramicon;
                }
                routeTime = 12;

                if (routeTime > 50)
                {
                    mins = "0" + (60 - routeTime).ToString();
                }
                else
                {
                    mins = (60 - routeTime).ToString();
                }
                switch (comboBox1.SelectedItem.ToString().Split(' ')[2])
                {
                    case "2":
                        startTime = "1:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "2:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "4":
                        startTime = "3:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "4:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "6":
                        startTime = "5:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "6:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "8":
                        startTime = "7:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "8:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "10":
                        startTime = "9:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "10:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "12":
                        startTime = "11:" + mins + " π.μ";
                        endTime = "12:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                }
            }
            else if (comboBox1.SelectedItem.ToString().Split(' ').First() == "Δουλειά")
            {
                destination = comboBox1.SelectedItem.ToString().Split(' ').First();
                label5.Text = "Προς " + comboBox1.SelectedItem.ToString().Split(' ').First();
                label6.Text = "Επιλογή Τρόπου Μετακίνησης:";
                radioButton1.Text = "Πόδια";
                radioButton2.Text = "Αυτοκίνητο";
                if (radioButton2.Text == "Αυτοκίνητο")
                {
                    pictureBox1.Image = Properties.Resources.caricon;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                }
                if (radioButton1.Text == "Πόδια")
                {
                    pictureBox2.Image = Properties.Resources.walking2;
                }
                else if (radioButton1.Text == "Τραμ")
                {
                    pictureBox2.Image = Properties.Resources.tramicon;
                }
                routeTime = 10;

                if (routeTime > 50)
                {
                    mins = "0" + (60 - routeTime).ToString();
                }
                else
                {
                    mins = (60 - routeTime).ToString();
                }
                switch (comboBox1.SelectedItem.ToString().Split(' ')[2])
                {
                    case "2":
                        startTime = "1:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "2:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "4":
                        startTime = "3:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "4:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "6":
                        startTime = "5:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "6:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "8":
                        startTime = "7:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "8:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "10":
                        startTime = "9:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "10:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "12":
                        startTime = "11:" + mins + " π.μ";
                        endTime = "12:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                }
            }
            else if (comboBox1.SelectedItem.ToString().Split(' ').First() == "Σινεμά")
            {
                destination = comboBox1.SelectedItem.ToString().Split(' ').First();
                label5.Text = "Προς " + comboBox1.SelectedItem.ToString().Split(' ').First();
                label6.Text = "Επιλογή Τρόπου Μετακίνησης:";
                radioButton1.Text = "Τραμ";
                radioButton2.Text = "Αυτοκίνητο";
                if (radioButton2.Text == "Αυτοκίνητο")
                {
                    pictureBox1.Image = Properties.Resources.caricon;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                }
                if (radioButton1.Text == "Πόδια")
                {
                    pictureBox2.Image = Properties.Resources.walking2;
                }
                else if (radioButton1.Text == "Τραμ")
                {
                    pictureBox2.Image = Properties.Resources.tramicon;
                }
                routeTime = 29;

                if (routeTime > 50)
                {
                    mins = "0" + (60 - routeTime).ToString();
                }
                else
                {
                    mins = (60 - routeTime).ToString();
                }
                switch (comboBox1.SelectedItem.ToString().Split(' ')[2])
                {
                    case "2":
                        startTime = "1:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "2:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "4":
                        startTime = "3:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "4:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "6":
                        startTime = "5:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "6:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "8":
                        startTime = "7:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "8:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "10":
                        startTime = "9:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "10:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "12":
                        startTime = "11:" + mins + " π.μ";
                        endTime = "12:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                }
            }
            else if (comboBox1.SelectedItem.ToString().Split(' ').First() == "Θέατρο")
            {
                destination = comboBox1.SelectedItem.ToString().Split(' ').First();
                label5.Text = "Προς " + comboBox1.SelectedItem.ToString().Split(' ').First();
                label6.Text = "Επιλογή Τρόπου Μετακίνησης:";
                radioButton1.Text = "Τραμ";
                radioButton2.Text = "Αυτοκίνητο";
                if (radioButton2.Text == "Αυτοκίνητο")
                {
                    pictureBox1.Image = Properties.Resources.caricon;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                }
                if (radioButton1.Text == "Πόδια")
                {
                    pictureBox2.Image = Properties.Resources.walking2;
                }
                else if (radioButton1.Text == "Τραμ")
                {
                    pictureBox2.Image = Properties.Resources.tramicon;
                }
                routeTime = 22;

                if (routeTime > 50)
                {
                    mins = "0" + (60 - routeTime).ToString();
                }
                else
                {
                    mins = (60 - routeTime).ToString();
                }
                switch (comboBox1.SelectedItem.ToString().Split(' ')[2])
                {
                    case "2":
                        startTime = "1:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "2:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "4":
                        startTime = "3:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "4:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "6":
                        startTime = "5:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "6:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "8":
                        startTime = "7:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "8:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "10":
                        startTime = "9:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "10:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "12":
                        startTime = "11:" + mins + " π.μ";
                        endTime = "12:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                }
            }
            else if (comboBox1.SelectedItem.ToString().Split(' ').First() == "Πάρτι")
            {
                destination = comboBox1.SelectedItem.ToString().Split(' ').First();
                label5.Text = "Προς " + comboBox1.SelectedItem.ToString().Split(' ').First();
                label6.Text = "Επιλογή Τρόπου Μετακίνησης:";
                radioButton1.Text = "Τραμ";
                radioButton2.Text = "Αυτοκίνητο";
                if (radioButton2.Text == "Αυτοκίνητο")
                {
                    pictureBox1.Image = Properties.Resources.caricon;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                }
                if (radioButton1.Text == "Πόδια")
                {
                    pictureBox2.Image = Properties.Resources.walking2;
                }
                else if (radioButton1.Text == "Τραμ")
                {
                    pictureBox2.Image = Properties.Resources.tramicon;
                }
                routeTime = 18;

                if (routeTime > 50)
                {
                    mins = "0" + (60 - routeTime).ToString();
                }
                else
                {
                    mins = (60 - routeTime).ToString();
                }
                switch (comboBox1.SelectedItem.ToString().Split(' ')[2])
                {
                    case "2":
                        startTime = "1:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "2:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "4":
                        startTime = "3:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "4:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "6":
                        startTime = "5:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "6:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "8":
                        startTime = "7:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "8:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "10":
                        startTime = "9:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "10:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "12":
                        startTime = "11:" + mins + " π.μ";
                        endTime = "12:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                }
            }
            else if (comboBox1.SelectedItem.ToString().Split(' ').First() == "Σπίτι")
            {
                destination = comboBox1.SelectedItem.ToString().Split(' ').First();
                label5.Text = "Βρίσκεστε Σπίτι!";
                label6.Text = "Επιλογή Δραστηριότητας:";
                radioButton1.Text = "Τάισμα\nΚατοικιδίων";
                radioButton2.Text = "Ξεκούραση";
                if (radioButton1.Text == "Τάισμα\nΚατοικιδίων")
                {
                    pictureBox2.Image = Properties.Resources.paw2;
                }
                if (radioButton2.Text == "Ξεκούραση")
                {
                    pictureBox1.Image = Properties.Resources.rest;
                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                }
                
                routeTime = 0;

                mins = "00";
                switch (comboBox1.SelectedItem.ToString().Split(' ')[2])
                {
                    case "2":
                        startTime = "2:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "2:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "4":
                        startTime = "4:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "4:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "6":
                        startTime = "6:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "6:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "8":
                        startTime = "8:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "8:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "10":
                        startTime = "10:" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        endTime = "10:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                    case "12":
                        startTime = "12:" + mins + " π.μ";
                        endTime = "12:00 " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                        break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().ShowDialog();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if(radioButton1.Checked)
                    startTime = startTime.Split(':').First() + ":" + (Int32.Parse(mins) - 8).ToString() + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                else
                startTime = startTime.Split(':').First() + ":" + (Int32.Parse(mins)-3).ToString() + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
            }
            else
            {
                startTime = startTime.Split(':').First() + ":" + mins + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                checkBox2.Checked = false;
            }
            if(!checkBox2.Enabled)
            {
                checkBox2.Enabled = true;
            }
            else
            {
                checkBox2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (destination == "Σπίτι")
            {
                route = Properties.Resources.home;
            }
            if (destination == "Γυμναστήριο" && transport == "Αυτοκίνητο" && !checkBox1.Checked)
            {
                route = Properties.Resources.gymcar;
            }
            else if (destination == "Γυμναστήριο" && transport == "Αυτοκίνητο" && checkBox1.Checked)
            {
                route = Properties.Resources.gymcarcoffee;
            }
            else if (destination == "Γυμναστήριο" && transport == "Πόδια" && checkBox1.Checked)
            {
                route = Properties.Resources.gymfeetcoffee;
            }
            else if (destination == "Γυμναστήριο" && transport == "Πόδια" && !checkBox1.Checked)
            {
                route = Properties.Resources.gymfeet;
            }
            else if (destination == "Πανεπιστήμιο" && transport == "Αυτοκίνητο" && !checkBox1.Checked)
            {
                route = Properties.Resources.unicar;
            }
            else if (destination == "Πανεπιστήμιο" && transport == "Αυτοκίνητο" && checkBox1.Checked)
            {
                route = Properties.Resources.unicarcoffee;
            }
            else if (destination == "Πανεπιστήμιο" && transport == "Πόδια" && checkBox1.Checked)
            {
                route = Properties.Resources.unifeetcoffee;
            }
            else if (destination == "Πανεπιστήμιο" && transport == "Πόδια" && !checkBox1.Checked)
            {
                route = Properties.Resources.unifeet;
            }
            else if (destination == "Μάθημα Πίανο" && transport == "Αυτοκίνητο" && !checkBox1.Checked)
            {
                route = Properties.Resources.pianocar;
            }
            else if (destination == "Μάθημα Πίανο" && transport == "Αυτοκίνητο" && checkBox1.Checked)
            {
                route = Properties.Resources.pianocarcoffee;
            }
            else if (destination == "Μάθημα Πίανο" && transport == "Τραμ")
            {
                route = Properties.Resources.pianotram;
            }
            else if (destination == "Καφετέρια" && transport == "Αυτοκίνητο" && !checkBox1.Checked)
            {
                route = Properties.Resources.cafeteriacar;
            }
            else if (destination == "Καφετέρια" && transport == "Αυτοκίνητο" && checkBox1.Checked)
            {
                route = Properties.Resources.cafeteriacarcoffee;
            }
            else if (destination == "Καφετέρια" && transport == "Τραμ")
            {
                route = Properties.Resources.cafeteriatram;
            }
            else if (destination == "Σουπερμάρκετ" && transport == "Αυτοκίνητο" && !checkBox1.Checked)
            {
                route = Properties.Resources.supermarketcar;
            }
            else if (destination == "Σουπερμάρκετ" && transport == "Αυτοκίνητο" && checkBox1.Checked)
            {
                route = Properties.Resources.supermarketcarcoffee;
            }
            else if (destination == "Σουπερμάρκετ" && transport == "Τραμ")
            {
                route = Properties.Resources.supermarkettram;
            }
            else if (destination == "Εμπορικό Κέντρο" && transport == "Αυτοκίνητο" && !checkBox1.Checked)
            {
                route = Properties.Resources.mallcar;
            }
            else if (destination == "Εμπορικό Κέντρο" && transport == "Αυτοκίνητο" && checkBox1.Checked)
            {
                route = Properties.Resources.mallcarcoffee;
            }
            else if (destination == "Εμπορικό Κέντρο" && transport == "Πόδια" && checkBox1.Checked)
            {
                route = Properties.Resources.mallfeetcoffee;
            }
            else if (destination == "Εμπορικό Κέντρο" && transport == "Πόδια" && !checkBox1.Checked)
            {
                route = Properties.Resources.mallfeet;
            }
            else if (destination == "Εστιατόριο" && transport == "Αυτοκίνητο" && !checkBox1.Checked)
            {
                route = Properties.Resources.restaurantcar;
            }
            else if (destination == "Εστιατόριο" && transport == "Αυτοκίνητο" && checkBox1.Checked)
            {
                route = Properties.Resources.restaurantcarcoffee;
            }
            else if (destination == "Εστιατόριο" && transport == "Τραμ")
            {
                route = Properties.Resources.restauranttram;
            }
            else if (destination == "Βιβλιοθήκη" && transport == "Αυτοκίνητο" && !checkBox1.Checked)
            {
                route = Properties.Resources.librarycar;
            }
            else if (destination == "Βιβλιοθήκη" && transport == "Αυτοκίνητο" && checkBox1.Checked)
            {
                route = Properties.Resources.librarycarcoffee;
            }
            else if (destination == "Βιβλιοθήκη" && transport == "Πόδια" && checkBox1.Checked)
            {
                route = Properties.Resources.libraryfeetcoffee;
            }
            else if (destination == "Βιβλιοθήκη" && transport == "Πόδια" && !checkBox1.Checked)
            {
                route = Properties.Resources.libraryfeet;
            }
            else if (destination == "Παραλία" && transport == "Αυτοκίνητο" && !checkBox1.Checked)
            {
                route = Properties.Resources.beachcar;
            }
            else if (destination == "Παραλία" && transport == "Αυτοκίνητο" && checkBox1.Checked)
            {
                route = Properties.Resources.beachcarcoffee;
            }
            else if (destination == "Παραλία" && transport == "Πόδια" && checkBox1.Checked)
            {
                route = Properties.Resources.beachfeetcoffee;
            }
            else if (destination == "Παραλία" && transport == "Πόδια" && !checkBox1.Checked)
            {
                route = Properties.Resources.beachfeet;
            }
            else if (destination == "Δουλειά" && transport == "Αυτοκίνητο" && !checkBox1.Checked)
            {
                route = Properties.Resources.workcar;
            }
            else if (destination == "Δουλειά" && transport == "Αυτοκίνητο" && checkBox1.Checked)
            {
                route = Properties.Resources.workcarcoffee;
            }
            else if (destination == "Δουλειά" && transport == "Πόδια" && checkBox1.Checked)
            {
                route = Properties.Resources.workfeetcoffee;
            }
            else if (destination == "Δουλειά" && transport == "Πόδια" && !checkBox1.Checked)
            {
                route = Properties.Resources.workfeet;
            }
            else if (destination == "Σινεμά" && transport == "Αυτοκίνητο" && !checkBox1.Checked)
            {
                route = Properties.Resources.cinemacar;
            }
            else if (destination == "Σινεμά" && transport == "Αυτοκίνητο" && checkBox1.Checked)
            {
                route = Properties.Resources.cinemacarcoffee;
            }
            else if (destination == "Σινεμά" && transport == "Τραμ")
            {
                route = Properties.Resources.cinematram;
            }
            else if (destination == "Θέατρο" && transport == "Αυτοκίνητο" && !checkBox1.Checked)
            {
                route = Properties.Resources.theatrecar;
            }
            else if (destination == "Θέατρο" && transport == "Αυτοκίνητο" && checkBox1.Checked)
            {
                route = Properties.Resources.theatrecarcoffee;
            }
            else if (destination == "Θέατρο" && transport == "Τραμ")
            {
                route = Properties.Resources.theatretram;
            }
            else if (destination == "Πάρτι" && transport == "Αυτοκίνητο" && !checkBox1.Checked)
            {
                route = Properties.Resources.partycar;
            }
            else if (destination == "Πάρτι" && transport == "Αυτοκίνητο" && checkBox1.Checked)
            {
                route = Properties.Resources.partycarcoffee;
            }
            else if (destination == "Πάρτι" && transport == "Τραμ")
            {
                route = Properties.Resources.partytram;
            }
            new RouteInformation(destination,transport,startTime,endTime,route).ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Text == "Πόδια")
            {
                checkBox1.Checked = false;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                transport = "Πόδια";
                startTime = startTime.Split(':').First() + ":" + (Int32.Parse(mins) - 5).ToString() + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
            }
            else if(radioButton1.Text == "Τραμ")
            {
                checkBox1.Checked = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                transport = "Τραμ";
                startTime = startTime.Split(':').First() + ":" + (Int32.Parse(mins) - 5).ToString() + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
                
            }
            else
            {
                checkBox1.Checked = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                transport = "Τραμ";
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Text == "Αυτοκίνητο")
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                transport = "Αυτοκίνητο";
                startTime = startTime.Split(':').First() + ":" + (Int32.Parse(mins)).ToString() + " " + comboBox1.SelectedItem.ToString().Split(' ').Last();
            }
            else
            {
                checkBox1.Checked = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                transport = "Αυτοκίνητο";
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Επιλέξτε τις δραστηριότητες που θα πραγματοποιήσετε για τις πρωινές, μεσημεριανές, απογευματινές και βραδινές ώρες. Μπορείτε να επιλέξετε μέχρι 2 δραστηριότητες για κάθε διάστημα της ημέρας. Στη συνέχεια πατήστε το κουμπί 'Προσθήκη' ώστε να δημιουργηθεί το Πλάνο Ημέρας.";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να πατήσετε το κουμπί 'Αρχικό Μενού' για να μεταβείτε στη φόρμα του αρχικού μενού.";
        }

        private void richTextBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Εδώ μπορείτε να δείτε το πλάνο της ημέρας σας.";

        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Μπορείτε να επιλέξετε ανάλογα την δραστηριότητα που θα πραγματοποιήσετε τον τρόπο μετακίνησης και το αν θέλετε καφέ στο δρόμο είτε να τον αγοράσετε εκείνη τη στιγμή είτε ηλεκτρονικά. Στη συνέχεια πατώντας το κουμπί ΄Εμφάνιση Διαδρομής' εμφανίζεται ένας χάρτης με την διαδρομή από το σπίτι σας προς την επιλεγμένη τοποθεσία.";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "virtualassistant.chm", HelpNavigator.TopicId, "20");
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.virtualassistanthelppressed1;
            pictureBox7.Visible = true;
            richTextBox1.Visible = true;
            resetTimer();
            richTextBox1.Text = "Πατήστε το κουμπί 'ΒΟΗΘΕΙΑ' για περισσότερες πληροφορίες πάνω στις λειτουργίες της εφαρμογής.";
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.virtualassistanthelp;
        }
    }
}
