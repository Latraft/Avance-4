using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales.Busqueda;
using EDDemo.Estructuras_Lineales.Clases;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Estructuras_No_Lineales.Clases;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCalculadora mCalcu = new frmCalculadora();
            mCalcu.MdiParent = this;
            mCalcu.Show();
        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListas mLista = new frmListas();
            mLista.MdiParent = this;
            mLista.Show();

        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola cola = new frmCola();
            cola.MdiParent = this;
            cola.Show();
        }

        private void calculadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculadora mCalcu = new frmCalculadora();
            mCalcu.MdiParent = this;
            mCalcu.Show();
        }

        private void burbujasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBurbuja burbuja = new frmBurbuja();
            burbuja.MdiParent = this;
            burbuja.Show();
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusqueda busqueda = new frmBusqueda();
            busqueda.MdiParent = this;
            busqueda.Show();
        }

    }
}
