namespace ProyectoFinalProgramacion
{
    partial class AlgorithmsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlgorithmsForm));
            btnSorting = new Button();
            btnSearch = new Button();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSorting
            // 
            btnSorting.Location = new Point(196, 205);
            btnSorting.Name = "btnSorting";
            btnSorting.Size = new Size(94, 29);
            btnSorting.TabIndex = 0;
            btnSorting.Text = "Sorting";
            btnSorting.UseVisualStyleBackColor = true;
            btnSorting.Click += btnSorting_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(473, 205);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(335, 265);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 41);
            label1.Name = "label1";
            label1.Size = new Size(199, 46);
            label1.TabIndex = 3;
            label1.Text = "Algorithms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 107);
            label2.Name = "label2";
            label2.Size = new Size(533, 60);
            label2.TabIndex = 4;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AlgorithmsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 318);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(btnSorting);
            Name = "AlgorithmsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlgorithmsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSorting;
        private Button btnSearch;
        private Button btnBack;
        private Label label1;
        private Label label2;
    }
}