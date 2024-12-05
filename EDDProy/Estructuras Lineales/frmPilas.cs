using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using EDDemo.Clases;

namespace EDDemo

{
    public partial class frmPilas : Form
    {
        public Pilas miPila;


        public frmPilas()
        {
            InitializeComponent();
            miPila = new Pilas();



        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            int valor;

            if (int.TryParse(textBox1.Text, out valor))
            {
                miPila.Push(valor);
                btnText.Text = miPila.Mostrar();
            }

            else
            {
                
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnPop_Click(object sender, EventArgs e)
        {


           miPila.Pop();
           btnText.Text = miPila.Mostrar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            string mostrar = miPila.Mostrar();
            btnText.Text = mostrar;

        }

        private void btnText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmPilas_Load(object sender, EventArgs e)
        {

        }

        private void btnText_Click(object sender, EventArgs e)
        {

        }
    }
}
