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
            this.emailUser = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.disponibilTab = new System.Windows.Forms.TabPage();
            this.dataGridCartiDisponibile = new System.Windows.Forms.DataGridView();
            this.imprumutTab = new System.Windows.Forms.TabPage();
            this.statisticiTab = new System.Windows.Forms.TabPage();
            this.dataGridCartiImprumut = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.disponibilTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCartiDisponibile)).BeginInit();
            this.imprumutTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCartiImprumut)).BeginInit();
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
            this.dataGridCartiDisponibile.Size = new System.Drawing.Size(1201, 759);
            this.dataGridCartiDisponibile.TabIndex = 0;
            // 
            // imprumutTab
            // 
            this.imprumutTab.Controls.Add(this.dataGridCartiImprumut);
            this.imprumutTab.Location = new System.Drawing.Point(8, 39);
            this.imprumutTab.Name = "imprumutTab";
            this.imprumutTab.Padding = new System.Windows.Forms.Padding(3);
            this.imprumutTab.Size = new System.Drawing.Size(1228, 803);
            this.imprumutTab.TabIndex = 1;
            this.imprumutTab.Text = "Carti imprumutate";
            this.imprumutTab.UseVisualStyleBackColor = true;
            // 
            // statisticiTab
            // 
            this.statisticiTab.Location = new System.Drawing.Point(8, 39);
            this.statisticiTab.Name = "statisticiTab";
            this.statisticiTab.Padding = new System.Windows.Forms.Padding(3);
            this.statisticiTab.Size = new System.Drawing.Size(1228, 803);
            this.statisticiTab.TabIndex = 2;
            this.statisticiTab.Text = "Statistici biblioteca";
            this.statisticiTab.UseVisualStyleBackColor = true;
            // 
            // dataGridCartiImprumut
            // 
            this.dataGridCartiImprumut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCartiImprumut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCartiImprumut.Location = new System.Drawing.Point(14, 22);
            this.dataGridCartiImprumut.Name = "dataGridCartiImprumut";
            this.dataGridCartiImprumut.RowHeadersWidth = 82;
            this.dataGridCartiImprumut.RowTemplate.Height = 33;
            this.dataGridCartiImprumut.Size = new System.Drawing.Size(1201, 759);
            this.dataGridCartiImprumut.TabIndex = 1;
            // 
            // MeniuFreeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCartiImprumut)).EndInit();
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
    }
}