using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public partial class frmCola : Form
    {
        private List<int> varillaA = new List<int>();
        private List<int> varillaB = new List<int>();
        private List<int> varillaC = new List<int>();
        private int numberOfDiscs;

        private bool cancelarEjecucion = false;
        public frmCola()
        {
            InitializeComponent();
        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }
        private void MostrarEstado()
        {
            lblVarillaA.Text = "Varilla A: " + string.Join(" ", varillaA);
            lblVarillaB.Text = "Varilla B: " + string.Join(" ", varillaB);
            lblVarillaC.Text = "Varilla C: " + string.Join(" ", varillaC);
        }

        private string GetVarillaNombre(List<int> varilla)
        {
            if (varilla == varillaA) return "A";
            if (varilla == varillaB) return "B";
            if (varilla == varillaC) return "C";
            return "Desconocida";
        }


        private void Solve(int numberOfDiscs, List<int> fromRod, List<int> toRod, List<int> auxRod)
        {
            
            if (cancelarEjecucion) return;

            if (numberOfDiscs == 1)
            {
              
                int disc = fromRod[0];
                fromRod.RemoveAt(0);
                toRod.Insert(0, disc);

            
                lblProgreso.Text = $"Mueve disco {disc} de {GetVarillaNombre(fromRod)} a {GetVarillaNombre(toRod)}";
                MostrarEstado();

                
                Application.DoEvents();
                return;
            }

            
            Solve(numberOfDiscs - 1, fromRod, auxRod, toRod);

            
            if (cancelarEjecucion) return;

      
            int currentDisc = fromRod[0];
            fromRod.RemoveAt(0);
            toRod.Insert(0, currentDisc);

            lblProgreso.Text = $"Mueve disco {currentDisc} de {GetVarillaNombre(fromRod)} a {GetVarillaNombre(toRod)}";
            MostrarEstado();

            Application.DoEvents();

            
            if (cancelarEjecucion) return;

         
            Solve(numberOfDiscs - 1, auxRod, toRod, fromRod);
        }




        private void lblVarillaA_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtDiscos.Text, out numberOfDiscs) && numberOfDiscs > 0)
            {
                cancelarEjecucion = false; 

                btnIniciar.Enabled = false; 
                btnDetener.Enabled = true; 

                
                varillaA.Clear();
                varillaB.Clear();
                varillaC.Clear();

                
                for (int i = numberOfDiscs; i > 0; i--)
                {
                    varillaA.Add(i);
                }

                
                MostrarEstado();
                lblProgreso.Text = "Resolviendo...";

                
                Solve(numberOfDiscs, varillaA, varillaC, varillaB);

                if (!cancelarEjecucion)
                {
                    lblProgreso.Text = "¡Completado!";
                }

                btnIniciar.Enabled = true; 
                btnDetener.Enabled = false; 
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número entero positivo.");
            }
        }

        private void btnMoverDiscos_Click(object sender, EventArgs e)
        {

        }

        private void lblProgreso_Click(object sender, EventArgs e)
        {

        }

        private void lblVarillaB_Click(object sender, EventArgs e)
        {

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            cancelarEjecucion = true;
            lblProgreso.Text = "Ejecución detenida.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int Fibonacci(int n)
        {
            if (n == 0) return 0; // Caso base 1
            if (n == 1) return 1; // Caso base 2
            return Fibonacci(n - 1) + Fibonacci(n - 2); // Llamada recursiva
        }

        private void btnFiabIn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(btnFib.Text, out int n) && n >= 0)
            {
                int resultado = Fibonacci(n); // Usamos la versión iterativa
                btnResult.Text = $"Fibonacci({n}) = {resultado}";
            }
            else
            {
                MessageBox.Show("Introduce un número entero no negativo.");
            }
        }
    }
}
