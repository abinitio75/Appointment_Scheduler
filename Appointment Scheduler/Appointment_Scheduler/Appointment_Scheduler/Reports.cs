using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;

namespace Appointment_Scheduler
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            Height = 290;
            Width = 130;
            dgvReport.Height = 200;
            dgvReport.Width = 110;
            dgvReport.Left = 5;
            btnOkay.Top = 220;
            btnOkay.Left = 35;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prime Time Report";
            PrimeTimeReport();
        }
        
        public Reports(string s)
        {
            InitializeComponent();
            Height = 400;
            Width = 380;
            dgvReport.Height = 300;
            dgvReport.Width = 355;
            dgvReport.Left = 5;
            btnOkay.Top = 325;
            btnOkay.Left = 155;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedule Report";
            ScheduleReport();
        }

        public Reports(int i)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointment Report";
            Height = 400;
            Width = 220;
            dgvReport.Width = 180;
            dgvReport.Height = 300;
            dgvReport.Left = 10;
            btnOkay.Top = 325;
            btnOkay.Left = 75;
            AppointmentReport();
        }

        private void AppointmentReport()
        {
            SortedDictionary<string, SortedDictionary<string, int>> apptReport = new SortedDictionary<string, SortedDictionary<string, int>>();
            
            DateTime start = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime end = start.AddMonths(1);

            try
            {
                do
                {
                    apptReport.Add(
                        System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(start.Month),
                        new Report().GetAppointmentsReport(start, end));
                    start = start.AddMonths(1);
                    end = start.AddMonths(1);
                }
                while (start.Month != 1);
            }
            catch(Exception e)
            {
                Common.WriteToLog(e.Message);
                MessageBox.Show(e.Message);
            }

            dgvReport.DataSource = apptReport.SelectMany(dict => dict.Value, (dict, val) => new
            {
                Month = dict.Key.ToString(),
                Type = val.Key.ToString(),
                Count = val.Value.ToString()
            }).ToList();

        }

        private void ScheduleReport()
        {
            List<object> scheduleReport = new Report().GetScheduleReport();
            dgvReport.DataSource = scheduleReport;
        }

        private void PrimeTimeReport()
        {
            List<object> primeTimeReport = new Report().GetPrimeTimeReport();
            dgvReport.DataSource = primeTimeReport;
        }
        
        private void btnOkay_Click(object sender, EventArgs e) => Close();
    }
}
