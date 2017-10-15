namespace SalonEntity
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
            this.components = new System.ComponentModel.Container();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnShowAddCustomerForm = new System.Windows.Forms.Button();
            this.dgVvisits = new System.Windows.Forms.DataGridView();
            this.lblVisits = new System.Windows.Forms.Label();
            this.frmCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.frmCustomerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgVvisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmCustomerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(252, 243);
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(201, 20);
            this.tbNotes.TabIndex = 3;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(480, 240);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(42, 13);
            this.lblRows.TabIndex = 6;
            this.lblRows.Text = "Zeilen: ";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(204, 246);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(46, 13);
            this.lblNotes.TabIndex = 7;
            this.lblNotes.Text = "Notizen:";
            // 
            // btnShowAddCustomerForm
            // 
            this.btnShowAddCustomerForm.Location = new System.Drawing.Point(450, 270);
            this.btnShowAddCustomerForm.Name = "btnShowAddCustomerForm";
            this.btnShowAddCustomerForm.Size = new System.Drawing.Size(75, 23);
            this.btnShowAddCustomerForm.TabIndex = 10;
            this.btnShowAddCustomerForm.Text = "Add ";
            this.btnShowAddCustomerForm.UseVisualStyleBackColor = true;
            this.btnShowAddCustomerForm.Click += new System.EventHandler(this.btnShowAddCustomerForm_Click);
            // 
            // dgVvisits
            // 
            this.dgVvisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVvisits.Location = new System.Drawing.Point(12, 318);
            this.dgVvisits.Name = "dgVvisits";
            this.dgVvisits.Size = new System.Drawing.Size(510, 69);
            this.dgVvisits.TabIndex = 11;
            // 
            // lblVisits
            // 
            this.lblVisits.AutoSize = true;
            this.lblVisits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisits.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVisits.Location = new System.Drawing.Point(12, 302);
            this.lblVisits.Name = "lblVisits";
            this.lblVisits.Size = new System.Drawing.Size(37, 13);
            this.lblVisits.TabIndex = 12;
            this.lblVisits.Text = "Visits";
            // 
            // frmCustomerBindingSource
            // 
            this.frmCustomerBindingSource.DataSource = typeof(SalonEntity.FrmCustomer);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 13;
            // 
            // frmCustomerBindingSource1
            // 
            this.frmCustomerBindingSource1.DataSource = typeof(SalonEntity.FrmCustomer);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 399);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblVisits);
            this.Controls.Add(this.dgVvisits);
            this.Controls.Add(this.btnShowAddCustomerForm);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.tbNotes);
            this.Name = "FrmCustomer";
            this.ShowIcon = false;
            this.Text = "Salon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCustomer_FormClosing);
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVvisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmCustomerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnShowAddCustomerForm;
        private System.Windows.Forms.DataGridView dgVvisits;
        private System.Windows.Forms.Label lblVisits;
        private System.Windows.Forms.BindingSource frmCustomerBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource frmCustomerBindingSource1;
    }
}
#endregion