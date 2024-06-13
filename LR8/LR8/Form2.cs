using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateArrVectorForm new_1 = new CreateArrVectorForm(this);
            this.Hide();
            new_1.Show();
            new_1.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateLinkedListVectorForm new_2 = new CreateLinkedListVectorForm(this);
            this.Hide();
            new_2.Show();
            new_2.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateVectorsForm new_3 = new CreateVectorsForm(this);
            this.Hide();
            new_3.Show();
            new_3.Focus();
        }
    }
}
