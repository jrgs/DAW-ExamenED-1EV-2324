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
        int divisionRestas(int AERG2324dividendo, int AERG2324divisor)
        {
            // Declaramos una variable para almacenar el resultado.
            //AERG2324.SEGUNDO ERROR.MODIFICAMOS EL VALOR INICIAL DE CONT 
            //int cont = 0;
            int cont = 1;
            // Restamos el divisor al dividendo
            //
            while (AERG2324dividendo > AERG2324divisor)
            {//! AERG2324.PRIMER ERROR.SE HA DE CAMBIARLAS VARIABLES DE ORDEN
                AERG2324dividendo -= AERG2324divisor;
                    //AERG2324divisor -= AERG2324dividendo;
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
                int AERG2324dividendo, AERG2324divisor, resultado;

                // Leemos los valores del cuadro de texto.
                AERG2324dividendo = int.Parse(txtDividendo.Text);
                AERG2324divisor = int.Parse(txtDivisor.Text);

                // Comprobamos que el divisor no sea cero.
                if (AERG2324divisor == 0)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor no puede ser cero.");
                }
                // Comprobamos que el divisor no sea mayor que el dividendo.
                //AERG2324.TERCER ERROR.SE HA DE QUITAR EL SIGNO = PARA QUE NO SALTE A LA EXCEPCION EN CASO DE QUE DIVIDENDO Y DIVISOR SEAN IGUALES
               // if (AERG2324dividendo <= AERG2324divisor)
               if(AERG2324dividendo < AERG2324divisor)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor ha de ser menor que el dividendo.");
                }

                // Llamamos a la función para realizar la división.
                resultado = divisionRestas(AERG2324dividendo, AERG2324divisor);

                // Mostramos el resultado.
                MessageBox.Show("El resultado de dividir " + AERG2324dividendo + " entre " + AERG2324divisor + " es : " + resultado);
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