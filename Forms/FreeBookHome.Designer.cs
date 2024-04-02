namespace AplicatieFreeBook.Forms
{
    partial class FreeBookHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreeBookHome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logInbutton = new System.Windows.Forms.Button();
            this.singUpbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplicatieFreeBook.Properties.Resources.sigla_Biblioteca_Alexandria;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1034, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logInbutton
            // 
            this.logInbutton.BackColor = System.Drawing.Color.Bisque;
            this.logInbutton.Location = new System.Drawing.Point(223, 632);
            this.logInbutton.Name = "logInbutton";
            this.logInbutton.Size = new System.Drawing.Size(246, 89);
            this.logInbutton.TabIndex = 1;
            this.logInbutton.Text = "Logare";
            this.logInbutton.UseVisualStyleBackColor = false;
            this.logInbutton.Click += new System.EventHandler(this.logInbutton_Click);
            // 
            // singUpbutton
            // 
            this.singUpbutton.BackColor = System.Drawing.Color.Bisque;
            this.singUpbutton.Location = new System.Drawing.Point(597, 632);
            this.singUpbutton.Name = "singUpbutton";
            this.singUpbutton.Size = new System.Drawing.Size(246, 89);
            this.singUpbutton.TabIndex = 2;
            this.singUpbutton.Text = "Inregistrare";
            this.singUpbutton.UseVisualStyleBackColor = false;
            this.singUpbutton.Click += new System.EventHandler(this.singUpbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 498);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1035, 128);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FreeBookHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1063, 751);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.singUpbutton);
            this.Controls.Add(this.logInbutton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FreeBookHome";
            this.Text = "FreeBookHome";
            this.Load += new System.EventHandler(this.FreeBookHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logInbutton;
        private System.Windows.Forms.Button singUpbutton;
        private System.Windows.Forms.TextBox textBox1;
    }
}