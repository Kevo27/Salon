using SalonADOStart;
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

namespace SalonADOStart_BS
{

    public partial class FrmAddCustomer : Form
    {
        private const string SQLCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=salon;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private FrmCustomer mainForm = null;

        public FrmAddCustomer(FrmCustomer callingForm)
        {
            mainForm = callingForm as FrmCustomer;
            InitializeComponent();
        }
          
        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if(txtBforename.Text == null || txtBforename.Text == String.Empty || txtBlastname.Text == null || txtBlastname.Text == String.Empty)
            {
                MessageBox.Show("Forename and Lastname cannot be empty!");
                return;
            }
            if(dtPbirthday.Value >= DateTime.Now)
            {
                MessageBox.Show("Please select a valid birthday date");
                return;
            }

            AddCustomer(txtBforename.Text, txtBlastname.Text, dtPbirthday.Value, cbFemale.Checked, txtBnotes.Text);         
        }

        private void AddCustomer(string FName, string LName, DateTime Birthday, Boolean Female, string Notes)
        {
            
            DataRow dr = this.mainForm.customerTable.NewRow();

            dr[1] = FName;
            dr[2] = LName;
            dr[3] = Birthday;
            dr[4] = Female;
            dr[5] = Notes;

            this.mainForm.customerTable.Rows.Add(dr);               

            this.mainForm.daCustomers.Update(this.mainForm.customerTable);

            MessageBox.Show("User Added!");
            ClearData();

        }
        private void ClearData()
        {
            this.txtBforename.Text = "";
            this.txtBlastname.Text = "";
            this.dtPbirthday.Value = DateTime.Now;
            this.cbFemale.Checked = false;
            this.txtBnotes.Text = "";
        }
        private void RefreshCustomerForm()
        {
            this.mainForm.initCustomers();
           
        }


    }
}
