using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIC_FINDER
{
    public partial class NIC_FINDER : Form
    {
        public NIC_FINDER()
        {
            InitializeComponent();
        }

        bool checkIsInteger(string nicNo)
        {
            return !Regex.IsMatch(nicNo, @"^\d+$");
        }

        void onError()
        {
            lblGender.Text = "GENDER";
            txtDOB.Text = "DATE OF BIRTH";
            lblAge.Text = "AGE";
            lblDay.Text = "DAY";
            txtNIC.Focus();
        }

        string findAge(DateTime DOB)
        {
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(DOB).Ticks).Year - 1;
            DateTime PastYearDate = DOB.AddYears(Years);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == Now)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= Now)
                {
                    Months = i - 1;
                    break;
                }
            }
            int Days = Now.Subtract(PastYearDate.AddMonths(Months)).Days;
            int Hours = Now.Subtract(PastYearDate).Hours;
            int Minutes = Now.Subtract(PastYearDate).Minutes;
            int Seconds = Now.Subtract(PastYearDate).Seconds;
            return String.Format("{0} Years {1} Months {2} Days",
            Years, Months, Days);

            //{ 3} Hour(s) {4} Second(s)
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string nicNo = txtNIC.Text;
            int dayText, day = 0;
            string year, month="", gender;
            if(nicNo.Length != 10 && nicNo.Length!= 12)
            {
                MessageBox.Show("10 or 12 Digits Number Required");
                onError();
            }
            else if (nicNo.Length==10 && checkIsInteger(nicNo.Substring(0, 9)))
            {
                MessageBox.Show("Invalid NIC No");
                onError();
            }
            else
            {
                if(nicNo.Length==10)
                {
                    year = "19" + nicNo.Substring(0,2);
                    dayText =  Convert.ToInt32(nicNo.Substring(2, 3));
                }
                else
                {
                    year = nicNo.Substring(0,4);
                    dayText = Convert.ToInt32(nicNo.Substring(4, 3));
                }

                //Gender
                if (dayText > 500)
                {
                    gender = "Female";
                    dayText = dayText - 500;
                }
                else gender = "Male";

                if(dayText<1 && dayText>366)
                {
                    MessageBox.Show("Invalid NIC No");
                    onError();
                }
                else
                {
                    //Month
                    if (dayText > 335)
                    {
                        day = dayText - 335;
                        month = "December";
                    }
                    else if (dayText > 305)
                    {
                        day = dayText - 305;
                        month = "November";
                    }
                    else if (dayText > 274)
                    {
                        day = dayText - 274;
                        month = "October";
                    }
                    else if (dayText > 244)
                    {
                        day = dayText - 244;
                        month = "September";
                    }
                    else if (dayText > 213)
                    {
                        day = dayText - 213;
                        month = "August";
                    }
                    else if (dayText > 182)
                    {
                        day = dayText - 182;
                        month = "July";
                    }
                    else if (dayText > 152)
                    {
                        day = dayText - 152;
                        month = "June";
                    }
                    else if (dayText > 121)
                    {
                        day = dayText - 121;
                        month = "May";
                    }
                    else if (dayText > 91)
                    {
                        day = dayText - 91;
                        month = "April";
                    }
                    else if (dayText > 60)
                    {
                        day = dayText - 60;
                        month = "March";
                    }
                    else if (dayText < 32)
                    {
                        month = "January";
                        day = dayText;
                    }
                    else if (dayText > 31)
                    {
                        day = dayText - 31;
                        month = "February";
                    }

                    //Clipboard.SetText("");
                    //MessageBox.Show(gender+" ("+year+"/"+month+"/"+day+")");
                    lblGender.Text = gender;
                    txtDOB.Text = $"{year}/{month}/{day}";
                    //MessageBox.Show(Convert.ToDateTime(txtDOB.Text).ToString());
                    try
                    {
                        lblAge.Text = findAge(Convert.ToDateTime(txtDOB.Text));
                        lblDay.Text = Convert.ToDateTime(txtDOB.Text).ToString("dddd");
                    }
                    catch(Exception exc)
                    {
                        lblAge.Text = "AGE";
                        lblDay.Text = "DAY";
                        //MessageBox.Show("Birth Date is Incorrect");
                    }
                }

            }
        }

        private void txtNIC_KeyDown(object sender, KeyEventArgs e)
        {
            string NICNo = txtNIC.Text;
            if (e.KeyCode == Keys.Enter)
            {
                txtNIC.Text = NICNo;
                btnFind.PerformClick();
            }
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            string message = "© 2020 Mohamed Nifras. All Rights Reserved"; 
            message+="\n\nFor More Help: ";
            message += "\n\nContact No: 0772794984 / 0757906198";
            message += "\n\nEmail: 3mpresent@gmail.com";
            MessageBox.Show(message);
        }
    }
}
