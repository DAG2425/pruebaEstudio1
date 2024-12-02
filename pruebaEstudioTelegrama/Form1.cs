using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaEstudioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            double coste = 0;
            textoTelegrama = txtTelegrama.Text;

            char[] delimitadores = new char[] { ' ', '\r' , '\n' };
            int numPalabras = textoTelegrama.Split(delimitadores, StringSplitOptions.RemoveEmptyEntries).Length;

            if (rdbOrdinario.Checked)
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);

            if (rdbUrgente.Checked)
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);

            if (!rdbOrdinario.Checked && !rdbUrgente.Checked)
                MessageBox.Show("Poe favor, indica el tipo de telegrama a enviar");
          

            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
    
}
