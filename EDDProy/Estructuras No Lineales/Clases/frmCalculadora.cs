using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales.Clases
{
    public partial class frmCalculadora : Form
    {
        
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnFactorial_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHazlo_Click(object sender, EventArgs e)
        {
            int valor;

            
            if (int.TryParse(btnFactorial.Text, out valor) && valor >= 0)
            {
              
                BigInteger resultado = CalculadoraFactorial.Factorial(valor);

                
                btnResultado.Text = $"Factorial: {resultado}";
            }
            else
            {
              
                MessageBox.Show("Por favor, ingresa un número válido mayor o igual a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBottar_Click(object sender, EventArgs e)
        {
            btnResultado.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnRespuesta_Click(object sender, EventArgs e)
        {

        }

        private void btnExponenteCalcu_Click(object sender, EventArgs e)
        {
            double baseNumber;
            int exponent;

            // Validar que la base y el exponente ingresados sean números válidos
            if (double.TryParse(btnBaseZ.Text, out baseNumber) && int.TryParse(btnExponenteZ.Text, out exponent) && exponent >= 0)
            {
                // Llamar al método Potencia
                double resultado = CalculoExponente.Potencia(baseNumber, exponent);

                // Mostrar el resultado en btnRespuesta
                btnRespuesta.Text = $"Potencia: {resultado}";
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("Por favor, ingresa una base válida y un exponente mayor o igual a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExponenteZ_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtArreglo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                
                int[] arreglo = txtArreglo.Text
                    .Split(',')                     
                    .Select(int.Parse)             
                    .ToArray();                    

                
                int suma = SumArrayElements(arreglo);

                
                lblResultado.Text = $"Suma: {suma}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Asegúrate de introducir números separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static int SumArrayElements(int[] array)
        {
            return SumArrayElementsRecursive(array, 0);
        }

        private static int SumArrayElementsRecursive(int[] array, int index)
        {
            if (index >= array.Length)
                return 0;

            return array[index] + SumArrayElementsRecursive(array, index + 1);
        }
    }
}
