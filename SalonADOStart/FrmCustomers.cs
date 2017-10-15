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

namespace SalonADOStart
{


    public partial class FrmCustomer : Form
    {
        private const string SQLCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=salon;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private SqlConnection con;
        private SqlDataAdapter daCustomers;
        private DataTable dtCustomers;

        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            initCustomers();
        }

        private void initCustomers()
        {
            this.con = new SqlConnection(SQLCon);
            this.daCustomers = new SqlDataAdapter();
            this.daCustomers.RowUpdated += DaCustomers_RowUpdated;
            this.dtCustomers = new DataTable();
            this.dtCustomers.RowDeleted += DtCustomers_RowDeleted;
            this.dtCustomers.ColumnChanged += DtCustomers_ColumnChanged;


            this.daCustomers.SelectCommand = new SqlCommand("SELECT * FROM Customers Order by CustomerId", this.con);
            SqlCommandBuilder scb = new SqlCommandBuilder(this.daCustomers);
            this.daCustomers.UpdateCommand = scb.GetUpdateCommand();
            this.daCustomers.InsertCommand = scb.GetInsertCommand();
            this.daCustomers.DeleteCommand = scb.GetDeleteCommand();

            this.daCustomers.Fill(this.dtCustomers);
            dgvCustomer.DataSource = this.dtCustomers;
        }

        private void DaCustomers_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.StatementType == StatementType.Insert)
            {
                SqlCommand cmd = new SqlCommand("SELECT @@IDENTITY", con);
                long identity = Int64.TryParse(cmd.ExecuteScalar().ToString(), out identity) ? identity : -1;
                if (identity == -1) return;
                e.Row["CustomerId"] = identity;
                e.Status = UpdateStatus.SkipCurrentRow;
            }
        }

        private void DtCustomers_RowDeleted(object sender, DataRowChangeEventArgs e)
        {
        }

        private void DtCustomers_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            //this.daCustomers.Update(this.dtCustomers);
        }

        private bool newCustomer(string firstName, string lastName, DateTime birthDay, bool isFemale)
        {
            try
            {
                DataRow dataRow = this.dtCustomers.NewRow();
                dataRow.SetField<string>("FName", firstName);
                dataRow.SetField<string>("LName", lastName);
                dataRow.SetField<DateTime>("BirthDay", birthDay);
                dataRow.SetField<bool>("Female", isFemale);

                this.dtCustomers.Rows.Add(dataRow);
                this.daCustomers.Update(this.dtCustomers);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            DateTime dtBirthday = DateTime.Parse(tbGeburtstag.Text);

            newCustomer(tbVorname.Text, tbNachname.Text, dtBirthday, cbIsFemale.Checked);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
