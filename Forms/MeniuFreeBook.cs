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
    public partial class MeniuFreeBook : Form
    {
        public UtilizatorModel utilizator = new UtilizatorModel();
        public MeniuFreeBook()
        {
            InitializeComponent();
          
         
        }

        private void MeniuFreeBook_Load(object sender, EventArgs e)
        {
            emailUser.Text="Email utilizator: "+utilizator.Email;
            CreateCartiDisponibil();
            
        }

        private void CreateCartiDisponibil()
        {
            DataGridViewColumn titluColumn = new DataGridViewTextBoxColumn();
            titluColumn.HeaderText = "Titlu";
            DataGridViewColumn autorColumn = new DataGridViewTextBoxColumn();
            autorColumn.HeaderText = "Autor";
            DataGridViewColumn genColumn = new DataGridViewTextBoxColumn();
            genColumn.HeaderText = "Gen";
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Imprumuta carte";
            dataGridCartiDisponibile.Columns.Add(titluColumn);
            dataGridCartiDisponibile.Columns.Add(autorColumn);
            dataGridCartiDisponibile.Columns.Add(genColumn);
            dataGridCartiDisponibile.Columns.Add(buttonColumn);
            DataTable dataTable = DataBaseHelper.GetCarti();
            foreach(DataRow row in dataTable.Rows) 
            { 
                dataGridCartiDisponibile.Rows.Add(row.ItemArray);
            }

        }
    }
}
