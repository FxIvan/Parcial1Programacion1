using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1Programacion1
{
    public partial class frmParcial : Form
    {
        Cola lista = new Cola();
        public frmParcial()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            lista.Desencolar();
            ListarImpresiones();
        }

        private void ShowMessageVacio()
        {
            MessageBox.Show("Por favor agregar cantidad de impresion");
            return;
        }

        private void ListarImpresiones()
        {
            lstListaDeCopia.Items.Clear();
            Nodo aux = lista.Inicio;
            while (aux != null)
            {
                lstListaDeCopia.Items.Add(aux.Impresora + " - " + aux.Copias);
                aux = aux.Siguiente;
            }

            txtCantidadDeCopias.Text = "";
        }

        private void FuncionEncolar(Nodo nuevoNodo)
        {
            lista.Encolar(nuevoNodo);
        }

        private void btnHPOne_Click(object sender, EventArgs e)
        {
            if(txtCantidadDeCopias.Text.Length == 0)
            {
                ShowMessageVacio();
                return;
            }
            int cantidaCopia = Convert.ToInt32(txtCantidadDeCopias.Text);
            Nodo nuevoImpresion = new Nodo("HP ONE", cantidaCopia);
            FuncionEncolar(nuevoImpresion);
            ListarImpresiones();
        }

        private void btnIBMFullColor_Click(object sender, EventArgs e)
        {
            if (txtCantidadDeCopias.Text.Length == 0)
            {
                ShowMessageVacio();
                return;
            }
            int cantidaCopia = Convert.ToInt32(txtCantidadDeCopias.Text);
            Nodo nuevoImpresion = new Nodo("IBM Full color", cantidaCopia);
            FuncionEncolar(nuevoImpresion);
            ListarImpresiones();
        }

        private void btnXEROXPrint_Click(object sender, EventArgs e)
        {
            if (txtCantidadDeCopias.Text.Length == 0)
            {
                ShowMessageVacio();
                return;
            }
            int cantidaCopia = Convert.ToInt32(txtCantidadDeCopias.Text);
            Nodo nuevoImpresion = new Nodo("XEROX", cantidaCopia);
            FuncionEncolar(nuevoImpresion);
            ListarImpresiones();
        }

        private void btnHPTL1_Click(object sender, EventArgs e)
        {
            if (txtCantidadDeCopias.Text.Length == 0)
            {
                ShowMessageVacio();
                return;
            }
            int cantidaCopia = Convert.ToInt32(txtCantidadDeCopias.Text);
            Nodo nuevoImpresion = new Nodo("HP TL-1", cantidaCopia);
            FuncionEncolar(nuevoImpresion);
            ListarImpresiones();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
