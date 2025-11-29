using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busqueda_Ordenamiento.Formularios
{
    public partial class FrmQuickSort : Form
    {
        List<int> numeros = new List<int>();
        public FrmQuickSort()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            btnGenerar.Enabled = false;
            btnOrdenar.Enabled = false;
            btnLineal.Enabled = false;
            btnBinaria.Enabled = false;
            try
            {
                int num = int.Parse(tbRegistros.Text);
                if (num > 0)
                {
                    Random random = new Random();
                    numeros.Clear();
                    Stopwatch sw = new Stopwatch();
                    lblTimeIniOriginal.Text = "Tiempo de inicio: " + DateTime.Now.ToString("HH:mm:ss");
                    sw.Start();
                    for (int i = 0; i < num; i++)
                    {
                        numeros.Add(random.Next(1, 10000));
                    }
                    lstOriginal.DataSource = null;
                    lstOriginal.DataSource = numeros;
                    sw.Stop();
                    lblTimeEndOriginal.Text = "Tiempo de fin: " + DateTime.Now.ToString("HH:mm:ss");
                    lblDurationOriginal.Text = "Duración: " + sw.ElapsedMilliseconds / 1000.0000 + " segundos";
                }
                else
                {
                    MessageBox.Show("Ingrese un valor entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbRegistros.Clear();
                    tbRegistros.Focus();
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Valor muy grande. Ingrese un valor entre 1 y 2,147,483,647.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbRegistros.Clear();
                tbRegistros.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbRegistros.Clear();
                tbRegistros.Focus();
            }
            btnGenerar.Enabled = true;
            btnOrdenar.Enabled = true;
            btnLineal.Enabled = true;
            btnBinaria.Enabled = true;
            tbRegistros.Clear();
            tbRegistros.Focus();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

        }
    }
}
