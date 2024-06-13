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
    public partial class CreateArrVectorForm : Form
    {
        Form2 menu;
        public CreateArrVectorForm()
        {
            InitializeComponent();
        }
        public CreateArrVectorForm(Form2 menu)
        {
            this.menu = menu;
            InitializeComponent();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            ArrayVector vector = new ArrayVector(Convert.ToInt32(numericUpDown1.Value));
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
                    vector.vector = user_values;
                    ArrayVectorForm vector_form = new ArrayVectorForm(vector, menu);
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

        private void CreateArrVectorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
