using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LR8
{
    public partial class CreateVectorsForm : Form
    {
        Form2 menu;
        IVectorable first_vector;
        IVectorable second_vector;
        public CreateVectorsForm()
        {
            InitializeComponent();
        }
        public CreateVectorsForm(Form2 menu)
        {
            InitializeComponent();
            this.menu = menu;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            menu.Show();
            menu.Focus();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((first_vector != null) && (second_vector != null)) 
            {
                VectorsForm vectors = new VectorsForm(first_vector , second_vector, menu);
                vectors.Show();
                vectors.Focus();
                this.Close();
            }
            else
            {
                string message = "Пожалйста, введите все вектора.";
                MessageBox.Show(message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                first_vector = new ArrayVector(Convert.ToInt32(numericUpDown1.Value));


                try
                {
                    double[] user_values = (textBox1.Text).Split(' ').Select(double.Parse).ToArray();
                    if (first_vector.Length != user_values.Length)
                    {
                        string message = "Вы ввели недопустимы вектор! Повторите ввод!";
                        MessageBox.Show(message);

                    }
                    else
                    {
                        for (int i = 0; i < (Convert.ToInt32(numericUpDown1.Value)); i++)
                        {
                            first_vector[i] = user_values[i];
                        }

                    }
                }
                catch
                {
                    string message = "Вы ввели недопустимы вектор! Повторите ввод!";
                    MessageBox.Show(message);
                }
            }
            else
            {
                first_vector = new LinkedListVector(Convert.ToInt32(numericUpDown1.Value));


                try
                {
                    double[] user_values = (textBox1.Text).Split(' ').Select(double.Parse).ToArray();
                    if (first_vector.Length != user_values.Length)
                    {
                        string message = "Вы ввели недопустимы вектор! Повторите ввод!";
                        MessageBox.Show(message);

                    }
                    else
                    {
                        for (int i = 0; i < (Convert.ToInt32(numericUpDown1.Value)); i++)
                        {
                            first_vector[i] = user_values[i];
                        }

                    }
                }
                catch
                {
                    string message = "Вы ввели недопустимы вектор! Повторите ввод!";
                    MessageBox.Show(message);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                second_vector = new ArrayVector(Convert.ToInt32(numericUpDown2.Value));


                try
                {
                    double[] user_values = (textBox2.Text).Split(' ').Select(double.Parse).ToArray();
                    if (second_vector.Length != user_values.Length)
                    {
                        string message = "Вы ввели недопустимы вектор! Повторите ввод!";
                        MessageBox.Show(message);

                    }
                    else
                    {
                        for (int i = 0; i < (Convert.ToInt32(numericUpDown2.Value)); i++)
                        {
                            second_vector[i] = user_values[i];
                        }

                    }
                }
                catch
                {
                    string message = "Вы ввели недопустимы вектор! Повторите ввод!";
                    MessageBox.Show(message);
                }
            }
            else
            {
                second_vector = new LinkedListVector(Convert.ToInt32(numericUpDown2.Value));


                try
                {
                    double[] user_values = (textBox2.Text).Split(' ').Select(double.Parse).ToArray();
                    if (second_vector.Length != user_values.Length)
                    {
                        string message = "Вы ввели недопустимы вектор! Повторите ввод!";
                        MessageBox.Show(message);

                    }
                    else
                    {
                        for (int i = 0; i < (Convert.ToInt32(numericUpDown2.Value)); i++)
                        {
                            second_vector[i] = user_values[i];
                        }

                    }
                }
                catch
                {
                    string message = "Вы ввели недопустимы вектор! Повторите ввод!";
                    MessageBox.Show(message);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CreateVectorsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
