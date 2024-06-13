using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR8
{
    public partial class ArrayVectorForm : Form
    {
        Form2 menu;
        ArrayVector vector;
        public ArrayVectorForm()
        {
            InitializeComponent();
        }
        public ArrayVectorForm(ArrayVector vector, Form2 menu)
        {
            InitializeComponent();
            this.vector = vector;
            label2.Text = "Вектор: " + vector.ToString();
            this.menu = menu;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ArrayVectorForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Модуль равен:" + vector.GetNorm();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string index_str = textBox2.Text;
                int index = Convert.ToInt32(index_str);
                string value_str = textBox3.Text;
                int value = Convert.ToInt32(value_str);
                vector[index] = value;
                label9.Text = "Значение уcпешно изменено";
                label2.Text = "Вектор: " + vector.ToString();

            }
            catch (FormatException)
            {
                string message = "Вы ввели недопустимое значение!";
                MessageBox.Show(message);
            }
            catch (IndexOutOfRangeException)
            {
                string message = "Элемента с таким индексом не существует";
                MessageBox.Show(message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string input = textBox4.Text;
            try
            {
                int output = Convert.ToInt32(input);
                label7.Text = "Элемент с заданным индексом:" + Convert.ToString(vector[output]);
            }
            catch (FormatException)
            {
                string message = "Вы ввели недопустимое значение!";
                MessageBox.Show(message);
            }
            catch (IndexOutOfRangeException)
            {
                string message = "Элемента с таким индексом не существует";
                MessageBox.Show(message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label10.Text = "Длина вектора равна:" + vector.Length;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu.Show();
            menu.Focus();
            this.Close();
        }
    }
}
