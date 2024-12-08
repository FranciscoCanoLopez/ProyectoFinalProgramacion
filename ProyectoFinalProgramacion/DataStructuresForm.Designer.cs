namespace ProyectoFinalProgramacion
{
    partial class DataStructuresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataStructuresForm));
            label1 = new Label();
            label2 = new Label();
            btnLinear = new Button();
            btnNonLinear = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 33);
            label1.Name = "label1";
            label1.Size = new Size(266, 46);
            label1.TabIndex = 0;
            label1.Text = "Data Structures";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 99);
            label2.Name = "label2";
            label2.Size = new Size(662, 160);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLinear
            // 
            btnLinear.Location = new Point(181, 286);
            btnLinear.Name = "btnLinear";
            btnLinear.Size = new Size(94, 29);
            btnLinear.TabIndex = 2;
            btnLinear.Text = "Linear";
            btnLinear.UseVisualStyleBackColor = true;
            btnLinear.Click += btnLinear_Click;
            // 
            // btnNonLinear
            // 
            btnNonLinear.Location = new Point(498, 286);
            btnNonLinear.Name = "btnNonLinear";
            btnNonLinear.Size = new Size(94, 29);
            btnNonLinear.TabIndex = 3;
            btnNonLinear.Text = "Non Linear";
            btnNonLinear.UseVisualStyleBackColor = true;
            btnNonLinear.Click += btnNonLinear_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(337, 350);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // DataStructuresForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnNonLinear);
            Controls.Add(btnLinear);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DataStructuresForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataStructuresForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnLinear;
        private Button btnNonLinear;
        private Button btnBack;
    }
}