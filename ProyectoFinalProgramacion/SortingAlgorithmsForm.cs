using Algoritmos;
using Heapsort_Quicksort_Selectiosort;
using ProyectoFinalProgramacion.SortingAlgorithms;
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
using System.Windows.Forms.VisualStyles;

namespace ProyectoFinalProgramacion
{
    public partial class SortingAlgorithmsForm : Form
    {
        Organization organizar = new Organization();
        int[] array = new int[10];
        public SortingAlgorithmsForm()
        {
            InitializeComponent();

            //ShellSort

            // Configuración inicial del DataGridView
            dataGridView1.ColumnCount = 10;  // Vamos a mostrar el arreglo completo en una fila de 10 columnas
            dataGridView1.RowCount = 1;      // Solo una fila para los números

            // Configurar el DataGridView para que no pueda editarse
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            // Asegurar que se muestre correctamente el contenido
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //CountingSort

            stopwatchCountingSort = new Stopwatch();

            // Configurar ComboBox con opciones de orden
            cBOrdenCountingSort.Items.Add("Ascendente");
            cBOrdenCountingSort.Items.Add("Descendente");
            cBOrdenCountingSort.SelectedIndex = 0; // Seleccionar "Ascendente" por defecto

            //BucketSort

            random = new Random();
            numbers = new int[10];

            // Configuración del ListView lstvOrder
            lstvOrder.View = View.Details;
            for (int i = 0; i <= 4; i++)
            {
                lstvOrder.Columns.Add("" + i, 60);
            }

            // Configuración del ListView lstvBucket
            lstvBucket.View = View.Details;
            lstvBucket.Columns.Add("Bucket", 80);
            lstvBucket.Columns.Add("Range", 80);
            lstvBucket.Columns.Add("Bucket numbers", 150);

            cbxOrderBucketSort.Items.Add("Ascendente");
            cbxOrderBucketSort.Items.Add("Descendente");
            cbxOrderBucketSort.SelectedIndex = 0; // Predeterminado en Ascendenteçe

            //Merge sort
            InitializeListView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AlgorithmsForm algorithmsForm = new AlgorithmsForm();
            algorithmsForm.Show();
            this.Close();
        }

        //BubbleSort, CocktailSort, InsertionSort

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (ComBoxSelect.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un tipo de algoritmo de organisacion");
                return;
            }
            string seleccion = ComBoxSelect.SelectedItem.ToString()!;


            LsBoxOrder.Items.Clear();
            int[] Numbers = TxtDataNum.Text.Split(' ').Select(int.Parse).ToArray();
            int[] arregloDesordenado = organizar.DesordenarArreglo(Numbers);

            switch (seleccion)
            {
                case "Bubblesort":
                    organizar.OnSwap += UpdateListBox;
                    organizar.BubbleSort(Numbers);
                    organizar.OnSwap -= UpdateListBox;
                    break;

                case "Cocktail sort":
                    organizar.OnSwap += UpdateListBox;
                    organizar.Cocktail_Sort(Numbers);
                    organizar.OnSwap -= UpdateListBox;
                    break;
                case "Insertion sort":
                    organizar.OnSwap += UpdateListBox;
                    organizar.Insertionsort(Numbers);
                    organizar.OnSwap -= UpdateListBox;
                    break;
            }
        }

        private void UpdateListBox(int[] numbers)
        {
            string line = string.Join(" ", numbers);
            LsBoxOrder.Items.Add(line);
        }

        //HeapSort, QuickSort, SelectionSort
        private void btnRandom_Click(object sender, EventArgs e)
        {

            //Generate a random array
            Random rand = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 100);
            }
            //Display the array in the textbox
            tbArray.Text = string.Join(", ", array);
            this.array = array;


        }

        public void UpdateListBoxHeapSortQuickSortSelectionSort(int[] array)
        {
            if (lboxArray.InvokeRequired)
            {
                lboxArray.Invoke(new Action(() => UpdateListBoxHeapSortQuickSortSelectionSort(array)));
            }
            else
            {
                lboxArray.Items.Clear();
                foreach (var item in array)
                {
                    lboxArray.Items.Add(item);
                }
            }
        }

        private async void btnSort_Click(object sender, EventArgs e)
        {
            // Clear the ListBox
            lBoxunsorted.Items.Clear();
            foreach (var item in array)
            {
                lBoxunsorted.Items.Add(item);
            }

            switch (cbOption.SelectedIndex)
            {
                case 0:
                    SelectionSort selectionSorter = new SelectionSort(UpdateListBoxHeapSortQuickSortSelectionSort);
                    await selectionSorter.SelectionsortAsync(array);
                    break;

                case 1:
                    HeapSort heapSorter = new HeapSort(UpdateListBoxHeapSortQuickSortSelectionSort);
                    await heapSorter.HeapsortAsync(array);
                    break;

                case 2:
                    QuickSort quickSorter = new QuickSort(UpdateListBoxHeapSortQuickSortSelectionSort);
                    await quickSorter.QuicksortAsync(array, 0, array.Length - 1);
                    break;

                default:
                    MessageBox.Show("Selecciona un algoritmo válido.");
                    break;
            }
        }

        //ShellSort
        private void btnShellSort_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los números ingresados por el usuario
                string input = txtInput.Text;
                int[] numbers = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToArray();

                // Desordenar el arreglo antes de ordenar
                ShuffleArray(numbers);

                // Mostrar el arreglo desordenado
                ShowArrayState(numbers);

                // Aplicar Shell Sort y mostrar cada paso
                ShellSort(numbers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Algoritmo de Shell Sort con visualización
        private void ShellSort(int[] arr)
        {
            int n = arr.Length;

            // Inicializar el intervalo
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j;

                    // Realizar la comparación y reordenamiento
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];

                        // Mostrar el estado actual con los cambios
                        ShowArrayState(arr, j, j - gap); // Resaltamos los elementos intercambiados
                    }

                    arr[j] = temp;

                    // Mostrar el estado después de la inserción
                    ShowArrayState(arr, j, i);
                }
            }

        }

        // Función para mostrar el estado del arreglo completo en el DataGridView
        private void ShowArrayState(int[] arr, int? index1 = null, int? index2 = null)
        {
            // Agregar el arreglo como una nueva fila (acumulando los cambios)
            DataGridViewRow row = new DataGridViewRow();
            foreach (int number in arr)
            {
                DataGridViewCell cell = new DataGridViewTextBoxCell
                {
                    Value = number
                };
                row.Cells.Add(cell);
            }
            dataGridView1.Rows.Add(row);

            // Resaltar los intercambios en la fila
            if (index1.HasValue && index2.HasValue)
            {
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[index1.Value].Style.BackColor = Color.Yellow;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[index1.Value].Style.ForeColor = Color.Red;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[index2.Value].Style.BackColor = Color.Yellow;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[index2.Value].Style.ForeColor = Color.Red;
            }

            // Actualizar la interfaz
            dataGridView1.Refresh();
            System.Threading.Thread.Sleep(500); // Pausa para visualizar el cambio
        }

        // Función para desordenar el arreglo (Algoritmo Fisher-Yates)
        private void ShuffleArray(int[] arr)
        {
            Random rand = new Random();
            int n = arr.Length;

            // Recorremos el arreglo desde el final hasta el principio
            for (int i = n - 1; i > 0; i--)
            {
                // Elegimos un índice aleatorio entre 0 y i
                int j = rand.Next(0, i + 1);

                // Intercambiamos arr[i] con arr[j]
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        //counting sort

        int[]? inputArrayCountingSort;
        int[]? countArrayCountingSort;
        int[]? outputArrayCountingSort;
        int maxIndexCountingSort;
        int currentIndexCountingSort;
        Stopwatch stopwatchCountingSort;

        private void btnCountingSort_Click(object sender, EventArgs e)
        {
            // Leer y procesar los números ingresados en el TextBox
            inputArrayCountingSort = txtInputCountingSort.Text.Split(',')
                                       .Select(n => int.Parse(n.Trim()))
                                       .ToArray();

            // Mezclar el arreglo con la clase ArrayShuffler
            arrayShuffler.Shuffle(inputArrayCountingSort);

            // Inicializar los arreglos y variables para el proceso de Counting Sort
            outputArrayCountingSort = new int[inputArrayCountingSort.Length];
            int maxValue = inputArrayCountingSort.Max();
            countArrayCountingSort = new int[maxValue + 1];
            maxIndexCountingSort = cBOrdenCountingSort.SelectedItem!.ToString() == "Ascendente" ? 0 : countArrayCountingSort.Length - 1;
            currentIndexCountingSort = 0;

            // Crear el arreglo de conteo
            foreach (int num in inputArrayCountingSort)
            {
                countArrayCountingSort[num]++;
            }

            // Limpiar el DataGridView y mostrar el arreglo desordenado inicialmente
            dgvOutputCountingSort.Rows.Clear();
            dgvOutputCountingSort.Rows.Add("Desordenado: " + string.Join(", ", inputArrayCountingSort));

            // Iniciar el temporizador para mostrar el ordenamiento paso a paso
            stopwatchCountingSort.Restart(); // Iniciar el cronómetro
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool ascending = cBOrdenCountingSort.SelectedItem!.ToString() == "Ascendente";

            // Condición para detener el temporizador según el orden elegido
            if ((ascending && maxIndexCountingSort >= countArrayCountingSort!.Length) || (!ascending && maxIndexCountingSort < 0))
            {
                timer1.Stop();
                stopwatchCountingSort.Stop(); // Detener el cronómetro

                // Mostrar el tiempo total de ordenamiento en el label con formato hh:mm:ss:fff
                TimeSpan elapsed = stopwatchCountingSort.Elapsed;
                lblTimeElapsed.Text = $"Tiempo de ordenamiento: {elapsed:hh\\:mm\\:ss\\:fff}";
                MessageBox.Show($"El ordenamiento ha finalizado.\nTiempo total: {elapsed:hh\\:mm\\:ss\\:fff}", "Ordenamiento Completado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Si el valor en countArrayCountingSort[maxIndexCountingSort] es mayor que cero, agregar al outputArrayCountingSort
            if (countArrayCountingSort![maxIndexCountingSort] > 0)
            {
                outputArrayCountingSort![currentIndexCountingSort++] = maxIndexCountingSort;
                countArrayCountingSort[maxIndexCountingSort]--;

                // Mostrar el estado actual del arreglo ordenado en una fila del DataGridView
                string currentState = string.Join(", ",
                    outputArrayCountingSort.Select(n => n == 0 ? "0" : n.ToString()));
                dgvOutputCountingSort.Rows.Add("Ordenando: " + currentState);
            }
            else
            {
                // Avanzar al siguiente índice en el arreglo de conteo según el orden elegido
                maxIndexCountingSort += ascending ? 1 : -1;
            }
        }

        //BucketSort
        Random random;
        int[] numbers;
        private void btnBucketSort_Click(object sender, EventArgs e)
        {
            // Asignar números aleatorios al arreglo
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }

            // Mezclar el arreglo de números con la clase ArrayShuffler
            arrayShuffler.Shuffle(numbers);

            // Mostrar los números desordenados en el TextBox
            txtOrderBucketSort.Text = string.Join(" , ", numbers);


            if (cbxOrderBucketSort.SelectedItem!.ToString() == "Ascendente")
            {
                BS(ascending: true);
            }
            else
            {
                BS(ascending: false);
            }
            // Llamar al método de ordenamiento por Bucket Sort



        }

        public void BS(bool ascending)
        {
            int bucketCount = 5;
            int bucketSize = 5;
            int[][] buckets = new int[bucketCount][];
            int[] bucketSizes = new int[bucketCount];

            for (int i = 0; i < bucketCount; i++)
            {
                buckets[i] = new int[bucketSize];
            }

            // Configuración del rango de índices dependiendo del orden
            lstvBucket.Items.Clear();
            for (int i = 0; i < numbers.Length; i++)
            {
                int bucketIndex;
                if (ascending)
                {
                    bucketIndex = (numbers[i] - 1) / (100 / bucketCount);
                }
                else
                {
                    bucketIndex = (100 - numbers[i]) / (100 / bucketCount);
                }

                for (int j = 0; j < bucketSize; j++)
                {
                    if (buckets[bucketIndex][j] == 0)
                    {
                        buckets[bucketIndex][j] = numbers[i];
                        break;
                    }
                }
            }

            // Mostrar los buckets en lstvBucket
            for (int i = 0; i < bucketCount; i++)
            {
                int rangeStart, rangeEnd;
                if (ascending)
                {
                    rangeStart = i * (100 / bucketCount) + 1;
                    rangeEnd = (i + 1) * (100 / bucketCount);
                }
                else
                {
                    rangeStart = 100 - (i * (100 / bucketCount));
                    rangeEnd = 100 - ((i + 1) * (100 / bucketCount)) + 1;
                }

                string range = rangeEnd + " - " + rangeStart;
                string bucketNumbers = string.Join(", ", buckets[i].Where(x => x != 0));
                ListViewItem bucketItem = new ListViewItem((i + 1).ToString());
                bucketItem.SubItems.Add(range);
                bucketItem.SubItems.Add(bucketNumbers);
                lstvBucket.Items.Add(bucketItem);
            }

            // Ordenar cada bucket y mostrar los pasos
            lstvOrder.Items.Clear();
            for (int i = 0; i < bucketCount; i++)
            {
                // Mostrar el estado original del bucket
                AddOriginalBucketState(buckets[i]);

                for (int j = 1; j < bucketSize; j++)
                {
                    int current = buckets[i][j];
                    if (current == 0)
                    {
                        break;
                    }

                    int k = j - 1;
                    while (k >= 0 && (ascending ? buckets[i][k] > current : buckets[i][k] < current))
                    {
                        // Mover el número hacia adelante
                        buckets[i][k + 1] = buckets[i][k];

                        // Mostrar el estado actual del bucket
                        AddStepToOrder(buckets[i]);
                        k--;
                    }
                    buckets[i][k + 1] = current;

                    // Mostrar el estado después de insertar
                    AddStepToOrder(buckets[i]);
                }
            }

            // Copiar elementos de los buckets al arreglo principal
            int index = 0;
            for (int i = 0; i < bucketCount; i++) // Recorrer los buckets en orden ascendente
            {
                for (int j = 0; j < bucketSize; j++)
                {
                    if (buckets[i][j] != 0)
                    {
                        numbers[index++] = buckets[i][j];
                    }
                }
            }

            // Mostrar el arreglo final ordenado
            txtOrderBucketSort.AppendText(" \nFinal order: " + string.Join(", ", numbers));
        }
        private void AddOriginalBucketState(int[] bucket)
        {
            // Crear un ListViewItem para mostrar el estado original del bucket
            ListViewItem originalItem = new ListViewItem("Original");

            for (int i = 0; i < bucket.Length; i++)
            {
                string value = bucket[i] == 0 ? "" : bucket[i].ToString();
                if (i == 0)
                {
                    originalItem.Text = value;
                }
                else
                {
                    originalItem.SubItems.Add(value);
                }
            }

            lstvOrder.Items.Add(originalItem);
        }

        private void AddStepToOrder(int[] bucket)
        {
            // Crear un ListViewItem para mostrar el estado actual
            ListViewItem stepItem = new ListViewItem();

            for (int i = 0; i < bucket.Length; i++)
            {
                string value = bucket[i] == 0 ? "" : bucket[i].ToString();
                if (i == 0)
                {
                    stepItem.Text = value;
                }
                else
                {
                    stepItem.SubItems.Add(value);
                }
            }

            lstvOrder.Items.Add(stepItem);
        }

        //MergeSort
        private int[]? numbersMergeSort;

        private void InitializeListView()
        {
            listViewStepsMergeSort.View = View.Details;
            listViewStepsMergeSort.Columns.Add("Descripción", 120);
            listViewStepsMergeSort.Columns.Add("Arreglo", 300);
            listViewStepsMergeSort.FullRowSelect = true;
            listViewStepsMergeSort.GridLines = true;
        }

        // Método para leer los números del TextBox y asignarlos al arreglo
        private void btnIngresarMergeSort_Click(object sender, EventArgs e)
        {
            try
            {
                numbersMergeSort = txtInputMergeSort.Text.Split(',').Select(int.Parse).ToArray();
                if (numbersMergeSort.Length != 8)
                {
                    MessageBox.Show("Por favor, ingrese exactamente 8 números separados por comas.");
                    return;
                }

                // Uso de la clase externa para mezclar elementos aleatoriamente
                arrayShuffler.Shuffle(numbersMergeSort);
                listViewStepsMergeSort.Items.Clear();
                DisplayArray(numbersMergeSort, "Arreglo inicial (mezcla aleatoria)");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo números separados por comas, sin espacios.");
            }
        }

        private void DisplayArray(int[] array, string description)
        {
            // Crear una copia del arreglo para evitar cambios inesperados
            int[] arrayCopy = (int[])array.Clone();

            var item = new ListViewItem(description);
            item.SubItems.Add(string.Join(", ", arrayCopy));
            listViewStepsMergeSort.Items.Add(item);
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            listViewStepsMergeSort.Items.Clear();
            if (numbersMergeSort == null || numbersMergeSort.Length != 8)
            {
                MessageBox.Show("Primero ingrese los 8 números en el formato adecuado.");
                return;
            }
            Algorithms.MergeSort(numbersMergeSort, 0, numbersMergeSort.Length - 1, DisplayArray);
        }

        private void btnDirectMerge_Click(object sender, EventArgs e)
        {
            listViewStepsMergeSort.Items.Clear();
            if (numbersMergeSort == null || numbersMergeSort.Length != 8)
            {
                MessageBox.Show("Primero ingrese los 8 números en el formato adecuado.");
                return;
            }
            Algorithms.DirectMerge(numbersMergeSort, DisplayArray);
        }

        private void btnNaturalMerge_Click(object sender, EventArgs e)
        {
            listViewStepsMergeSort.Items.Clear();
            if (numbersMergeSort == null || numbersMergeSort.Length != 8)
            {
                MessageBox.Show("Primero ingrese los 8 números en el formato adecuado.");
                return;
            }
            Algorithms.NaturalMerge(numbersMergeSort, DisplayArray);
        }

        private void btnClearListMergeSort_Click(object sender, EventArgs e)
        {
            listViewStepsMergeSort.Items.Clear();
        }

        //GnomeSort
        private int[] numbersGnomeSort = { 34, 2, 23, 67, 4, 90, 3 };
        private void SortingAlgorithmsForm_Load(object sender, EventArgs e)
        {
            DisplayNumbersGnomeSort(numbersGnomeSort);
        }
        private async void btnSortGnomeSort_Click(object sender, EventArgs e)
        {
            await GnomeSort(numbersGnomeSort);
        }

        private void DisplayNumbersGnomeSort(int[] arrayGnomeSort, int highlightIndex1 = -1, int highlightIndex2 = -1)
        {
            listBoxGnomeSort.Items.Clear();

            string displayText = "";

            for (int i = 0; i < arrayGnomeSort.Length; i++)
            {
                // Resaltar los elementos en comparación o intercambio
                if (i == highlightIndex1 || i == highlightIndex2)
                {
                    displayText += $"[{arrayGnomeSort[i]}] ";  // Números comparados o intercambiados
                }
                else
                {
                    displayText += $"{arrayGnomeSort[i]} ";  // Números normales
                }
            }

            // Mostrar todos los números en una fila
            listBoxGnomeSort.Items.Add(displayText.Trim());
        }

        private async Task GnomeSort(int[] arrayGnomeSort)
        {
            int indexGnomeSort = 0;

            while (indexGnomeSort < arrayGnomeSort.Length)
            {
                // Si estamos en el primer índice o el número actual es mayor o igual que el anterior
                if (indexGnomeSort == 0 || arrayGnomeSort[indexGnomeSort] >= arrayGnomeSort[indexGnomeSort - 1])
                {
                    // Mostrar los números actuales y avanzar al siguiente índice
                    DisplayNumbersGnomeSort(arrayGnomeSort, indexGnomeSort, indexGnomeSort - 1); // Resaltamos los números que estamos comparando
                    await Task.Delay(1000); // Pausa para visualizar la comparación sin intercambio
                    indexGnomeSort++;
                }
                else
                {
                    // Si el número actual es menor que el anterior, intercambiamos
                    DisplayNumbersGnomeSort(arrayGnomeSort, indexGnomeSort, indexGnomeSort - 1); // Resaltamos los números que estamos intercambiando
                    await Task.Delay(1000); // Pausa para visualizar el intercambio

                    // Realizamos el intercambio
                    int tempGnomeSort = arrayGnomeSort[indexGnomeSort];
                    arrayGnomeSort[indexGnomeSort] = arrayGnomeSort[indexGnomeSort - 1];
                    arrayGnomeSort[indexGnomeSort - 1] = tempGnomeSort;

                    // Retrocedemos al índice anterior para seguir comparando
                    indexGnomeSort--;

                    // Asegurarse de no retroceder más allá del principio
                    if (indexGnomeSort < 0)
                    {
                        indexGnomeSort = 0;
                    }

                    // Actualizar la visualización del arreglo con el intercambio
                    DisplayNumbersGnomeSort(arrayGnomeSort);
                    await Task.Delay(1000); // Pausa para visualizar el estado después del intercambio
                }
            }

            // Mostrar el resultado final
            DisplayNumbersGnomeSort(arrayGnomeSort);
            MessageBox.Show("¡Complete ordering!", "Gnome Sort", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShuffleGnomeSort_Click(object sender, EventArgs e)
        {
            ShuffleArrayGnomeSort(numbersGnomeSort);
            // Muestra los números mezclados
            DisplayNumbersGnomeSort(numbersGnomeSort);
        }

        private void ShuffleArrayGnomeSort(int[] array)
        {
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
        }
        //PidgeonHole
        private void btnSortPidgeonHola_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los números del TextBox
                int[] arr = txtInputPidgeonHola.Text.Split(',').Select(int.Parse).ToArray();

                // Ordenar el array usando Pigeonhole Sort
                PidgeonholeSort(arr);

                // Mostrar el array ordenado en el TextBox
                txtOutputPidgeonHola.Text = string.Join(", ", arr);
            }
            catch
            {
                MessageBox.Show("Por favor, ingresa números válidos separados por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PidgeonholeSort(int[] arr)
        {
            int min = arr.Min();
            int max = arr.Max();
            int range = max - min + 1;
            int[] holes = new int[range];

            // Inicializar los agujeros
            foreach (var num in arr)
                holes[num - min]++;

            // Recoger los elementos de los agujeros y ponerlos de vuelta en el array
            int index = 0;
            for (int i = 0; i < range; i++)
            {
                while (holes[i]-- > 0)
                    arr[index++] = i + min;
            }
        }

        private void btnClearPidgeonHola_Click(object sender, EventArgs e)
        {
            txtOutputPidgeonHola.Clear();
        }

        //CombSort
        private void btnSortCombSort_Click(object sender, EventArgs e)
        {
            // Limpia el DataGridView para el nuevo conjunto de datos
            dataGridViewStepsCombSort.Rows.Clear();
            dataGridViewStepsCombSort.Columns.Clear();

            // Genera un arreglo de 6 números aleatorios
            int[] numbersCombSort = GenerateRandomArrayCombSort(6);

            // Crea las columnas en el DataGridView
            for (int i = 0; i < numbersCombSort.Length; i++)
            {
                dataGridViewStepsCombSort.Columns.Add("Column" + i, "Elemento " + i);
            }

            // Muestra el arreglo inicial en el DataGridView
            AddArrayToDataGridViewCombSort(numbersCombSort, "Array inicial");

            // Llama al método de Comb Sort y muestra el proceso en DataGridView
            CombSort(numbersCombSort);

            // Muestra el resultado final en el DataGridView
            AddArrayToDataGridViewCombSort(numbersCombSort, "Array ordenado");
        }

        private int[] GenerateRandomArrayCombSort(int size)
        {
            Random randomCombSort = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = randomCombSort.Next(1, 101); // Números aleatorios entre 1 y 100
            }
            return array;
        }

        private void CombSort(int[] array)
        {
            int gap = array.Length;
            bool swapped = true;
            double shrinkFactor = 1.3;

            // Comienza el proceso de ordenamiento
            while (gap > 1 || swapped)
            {
                // Actualiza el valor de gap
                gap = (int)(gap / shrinkFactor);
                if (gap < 1)
                    gap = 1;

                swapped = false;

                // Recorre el arreglo y compara elementos a la distancia actual
                for (int i = 0; i + gap < array.Length; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        // Intercambia los elementos
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;
                        swapped = true;

                        // Muestra el estado actual del arreglo en el DataGridView
                        AddArrayToDataGridViewCombSort(array, "Paso intermedio");
                    }
                }
            }
        }
        private void AddArrayToDataGridViewCombSort(int[] array, string label)
        {
            // Crea una fila nueva en el DataGridView
            int rowIndex = dataGridViewStepsCombSort.Rows.Add();
            for (int i = 0; i < array.Length; i++)
            {
                dataGridViewStepsCombSort.Rows[rowIndex].Cells[i].Value = array[i];
            }
        }

        //RadixSort

        private void RandomizeNumbers()
        {
            Random random = new Random();
            List<int> numbers = Enumerable.Range(0, 10).Select(_ => random.Next(1, 1000)).ToList();
            txtNumbersRadixSort.Text = string.Join(", ", numbers);
        }
        private void btnRandomizeRadixSort_Click(object sender, EventArgs e)
        {
            RandomizeNumbers();
        }

        private void btnLSDRadixSort_Click(object sender, EventArgs e)
        {
            PerformRadixSort(lsd: true); // Perform LSD Radix Sort
        }

        private void btnMSDRadixSort_Click(object sender, EventArgs e)
        {
            PerformRadixSort(lsd: false); // Perform MSD Radix Sort
        }
        private void PerformRadixSort(bool lsd)
        {
            if (string.IsNullOrWhiteSpace(txtNumbersRadixSort.Text))
            {
                MessageBox.Show("Please enter numbers to sort.");
                return;
            }

            // Parse numbers
            string[] input = txtNumbersRadixSort.Text.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = input.Select(int.Parse).ToList();

            // Perform sorting
            List<int> sorted = lsd ? RadixSortLSD(numbers) : RadixSortMSD(numbers);

            // Display sorted numbers
            lstSortedRadixSort.Items.Clear();
            foreach (var num in sorted)
            {
                lstSortedRadixSort.Items.Add(num);
            }
        }

        private List<int> RadixSortLSD(List<int> numbers)
        {
            int maxNumber = numbers.Max();
            int maxDigits = maxNumber.ToString().Length;

            for (int digit = 0; digit < maxDigits; digit++)
            {
                numbers = numbers.OrderBy(num => (num / (int)Math.Pow(10, digit)) % 10).ToList();
            }

            return numbers;
        }

        private List<int> RadixSortMSD(List<int> numbers)
        {
            void Sort(List<int> list, int digit)
            {
                if (list.Count <= 1 || digit < 0)
                    return;

                var buckets = new List<int>[10];
                for (int i = 0; i < 10; i++)
                    buckets[i] = new List<int>();

                foreach (var num in list)
                {
                    int bucketIndex = (num / (int)Math.Pow(10, digit)) % 10;
                    buckets[bucketIndex].Add(num);
                }

                list.Clear();
                foreach (var bucket in buckets)
                {
                    Sort(bucket, digit - 1);
                    list.AddRange(bucket);
                }
            }

            int maxNumber = numbers.Max();
            int maxDigits = maxNumber.ToString().Length;

            Sort(numbers, maxDigits - 1);
            return numbers;
        }
    }
}
