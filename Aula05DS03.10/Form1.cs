using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula05DS03._10
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMostrar1_Click(object sender, EventArgs e)
        {
            listBoxNumeros.Items.Clear();

            for (int i = 1; i <= numericUpDownValor.Value; i++)
            {
                listBoxNumeros.Items.Add(i);
            }
        }

        private void buttonMostrar2_Click(object sender, EventArgs e)
        {
            listBoxNumeros.Items.Clear();

            int aux = 1;

            while (aux <= numericUpDownValor.Value)
            {
                listBoxNumeros.Items.Add(aux);
                aux++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxValorB.Items.Clear();

            int aux = 1;

            while (aux <= 10)
            {
                listBoxValorB.Items.Add(aux + " X " + numericUpDownB.Value + " = " + aux * numericUpDownB.Value);
                aux++;
            }
        }

        private void labelValorB_Click(object sender, EventArgs e)
        {

        }

        private void buttonMostrarA_Click(object sender, EventArgs e)
        {
            listBoxValorA.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {
                listBoxValorA.Items.Add(i+" X "+ numericUpDownA.Value+" = "+i * numericUpDownA.Value);
            }
        }

        private void listBoxNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
