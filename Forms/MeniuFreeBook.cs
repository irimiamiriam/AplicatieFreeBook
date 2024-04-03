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
using System.Windows.Forms.DataVisualization.Charting;

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
           for(int i=2000; i<=2024; i++)
            {
                anImprumutListBox.Items.Add(i.ToString());
            }
            CreateChartPie();


        }

        private void NumarUtilizatoriChart()
        {
            chartUsersAnual.Series.Clear();
            Series serie = new Series();
            serie.Name = "luni";
            string anString = anImprumutListBox.SelectedItem.ToString();
            string dateString = "1/1/" + anString;
            DateTime an = DateTime.ParseExact(dateString, "M/d/yyyy", null);
            var imprumuturiPeAn = DataBaseHelper.GetImprumuturiPeAn(an, an.AddYears(1)).Select(x => x.DataImprumut).OrderBy(x => x).Select(x => x.ToString("MMM")).ToList();
            var imprumuturiPeLuni = imprumuturiPeAn.GroupBy(x => x).ToList();
            DateTime temp = DateTime.Now.AddDays(1 - DateTime.Now.DayOfYear);
            for (int i = 0; i < 11; i++)
            {
                string data = temp.ToString("MMM");
                serie.Points.AddXY(data, 0);
                serie.Points[i].Tag= data;
                serie.Points[i].XValue = i;
                temp = temp.AddMonths(1);
            }
            foreach (var item in imprumuturiPeLuni)
            {
                DataPoint pointToUpdate = serie.Points.FirstOrDefault(p => p.Tag.ToString() == item.First()); ;
                pointToUpdate.YValues[0]= item.Count();
            }
            chartUsersAnual.Series.Add(serie);
            chartUsersAnual.ChartAreas[0].AxisX.Interval = 1;
            chartUsersAnual.Series[0].IsValueShownAsLabel = true;
            chartUsersAnual.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartUsersAnual.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chartUsersAnual.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartUsersAnual.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chartUsersAnual.ChartAreas[0].RecalculateAxesScale();


        }

        private void CreateChartPie()
        {
            
            chartPie.Series.Clear();
            chartPie.ChartAreas.Clear();
            chartPie.Legends.Clear();
            ChartArea chartArea1 = new ChartArea();
            chartArea1.Name = "PieChartArea";
            chartPie.ChartAreas.Add(chartArea1);
            Series serie = new Series();
            serie.Name = "Carti Populare";
            serie.ChartArea = "PieChartArea";
            serie.ChartType= SeriesChartType.Pie;
            var cartiPopulare = DataBaseHelper.GetCartiPopulare().OrderBy(x => x).ToList(); ;
            var celeMaiCitieCarti = cartiPopulare.GroupBy(x => x).OrderByDescending(x => x.Count()).Take(4).ToList();
            foreach (var item in celeMaiCitieCarti)
            {
                serie.Points.AddXY(item.First(), item.Count());
            }
            chartPie.Series.Add(serie);
            chartPie.Legends.Add(new Legend("Legend1"));
            chartPie.Series[0].IsValueShownAsLabel = true;
            chartPie.Series[0].Legend = "Legend1";
            chartPie.Series[0].IsVisibleInLegend = true;
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
            {
                buttonColumn.HeaderText = "Imprumuta carte";
                buttonColumn.Name = "imprumut";
             
            }
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

        private void dataGridCartiDisponibile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridCartiDisponibile.Columns["imprumut"].Index)
            {
                CarteModel carteModel = new CarteModel()
                {
                    Titlu = dataGridCartiDisponibile.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    Autor= dataGridCartiDisponibile.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Gen = dataGridCartiDisponibile.Rows[e.RowIndex].Cells[2].Value.ToString()
                };
                if (nrDisponibile < 3)
                {
                    DataBaseHelper.InsertCarteIntoImprumut(carteModel, utilizator.Email);
                  
                    dataGridCartiImprumut.Rows.Add(dataGridCartiImprumut.Rows.Count, carteModel.Titlu, carteModel.Autor, carteModel.Gen, DateTime.Now, DateTime.Now.AddDays(30));
                    dataGridCartiImprumut.Rows[dataGridCartiImprumut.Rows.Count-2].DefaultCellStyle.BackColor = Color.Green;
                    nrDisponibile++;
                    disponibilLabel.Text = "Disponibilitate imprumuturi " + nrDisponibile + "/3 ";
                    progressBar.Value = nrDisponibile;
                }
                else MessageBox.Show("Ati imprumutat deja 3 carti!");
                CreateChartPie();
            }
        }

        private void anImprumutListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            NumarUtilizatoriChart();
        }


    }
}
