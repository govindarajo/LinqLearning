using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnanymousMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button1 = new Button();
            button1.Text = "Click Me";
            button1.Click += delegate { MessageBox.Show("Clicked me"); };//Button1_Click;
            this.Controls.Add(button1);


        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Clicked me");
        //   // throw new NotImplementedException();
        //}

        
    }
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
