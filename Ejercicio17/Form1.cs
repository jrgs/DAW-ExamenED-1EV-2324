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
        // Contamos cuantas veces "cabe" el dividendo_so2324 en el divisor_so2324.
        int divisionRestas(int dividendo_so2324, int divisor_so2324)
        {
            // Declaramos una variable para almacenar el resultado.
            int cont = 0;

            // Restamos el divisor_so2324 al dividendo_so2324
            //
            while (dividendo_so2324 >= divisor_so2324) // while (dividendo_so2324 > divisor_so2324)
            {
                dividendo_so2324 -= divisor_so2324; //divisor_so2324 -= dividendo_so2324; => 1 error
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
                int dividendo_so2324, divisor_so2324, resultado;

                // Leemos los valores del cuadro de texto.
                dividendo_so2324 = int.Parse(txtDividendo.Text);
                divisor_so2324 = int.Parse(txtDivisor.Text);

                // Comprobamos que el divisor no sea cero.
                if (divisor_so2324 == 0)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor no puede ser cero.");
                }
                // Comprobamos que el divisor_so2324 no sea mayor que el dividendo_so2324.
                if (dividendo_so2324 < divisor_so2324) // if (dividendo_so2324 <= divisor_so2324) => error 3
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor ha de ser menor que el dividendo.");
                }

                // Llamamos a la función para realizar la división.
                resultado = divisionRestas(dividendo_so2324, divisor_so2324);

                // Mostramos el resultado.
                MessageBox.Show("El resultado de dividir " + dividendo_so2324 + " entre " + divisor_so2324 + " es : " + resultado);
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