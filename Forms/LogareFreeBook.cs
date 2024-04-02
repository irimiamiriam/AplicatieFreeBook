using AplicatieFreeBook.DataAcces;
using AplicatieFreeBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieFreeBook.Forms
{
    public partial class LogareFreeBook : Form
    {
        UtilizatorModel utilizator = new UtilizatorModel();
        public LogareFreeBook()
        {
            InitializeComponent();
        }

        private void Logarebutton_Click(object sender, EventArgs e)
        {
           
            utilizator = DataBaseHelper.GetUtilizator(emailtextBox.Text, parolatextBox.Text);
            if (utilizator != null)
            {
                MeniuFreeBook meniuFreeBook = new MeniuFreeBook();
                meniuFreeBook.utilizator = utilizator;
                this.Hide();
                meniuFreeBook.ShowDialog();
                this.Close();

            }
            else { MessageBox.Show("Eroare autentificare!");
                emailtextBox.Text = "";
                parolatextBox.Text = "";
            }
        }
    }
}
