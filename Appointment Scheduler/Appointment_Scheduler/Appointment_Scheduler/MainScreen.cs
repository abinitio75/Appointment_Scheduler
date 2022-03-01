using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Timers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Appointment_Scheduler
{
    public partial class MainScreen : Form
    {
        private static SortedList<DateTime, Appointment> appointmentList = new SortedList<DateTime, Appointment>();
        private List<Customer> customerList = new List<Customer>();

        private readonly System.Timers.Timer timer = new System.Timers.Timer(300000);

        public MainScreen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void MainScreen_Load(object sender, EventArgs e)
        {
            customerList = new Customer().GetCustomerList();
            tsBtnMonthView_Click(tsBtnMonthView, new System.EventArgs());
            StartTimer();
            System.Timers.Timer t = new System.Timers.Timer(1500);
            t.Elapsed += CheckAppointmentInterval;
            t.Enabled = true;
            t.AutoReset = false;
        }

        private void StartTimer()
        {
            timer.Elapsed += CheckAppointmentInterval;
            timer.Enabled = true;
            GC.KeepAlive(timer);
            timer.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tsBtnCustomerList.Checked)
            {
                new EditCustomers(ref customerList).ShowDialog();
                tsBtnCustomerList_Click(tsBtnCustomerList, new System.EventArgs());
            }
            else
            {
                new EditAppointments(ref customerList, ref appointmentList).ShowDialog();
                
                if (tsBtnMonthView.Checked)
                    tsBtnMonthView_Click(tsBtnMonthView, new System.EventArgs());
                else
                    tsBtnWeekView_Click(tsBtnWeekView, new System.EventArgs());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvView.CurrentRow.Selected)
            {
                if (tsBtnCustomerList.Checked)
                {
                    new EditCustomers(ref customerList, (Customer)dgvView.CurrentRow.DataBoundItem).ShowDialog();
                    tsBtnCustomerList_Click(tsBtnCustomerList, new System.EventArgs());
                }
                else
                {
                    new EditAppointments((Appointment)dgvView.CurrentRow.DataBoundItem, ref customerList, ref appointmentList).ShowDialog();
                    
                    if (tsBtnMonthView.Checked)
                        tsBtnMonthView_Click(tsBtnMonthView, new System.EventArgs());
                    else
                        tsBtnWeekView_Click(tsBtnWeekView, new System.EventArgs());
                }
            }
            else
                MessageBox.Show("Please make a selection first.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvView.CurrentRow.Selected)
            {
                if (tsBtnCustomerList.Checked)
                {
                    new Customer().Delete((int)dgvView.CurrentRow.Cells["customerId"].Value);
                    tsBtnCustomerList_Click(tsBtnCustomerList, new System.EventArgs());
                }

                else
                {
                    new Appointment().Delete((int)dgvView.CurrentRow.Cells["appointmentId"].Value);
                    if (tsBtnMonthView.Checked)
                        tsBtnMonthView_Click(tsBtnMonthView, new System.EventArgs());
                    else
                        tsBtnWeekView_Click(tsBtnWeekView, new System.EventArgs());
                }
            }
        }
        
        private void tsBtnMonthView_Click(object sender, EventArgs e)
        {
            UncheckButtons(ref sender);
            SetView();
            tsLabelAppointment.Text = "Month Appointments";
        }
        
        private void tsBtnWeekView_Click(object sender, EventArgs e)
        {   
            UncheckButtons(ref sender);
            SetView();
            tsLabelAppointment.Text = "Week Appointments";
        }

        private void tsBtnCustomerList_Click(object sender, EventArgs e)
        {
            UncheckButtons(ref sender);
            SetView();
        }
        
        private void SetView()
        {
            if (!tsBtnCustomerList.Checked)
            {
                appointmentList = new Appointment().GetAppointments(tsBtnMonthView.Checked);
                dgvView.DataSource = appointmentList.Select(vals => vals.Value).ToList();
            }
            else
            {
                customerList = new Customer().GetCustomerList();
                dgvView.DataSource = customerList;
                dgvView.Columns["customerName"].DisplayIndex = 0;
                dgvView.Columns["phone"].DisplayIndex = 1;
                dgvView.Columns["address"].DisplayIndex = 2;
                dgvView.Columns["address2"].DisplayIndex = 3;
                dgvView.Columns["postalCode"].DisplayIndex = 4;
                dgvView.Columns["city"].DisplayIndex = 5;
                dgvView.Columns["country"].DisplayIndex = 6;
                tsLabelAppointment.Text = "Customer List";
            }
        }
        
        private void UncheckButtons(ref object sender)
        {
            foreach (ToolStripButton btn in toolStrip1.Items.OfType<ToolStripButton>())
            {
                btn.Checked = sender == btn;
            }
        }

        private void CheckAppointmentInterval(object caller, ElapsedEventArgs e)
        {
            if(appointmentList.Count > 0)
            {
                Func<SortedList<DateTime, Appointment>, DateTime, DateTime, string> checkForUpcomingAppointment = (apptList, dtNow, dtRange) =>
                   apptList.Values.AsEnumerable().Where(appt => appt.Start > dtNow &&
                   appt.Start < dtRange).Select(appt => appt.CustomerName).DefaultIfEmpty<string>("").First();

                string appointmentName;
                DateTime now = DateTime.Now;
                DateTime range = now.AddMinutes(15);
                
                appointmentName = checkForUpcomingAppointment(appointmentList, now, range);
                
                if (!string.IsNullOrEmpty(appointmentName))
                {
                    DateTime appt = appointmentList.Where(appointment => appointment.Value.CustomerName ==
                        appointmentName).Select(kvp => kvp.Key).FirstOrDefault();
                    
                    MessageBox.Show("You have an upcoming appointment with " + appointmentName + " at " + 
                        appt.ToString("t"));
                }
            }
        }
        
        private void btnAppointmentTypeReport_Click(object sender, EventArgs e)
        {
            Hide();
            new Reports(0).ShowDialog();
            Show();
        }

        private void btnScheduleReport_Click(object sender, EventArgs e)
        {
            Hide();
            new Reports("").ShowDialog();
            Show();
        }

        private void btnPeakTimes_Click(object sender, EventArgs e)
        {
            Hide();
            new Reports().ShowDialog();
            Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e) => Close();

        private void btnExit_Click(object sender, EventArgs e) => System.Windows.Forms.Application.Exit();
    }
}
