namespace SalonADOStart_BS
{
    partial class FrmAddCustomer
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblVorname = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtBlastname = new System.Windows.Forms.TextBox();
            this.txtBforename = new System.Windows.Forms.TextBox();
            this.dtPbirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblFemale = new System.Windows.Forms.Label();
            this.cbFemale = new System.Windows.Forms.CheckBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtBnotes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(197, 226);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.Text = "Add ";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Location = new System.Drawing.Point(9, 29);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(54, 13);
            this.lblVorname.TabIndex = 1;
            this.lblVorname.Text = "Forename";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(10, 71);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(53, 13);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Lastname";
            // 
            // txtBlastname
            // 
            this.txtBlastname.Location = new System.Drawing.Point(12, 87);
            this.txtBlastname.Name = "txtBlastname";
            this.txtBlastname.Size = new System.Drawing.Size(100, 20);
            this.txtBlastname.TabIndex = 1;
            // 
            // txtBforename
            // 
            this.txtBforename.Location = new System.Drawing.Point(13, 46);
            this.txtBforename.Name = "txtBforename";
            this.txtBforename.Size = new System.Drawing.Size(100, 20);
            this.txtBforename.TabIndex = 0;
            // 
            // dtPbirthday
            // 
            this.dtPbirthday.Location = new System.Drawing.Point(12, 133);
            this.dtPbirthday.Name = "dtPbirthday";
            this.dtPbirthday.Size = new System.Drawing.Size(200, 20);
            this.dtPbirthday.TabIndex = 2;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(12, 114);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(45, 13);
            this.lblBirthday.TabIndex = 6;
            this.lblBirthday.Text = "Birthday";
            // 
            // lblFemale
            // 
            this.lblFemale.AutoSize = true;
            this.lblFemale.Location = new System.Drawing.Point(12, 169);
            this.lblFemale.Name = "lblFemale";
            this.lblFemale.Size = new System.Drawing.Size(41, 13);
            this.lblFemale.TabIndex = 7;
            this.lblFemale.Text = "Female";
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.Location = new System.Drawing.Point(60, 169);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(15, 14);
            this.cbFemale.TabIndex = 3;
            this.cbFemale.UseVisualStyleBackColor = true;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(9, 203);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 9;
            this.lblNotes.Text = "Notes";
            // 
            // txtBnotes
            // 
            this.txtBnotes.Location = new System.Drawing.Point(15, 219);
            this.txtBnotes.Name = "txtBnotes";
            this.txtBnotes.Size = new System.Drawing.Size(100, 20);
            this.txtBnotes.TabIndex = 4;
            // 
            // FrmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtBnotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.cbFemale);
            this.Controls.Add(this.lblFemale);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.dtPbirthday);
            this.Controls.Add(this.txtBforename);
            this.Controls.Add(this.txtBlastname);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblVorname);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "FrmAddCustomer";
            this.Text = "FrmAddCustomer";
            this.Load += new System.EventHandler(this.FrmAddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtBlastname;
        private System.Windows.Forms.TextBox txtBforename;
        private System.Windows.Forms.DateTimePicker dtPbirthday;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblFemale;
        private System.Windows.Forms.CheckBox cbFemale;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtBnotes;
    }
}