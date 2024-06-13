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
    public partial class CreateLinkedListVectorForm : Form
    {
        Form2 menu;
        public CreateLinkedListVectorForm()
        {
            InitializeComponent();
        }
        public CreateLinkedListVectorForm(Form2 menu)
        {
            InitializeComponent();
            this.menu = menu;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            LinkedListVector vector = new LinkedListVector(Convert.ToInt32(numericUpDown1.Value));
            try
            {
                double[] user_values = (textBox1.Text).Split(' ').Select(double.Parse).ToArray();
                if (vector.Length != user_values.Length)
                {
                    string message = "Вы ввели недопустимы вектор! Повторите ввод!";
                    MessageBox.Show(message);

                }
                else
                {
                    for (int i = 0; i < vector.Length; i++)
                    {
                        vector[i] = user_values[i];
                    }

                    LinkedListVectorForm vector_form = new LinkedListVectorForm(menu, vector);
                    vector_form.Show();
                    this.Close();
                }
            }
            catch
            {
                string message = "Вы ввели недопустимы вектор! Повторите ввод!";
                MessageBox.Show(message);
            }
        }
        public void Create()
        {
            LinkedListVector vector = new LinkedListVector(Convert.ToInt32(numericUpDown1.Value));
            try
            {
                double[] user_values = (textBox1.Text).Split(' ').Select(double.Parse).ToArray();
                if (vector.Length != user_values.Length)
                {
                    string message = "Вы ввели недопустимы вектор! Повторите ввод!";
                    MessageBox.Show(message);

                }
                else
                {
                    for(int i =0; i < vector.Length;i++)
                    {
                        vector[i] = user_values[i];
                    }
                    
                    LinkedListVectorForm vector_form = new LinkedListVectorForm(menu, vector);
                    vector_form.Show();
                    vector_form.Focus();
                    this.Close();
                }
            }
            catch
            {
                string message = "Вы ввели недопустимы вектор! Повторите ввод!";
                MessageBox.Show(message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.Show();
            menu.Focus();
            this.Close();
        }

        private void CreateLinkedListVectorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
