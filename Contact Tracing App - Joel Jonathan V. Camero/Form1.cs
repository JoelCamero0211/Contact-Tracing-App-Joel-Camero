﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App___Joel_Jonathan_V.Camero
{
    public partial class ContactTracingApp : Form
    {
        public ContactTracingApp()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Jr\Desktop\Contact Tracing App\Contact Tracing Information.txt", true);
            file.WriteLine("");
            file.WriteLine("Name: " + textBoxName.Text);
            file.WriteLine("Age: " + textBoxAge.Text);
            file.WriteLine("Address: " + textBoxAddress.Text);
            file.WriteLine("Phone #: " + textBoxPhoneNum.Text);
            file.WriteLine("Email Address: " + textBoxEmail.Text);
            file.WriteLine("Time: " + textBoxTime.Text);
            file.WriteLine("Date: " + textBoxDate.Text);
            file.WriteLine("Temperature: " + textBoxTemperature.Text);
            file.WriteLine("");
            file.WriteLine("-------------------------------------------------------------------------------------"); //separator of info of people
            file.Close();   
        }
    }
}
