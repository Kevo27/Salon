using SalonEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonEntity
{
    
    public partial class FrmCustomer : Form
    {
        private const string SQLCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=salon;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public SqlDataAdapter daCustomers;
        public BindingSource CustomersBs = new BindingSource();
        public BindingSource VisitsBs = new BindingSource();
        public DataTable customerTable = new DataTable("Customers");
        public DataTable visitsTable = new DataTable("Visits");
        public SqlDataAdapter daVisits;

        private BindingSource bsVisits = new BindingSource();

        DataSet data = new DataSet();

        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            initCustomers();
        }

        public void initCustomers()
        {
            try
            {
                daCustomers = new SqlDataAdapter("SELECT * FROM Customers ", SQLCon);
                daVisits = new SqlDataAdapter("SELECT * FROM Visits ", SQLCon);

                SqlCommandBuilder daCustomerCommandBuilder = new SqlCommandBuilder(daCustomers);
                SqlCommandBuilder daVisitsCommandBuilder = new SqlCommandBuilder(daVisits);

                // Add data from the Customers table to the DataSet.
                daCustomers = new
                     SqlDataAdapter("select * from Customers", SQLCon);
                daCustomers.Fill(data, "Customers");

                // Add data from the Orders table to the DataSet.
                daVisits = new
                    SqlDataAdapter("select * from Visits", SQLCon);
                daVisits.Fill(data, "Visits");


                // Establish a relationship between the two tables.
                DataRelation relation = new DataRelation("CustomersVisits",
                    data.Tables["Customers"].Columns["CustomerID"],
                    data.Tables["Visits"].Columns["CustomerID"]);
                data.Relations.Add(relation);

                CustomersBs.DataSource = data;
                CustomersBs.DataMember = "Customers";

                VisitsBs.DataSource = CustomersBs;
                VisitsBs.DataMember = "CustomersVisits";

                this.daCustomers.Fill(customerTable);
                this.daVisits.Fill(visitsTable);

                daCustomers.InsertCommand = daCustomerCommandBuilder.GetInsertCommand();
                daCustomers.UpdateCommand = daCustomerCommandBuilder.GetUpdateCommand();
                daCustomers.DeleteCommand = daCustomerCommandBuilder.GetDeleteCommand();

                daVisits.InsertCommand = daVisitsCommandBuilder.GetInsertCommand();
                daVisits.UpdateCommand = daVisitsCommandBuilder.GetUpdateCommand();
                daVisits.DeleteCommand = daVisitsCommandBuilder.GetDeleteCommand();


                this.dgvCustomer.AutoGenerateColumns = false;
                this.dgvCustomer.DataSource = CustomersBs;
                this.dgvCustomer.ReadOnly = true;

                this.dgVvisits.AutoGenerateColumns = false;
                this.dgVvisits.DataSource = VisitsBs;

                //Add columns for DataGridView Customers
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "FName";
                column.Name = "Forename";
                this.dgvCustomer.Columns.Add(column);

                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "LName";
                column.Name = "Lastname";
                this.dgvCustomer.Columns.Add(column);

                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "Birthday";
                column.Name = "Birthday";
                this.dgvCustomer.Columns.Add(column);

                DataGridViewColumn cFemale = new DataGridViewCheckBoxColumn();
                cFemale.DataPropertyName = "Female";
                cFemale.Name = "Female";
                this.dgvCustomer.Columns.Add(cFemale);

                //Add columns for DataGridView Visits
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "VisitDate";
                column.Name = "Date";
                this.dgVvisits.Columns.Add(column);

                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "ActDuration";
                column.Name = "Duration";
                this.dgVvisits.Columns.Add(column);

                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "Notes";
                column.Name = "Note";
                this.dgVvisits.Columns.Add(column);

                if (this.dgvCustomer.RowCount > 0)
                {
                    if (this.tbNotes.DataBindings.Count > 0)
                    {
                        this.tbNotes.DataBindings.Clear();
                    }

                    this.tbNotes.DataBindings.Add("Text", CustomersBs, "Notes");
                    this.lblRows.Text = "Zeilen: " + Convert.ToString(this.dgvCustomer.RowCount);
                }

                CustomersBs.CurrentChanged += Bs_CurrentChanged;
                VisitsBs.CurrentChanged += Visits_CurrentChanged;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(String.Format("Sql Error: {0}", sqlEx));
            }
        }

        private void Visits_CurrentChanged(object sender, EventArgs e)
        {
            daVisits.Update(data.Tables["Visits"]);
        }

        private void Bs_CurrentChanged(object sender, EventArgs e)
        {
            daCustomers.Update(data.Tables["Customers"]);
        }

        private void btnShowAddCustomerForm_Click(object sender, EventArgs e)
        {
            //FrmAddCustomer formAddCustomer = new FrmAddCustomer(this);
            //formAddCustomer.Show();
        }

        private void initVisits ()
        {

        }

        private void FrmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomersBs.EndEdit();
            VisitsBs.EndEdit();
            daVisits.Update(data.Tables["Visits"]);
            daCustomers.Update(data.Tables["Customers"]);
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
