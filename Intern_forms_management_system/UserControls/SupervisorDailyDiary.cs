﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Intern_forms_management_system.UserControls
{
    public partial class SupervisorDailyDiary : UserControl
    {
        public SupervisorDailyDiary()
        {
            InitializeComponent();
        }

        private void btnViewDiary_Click(object sender, EventArgs e)
        {
            try
            {
                DbOperation dbops = new DbOperation();
                DataSet ds = new DataSet();
                ds = dbops.viewDailyDiary(cmbStdID.SelectedItem.ToString(), dateTimeFrom.Value.ToString("yyyy-MM-dd"), dateTimeTo.Value.ToString("yyyy-MM-dd"));
                dailyDiaryView.DataSource = ds;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void SupervisorDailyDiary_Load(object sender, EventArgs e)
        {
            try
            {
                DbOperation dbops = new DbOperation();
                DataTable dataTabl1 = new DataTable();
                dataTabl1 = dbops.loadStudentId();
                int indx = 0;

                while (indx < dataTabl1.Rows.Count)
                {
                    try
                    {
                        object name = dataTabl1.Rows[indx]["studentId"];

                        cmbStdID.Items.Add(name.ToString());

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    indx++;
                }
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
