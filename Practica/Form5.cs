using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double codigo, ingM, InnsL, InnsP, IR;
            if (treeView1.SelectedNode.Text == "")
            {
                MessageBox.Show("Seleccione una rama");
            }else if (textBox6.Text == "")
            {
                MessageBox.Show("No se aceptan espacios, Digite su nombre");
                textBox6.Focus();
            }
            else if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("No se aceptan espacios, Digite su codigo de INNS");
                maskedTextBox1.Focus();
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("No se aceptan espacios, Digite su salario mensual");
                textBox1.Focus();
            }
            else if (textBox1.Text=="0")
            {
                MessageBox.Show("No se acepta ceros, Digite su salario mensual");
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                codigo = Convert.ToDouble(maskedTextBox1.Text);
                if (treeView1.SelectedNode.Text.Equals("INNS Laboral"))
                {
                    ingM = Convert.ToDouble(textBox1.Text);
                    if (ingM < 6000 || ingM > 500000)
                    {
                        MessageBox.Show("Rango entre 6,000 a 500,000");
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    else
                    {
                        textBox3.Text = "";
                        textBox4.Text = "";
                        InnsL = ingM * 0.07;
                        ingM = ingM - InnsL;
                        textBox2.Text = InnsL.ToString();
                        textBox5.Text = ingM.ToString();
                    }
                }
                else if (treeView1.SelectedNode.Text.Equals("INNS Patronal"))
                {
                    ingM = Convert.ToDouble(textBox1.Text);
                    if (ingM < 6000 || ingM > 500000)
                    {
                        MessageBox.Show("Rango entre 6,000 a 500,000");
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    else
                    {
                        textBox2.Text = "";
                        textBox4.Text = "";
                        InnsP = ingM * 0.22;
                        textBox3.Text = InnsP.ToString();
                        textBox5.Text = ingM.ToString();
                    }

                }
                else if (treeView1.SelectedNode.Text.Equals("IR"))
                {
                    ingM = Convert.ToDouble(textBox1.Text);
                    if (ingM < 6000 || ingM > 500000)
                    {
                        MessageBox.Show("Rango entre 6,000 a 500,000");
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    else
                    {
                        textBox2.Text = "";
                        textBox3.Text = "";
                        IR = ingM * 0.11;
                        ingM = ingM - IR;
                        textBox4.Text = IR.ToString();
                        textBox5.Text = ingM.ToString();
                    }
                }



            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("No se puede agregar sin antes cacular el salarion mensual");
            }
            else
            {

                int i = 0;
                double n = 0;
                for (n = 0; n < dataGridView1.Rows.Count - 1; n++)
                {

                }

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = n + 1;
                row.Cells[1].Value = textBox6.Text;
                row.Cells[2].Value = textBox2.Text;
                row.Cells[3].Value = textBox3.Text;
                row.Cells[4].Value = textBox4.Text;
                row.Cells[5].Value = textBox5.Text;
                row.Cells[6].Value = maskedTextBox1.Text;

                dataGridView1.Rows.Add(row);
                textBox1.Text = "";
                maskedTextBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                maskedTextBox1.Focus();
            }
        }
    }
}
