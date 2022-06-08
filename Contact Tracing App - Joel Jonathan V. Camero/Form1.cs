using System;
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
            
            file.WriteLine("Name: ");
            file.WriteLine("Age: ");
            file.WriteLine("Address: ");
            file.WriteLine("Phone #: ");
            file.WriteLine("Email Address: ");
            file.WriteLine("Time: ");
            file.WriteLine("Date: ");
            file.WriteLine("Temperature: ");
            file.WriteLine("");
            file.WriteLine("-------------------------------------------------------------------------------------"); //separator of info of people
            file.Close();   
        }
    }
}
