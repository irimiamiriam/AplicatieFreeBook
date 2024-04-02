namespace AplicatieFreeBook.Forms
{
    partial class LogareFreeBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.parolatextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.Logarebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(270, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logare in contul FreeBook";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Parola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            // 
            // parolatextBox
            // 
            this.parolatextBox.Location = new System.Drawing.Point(338, 236);
            this.parolatextBox.Name = "parolatextBox";
            this.parolatextBox.PasswordChar = '*';
            this.parolatextBox.Size = new System.Drawing.Size(432, 31);
            this.parolatextBox.TabIndex = 9;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(338, 156);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(432, 31);
            this.emailtextBox.TabIndex = 8;
            // 
            // Logarebutton
            // 
            this.Logarebutton.BackColor = System.Drawing.Color.SandyBrown;
            this.Logarebutton.Location = new System.Drawing.Point(326, 331);
            this.Logarebutton.Name = "Logarebutton";
            this.Logarebutton.Size = new System.Drawing.Size(306, 67);
            this.Logarebutton.TabIndex = 12;
            this.Logarebutton.Text = "Logare";
            this.Logarebutton.UseVisualStyleBackColor = false;
            this.Logarebutton.Click += new System.EventHandler(this.Logarebutton_Click);
            // 
            // LogareFreeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(959, 444);
            this.Controls.Add(this.Logarebutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.parolatextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.label1);
            this.Name = "LogareFreeBook";
            this.Text = "LogareFreeBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parolatextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Button Logarebutton;
    }
}