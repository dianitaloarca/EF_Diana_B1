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

        private void label1_Click(object sender, EventArgs e)
            //Obligar al usuario a elegir dos numeros diferentes y compararlos
        {
            if (int.TryParse(textBox1.Text, out int numero))
            {   if (numero > 0 && < 250)
                    MessageBox.Show("el número es mayor");
            }
        }
    }
}
