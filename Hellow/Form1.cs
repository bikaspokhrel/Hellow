using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hellow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            //lblOutput.Text = "Hellow World";
            //lblOutput.Text = txtInput.Text; //this will outuput the text input by users in the textbox
            //lbxHello.Items.Add(txtInput.Text);//this will add items from the textbox to the list box
            string Country = "New Zealand";
            string Name = txtInput.Text;
            lbxHello.Items.Add(Country);
            MessageBox.Show("Hi My Name is " +Name+ ", I came from " + Country + ", which is a beautiful nation");
        }
        
        private void lbxHello_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxHello.Items.Clear();
        }
    }
}
