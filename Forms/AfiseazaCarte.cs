using AplicatieFreeBook.DataAcces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AplicatieFreeBook.Forms
{
    public partial class AfiseazaCarte : Form
    {
        public string titluSelectat;
        public AfiseazaCarte()
        {
            InitializeComponent();

        }

      

        private void AfiseazaCarte_Load(object sender, EventArgs e)
        {
            int idCarte = DataBaseHelper.GetCarteId(titluSelectat);

            string path = @"file:///C:/Users/Miriam/Documents/Aplicatii%20C%23/AplicatieFreeBook/Resurse/cartipdf/";
            webBrowser1.Navigate(path);
          

        }
    }
}
