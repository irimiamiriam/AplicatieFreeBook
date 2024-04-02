using AplicatieFreeBook.DataAcces;
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
    public partial class FreeBookHome : Form
    {
        public FreeBookHome()
        {
            InitializeComponent();
        }

        private void singUpbutton_Click(object sender, EventArgs e)
        {
            CreeazaContFreeBook creeazaContFreeBook = new CreeazaContFreeBook();
            this.Hide();
            creeazaContFreeBook.ShowDialog();
            this.Show();
        }

        private void logInbutton_Click(object sender, EventArgs e)
        {
            LogareFreeBook logareFreeBook = new LogareFreeBook();
            this.Hide();
            logareFreeBook.ShowDialog();
            this.Show();
        }

        private void FreeBookHome_Load(object sender, EventArgs e)
        {
            DataBaseHelper.Initialisation();
        }
    }
}
