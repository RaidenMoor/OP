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
    public partial class LinkedListVectorForm : Form
    {
        Form2 menu;
        LinkedListVector vector;
        public LinkedListVectorForm()
        {
            InitializeComponent();
        }
        public LinkedListVectorForm(Form2 menu, LinkedListVector vector)
        {
            InitializeComponent();
            this.menu = menu;
            this.vector = vector;
            label3.Text = vector.ToString();
        }
        private void LinkedListVectorForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "Модуль равен:" + vector.GetNorm();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                vector.AddElement(Convert.ToInt32(textBox5.Text));
                label3.Text = vector.ToString();
            }
            catch (FormatException)
            {
                string message = "Вы ввели недопустимое значение.";
                MessageBox.Show(message);
            }
            catch (ArgumentOutOfRangeException)
            {
                string message = "Элемента с таким индексом не существует.";
                MessageBox.Show(message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            menu.Show();
            menu.Focus();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string index_str = textBox1.Text;
                int index = Convert.ToInt32(index_str);
                string value_str = textBox3.Text;
                int value = Convert.ToInt32(value_str);
                vector[index] = value;
                label9.Text = "Значение уcпешно изменено";
                label3.Text = "Вектор: " + vector.ToString();

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label9.Text = "Длина вектора равна:" + vector.Length;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                vector.DeleteFromStart();
                label3.Text = vector.ToString();
            }
            catch (IndexOutOfRangeException)
            {
                string message = "Список пуст!";
                MessageBox.Show(message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                vector.DeleteFromEnd();
                label3.Text = vector.ToString();
            }
            catch (IndexOutOfRangeException)
            {
                string message = "Список пуст!";
                MessageBox.Show(message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                vector.DeleteElement(Convert.ToInt32(textBox2.Text));
                label3.Text = vector.ToString();
            }
            catch (FormatException)
            {
                string message = "Вы ввели недопустимое значение.";
                MessageBox.Show(message);
            }
            catch (ArgumentOutOfRangeException)
            {
                string message = "Элемента с таким индексом не существует.";
                MessageBox.Show(message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            vector.AddToStart();
            label3.Text = vector.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            vector.AddToTheEnd();
            label3.Text= vector.ToString();
        }
    }
}
