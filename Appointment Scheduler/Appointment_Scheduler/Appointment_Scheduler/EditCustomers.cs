using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Appointment_Scheduler
{
    public partial class EditCustomers : Form
    {
        Customer customer = new Customer();
        List<Customer> customerList;

        public EditCustomers(ref List<Customer> customerList)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.customerList = customerList;
        }
        
        public EditCustomers(ref List<Customer> customerList, Customer customer)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.customerList = customerList;
            this.customer = customer;
            txtAddress1.Text = customer.Address;
            txtAddress2.Text = customer.Address2;
            txtCity.Text = customer.City;
            txtCountry.Text = customer.Country;
            txtName.Text = customer.CustomerName;
            txtPhoneNumber.Text = customer.Phone;
            txtPostalCode.Text = customer.PostalCode;
        }
        
        private void btnApply_Click(object sender, EventArgs e)
        {
            bool stop = false;
            
            foreach (Control tBox in this.Controls.OfType<TextBox>())
            {
                if(tBox != txtAddress2)
                    stop = string.IsNullOrEmpty(tBox.Text);
                if (stop)
                    break;
            }
            
            if (!stop)
            {
                string name = txtName.Text, address1 = txtAddress1.Text, address2 = txtAddress2.Text,
                postalCode = txtPostalCode.Text, phoneNumber = txtPhoneNumber.Text, city = txtCity.Text,
                country = txtCountry.Text;
                int active = cbxActive.Checked ? 1 : 0;
                
                if (customer.CustomerID == 0)
                {
                    new Customer().Add(country, city, address1, address2, postalCode, phoneNumber, name, active, ref customerList);
                }
                else
                {
                    new Customer().Update(country, city, address1, address2, postalCode, phoneNumber, name, active, ref customer, ref customerList);
                }
                Close();
            }
            else
            {
                MessageBox.Show("Please fill out all fields.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
