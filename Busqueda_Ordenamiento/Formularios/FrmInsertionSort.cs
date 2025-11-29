using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Busqueda_Ordenamiento.Formularios
{
    public partial class FrmInsertionSort : Form
    {
        /// <summary>
        /// Declaración de lista de números tipo int.
        /// </summary>
        List<int> numeros = new List<int>();
        public FrmInsertionSort()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Botones deshabititados para evitar errores durante la generación de números.
            btnGenerar.Enabled = false;
            btnOrdenar.Enabled = false;
            btnLineal.Enabled = false;
            btnBinaria.Enabled = false;

            // Control de excepciones.
            try
            {
                // Generación de números aleatorios (registros).
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
                        numeros.Add(random.Next(1,10000));
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

            // Habilitación de botones luego de la generación de números.
            btnGenerar.Enabled = true;
            btnOrdenar.Enabled = true;
            btnLineal.Enabled = true;
            btnBinaria.Enabled = true;
            tbRegistros.Clear();
            tbRegistros.Focus();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Botones deshabititados para evitar errores durante el ordenamiento de números.
            btnGenerar.Enabled = false;
            btnOrdenar.Enabled = false;
            btnLineal.Enabled = false;
            btnBinaria.Enabled = false;

            // Verificación de que la lista contenga números para ordenar.
            if (numeros.Count < 0)
            {
                MessageBox.Show("No hay números para ordenar. Genere una lista primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Algoritmo de ordenamiento Insertion Sort e inicialización de cronómetro.
                Stopwatch sw = new Stopwatch();
                lblTimeIniSorted.Text = "Tiempo de inicio: " + DateTime.Now.ToString("HH:mm:ss");
                sw.Start();
                for (int i = 1; i < numeros.Count; i++)
                {
                    int clave = numeros[i];
                    int j = i - 1;
                    while (j >= 0 && numeros[j] > clave)
                    {
                        numeros[j + 1] = numeros[j];
                        j--;
                    }
                    numeros[j + 1] = clave;
                }

                // Actualización de la lista ordenada y cronómetro.
                lstOrdenada.DataSource = null;
                lstOrdenada.DataSource = numeros;
                sw.Stop();
                lblTimeEndSorted.Text = "Tiempo de fin: " + DateTime.Now.ToString("HH:mm:ss");
                lblDurationSorted.Text = "Duración: " + sw.ElapsedMilliseconds / 1000.0000 + " segundos";
            }

            // Habilitación de botones luego del ordenamiento de números.
            btnGenerar.Enabled = true;
            btnOrdenar.Enabled = true;
            btnLineal.Enabled = true;
            btnBinaria.Enabled = true;
        }

        private void btnBinaria_Click(object sender, EventArgs e)
        {

        }
    }
}
