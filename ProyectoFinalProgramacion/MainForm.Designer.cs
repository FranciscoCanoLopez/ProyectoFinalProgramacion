namespace ProyectoFinalProgramacion
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDataStructures = new Button();
            btnAlgorithms = new Button();
            btnExit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDataStructures
            // 
            btnDataStructures.Location = new Point(102, 121);
            btnDataStructures.Name = "btnDataStructures";
            btnDataStructures.Size = new Size(100, 71);
            btnDataStructures.TabIndex = 0;
            btnDataStructures.Text = "Data\r\nStructures";
            btnDataStructures.UseVisualStyleBackColor = true;
            btnDataStructures.Click += btnDataStructures_Click;
            // 
            // btnAlgorithms
            // 
            btnAlgorithms.Location = new Point(317, 121);
            btnAlgorithms.Name = "btnAlgorithms";
            btnAlgorithms.Size = new Size(94, 71);
            btnAlgorithms.TabIndex = 1;
            btnAlgorithms.Text = "Algorithms";
            btnAlgorithms.UseVisualStyleBackColor = true;
            btnAlgorithms.Click += btnAlgorithms_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(208, 223);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 82);
            label1.TabIndex = 3;
            label1.Text = "Data Structure \r\nFinal Project";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 280);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnAlgorithms);
            Controls.Add(btnDataStructures);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDataStructures;
        private Button btnAlgorithms;
        private Button btnExit;
        private Label label1;
    }
}
