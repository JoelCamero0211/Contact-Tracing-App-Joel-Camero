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
        public byte visitorNumb = 0;
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            StreamWriter file = new StreamWriter(@"C:\Users\Jr\Desktop\Contact Tracing App\Contact Tracing Information.txt", true);
            file.WriteLine("");
            file.WriteLine("Visitor #" + ++visitorNumb);
            file.WriteLine("Name: " + textBoxName.Text);
            file.WriteLine("Age: " + textBoxAge.Text);
            file.WriteLine("Address: " + textBoxAddress.Text);
            file.WriteLine("Phone #: " + textBoxPhoneNum.Text);
            file.WriteLine("Email Address: " + textBoxEmail.Text);
            file.WriteLine("Time: " + textBoxTime.Text);
            file.WriteLine("Date: " + textBoxDate.Text);
            file.WriteLine("Temperature: " + textBoxTemprtr.Text);
            file.WriteLine("");
            file.WriteLine("-------------------------------------------------------------------------------------"); //separator of info of people
            file.Close();

            MessageBox.Show("Thank you for answering the Contact Tracing Form. Your safety is our priority!");
        }

        private void buttonAddPeople_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxAge.Clear();
            textBoxAddress.Clear();
            textBoxPhoneNum.Clear();
            textBoxEmail.Clear();
            textBoxTime.Clear();
            textBoxDate.Clear();
            textBoxTemprtr.Clear();
        }
    }
}
