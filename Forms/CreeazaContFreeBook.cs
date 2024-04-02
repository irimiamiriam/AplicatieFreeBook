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
    public partial class CreeazaContFreeBook : Form
    {
        public CreeazaContFreeBook()
        {
            InitializeComponent();
        }

        private void Inregistrarebutton_Click(object sender, EventArgs e)
        {
            bool verificareEmpty = false;
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        verificareEmpty = true;
                    }
                }
            }
           if (verificareEmpty == false)
            {
                if (parolatextBox.Text == confparolatextBox.Text)
                {
                    if(DataBaseHelper.CheckEmail(emailtextBox.Text)==true)
                    {
                        UtilizatorModel utilizator = new UtilizatorModel()
                        {
                            Email= emailtextBox.Text,
                            Password= confparolatextBox.Text,
                            Nume= numetextBox.Text,
                            Prenume= prenumetextBox.Text
                        };
                        DataBaseHelper.CreateUser(utilizator);
                        MeniuFreeBook meniuFreeBook = new MeniuFreeBook();
                        meniuFreeBook.utilizator = utilizator;
                        this.Hide();
                        meniuFreeBook.ShowDialog();
                        this.Close();
                        
                    }else { MessageBox.Show("Exista deja un cont care foloseste acest email!"); }
                }else { MessageBox.Show("Campurile parola si confirmare parola nu sunt identice"); }
            }else { MessageBox.Show("Completati toate campurile");}
        }
    }
}
