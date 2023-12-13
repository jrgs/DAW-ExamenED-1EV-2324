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
        float divisionRestas(float dividendoSGL2324, float divisorSGL2324)
        {
            // Declaramos una variable para almacenar el resultado.
            float cont = 1;

            // Realizamos la division
           
              cont= dividendoSGL2324 / divisorSGL2324;
            

            // Devolvemos el resultado.
            return cont;
        }

        // Evento que se llama al pulsar el botón "Dividir".
        private void btDividir_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaramos las variables necesarias.
                float dividendoSGL2324, divisorSGL2324, resultado;

                // Leemos los valores del cuadro de texto.
                dividendoSGL2324 = float.Parse(txtDividendo.Text);
                divisorSGL2324 = float.Parse(txtDivisor.Text);

                // Comprobamos que el divisor no sea cero.
                if (divisorSGL2324 == 0)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor no puede ser cero.");
                }
              
                // Llamamos a la función para realizar la división.
                resultado = divisionRestas(dividendoSGL2324, divisorSGL2324);

                // Mostramos el resultado.
                MessageBox.Show("El resultado de dividir " + dividendoSGL2324 + " entre " + divisorSGL2324 + " es : " + resultado);
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