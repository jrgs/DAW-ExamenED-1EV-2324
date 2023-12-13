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

        // Función que realiza una división entera mediante restas sucesivas.
        // Contamos cuantas veces "cabe" el dividendoLCLDAW en el divisorLCLDAW.
        int divisionRestas(int dividendoLCLDAW, int divisorLCLDAW)
        {
            // Declaramos una variable para almacenar el resultado.
            int cont = 1;

            // Restamos el divisorLCLDAW al dividendoLCLDAW
            //
            while (dividendoLCLDAW > divisorLCLDAW)
            {
                    dividendoLCLDAW -= divisorLCLDAW;
                    cont++;
            }

            // Devolvemos el resultado.
            return cont;
        }

        // Evento que se llama al pulsar el botón "Dividir".
        private void btDividir_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaramos las variables necesarias.
                int dividendoLCLDAW, divisorLCLDAW, resultado;

                // Leemos los valores del cuadro de texto.
                dividendoLCLDAW = int.Parse(txtDividendo.Text);
                divisorLCLDAW = int.Parse(txtDivisor.Text);

                // Comprobamos que el divisorLCLDAW no sea cero.
                if (divisorLCLDAW == 0)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor no puede ser cero.");
                }
                // Comprobamos que el divisorLCLDAW no sea mayor que el dividendoLCLDAW.
                if (dividendoLCLDAW < divisorLCLDAW)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor ha de ser menor que el dividendo.");
                }

                // Llamamos a la función para realizar la división.
                resultado = divisionRestas(dividendoLCLDAW, divisorLCLDAW);

                // Mostramos el resultado.
                MessageBox.Show("El resultado de dividir " + dividendoLCLDAW + " entre " + divisorLCLDAW + " es : " + resultado);
            }
            catch (FormatException ex)
            {
                // Capturamos la excepción de formato incorrecto.
                MessageBox.Show("Error de formato: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Capturamos cualquier otra excepción.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}