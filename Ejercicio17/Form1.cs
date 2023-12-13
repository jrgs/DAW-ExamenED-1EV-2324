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
        int divisionRestas(int dividendo_MMA2324, int divisor_MMA2324)
        {
            // Declaramos una variable para almacenar el resultado.
            int cont = 0;

            // Restamos el divisor al dividendo
            //
            while (dividendo_MMA2324 > 0)
            {
                    dividendo_MMA2324 = dividendo_MMA2324 - divisor_MMA2324;
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
                int dividendo_MMA2324, divisor_MMA2324, resultado;

                // Leemos los valores del cuadro de texto.
                dividendo_MMA2324 = int.Parse(txtDividendo.Text);
                divisor_MMA2324 = int.Parse(txtDivisor.Text);

                // Comprobamos que el divisor no sea cero.
                if (divisor_MMA2324 == 0)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor no puede ser cero.");
                }
                // Comprobamos que el divisor no sea mayor que el dividendo.
                if (dividendo_MMA2324 < divisor_MMA2324)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor ha de ser menor que el dividendo.");
                }

                // Llamamos a la función para realizar la división.
                resultado = divisionRestas(dividendo_MMA2324, divisor_MMA2324);

                // Mostramos el resultado.
                MessageBox.Show("El resultado de dividir " + dividendo_MMA2324 + " entre " + divisor_MMA2324 + " es : " + resultado);
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