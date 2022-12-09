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
    public partial class RouteInformation : Form
    {
        public RouteInformation()
        {
            InitializeComponent();
        }

        public RouteInformation(string destination,string transport,string timeStart,string timeEnd,Image route)
        {
            InitializeComponent();
            if(destination == "Σπίτι" && transport == "Τραμ")
            {
                label5.Text = "Χάρτης Διαδρομών";
                label1.Text = "Ώρα Δραστηριότητας: " + timeStart;
                label2.Text = "Μπορείτε να προγραμματίσετε τάισμα των κατοικιδίων σας πηγαίνοντας\nστην Αυτόματη Ταΐστρα από το Αρχικό Μενού.";
                label3.Text = "";
                label4.Text = "";
            }
            else if(destination == "Σπίτι")
            {
                label5.Text = "Χάρτης Διαδρομών";
                label1.Text = "Ώρα Δραστηριότητας: " + timeStart;
                label2.Text = "Καλή Ξεκούραση!";
                label3.Text = "";
                label4.Text = "";
            }
            else
            {
                label5.Text = "Διαδρομή: Σπίτι - " + destination;
                label1.Text = "Μέσο Μεταφοράς: " + transport;
                label2.Text = "Ώρα Αναχώρησης: " + timeStart;
                label3.Text = "Ώρα Άφιξης: " + timeEnd;
                label4.Text = "*Η κίνηση αναπαριστάται με κίτρινο χρώμα στον χάρτη. Επίσης,\n υπάρχει ένδειξη για πάρκινγκ στην οποία θα βρείτε να παρκάρετε\n και μπορείτε να παραλάβετε τον καφέ σας στην ένδειξη του καφέ.";
            }
            pictureBox1.Image = route;
        }
    }
}
