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
        string titluSelectat;
        int nrDisponibile = 0;
        public MeniuFreeBook()
        {
            InitializeComponent();
          
         
        }

        private void MeniuFreeBook_Load(object sender, EventArgs e)
        {
            emailUser.Text="Email utilizator: "+utilizator.Email;
            CreateCartiDisponibil();
            CreateCartiImprumutate();
            
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
            DataTable dataTable = DataBaseHelper.GetCartiDisponibile();
            foreach(DataRow row in dataTable.Rows) 
            { 
                dataGridCartiDisponibile.Rows.Add(row.ItemArray);
            }

        }

        private void CreateCartiImprumutate()
        {
            int id = 0;
            DataGridViewColumn indexColumn = new DataGridViewTextBoxColumn();
            indexColumn.HeaderText = "Index";
            DataGridViewColumn titluColumn = new DataGridViewTextBoxColumn();
            titluColumn.HeaderText = "Titlu";
            DataGridViewColumn autorColumn = new DataGridViewTextBoxColumn();
            autorColumn.HeaderText = "Autor";
            DataGridViewColumn dataImprumutColumn = new DataGridViewTextBoxColumn();
            dataImprumutColumn.HeaderText = "Data Imprumut";
            DataGridViewColumn dataDisponibilColumn = new DataGridViewTextBoxColumn();
            dataDisponibilColumn.HeaderText = "Data disponibilitate";
          
            dataGridCartiImprumut.Columns.Add(indexColumn);
            dataGridCartiImprumut.Columns.Add(titluColumn);
            dataGridCartiImprumut.Columns.Add(autorColumn);
            dataGridCartiImprumut.Columns.Add(dataImprumutColumn);
            dataGridCartiImprumut.Columns.Add(dataDisponibilColumn);

            DataTable dataTable = DataBaseHelper.GetCartiImprumutate(utilizator.Email);
          
            foreach (DataRow row in dataTable.Rows)
            {
                id++;
                dataGridCartiImprumut.Rows.Add(id, row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());

                DateTime dataDisponibil = DateTime.ParseExact(row[3].ToString(), "M/d/yyyy hh:mm:ss tt", null);
                if (dataDisponibil < DateTime.Parse("1/1/2019"))
                {
                    dataGridCartiImprumut.Rows[id - 1].DefaultCellStyle.BackColor = Color.Red;
                }
                else { dataGridCartiImprumut.Rows[id - 1].DefaultCellStyle.BackColor = Color.Green; nrDisponibile++; }

            }
            disponibilLabel.Text = "Disponibilitate imprumuturi " + nrDisponibile + "/3 ";
            progressBar.Value= nrDisponibile;
        }

        private void dataGridCartiImprumut_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titluSelectat = dataGridCartiImprumut.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dataGridCartiImprumut.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.Green)
            {
                AfiseazaCarte afiseazaCarte = new AfiseazaCarte();
                afiseazaCarte.titluSelectat = titluSelectat;
                this.Hide();
                afiseazaCarte.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Perioada imprumutului expirata!");
        }
    }
}
