using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Diana_B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero1) && int.TryParse(textBox2.Text, out int numero2))
            //Comparar los números
            {
                if (numero1 > numero2)
                {
                    MessageBox.Show($"El número {numero1} es mayor que el {numero2}");
                }
                else if (numero2 > numero1)
                {
                    MessageBox.Show($"El número {numero2} es mayor que el {numero1}");
                }
                else
                {
                    MessageBox.Show($"¡Es un empate! {numero1} y {numero2} son iguales!");
                }
            }
            else
            {
                MessageBox.Show("Uyy, por favor ingresa un número válido! :(");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
