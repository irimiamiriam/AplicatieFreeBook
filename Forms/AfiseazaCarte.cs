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
using System.Windows.Forms;

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

        }
    }
}
