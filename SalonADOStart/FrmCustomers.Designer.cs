namespace SalonADOStart
{
    partial class FrmCustomer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.tbNachname = new System.Windows.Forms.TextBox();
            this.tbGeburtstag = new System.Windows.Forms.TextBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.cbIsFemale = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(513, 225);
            this.dgvCustomer.TabIndex = 0;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(12, 252);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Zählen";
            this.btnCount.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(450, 289);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // tbVorname
            // 
            this.tbVorname.Location = new System.Drawing.Point(57, 291);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(99, 20);
            this.tbVorname.TabIndex = 3;
            // 
            // tbNachname
            // 
            this.tbNachname.Location = new System.Drawing.Point(162, 291);
            this.tbNachname.Name = "tbNachname";
            this.tbNachname.Size = new System.Drawing.Size(99, 20);
            this.tbNachname.TabIndex = 4;
            // 
            // tbGeburtstag
            // 
            this.tbGeburtstag.Location = new System.Drawing.Point(267, 291);
            this.tbGeburtstag.Name = "tbGeburtstag";
            this.tbGeburtstag.Size = new System.Drawing.Size(99, 20);
            this.tbGeburtstag.TabIndex = 5;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(486, 240);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(39, 13);
            this.lblRows.TabIndex = 6;
            this.lblRows.Text = "Zeilen:";
            // 
            // cbIsFemale
            // 
            this.cbIsFemale.AutoSize = true;
            this.cbIsFemale.Location = new System.Drawing.Point(372, 293);
            this.cbIsFemale.Name = "cbIsFemale";
            this.cbIsFemale.Size = new System.Drawing.Size(71, 17);
            this.cbIsFemale.TabIndex = 7;
            this.cbIsFemale.Text = "Is Female";
            this.cbIsFemale.UseVisualStyleBackColor = true;
            this.cbIsFemale.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 324);
            this.Controls.Add(this.cbIsFemale);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.tbGeburtstag);
            this.Controls.Add(this.tbNachname);
            this.Controls.Add(this.tbVorname);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "FrmCustomer";
            this.ShowIcon = false;
            this.Text = "Kunden";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.TextBox tbNachname;
        private System.Windows.Forms.TextBox tbGeburtstag;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.CheckBox cbIsFemale;
    }
}

