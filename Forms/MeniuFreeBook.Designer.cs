namespace AplicatieFreeBook.Forms
{
    partial class MeniuFreeBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.emailUser = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.disponibilTab = new System.Windows.Forms.TabPage();
            this.dataGridCartiDisponibile = new System.Windows.Forms.DataGridView();
            this.imprumutTab = new System.Windows.Forms.TabPage();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.disponibilLabel = new System.Windows.Forms.Label();
            this.dataGridCartiImprumut = new System.Windows.Forms.DataGridView();
            this.statisticiTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.anImprumutListBox = new System.Windows.Forms.ListBox();
            this.label = new System.Windows.Forms.Label();
            this.chartUsersAnual = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.disponibilTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCartiDisponibile)).BeginInit();
            this.imprumutTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCartiImprumut)).BeginInit();
            this.statisticiTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsersAnual)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            this.SuspendLayout();
            // 
            // emailUser
            // 
            this.emailUser.AutoSize = true;
            this.emailUser.Location = new System.Drawing.Point(54, 44);
            this.emailUser.Name = "emailUser";
            this.emailUser.Size = new System.Drawing.Size(164, 25);
            this.emailUser.TabIndex = 0;
            this.emailUser.Text = "Email utilizator: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.disponibilTab);
            this.tabControl1.Controls.Add(this.imprumutTab);
            this.tabControl1.Controls.Add(this.statisticiTab);
            this.tabControl1.Location = new System.Drawing.Point(23, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1244, 850);
            this.tabControl1.TabIndex = 1;
            // 
            // disponibilTab
            // 
            this.disponibilTab.Controls.Add(this.dataGridCartiDisponibile);
            this.disponibilTab.Location = new System.Drawing.Point(8, 39);
            this.disponibilTab.Name = "disponibilTab";
            this.disponibilTab.Padding = new System.Windows.Forms.Padding(3);
            this.disponibilTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.disponibilTab.Size = new System.Drawing.Size(1228, 803);
            this.disponibilTab.TabIndex = 0;
            this.disponibilTab.Text = "Carti disponibile";
            this.disponibilTab.UseVisualStyleBackColor = true;
            // 
            // dataGridCartiDisponibile
            // 
            this.dataGridCartiDisponibile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCartiDisponibile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCartiDisponibile.Location = new System.Drawing.Point(14, 14);
            this.dataGridCartiDisponibile.Name = "dataGridCartiDisponibile";
            this.dataGridCartiDisponibile.RowHeadersWidth = 82;
            this.dataGridCartiDisponibile.RowTemplate.Height = 33;
            this.dataGridCartiDisponibile.Size = new System.Drawing.Size(1193, 529);
            this.dataGridCartiDisponibile.TabIndex = 0;
            this.dataGridCartiDisponibile.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCartiDisponibile_CellClick);
            // 
            // imprumutTab
            // 
            this.imprumutTab.Controls.Add(this.progressBar);
            this.imprumutTab.Controls.Add(this.disponibilLabel);
            this.imprumutTab.Controls.Add(this.dataGridCartiImprumut);
            this.imprumutTab.Location = new System.Drawing.Point(8, 39);
            this.imprumutTab.Name = "imprumutTab";
            this.imprumutTab.Padding = new System.Windows.Forms.Padding(3);
            this.imprumutTab.Size = new System.Drawing.Size(1228, 803);
            this.imprumutTab.TabIndex = 1;
            this.imprumutTab.Text = "Carti imprumutate";
            this.imprumutTab.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(463, 636);
            this.progressBar.Maximum = 3;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(700, 66);
            this.progressBar.TabIndex = 3;
            // 
            // disponibilLabel
            // 
            this.disponibilLabel.AutoSize = true;
            this.disponibilLabel.Location = new System.Drawing.Point(71, 648);
            this.disponibilLabel.Name = "disponibilLabel";
            this.disponibilLabel.Size = new System.Drawing.Size(70, 25);
            this.disponibilLabel.TabIndex = 2;
            this.disponibilLabel.Text = "label1";
            // 
            // dataGridCartiImprumut
            // 
            this.dataGridCartiImprumut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCartiImprumut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCartiImprumut.Location = new System.Drawing.Point(14, 22);
            this.dataGridCartiImprumut.Name = "dataGridCartiImprumut";
            this.dataGridCartiImprumut.RowHeadersWidth = 82;
            this.dataGridCartiImprumut.RowTemplate.Height = 33;
            this.dataGridCartiImprumut.Size = new System.Drawing.Size(1191, 557);
            this.dataGridCartiImprumut.TabIndex = 1;
            this.dataGridCartiImprumut.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCartiImprumut_CellDoubleClick);
            // 
            // statisticiTab
            // 
            this.statisticiTab.Controls.Add(this.tabControl2);
            this.statisticiTab.Location = new System.Drawing.Point(8, 39);
            this.statisticiTab.Name = "statisticiTab";
            this.statisticiTab.Padding = new System.Windows.Forms.Padding(3);
            this.statisticiTab.Size = new System.Drawing.Size(1228, 803);
            this.statisticiTab.TabIndex = 2;
            this.statisticiTab.Text = "Statistici biblioteca";
            this.statisticiTab.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(28, 25);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1194, 759);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.anImprumutListBox);
            this.tabPage1.Controls.Add(this.label);
            this.tabPage1.Controls.Add(this.chartUsersAnual);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1178, 712);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Numar Utilizatori";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // anImprumutListBox
            // 
            this.anImprumutListBox.FormattingEnabled = true;
            this.anImprumutListBox.ItemHeight = 25;
            this.anImprumutListBox.Location = new System.Drawing.Point(198, 38);
            this.anImprumutListBox.Name = "anImprumutListBox";
            this.anImprumutListBox.Size = new System.Drawing.Size(225, 54);
            this.anImprumutListBox.TabIndex = 2;
            this.anImprumutListBox.SelectedIndexChanged += new System.EventHandler(this.anImprumutListBox_SelectedValueChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(60, 38);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(132, 25);
            this.label.TabIndex = 1;
            this.label.Text = "An imprumut";
            // 
            // chartUsersAnual
            // 
            chartArea1.Name = "ChartArea1";
            this.chartUsersAnual.ChartAreas.Add(chartArea1);
            this.chartUsersAnual.Location = new System.Drawing.Point(77, 98);
            this.chartUsersAnual.Name = "chartUsersAnual";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartUsersAnual.Series.Add(series1);
            this.chartUsersAnual.Size = new System.Drawing.Size(993, 556);
            this.chartUsersAnual.TabIndex = 0;
            this.chartUsersAnual.Text = "numarUtilizatorichart";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartPie);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1178, 712);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Carti populare";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartPie
            // 
            this.chartPie.Location = new System.Drawing.Point(93, 78);
            this.chartPie.Name = "chartPie";
            series2.Name = "Series1";
            this.chartPie.Series.Add(series2);
            this.chartPie.Size = new System.Drawing.Size(993, 556);
            this.chartPie.TabIndex = 1;
            this.chartPie.Text = "numarUtilizatorichart";
            // 
            // MeniuFreeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1290, 971);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.emailUser);
            this.Name = "MeniuFreeBook";
            this.Text = "MeniuFreeBook";
            this.Load += new System.EventHandler(this.MeniuFreeBook_Load);
            this.tabControl1.ResumeLayout(false);
            this.disponibilTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCartiDisponibile)).EndInit();
            this.imprumutTab.ResumeLayout(false);
            this.imprumutTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCartiImprumut)).EndInit();
            this.statisticiTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsersAnual)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage disponibilTab;
        private System.Windows.Forms.TabPage imprumutTab;
        private System.Windows.Forms.TabPage statisticiTab;
        private System.Windows.Forms.DataGridView dataGridCartiDisponibile;
        private System.Windows.Forms.DataGridView dataGridCartiImprumut;
        private System.Windows.Forms.Label disponibilLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsersAnual;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox anImprumutListBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
    }
}