using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        Form2 menu = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Evelyn")
            {
                if (textBox2.Text == "Ecespinoza")
                {
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña invalida", "Error");
                    textBox2.Text = "";
                    textBox2.Focus();
                }
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto", "Error");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
