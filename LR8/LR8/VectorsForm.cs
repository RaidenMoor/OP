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
    public partial class VectorsForm : Form
    {
        Form2 menu;
        IVectorable firs_vector;
        IVectorable second_vector;
        public VectorsForm()
        {
            InitializeComponent();
        }
        public VectorsForm(IVectorable first_vector, IVectorable second_vector, Form2 menu)
        {
            InitializeComponent();
            this.menu = menu;
            this.firs_vector= first_vector;
            this.second_vector= second_vector;
            label4.Text = first_vector.ToString();
            label5.Text = second_vector.ToString();
        }

        private void VectorsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "Модуль первого вектора: " + firs_vector.GetNorm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "Модуль второго вектора: " + second_vector.GetNorm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (firs_vector .Length != second_vector .Length)
            {
                label8.Text = "Длины векторов не совпадают.";
            }
            else
            {
                label8.Text = "Сумма векторов равна: " + Vectors.Sum(firs_vector, second_vector);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (firs_vector.Length != second_vector.Length)
            {
                label9.Text = "Длины векторов не совпадают.";
            }
            else
            {
                label9.Text = "Скалярное произведение векторов равно: " + Vectors.Scalar(firs_vector, second_vector);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool cmp = firs_vector .Equals(second_vector);
            if (cmp)
            {
                label10.Text  = "Векторы равны.";
            }
            else
            {
                label10.Text = "Векторы не равны.";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            menu.Show();
            menu.Focus();
            this.Close();
        }
    }
}
