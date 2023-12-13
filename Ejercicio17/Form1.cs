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
        // Contamos cuantas veces "cabe" el dividendoIMS2324 en el divisorIMS2324.
        int divisionRestas(int dividendoIMS2324, int divisor2324)
        {
            // Declaramos una variable para almacenar el resultado.
            int cont = 0;

            // Restamos el divisorIMS2324 al dividendoIMS2324
            //
            while (dividendoIMS2324 >= divisor2324)  //Código corregido antes: dividendoIMS2324 > divisor2324
            {
                dividendoIMS2324 -= divisor2324; //Código corregidoantes: divisor2324 -= dividendoIMS2324
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
                int dividendoIMS2324, divisorIMS2324, resultado;

                // Leemos los valores del cuadro de texto.
                dividendoIMS2324 = int.Parse(txtDividendo.Text);
                divisorIMS2324 = int.Parse(txtDivisor.Text);

                // Comprobamos que el divisorIMS2324 no sea cero.
                if (divisorIMS2324 == 0)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisorIMS2324 no puede ser cero.");
                }
                // Comprobamos que el divisorIMS2324 no sea mayor que el dividendoIMS2324.
                if (dividendoIMS2324 < divisorIMS2324) //Código corregido antes: dividendoIMS2324 <= divisorIMS2324
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisorIMS2324 ha de ser menor o igual que el dividendoIMS2324."); //Código corregido antes: "El divisorIMS2324 ha de ser menor que el dividendoIMS2324."
                }

                // Llamamos a la función para realizar la división.
                resultado = divisionRestas(dividendoIMS2324, divisorIMS2324);

                // Mostramos el resultado.
                MessageBox.Show("El resultado de dividir " + dividendoIMS2324 + " entre " + divisorIMS2324 + " es : " + resultado);
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