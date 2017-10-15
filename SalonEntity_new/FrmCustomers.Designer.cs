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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.Female = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgVisits = new System.Windows.Forms.DataGridView();
            this.lblSurename = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtBsurename = new System.Windows.Forms.TextBox();
            this.txtBlastname = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lBcustomers = new System.Windows.Forms.ListBox();
            this.lblListbox = new System.Windows.Forms.Label();
            this.visitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actDurationMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stylistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitsTreatmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AutoGenerateColumns = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.birthDayDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.Female,
            this.visitsDataGridViewTextBoxColumn});
            this.dgvCustomers.DataSource = this.customerBindingSource;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(443, 99);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.TabStop = false;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Female
            // 
            this.Female.DataPropertyName = "Female";
            this.Female.HeaderText = "WeiblichJN";
            this.Female.Name = "Female";
            this.Female.Width = 50;
            // 
            // dgVisits
            // 
            this.dgVisits.AutoGenerateColumns = false;
            this.dgVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn1,
            this.visitDateDataGridViewTextBoxColumn,
            this.actDurationMinDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn1,
            this.stylistIDDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.visitsTreatmentsDataGridViewTextBoxColumn});
            this.dgVisits.DataSource = this.visitBindingSource;
            this.dgVisits.Location = new System.Drawing.Point(12, 148);
            this.dgVisits.Name = "dgVisits";
            this.dgVisits.Size = new System.Drawing.Size(443, 81);
            this.dgVisits.TabIndex = 1;
            this.dgVisits.TabStop = false;
            // 
            // lblSurename
            // 
            this.lblSurename.AutoSize = true;
            this.lblSurename.Location = new System.Drawing.Point(494, 12);
            this.lblSurename.Name = "lblSurename";
            this.lblSurename.Size = new System.Drawing.Size(49, 13);
            this.lblSurename.TabIndex = 2;
            this.lblSurename.Text = "Vorname";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(603, 12);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(59, 13);
            this.lblLastname.TabIndex = 3;
            this.lblLastname.Text = "Nachname";
            // 
            // txtBsurename
            // 
            this.txtBsurename.Location = new System.Drawing.Point(497, 28);
            this.txtBsurename.Name = "txtBsurename";
            this.txtBsurename.Size = new System.Drawing.Size(100, 20);
            this.txtBsurename.TabIndex = 0;
            // 
            // txtBlastname
            // 
            this.txtBlastname.Location = new System.Drawing.Point(605, 28);
            this.txtBlastname.Name = "txtBlastname";
            this.txtBlastname.Size = new System.Drawing.Size(100, 20);
            this.txtBlastname.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(497, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lBcustomers
            // 
            this.lBcustomers.FormattingEnabled = true;
            this.lBcustomers.Location = new System.Drawing.Point(582, 160);
            this.lBcustomers.Name = "lBcustomers";
            this.lBcustomers.Size = new System.Drawing.Size(123, 69);
            this.lBcustomers.TabIndex = 5;
            // 
            // lblListbox
            // 
            this.lblListbox.AutoSize = true;
            this.lblListbox.Location = new System.Drawing.Point(579, 144);
            this.lblListbox.Name = "lblListbox";
            this.lblListbox.Size = new System.Drawing.Size(43, 13);
            this.lblListbox.TabIndex = 6;
            this.lblListbox.Text = "Listbox:";
            // 
            // visitIDDataGridViewTextBoxColumn
            // 
            this.visitIDDataGridViewTextBoxColumn.DataPropertyName = "VisitID";
            this.visitIDDataGridViewTextBoxColumn.HeaderText = "VisitID";
            this.visitIDDataGridViewTextBoxColumn.Name = "visitIDDataGridViewTextBoxColumn";
            this.visitIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerIDDataGridViewTextBoxColumn1
            // 
            this.customerIDDataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.Name = "customerIDDataGridViewTextBoxColumn1";
            this.customerIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // visitDateDataGridViewTextBoxColumn
            // 
            this.visitDateDataGridViewTextBoxColumn.DataPropertyName = "VisitDate";
            this.visitDateDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.visitDateDataGridViewTextBoxColumn.Name = "visitDateDataGridViewTextBoxColumn";
            // 
            // actDurationMinDataGridViewTextBoxColumn
            // 
            this.actDurationMinDataGridViewTextBoxColumn.DataPropertyName = "ActDurationMin";
            this.actDurationMinDataGridViewTextBoxColumn.HeaderText = "Dauer";
            this.actDurationMinDataGridViewTextBoxColumn.Name = "actDurationMinDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn1
            // 
            this.notesDataGridViewTextBoxColumn1.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn1.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn1.Name = "notesDataGridViewTextBoxColumn1";
            // 
            // stylistIDDataGridViewTextBoxColumn
            // 
            this.stylistIDDataGridViewTextBoxColumn.DataPropertyName = "StylistID";
            this.stylistIDDataGridViewTextBoxColumn.HeaderText = "StylistID";
            this.stylistIDDataGridViewTextBoxColumn.Name = "stylistIDDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Visible = false;
            // 
            // visitsTreatmentsDataGridViewTextBoxColumn
            // 
            this.visitsTreatmentsDataGridViewTextBoxColumn.DataPropertyName = "VisitsTreatments";
            this.visitsTreatmentsDataGridViewTextBoxColumn.HeaderText = "VisitsTreatments";
            this.visitsTreatmentsDataGridViewTextBoxColumn.Name = "visitsTreatmentsDataGridViewTextBoxColumn";
            this.visitsTreatmentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataSource = typeof(SalonEntity_new.Visit);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            // 
            // birthDayDataGridViewTextBoxColumn
            // 
            this.birthDayDataGridViewTextBoxColumn.DataPropertyName = "BirthDay";
            this.birthDayDataGridViewTextBoxColumn.HeaderText = "Geburtstag";
            this.birthDayDataGridViewTextBoxColumn.Name = "birthDayDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Visible = false;
            // 
            // visitsDataGridViewTextBoxColumn
            // 
            this.visitsDataGridViewTextBoxColumn.DataPropertyName = "Visits";
            this.visitsDataGridViewTextBoxColumn.HeaderText = "Visits";
            this.visitsDataGridViewTextBoxColumn.Name = "visitsDataGridViewTextBoxColumn";
            this.visitsDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(SalonEntity_new.Customer);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 241);
            this.Controls.Add(this.lblListbox);
            this.Controls.Add(this.lBcustomers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBlastname);
            this.Controls.Add(this.txtBsurename);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblSurename);
            this.Controls.Add(this.dgVisits);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "FrmCustomer";
            this.Text = "Salon - Customer/Visits";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Female;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgVisits;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actDurationMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stylistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitsTreatmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource visitBindingSource;
        private System.Windows.Forms.Label lblSurename;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtBsurename;
        private System.Windows.Forms.TextBox txtBlastname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lBcustomers;
        private System.Windows.Forms.Label lblListbox;
    }
}

