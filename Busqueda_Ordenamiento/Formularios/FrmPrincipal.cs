using Busqueda_Ordenamiento.Formularios;
using System;
using System.Windows.Forms;

namespace Busqueda_Ordenamiento
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertionSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmInsertionSort().Show();
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmQuickSort().Show();
        }
    }
}
