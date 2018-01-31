using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DisplayLabel.Text = "";
        }

        private void MessageButton_Click(object sender, EventArgs e)
        {
            this.DisplayLabel.Text = "Hello " + this.InputTextbox.Text;
            comboBox1.Items.Add("Hello " + this.InputTextbox.Text);
        }

        private void InputTextbox_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.InputTextbox.Text) == false)
                this.MessageButton.Enabled = true;
            else
                this.MessageButton.Enabled = false;
        }

        private void MessageButton_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void MessageButton_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Value changed. New value is "+comboBox1.SelectedItem );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
