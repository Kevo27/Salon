using SalonEntity_new;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonEntity
{
    
    public partial class FrmCustomer : Form
    {
        SalonEntities _dbcontext;

        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set events
            customerBindingSource.CurrentChanged += customerBindingSource_CurrentChanged;
            visitBindingSource.CurrentChanged += visitBindingSource_CurrentChanged;

            //Load customer context
            this._dbcontext = new SalonEntities();
            this._dbcontext.Customers.Load();
            this.customerBindingSource.DataSource =
                    _dbcontext.Customers.Local.ToBindingList();

            //Load visits
            this._dbcontext.Visits.Load();
            this.customerBindingSource.MoveFirst();
            this.visitBindingSource.DataSource = ((Customer)this.customerBindingSource.Current).Visits;

            //Load Listbox
            this.lBcustomers.DataSource = this._dbcontext.Customers.ToList();
            this.lBcustomers.ValueMember = "FullName";

        }

        private void visitBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this._dbcontext.SaveChanges();
        }

        private void customerBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this._dbcontext.SaveChanges();
            this.visitBindingSource.DataSource = ((Customer)this.customerBindingSource.Current).Visits;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer();
            
            if(txtBlastname.Text.ToString() == "" || txtBlastname.Text.ToString() == null || txtBsurename.Text.ToString() == "" || txtBsurename.Text.ToString() == null)
            {
                MessageBox.Show("Please check your input!");
            };

            newCustomer.FName = txtBsurename.Text;
            newCustomer.LName = txtBlastname.Text;

            this._dbcontext.Customers.Add(newCustomer);

            this._dbcontext.SaveChanges();

            this.txtBsurename.Text = "";
            this.txtBlastname.Text = "";

            this.lBcustomers.DataSource = this._dbcontext.Customers.ToList();


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._dbcontext.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._dbcontext.Customers.Remove((Customer)this.customerBindingSource.Current);
            this._dbcontext.SaveChanges();
            this.lBcustomers.DataSource = this._dbcontext.Customers.ToList();
        }
    }
}
