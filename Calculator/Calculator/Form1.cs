using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isTypingNumber = false;

        private void btn1_Click(object sender, EventArgs e)
        {
            if (isTypingNumber)
                lblHienThi.Text = lblHienThi.Text + "1";
            else
                lblHienThi.Text = "1";
            isTypingNumber = true;
        
        }
    }
}
