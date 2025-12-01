using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        /// <summary>
        /// Método para habilitar los botones.
        /// </summary>
        public void Habilitar()
        {
            btnGenerar.Enabled = true;
            btnOrdenar.Enabled = true;
            btnLineal.Enabled = true;
            btnBinaria.Enabled = true;
        }

        /// <summary>
        /// Método para deshabilitar los botones.
        /// </summary>
        public void Deshabilitar()
        {
            btnGenerar.Enabled = false;
            btnOrdenar.Enabled = false;
            btnLineal.Enabled = false;
            btnBinaria.Enabled = false;
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Deshabilitar();
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
            Habilitar();
            tbRegistros.Clear();
            tbRegistros.Focus();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Deshabilitar();

            if (numeros.Count == 0)
            {
                MessageBox.Show("No hay números para ordenar. Genere una lista primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Algoritmo de ordenamiento Quick Sort e inicialización de cronómetro.
                Stopwatch sw = new Stopwatch();
                lblTimeIniSorted.Text = "Tiempo de inicio: " + DateTime.Now.ToString("HH:mm:ss");
                sw.Start();

                // Uso de una pila para manejar los rangos por procesar.
                int inicio = 0;
                int fin = numeros.Count - 1;
                Stack<(int, int)> pila = new Stack<(int, int)>();
                pila.Push((inicio, fin));
                while (pila.Count > 0)
                {
                    (inicio, fin) = pila.Pop();

                    // Particionar
                    int pivote = numeros[fin];
                    int i = inicio - 1;
                    for (int j = inicio; j < fin; j++)
                    {
                        if (numeros[j] <= pivote)
                        {
                            i++;
                            int temp = numeros[i];
                            numeros[i] = numeros[j];
                            numeros[j] = temp;
                        }
                    }

                    // Mover pivote a su posición
                    int temp2 = numeros[i + 1];
                    numeros[i + 1] = numeros[fin];
                    numeros[fin] = temp2;
                    int pivoteIndex = i + 1;

                    // Procesar el subarray izquierdo
                    if (inicio < pivoteIndex - 1) pila.Push((inicio, pivoteIndex - 1));

                    // Procesar el subarray derecho
                    if (pivoteIndex + 1 < fin) pila.Push((pivoteIndex + 1, fin));
                }
                // Actualización de la lista ordenada y cronómetro.
                lstOrdenada.DataSource = null;
                lstOrdenada.DataSource = new List<int>(numeros);
                sw.Stop();
                lblTimeEndSorted.Text = "Tiempo de fin: " + DateTime.Now.ToString("HH:mm:ss");
                lblDurationSorted.Text = "Duración: " + sw.ElapsedMilliseconds / 1000.0000 + " segundos";
            }
            Habilitar();
        }

        private void btnLineal_Click(object sender, EventArgs e)
        {
            Deshabilitar();

            // Validaciones de entrada de datos.
            if (!int.TryParse(tbNumBuscado.Text, out int buscado))
            {
                MessageBox.Show("Ingrese un número válido para buscar.");
                return;
            }
            if (numeros.Count == 0)
            {
                MessageBox.Show("Primero debe generar la lista de números.");
                return;
            }

            // Búsqueda lineal.
            int valorEncontrado = -1;
            Stopwatch sw = new Stopwatch();
            lblTimeIniBusqueda.Text = "Tiempo de inicio: " + DateTime.Now.ToString("HH:mm:ss");
            sw.Start();
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] == buscado)
                {
                    valorEncontrado = i;
                    break;
                }
            }
            if (valorEncontrado == -1)
            {
                MessageBox.Show("Elemento NO encontrado.");
            }
            else
            {
                // Crear una nueva lista para actualizar el listbox y evitar problemas de referencia.
                lstBusqueda.DataSource = null;
                lstBusqueda.DataSource = new List<int>(numeros);
                MessageBox.Show($"Elemento encontrado en el índice {valorEncontrado}.");

                // Resaltar en el listbox el elemento encontrado.
                lstBusqueda.SelectedIndex = valorEncontrado;
                lstBusqueda.TopIndex = valorEncontrado;
            }
            sw.Stop();
            lblTimeEndBusqueda.Text = "Tiempo de fin: " + DateTime.Now.ToString("HH:mm:ss");
            lblDurationSearch.Text = "Duración: " + sw.ElapsedMilliseconds / 1000.0000 + " segundos";
            Habilitar();
        }

        private void btnBinaria_Click(object sender, EventArgs e)
        {
            Deshabilitar();
            if (numeros.Count == 0)
            {
                MessageBox.Show("Primero debe generar y ordenar la lista.");
                Habilitar();
                return;
            }
            if (!int.TryParse(tbNumBuscado.Text, out int buscado))
            {
                MessageBox.Show("Ingrese un número válido para buscar.");
                Habilitar();
                return;
            }

            // Búsqueda binaria.
            int inicio = 0;
            int fin = numeros.Count - 1;
            int valorEncontrado = -1;
            Stopwatch sw = new Stopwatch();
            lblTimeIniBusqueda.Text = "Tiempo de inicio: " + DateTime.Now.ToString("HH:mm:ss");
            sw.Start();
            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (numeros[medio] == buscado)
                {
                    valorEncontrado = medio;
                    break;
                }
                else if (numeros[medio] < buscado)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }
            if (valorEncontrado == -1)
            {
                MessageBox.Show("Elemento no encontrado.");
            }
            else
            {
                // Crear una nueva lista para actualizar el listbox y evitar problemas de referencia.
                lstBusqueda.DataSource = null;
                lstBusqueda.DataSource = new List<int>(numeros);
                MessageBox.Show($"Elemento encontrado en el índice {valorEncontrado}.");

                // Resaltar en el listbox el elemento encontrado.
                lstBusqueda.SelectedIndex = valorEncontrado;
                lstBusqueda.TopIndex = valorEncontrado;
            }
            sw.Stop();
            lblTimeEndBusqueda.Text = "Tiempo de fin: " + DateTime.Now.ToString("HH:mm:ss");
            lblDurationSearch.Text = "Duración: " + sw.ElapsedMilliseconds / 1000.0000 + " segundos";
            Habilitar();
        }
    }
}
