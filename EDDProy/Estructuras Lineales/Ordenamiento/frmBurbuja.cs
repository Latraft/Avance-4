using OrdenamientoShellsort;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrdenamientoQuickSort;
using OrdenamientoInsertionSort;

namespace EDDemo.Estructuras_Lineales.Busqueda
{
    public partial class frmBurbuja : Form
    {
     
        public frmBurbuja()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer la entrada del TextBox
                string entrada = txtEntrada.Text;
                int[] numeros = entrada.Split(',').Select(int.Parse).ToArray();

                // Ordenar la lista con el método Burbuja
                Burbuja(numeros);

                // Mostrar la lista ordenada en el Label
                lblResultado.Text = "Lista ordenada: " + string.Join(", ", numeros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingresa una lista de números válidos separados por comas.\nError: " + ex.Message);
            }
        }
        private void Burbuja(int[] lista)
        {
            int n = lista.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (lista[j] > lista[j + 1])
                    {
                        // Intercambiar los elementos
                        int temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }
        }
    
    private void txtEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenarShellsort_Click(object sender, EventArgs e)
        {
            try
            {
                
                string entrada = txtNumeros.Text;
                int[] numeros = entrada.Split(',').Select(int.Parse).ToArray();

               
                Ordenador.Shellsort(numeros);

                
                lblResultadoOrdenado.Text = "Lista ordenada: " + string.Join(", ", numeros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingresa una lista de números válidos separados por comas.\nError: " + ex.Message);
            }
        }

        private void btnOrdenarQuickSort_Click(object sender, EventArgs e)
        {
            try
            {
                string entrada = txtNumero.Text;
                int[] numeros = entrada.Split(',').Select(int.Parse).ToArray();

                
                Ordenado.QuickSort(numeros);

                lblResultadoL.Text = "Lista ordenada: " + string.Join(", ", numeros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingresa una lista de números válidos separados por comas.\nError:" + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                string entrada = txtNumerosU.Text;
                int[] numeros = entrada.Split(',').Select(int.Parse).ToArray();


                Ordenada.InsertionSort(numeros);

                ImprimirArreglo(numeros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, ingresa una lista de números válidos separados por comas.\nError:" + ex.Message);
            }
        }
        private void ImprimirArreglo(int[] arr)
        {
            lblResultadorU.Text = "Lista ordenada: " + string.Join(", ", arr);
        }
        private void frmBurbuja_Load(object sender, EventArgs e)
        {


        }

        private void txtNumerosU_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
   
}

