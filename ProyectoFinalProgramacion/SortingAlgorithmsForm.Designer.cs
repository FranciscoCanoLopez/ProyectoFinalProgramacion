namespace ProyectoFinalProgramacion
{
    partial class SortingAlgorithmsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortingAlgorithmsForm));
            label1 = new Label();
            label2 = new Label();
            btnBack = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            ComBoxSelect = new ComboBox();
            LsBoxOrder = new ListBox();
            TxtDataNum = new TextBox();
            LblInstructurs = new Label();
            BtnInsert = new Button();
            label3 = new Label();
            tabPage2 = new TabPage();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            lBoxunsorted = new ListBox();
            btnSort = new Button();
            lboxArray = new ListBox();
            btnRandom = new Button();
            tbArray = new TextBox();
            cbOption = new ComboBox();
            tabPage4 = new TabPage();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            btnShellSort = new Button();
            txtInput = new TextBox();
            tabPage5 = new TabPage();
            label8 = new Label();
            cBOrdenCountingSort = new ComboBox();
            lblTimeElapsed = new Label();
            dgvOutputCountingSort = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            btnCountingSort = new Button();
            lblValues = new Label();
            txtInputCountingSort = new TextBox();
            BucketSort = new TabPage();
            cbxOrderBucketSort = new ComboBox();
            lstvBucket = new ListView();
            lstvOrder = new ListView();
            txtOrderBucketSort = new TextBox();
            btnBucketSort = new Button();
            tabPage7 = new TabPage();
            btnClearListMergeSort = new Button();
            lblNumbers = new Label();
            txtInputMergeSort = new TextBox();
            btnIngresarMergeSort = new Button();
            btnMezclaDirecta = new Button();
            btnMezclaNatural = new Button();
            btnMergeSort = new Button();
            listViewStepsMergeSort = new ListView();
            tabPage3 = new TabPage();
            btnShuffleGnomeSort = new Button();
            btnSortGnomeSort = new Button();
            listBoxGnomeSort = new ListBox();
            tabPage6 = new TabPage();
            btnClearPidgeonHola = new Button();
            btnSortPidgeonHola = new Button();
            txtOutputPidgeonHola = new TextBox();
            label11 = new Label();
            txtInputPidgeonHola = new TextBox();
            label10 = new Label();
            tabPage8 = new TabPage();
            dataGridViewStepsCombSort = new DataGridView();
            btnSortCombSort = new Button();
            tabPage9 = new TabPage();
            lstSortedRadixSort = new ListBox();
            txtNumbersRadixSort = new TextBox();
            btnMSDRadixSort = new Button();
            btnLSDRadixSort = new Button();
            btnRandomizeRadixSort = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOutputCountingSort).BeginInit();
            BucketSort.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStepsCombSort).BeginInit();
            tabPage9.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 32);
            label1.Name = "label1";
            label1.Size = new Size(328, 46);
            label1.TabIndex = 0;
            label1.Text = "Sorting Algorithms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 107);
            label2.Name = "label2";
            label2.Size = new Size(676, 140);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // btnBack
            // 
            btnBack.Location = new Point(277, 293);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(BucketSort);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Controls.Add(tabPage9);
            tabControl1.Location = new Point(751, 23);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(807, 425);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(ComBoxSelect);
            tabPage1.Controls.Add(LsBoxOrder);
            tabPage1.Controls.Add(TxtDataNum);
            tabPage1.Controls.Add(LblInstructurs);
            tabPage1.Controls.Add(BtnInsert);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(799, 392);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "BubbleSort, CocktailSort, InsertionSort";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 175);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 14;
            label4.Text = "Tipo de organisacion";
            // 
            // ComBoxSelect
            // 
            ComBoxSelect.FormattingEnabled = true;
            ComBoxSelect.Items.AddRange(new object[] { "Bubblesort", "Cocktail sort", "Insertion sort" });
            ComBoxSelect.Location = new Point(224, 172);
            ComBoxSelect.Margin = new Padding(3, 4, 3, 4);
            ComBoxSelect.Name = "ComBoxSelect";
            ComBoxSelect.Size = new Size(138, 28);
            ComBoxSelect.TabIndex = 13;
            // 
            // LsBoxOrder
            // 
            LsBoxOrder.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LsBoxOrder.FormattingEnabled = true;
            LsBoxOrder.ItemHeight = 51;
            LsBoxOrder.Location = new Point(420, 90);
            LsBoxOrder.Margin = new Padding(3, 4, 3, 4);
            LsBoxOrder.Name = "LsBoxOrder";
            LsBoxOrder.Size = new Size(342, 157);
            LsBoxOrder.TabIndex = 12;
            // 
            // TxtDataNum
            // 
            TxtDataNum.Location = new Point(42, 128);
            TxtDataNum.Name = "TxtDataNum";
            TxtDataNum.Size = new Size(247, 27);
            TxtDataNum.TabIndex = 11;
            // 
            // LblInstructurs
            // 
            LblInstructurs.AutoSize = true;
            LblInstructurs.Location = new Point(28, 90);
            LblInstructurs.Name = "LblInstructurs";
            LblInstructurs.Size = new Size(304, 20);
            LblInstructurs.TabIndex = 10;
            LblInstructurs.Text = "Ingresa 10 numeros seprados por un espacio";
            // 
            // BtnInsert
            // 
            BtnInsert.Location = new Point(295, 128);
            BtnInsert.Name = "BtnInsert";
            BtnInsert.Size = new Size(94, 29);
            BtnInsert.TabIndex = 9;
            BtnInsert.Text = "Insertar";
            BtnInsert.UseVisualStyleBackColor = true;
            BtnInsert.Click += BtnInsert_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 20);
            label3.Name = "label3";
            label3.Size = new Size(646, 46);
            label3.TabIndex = 8;
            label3.Text = "BubbleSort, CocktailSort, InsertionSort";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(lBoxunsorted);
            tabPage2.Controls.Add(btnSort);
            tabPage2.Controls.Add(lboxArray);
            tabPage2.Controls.Add(btnRandom);
            tabPage2.Controls.Add(tbArray);
            tabPage2.Controls.Add(cbOption);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(799, 392);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "SelectionSort, HeapSort, QuickSort ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(434, 143);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 17;
            label9.Text = "Organized";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(175, 143);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 16;
            label6.Text = "Disorganized";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(485, 31);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 15;
            label5.Text = "Algorithm";
            // 
            // lBoxunsorted
            // 
            lBoxunsorted.FormattingEnabled = true;
            lBoxunsorted.Location = new Point(175, 167);
            lBoxunsorted.Margin = new Padding(3, 4, 3, 4);
            lBoxunsorted.Name = "lBoxunsorted";
            lBoxunsorted.Size = new Size(137, 164);
            lBoxunsorted.TabIndex = 14;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(337, 90);
            btnSort.Margin = new Padding(3, 4, 3, 4);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(86, 31);
            btnSort.TabIndex = 13;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // lboxArray
            // 
            lboxArray.FormattingEnabled = true;
            lboxArray.Location = new Point(434, 167);
            lboxArray.Margin = new Padding(3, 4, 3, 4);
            lboxArray.Name = "lboxArray";
            lboxArray.Size = new Size(137, 164);
            lboxArray.TabIndex = 12;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(175, 51);
            btnRandom.Margin = new Padding(3, 4, 3, 4);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(86, 31);
            btnRandom.TabIndex = 10;
            btnRandom.Text = "Random";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // tbArray
            // 
            tbArray.Location = new Point(269, 55);
            tbArray.Margin = new Padding(3, 4, 3, 4);
            tbArray.Name = "tbArray";
            tbArray.Size = new Size(210, 27);
            tbArray.TabIndex = 9;
            // 
            // cbOption
            // 
            cbOption.FormattingEnabled = true;
            cbOption.Items.AddRange(new object[] { "Selectionsort", "Heapsort", "Quicksort" });
            cbOption.Location = new Point(485, 55);
            cbOption.Margin = new Padding(3, 4, 3, 4);
            cbOption.Name = "cbOption";
            cbOption.Size = new Size(138, 28);
            cbOption.TabIndex = 8;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(btnShellSort);
            tabPage4.Controls.Add(txtInput);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(799, 392);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "ShellSort";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(160, 142);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(478, 232);
            dataGridView1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(160, 19);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 8;
            label7.Text = "Array";
            // 
            // btnShellSort
            // 
            btnShellSort.Location = new Point(160, 82);
            btnShellSort.Margin = new Padding(3, 4, 3, 4);
            btnShellSort.Name = "btnShellSort";
            btnShellSort.Size = new Size(137, 31);
            btnShellSort.TabIndex = 7;
            btnShellSort.Text = "Activate Shell sort";
            btnShellSort.UseVisualStyleBackColor = true;
            btnShellSort.Click += btnShellSort_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(160, 43);
            txtInput.Margin = new Padding(3, 4, 3, 4);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(205, 27);
            txtInput.TabIndex = 6;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label8);
            tabPage5.Controls.Add(cBOrdenCountingSort);
            tabPage5.Controls.Add(lblTimeElapsed);
            tabPage5.Controls.Add(dgvOutputCountingSort);
            tabPage5.Controls.Add(btnCountingSort);
            tabPage5.Controls.Add(lblValues);
            tabPage5.Controls.Add(txtInputCountingSort);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(799, 392);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "CountingSort";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(607, 9);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 310;
            label8.Text = "Orden";
            // 
            // cBOrdenCountingSort
            // 
            cBOrdenCountingSort.FormattingEnabled = true;
            cBOrdenCountingSort.Location = new Point(607, 43);
            cBOrdenCountingSort.Name = "cBOrdenCountingSort";
            cBOrdenCountingSort.Size = new Size(151, 28);
            cBOrdenCountingSort.TabIndex = 309;
            // 
            // lblTimeElapsed
            // 
            lblTimeElapsed.AutoSize = true;
            lblTimeElapsed.Location = new Point(579, 89);
            lblTimeElapsed.Name = "lblTimeElapsed";
            lblTimeElapsed.Size = new Size(179, 20);
            lblTimeElapsed.TabIndex = 308;
            lblTimeElapsed.Text = "Tiempo de ordenamiento";
            // 
            // dgvOutputCountingSort
            // 
            dgvOutputCountingSort.AllowUserToAddRows = false;
            dgvOutputCountingSort.AllowUserToDeleteRows = false;
            dgvOutputCountingSort.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutputCountingSort.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dgvOutputCountingSort.EnableHeadersVisualStyles = false;
            dgvOutputCountingSort.Location = new Point(144, 133);
            dgvOutputCountingSort.Name = "dgvOutputCountingSort";
            dgvOutputCountingSort.RowHeadersWidth = 51;
            dgvOutputCountingSort.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOutputCountingSort.Size = new Size(551, 234);
            dgvOutputCountingSort.TabIndex = 307;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 500;
            // 
            // btnCountingSort
            // 
            btnCountingSort.Location = new Point(242, 85);
            btnCountingSort.Name = "btnCountingSort";
            btnCountingSort.Size = new Size(94, 29);
            btnCountingSort.TabIndex = 306;
            btnCountingSort.Text = "Sort";
            btnCountingSort.UseVisualStyleBackColor = true;
            btnCountingSort.Click += btnCountingSort_Click;
            // 
            // lblValues
            // 
            lblValues.AutoSize = true;
            lblValues.Location = new Point(55, 9);
            lblValues.Name = "lblValues";
            lblValues.Size = new Size(51, 20);
            lblValues.TabIndex = 305;
            lblValues.Text = "Values";
            // 
            // txtInputCountingSort
            // 
            txtInputCountingSort.Font = new Font("Segoe UI", 15F);
            txtInputCountingSort.Location = new Point(55, 38);
            txtInputCountingSort.Name = "txtInputCountingSort";
            txtInputCountingSort.Size = new Size(521, 41);
            txtInputCountingSort.TabIndex = 304;
            // 
            // BucketSort
            // 
            BucketSort.Controls.Add(cbxOrderBucketSort);
            BucketSort.Controls.Add(lstvBucket);
            BucketSort.Controls.Add(lstvOrder);
            BucketSort.Controls.Add(txtOrderBucketSort);
            BucketSort.Controls.Add(btnBucketSort);
            BucketSort.Location = new Point(4, 29);
            BucketSort.Name = "BucketSort";
            BucketSort.Padding = new Padding(3);
            BucketSort.Size = new Size(799, 392);
            BucketSort.TabIndex = 5;
            BucketSort.Text = "BucketSort";
            BucketSort.UseVisualStyleBackColor = true;
            // 
            // cbxOrderBucketSort
            // 
            cbxOrderBucketSort.FormattingEnabled = true;
            cbxOrderBucketSort.Location = new Point(44, 34);
            cbxOrderBucketSort.Margin = new Padding(3, 4, 3, 4);
            cbxOrderBucketSort.Name = "cbxOrderBucketSort";
            cbxOrderBucketSort.Size = new Size(138, 28);
            cbxOrderBucketSort.TabIndex = 11;
            // 
            // lstvBucket
            // 
            lstvBucket.Location = new Point(440, 18);
            lstvBucket.Margin = new Padding(3, 4, 3, 4);
            lstvBucket.Name = "lstvBucket";
            lstvBucket.Size = new Size(301, 154);
            lstvBucket.TabIndex = 9;
            lstvBucket.UseCompatibleStateImageBehavior = false;
            // 
            // lstvOrder
            // 
            lstvOrder.Location = new Point(441, 223);
            lstvOrder.Margin = new Padding(3, 4, 3, 4);
            lstvOrder.Name = "lstvOrder";
            lstvOrder.Size = new Size(300, 165);
            lstvOrder.TabIndex = 8;
            lstvOrder.UseCompatibleStateImageBehavior = false;
            // 
            // txtOrderBucketSort
            // 
            txtOrderBucketSort.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrderBucketSort.Location = new Point(44, 91);
            txtOrderBucketSort.Margin = new Padding(3, 4, 3, 4);
            txtOrderBucketSort.Multiline = true;
            txtOrderBucketSort.Name = "txtOrderBucketSort";
            txtOrderBucketSort.ReadOnly = true;
            txtOrderBucketSort.ScrollBars = ScrollBars.Vertical;
            txtOrderBucketSort.Size = new Size(337, 73);
            txtOrderBucketSort.TabIndex = 7;
            // 
            // btnBucketSort
            // 
            btnBucketSort.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBucketSort.Location = new Point(139, 174);
            btnBucketSort.Margin = new Padding(3, 4, 3, 4);
            btnBucketSort.Name = "btnBucketSort";
            btnBucketSort.Size = new Size(139, 43);
            btnBucketSort.TabIndex = 6;
            btnBucketSort.Text = "Bucket Sort ";
            btnBucketSort.UseVisualStyleBackColor = true;
            btnBucketSort.Click += btnBucketSort_Click;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(btnClearListMergeSort);
            tabPage7.Controls.Add(lblNumbers);
            tabPage7.Controls.Add(txtInputMergeSort);
            tabPage7.Controls.Add(btnIngresarMergeSort);
            tabPage7.Controls.Add(btnMezclaDirecta);
            tabPage7.Controls.Add(btnMezclaNatural);
            tabPage7.Controls.Add(btnMergeSort);
            tabPage7.Controls.Add(listViewStepsMergeSort);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(799, 392);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "MergeSort";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnClearListMergeSort
            // 
            btnClearListMergeSort.Location = new Point(271, 290);
            btnClearListMergeSort.Margin = new Padding(3, 4, 3, 4);
            btnClearListMergeSort.Name = "btnClearListMergeSort";
            btnClearListMergeSort.Size = new Size(86, 31);
            btnClearListMergeSort.TabIndex = 15;
            btnClearListMergeSort.Text = "Clear list";
            btnClearListMergeSort.UseVisualStyleBackColor = true;
            btnClearListMergeSort.Click += btnClearListMergeSort_Click;
            // 
            // lblNumbers
            // 
            lblNumbers.AutoSize = true;
            lblNumbers.Location = new Point(19, 110);
            lblNumbers.Name = "lblNumbers";
            lblNumbers.Size = new Size(69, 20);
            lblNumbers.TabIndex = 14;
            lblNumbers.Text = "Numbers";
            // 
            // txtInputMergeSort
            // 
            txtInputMergeSort.Location = new Point(84, 105);
            txtInputMergeSort.Margin = new Padding(3, 4, 3, 4);
            txtInputMergeSort.Name = "txtInputMergeSort";
            txtInputMergeSort.Size = new Size(172, 27);
            txtInputMergeSort.TabIndex = 13;
            // 
            // btnIngresarMergeSort
            // 
            btnIngresarMergeSort.Location = new Point(271, 105);
            btnIngresarMergeSort.Margin = new Padding(3, 4, 3, 4);
            btnIngresarMergeSort.Name = "btnIngresarMergeSort";
            btnIngresarMergeSort.Size = new Size(86, 31);
            btnIngresarMergeSort.TabIndex = 12;
            btnIngresarMergeSort.Text = "Ingresar";
            btnIngresarMergeSort.UseVisualStyleBackColor = true;
            btnIngresarMergeSort.Click += btnIngresarMergeSort_Click;
            // 
            // btnMezclaDirecta
            // 
            btnMezclaDirecta.Location = new Point(271, 186);
            btnMezclaDirecta.Margin = new Padding(3, 4, 3, 4);
            btnMezclaDirecta.Name = "btnMezclaDirecta";
            btnMezclaDirecta.Size = new Size(86, 31);
            btnMezclaDirecta.TabIndex = 11;
            btnMezclaDirecta.Text = "Directa";
            btnMezclaDirecta.UseVisualStyleBackColor = true;
            btnMezclaDirecta.Click += btnDirectMerge_Click;
            // 
            // btnMezclaNatural
            // 
            btnMezclaNatural.Location = new Point(271, 230);
            btnMezclaNatural.Margin = new Padding(3, 4, 3, 4);
            btnMezclaNatural.Name = "btnMezclaNatural";
            btnMezclaNatural.Size = new Size(86, 31);
            btnMezclaNatural.TabIndex = 10;
            btnMezclaNatural.Text = "Natural";
            btnMezclaNatural.UseVisualStyleBackColor = true;
            btnMezclaNatural.Click += btnNaturalMerge_Click;
            // 
            // btnMergeSort
            // 
            btnMergeSort.Location = new Point(271, 148);
            btnMergeSort.Margin = new Padding(3, 4, 3, 4);
            btnMergeSort.Name = "btnMergeSort";
            btnMergeSort.Size = new Size(86, 31);
            btnMergeSort.TabIndex = 9;
            btnMergeSort.Text = "Merge";
            btnMergeSort.UseVisualStyleBackColor = true;
            btnMergeSort.Click += btnMergeSort_Click;
            // 
            // listViewStepsMergeSort
            // 
            listViewStepsMergeSort.FullRowSelect = true;
            listViewStepsMergeSort.GridLines = true;
            listViewStepsMergeSort.Location = new Point(401, 81);
            listViewStepsMergeSort.Margin = new Padding(3, 4, 3, 4);
            listViewStepsMergeSort.Name = "listViewStepsMergeSort";
            listViewStepsMergeSort.Size = new Size(369, 240);
            listViewStepsMergeSort.TabIndex = 8;
            listViewStepsMergeSort.UseCompatibleStateImageBehavior = false;
            listViewStepsMergeSort.View = View.Details;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnShuffleGnomeSort);
            tabPage3.Controls.Add(btnSortGnomeSort);
            tabPage3.Controls.Add(listBoxGnomeSort);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(799, 392);
            tabPage3.TabIndex = 7;
            tabPage3.Text = "GnomeSort";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnShuffleGnomeSort
            // 
            btnShuffleGnomeSort.Location = new Point(228, 231);
            btnShuffleGnomeSort.Margin = new Padding(3, 4, 3, 4);
            btnShuffleGnomeSort.Name = "btnShuffleGnomeSort";
            btnShuffleGnomeSort.Size = new Size(144, 44);
            btnShuffleGnomeSort.TabIndex = 5;
            btnShuffleGnomeSort.Text = "Shuffle";
            btnShuffleGnomeSort.UseVisualStyleBackColor = true;
            btnShuffleGnomeSort.Click += btnShuffleGnomeSort_Click;
            // 
            // btnSortGnomeSort
            // 
            btnSortGnomeSort.Location = new Point(416, 231);
            btnSortGnomeSort.Margin = new Padding(3, 4, 3, 4);
            btnSortGnomeSort.Name = "btnSortGnomeSort";
            btnSortGnomeSort.Size = new Size(144, 44);
            btnSortGnomeSort.TabIndex = 4;
            btnSortGnomeSort.Text = "Sort";
            btnSortGnomeSort.UseVisualStyleBackColor = true;
            btnSortGnomeSort.Click += btnSortGnomeSort_Click;
            // 
            // listBoxGnomeSort
            // 
            listBoxGnomeSort.Font = new Font("Segoe UI", 20F);
            listBoxGnomeSort.FormattingEnabled = true;
            listBoxGnomeSort.ItemHeight = 45;
            listBoxGnomeSort.Location = new Point(37, 71);
            listBoxGnomeSort.Margin = new Padding(3, 4, 3, 4);
            listBoxGnomeSort.Name = "listBoxGnomeSort";
            listBoxGnomeSort.Size = new Size(711, 94);
            listBoxGnomeSort.TabIndex = 3;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(btnClearPidgeonHola);
            tabPage6.Controls.Add(btnSortPidgeonHola);
            tabPage6.Controls.Add(txtOutputPidgeonHola);
            tabPage6.Controls.Add(label11);
            tabPage6.Controls.Add(txtInputPidgeonHola);
            tabPage6.Controls.Add(label10);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(799, 392);
            tabPage6.TabIndex = 8;
            tabPage6.Text = "PidgeonHolesSort";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnClearPidgeonHola
            // 
            btnClearPidgeonHola.Location = new Point(323, 279);
            btnClearPidgeonHola.Name = "btnClearPidgeonHola";
            btnClearPidgeonHola.Size = new Size(94, 29);
            btnClearPidgeonHola.TabIndex = 5;
            btnClearPidgeonHola.Text = "Clear";
            btnClearPidgeonHola.UseVisualStyleBackColor = true;
            btnClearPidgeonHola.Click += btnClearPidgeonHola_Click;
            // 
            // btnSortPidgeonHola
            // 
            btnSortPidgeonHola.Location = new Point(71, 279);
            btnSortPidgeonHola.Name = "btnSortPidgeonHola";
            btnSortPidgeonHola.Size = new Size(94, 29);
            btnSortPidgeonHola.TabIndex = 4;
            btnSortPidgeonHola.Text = "Sort";
            btnSortPidgeonHola.UseVisualStyleBackColor = true;
            btnSortPidgeonHola.Click += btnSortPidgeonHola_Click;
            // 
            // txtOutputPidgeonHola
            // 
            txtOutputPidgeonHola.Location = new Point(71, 206);
            txtOutputPidgeonHola.Name = "txtOutputPidgeonHola";
            txtOutputPidgeonHola.Size = new Size(257, 27);
            txtOutputPidgeonHola.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(71, 164);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 2;
            label11.Text = "Resultado";
            // 
            // txtInputPidgeonHola
            // 
            txtInputPidgeonHola.Location = new Point(71, 108);
            txtInputPidgeonHola.Name = "txtInputPidgeonHola";
            txtInputPidgeonHola.Size = new Size(257, 27);
            txtInputPidgeonHola.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(71, 70);
            label10.Name = "label10";
            label10.Size = new Size(315, 20);
            label10.TabIndex = 0;
            label10.Text = "Ingresa números válidos separados por comas";
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(dataGridViewStepsCombSort);
            tabPage8.Controls.Add(btnSortCombSort);
            tabPage8.Location = new Point(4, 29);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(799, 392);
            tabPage8.TabIndex = 9;
            tabPage8.Text = "CombSort";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStepsCombSort
            // 
            dataGridViewStepsCombSort.AllowUserToOrderColumns = true;
            dataGridViewStepsCombSort.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStepsCombSort.Location = new Point(162, 37);
            dataGridViewStepsCombSort.Name = "dataGridViewStepsCombSort";
            dataGridViewStepsCombSort.RowHeadersWidth = 51;
            dataGridViewStepsCombSort.Size = new Size(475, 237);
            dataGridViewStepsCombSort.TabIndex = 5;
            // 
            // btnSortCombSort
            // 
            btnSortCombSort.Location = new Point(162, 301);
            btnSortCombSort.Name = "btnSortCombSort";
            btnSortCombSort.Size = new Size(203, 55);
            btnSortCombSort.TabIndex = 4;
            btnSortCombSort.Text = "Ordenar";
            btnSortCombSort.UseVisualStyleBackColor = true;
            btnSortCombSort.Click += btnSortCombSort_Click;
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(lstSortedRadixSort);
            tabPage9.Controls.Add(txtNumbersRadixSort);
            tabPage9.Controls.Add(btnMSDRadixSort);
            tabPage9.Controls.Add(btnLSDRadixSort);
            tabPage9.Controls.Add(btnRandomizeRadixSort);
            tabPage9.Location = new Point(4, 29);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(799, 392);
            tabPage9.TabIndex = 10;
            tabPage9.Text = "RadixSort";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // lstSortedRadixSort
            // 
            lstSortedRadixSort.FormattingEnabled = true;
            lstSortedRadixSort.Location = new Point(279, 80);
            lstSortedRadixSort.Name = "lstSortedRadixSort";
            lstSortedRadixSort.Size = new Size(272, 204);
            lstSortedRadixSort.TabIndex = 4;
            // 
            // txtNumbersRadixSort
            // 
            txtNumbersRadixSort.Location = new Point(28, 30);
            txtNumbersRadixSort.Name = "txtNumbersRadixSort";
            txtNumbersRadixSort.Size = new Size(523, 27);
            txtNumbersRadixSort.TabIndex = 3;
            // 
            // btnMSDRadixSort
            // 
            btnMSDRadixSort.Location = new Point(155, 129);
            btnMSDRadixSort.Name = "btnMSDRadixSort";
            btnMSDRadixSort.Size = new Size(94, 29);
            btnMSDRadixSort.TabIndex = 2;
            btnMSDRadixSort.Text = "MSD";
            btnMSDRadixSort.UseVisualStyleBackColor = true;
            btnMSDRadixSort.Click += btnMSDRadixSort_Click;
            // 
            // btnLSDRadixSort
            // 
            btnLSDRadixSort.Location = new Point(155, 80);
            btnLSDRadixSort.Name = "btnLSDRadixSort";
            btnLSDRadixSort.Size = new Size(94, 29);
            btnLSDRadixSort.TabIndex = 1;
            btnLSDRadixSort.Text = "LSD";
            btnLSDRadixSort.UseVisualStyleBackColor = true;
            btnLSDRadixSort.Click += btnLSDRadixSort_Click;
            // 
            // btnRandomizeRadixSort
            // 
            btnRandomizeRadixSort.Location = new Point(28, 80);
            btnRandomizeRadixSort.Name = "btnRandomizeRadixSort";
            btnRandomizeRadixSort.Size = new Size(94, 29);
            btnRandomizeRadixSort.TabIndex = 0;
            btnRandomizeRadixSort.Text = "Randomize";
            btnRandomizeRadixSort.UseVisualStyleBackColor = true;
            btnRandomizeRadixSort.Click += btnRandomizeRadixSort_Click;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // SortingAlgorithmsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 450);
            Controls.Add(tabControl1);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SortingAlgorithmsForm";
            Text = "SortingAlgorithmsForm";
            Load += SortingAlgorithmsForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOutputCountingSort).EndInit();
            BucketSort.ResumeLayout(false);
            BucketSort.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStepsCombSort).EndInit();
            tabPage9.ResumeLayout(false);
            tabPage9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnBack;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage BucketSort;
        private TabPage tabPage7;
        private Label label3;
        private Label label4;
        private ComboBox ComBoxSelect;
        private ListBox LsBoxOrder;
        private TextBox TxtDataNum;
        private Label LblInstructurs;
        private Button BtnInsert;
        private Label label5;
        private ListBox lBoxunsorted;
        private Button btnSort;
        private ListBox lboxArray;
        private Button btnRandom;
        private TextBox tbArray;
        private ComboBox cbOption;
        private Label label9;
        private Label label6;
        private DataGridView dataGridView1;
        private Label label7;
        private Button btnShellSort;
        private TextBox txtInput;
        private Label label8;
        private ComboBox cBOrdenCountingSort;
        private Label lblTimeElapsed;
        private DataGridView dgvOutputCountingSort;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnCountingSort;
        private Label lblValues;
        private TextBox txtInputCountingSort;
        private System.Windows.Forms.Timer timer1;
        private ComboBox cbxOrderBucketSort;
        private ListView lstvBucket;
        private ListView lstvOrder;
        private TextBox txtOrderBucketSort;
        private Button btnBucketSort;
        private Button btnClearListMergeSort;
        private Label lblNumbers;
        private TextBox txtInputMergeSort;
        private Button btnIngresarMergeSort;
        private Button btnMezclaDirecta;
        private Button btnMezclaNatural;
        private Button btnMergeSort;
        private ListView listViewStepsMergeSort;
        private TabPage tabPage3;
        private Button btnShuffleGnomeSort;
        private Button btnSortGnomeSort;
        private ListBox listBoxGnomeSort;
        private TabPage tabPage6;
        private Button btnClearPidgeonHola;
        private Button btnSortPidgeonHola;
        private TextBox txtOutputPidgeonHola;
        private Label label11;
        private TextBox txtInputPidgeonHola;
        private Label label10;
        private TabPage tabPage8;
        private DataGridView dataGridViewStepsCombSort;
        private Button btnSortCombSort;
        private TabPage tabPage9;
        private ListBox lstSortedRadixSort;
        private TextBox txtNumbersRadixSort;
        private Button btnMSDRadixSort;
        private Button btnLSDRadixSort;
        private Button btnRandomizeRadixSort;
    }
}