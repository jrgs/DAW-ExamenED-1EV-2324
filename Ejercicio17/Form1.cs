using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenED1EV2324
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int divisionRestas(int dividendoEV2324, int divisorEV2324)
        {
            int cont = 1;

            while (dividendoEV2324 > divisorEV2324)
            {
                    dividendoEV2324 -= divisorEV2324;
                    cont++;
            }

            return cont;
        }
        private void btDividir_Click(object sender, EventArgs e)
        {
            try
            {
                int dividendoEV2324, divisorEV2324, resultado;

                dividendoEV2324 = int.Parse(txtDividendo.Text);
                divisorEV2324 = int.Parse(txtDivisor.Text);

                if (divisorEV2324 == 0)
                {
                    throw new Exception("El divisorEV2324 no puede ser cero.");
                }
                if (dividendoEV2324 < divisorEV2324)
                {
                    throw new Exception("El divisorEV2324 ha de ser menor que el dividendoEV2324.");
                }

                resultado = divisionRestas(dividendoEV2324, divisorEV2324);

                MessageBox.Show("El resultado de dividir " + dividendoEV2324 + " entre " + divisorEV2324 + " es : " + resultado);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}