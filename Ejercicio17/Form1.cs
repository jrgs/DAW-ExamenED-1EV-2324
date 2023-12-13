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
        // Contamos cuantas veces "cabe" el dividendo en el divisorCBT1Z.
        int divisionRestas(int dividendoCBT1Z, int divisorCBT1Z)
        {
            // Declaramos una variable para almacenar el resultado.
            int cont = 1;

            // Restamos el divisorCBT1Z al dividendoCBT1Z
            //
            while (dividendoCBT1Z > divisorCBT1Z)
            {
                
                dividendoCBT1Z -=divisorCBT1Z;
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
                int dividendoCBT1Z, divisorCBT1Z, resultado;

                // Leemos los valores del cuadro de texto.
                dividendoCBT1Z = int.Parse(txtDividendo.Text);
                divisorCBT1Z = int.Parse(txtDivisor.Text);

                // Comprobamos que el divisorCBT1Z no sea cero.
                if (divisorCBT1Z == 0)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor no puede ser cero.");
                }
                // Comprobamos que el divisorCBT1Z no sea mayor que el dividendo.
                if (dividendoCBT1Z < divisorCBT1Z)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor ha de ser menor que el dividendo.");
                }

                // Llamamos a la función para realizar la división.
                resultado = divisionRestas(dividendoCBT1Z, divisorCBT1Z);

                // Mostramos el resultado.
                MessageBox.Show("El resultado de dividir " + dividendoCBT1Z + " entre " + divisorCBT1Z + " es : " + resultado);
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