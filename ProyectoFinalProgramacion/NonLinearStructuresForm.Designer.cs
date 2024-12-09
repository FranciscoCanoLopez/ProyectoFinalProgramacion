namespace ProyectoFinalProgramacion
{
    partial class NonLinearStructuresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NonLinearStructuresForm));
            label1 = new Label();
            label2 = new Label();
            btnBack = new Button();
            btnBinariTree = new Button();
            btnGraphs = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 49);
            label1.Name = "label1";
            label1.Size = new Size(413, 46);
            label1.TabIndex = 1;
            label1.Text = "Nonlinear data structure";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 118);
            label2.Name = "label2";
            label2.Size = new Size(706, 60);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(322, 319);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnBinariTree
            // 
            btnBinariTree.Location = new Point(174, 234);
            btnBinariTree.Name = "btnBinariTree";
            btnBinariTree.Size = new Size(94, 57);
            btnBinariTree.TabIndex = 7;
            btnBinariTree.Text = "Binari\r\nTree";
            btnBinariTree.UseVisualStyleBackColor = true;
            btnBinariTree.Click += btnBinariTree_Click;
            // 
            // btnGraphs
            // 
            btnGraphs.Location = new Point(493, 234);
            btnGraphs.Name = "btnGraphs";
            btnGraphs.Size = new Size(94, 57);
            btnGraphs.TabIndex = 8;
            btnGraphs.Text = "Graphs";
            btnGraphs.UseVisualStyleBackColor = true;
            btnGraphs.Click += btnGraphs_Click;
            // 
            // NonLinearStructuresForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 371);
            Controls.Add(btnGraphs);
            Controls.Add(btnBinariTree);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NonLinearStructuresForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NonLinearStructuresForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnBack;
        private Button btnBinariTree;
        private Button btnGraphs;
    }
}