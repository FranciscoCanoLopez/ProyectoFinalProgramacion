namespace ProyectoFinalProgramacion
{
    partial class LinearStructuresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinearStructuresForm));
            label1 = new Label();
            label2 = new Label();
            btnLists = new Button();
            btnStacks = new Button();
            btnQueues = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 42);
            label1.Name = "label1";
            label1.Size = new Size(351, 46);
            label1.TabIndex = 0;
            label1.Text = "Linear data structure";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 108);
            label2.Name = "label2";
            label2.Size = new Size(687, 60);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // btnLists
            // 
            btnLists.Location = new Point(132, 205);
            btnLists.Name = "btnLists";
            btnLists.Size = new Size(94, 29);
            btnLists.TabIndex = 2;
            btnLists.Text = "Lists";
            btnLists.UseVisualStyleBackColor = true;
            btnLists.Click += btnLists_Click;
            // 
            // btnStacks
            // 
            btnStacks.Location = new Point(341, 205);
            btnStacks.Name = "btnStacks";
            btnStacks.Size = new Size(94, 29);
            btnStacks.TabIndex = 3;
            btnStacks.Text = "Stacks";
            btnStacks.UseVisualStyleBackColor = true;
            btnStacks.Click += btnStacks_Click;
            // 
            // btnQueues
            // 
            btnQueues.Location = new Point(539, 205);
            btnQueues.Name = "btnQueues";
            btnQueues.Size = new Size(94, 29);
            btnQueues.TabIndex = 4;
            btnQueues.Text = "Queues";
            btnQueues.UseVisualStyleBackColor = true;
            btnQueues.Click += btnQueues_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(341, 307);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // LinearStructuresForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnQueues);
            Controls.Add(btnStacks);
            Controls.Add(btnLists);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LinearStructuresForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LinearStructuresForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnLists;
        private Button btnStacks;
        private Button btnQueues;
        private Button btnBack;
    }
}