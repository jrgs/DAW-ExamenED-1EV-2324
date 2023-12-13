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
        // Contamos cuantas veces "cabe" el dividendo en el divisor.
        int divisionRestas(int dividendoRCM2324, int divisorRCM2324)
        {
            //? Aqui cambio la variable cont por 0

            // Declaramos una variable para almacenar el resultado.
            int cont = 1;

            // Restamos el divisor al dividendo

            //invierto dividendo y divisor
            while (dividendoRCM2324 > divisorRCM2324)
            {
                 dividendoRCM2324 -= divisorRCM2324;

                cont ++;
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
                int dividendoRCM, divisorRCM, resultado;

                // Leemos los valores del cuadro de texto.
                dividendoRCM = int.Parse(txtDividendo.Text);
                divisorRCM = int.Parse(txtDivisor.Text);

                // Comprobamos que el divisor no sea cero.
                if (divisorRCM == 0)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor no puede ser cero.");
                }

                // suprimo el igual
                // Comprobamos que el divisor no sea mayor que el dividendo.
                if (dividendoRCM < divisorRCM)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor ha de ser menor que el dividendo.");
                }
               

                // Llamamos a la función para realizar la división.
                resultado = divisionRestas(dividendoRCM, divisorRCM);

                // Mostramos el resultado.
                MessageBox.Show("El resultado de dividir " + dividendoRCM + " entre " + divisorRCM + " es : " + resultado);
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