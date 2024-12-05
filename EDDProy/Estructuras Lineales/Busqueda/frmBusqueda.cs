using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BúsquedaSecuencial;
using BúsquedaPorHashing;

namespace EDDemo.Estructuras_Lineales.Busqueda
{
    public partial class frmBusqueda : Form
    {
        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void MostrarResultado(int índice)
        {
            if (índice == -1)
            {
                lblResultado.Text = "Elemento no encontrado.";
            }
            else
            {
                lblResultado.Text = $"Elemento encontrado en el índice: {índice}.";
            }
        }


        public static class Ordenador
        {
            public static int BúsquedaSecuencial(int[] arr, int objetivo)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == objetivo)
                    {
                        return i; 
                    }
                }
                return -1; 
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                
                string entrada = txtNumero.Text;
                int[] numeros = entrada.Split(',').Select(int.Parse).ToArray();

               
                int objetivo = int.Parse(txtObjetivo.Text);

            
                int índice = Ordenador.BúsquedaSecuencial(numeros, objetivo);

                
                MostrarResultado(índice);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        
        }

        private void txtNumeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObjetivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void MostrarResultados(int índice)
        {
            if (índice == -1)
            {
                lblResulta2.Text = "Elemento no encontrado.";
            }
            else
            {
                lblResulta2.Text = $"Elemento encontrado en el índice: {índice}.";
            }
        }

        private void btnBuscarr_Click(object sender, EventArgs e)
        {
            try
            {

                string entrada = txtNumeros.Text;


                if (string.IsNullOrWhiteSpace(entrada))
                {
                    MessageBox.Show("Por favor ingrese una lista de números.");
                    return;
                }


                string[] numerosComoCadenas = entrada.Split(',')
                                              .Select(s => s.Trim()) 
                                              .Where(s => !string.IsNullOrEmpty(s)) 
                                              .ToArray();


                int[] numeros = new int[numerosComoCadenas.Length];
                for (int i = 0; i < numerosComoCadenas.Length; i++)
                {
                    if (!int.TryParse(numerosComoCadenas[i], out numeros[i]))
                    {
                        MessageBox.Show($"El valor '{numerosComoCadenas[i]}' no es un número válido.");
                        return; 
                    }
                }


                if (int.TryParse(txtObjetivos.Text, out int objetivo))
                {

                    int tamañoTabla = 10;
                    int[] tablaHash = new int[tamañoTabla];


                    for (int i = 0; i < numeros.Length; i++)
                    {
                        int índic = Ordenad.FunciónHash(numeros[i], tamañoTabla);
                        tablaHash[índic] = numeros[i];
                    }


                    int índice = Ordenad.BúsquedaPorHashing(tablaHash, objetivo);

                    MostrarResultados(índice);
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un número válido en el campo de búsqueda.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}