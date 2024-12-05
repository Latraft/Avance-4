using EDDemo.Estructuras_No_Lineales.Clases;
using Estructuras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDDemo.Estructuras_Lineales.Clases
{
    public partial class frmListas : Form
    {
        ListaCircularDoble lista = new ListaCircularDoble();
        ListaDoblementeEnlazada enlazada = new ListaDoblementeEnlazada();
        private Lista_circular_doble list;


        public frmListas()
        {
            InitializeComponent();
            list = new Lista_circular_doble();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string mostrar = lista.Mostrar();
            btnCircular.Text = mostrar;
        }
        private void frmListas_Load(object sender, EventArgs e)
        {
            
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
              
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }

        private void btnCircular_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int valor;

            if (int.TryParse(btnDatoC.Text, out valor))
            {
                lista.Agregar(valor);
                btnCircular.Text = lista.Mostrar();
            }

            else
            {

                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            btnCircular.Text = "";


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int valor;

            if (int.TryParse(btnValores.Text, out valor))
            {
                enlazada.Agregar(valor);
                btnMostrar.Text = enlazada.MostrarDesdeFinal();
            }

            else
            {

                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string mostrar = enlazada.MostrarDesdeFinal();
            btnMostrar.Text = mostrar;
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            btnMostrar.Text = " ";
            

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            int valor;

            if (int.TryParse(btnValores.Text, out valor))
            {
                enlazada.Agregar(valor);
                btnMostrar.Text = enlazada.MostrarDesdeInicio();
            }

            else
            {

                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            list.CrearListaVacia();
            MessageBox.Show("Se ha creado una lista vacía.");
        }

        private void btnInser_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int dato))
            {
                list.Insertar(dato);
                MessageBox.Show("Dato insertado correctamente.");
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }
        }

        private void btnVerL_Click(object sender, EventArgs e)
        {
            textBox1.Text = list.VerLista();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(btnInser.Text, out int dato))
            {
                var nodo = list.Buscar(dato);
                textBox2.Text = nodo != null ? "Dato encontrado." : "Dato no encontrado.";
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int dato))
            {
                bool eliminado = list.Eliminar(dato);
                textBox1.Text = eliminado ? "Dato eliminado correctamente." : "Dato no encontrado.";
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.");
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
