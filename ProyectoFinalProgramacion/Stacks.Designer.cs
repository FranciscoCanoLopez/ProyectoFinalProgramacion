namespace ProyectoFinalProgramacion
{
    partial class Stacks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stacks));
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            LblData = new Label();
            btnPeekStaticStack = new Button();
            btnPopStaticStack = new Button();
            btnPushStaticStack = new Button();
            lstStaticStack = new ListBox();
            txtInputStaticStack = new TextBox();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(182, 279);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(41, 29);
            label1.Name = "label1";
            label1.Size = new Size(119, 46);
            label1.TabIndex = 4;
            label1.Text = "Stacks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 97);
            label2.Name = "label2";
            label2.Size = new Size(462, 100);
            label2.TabIndex = 5;
            label2.Text = resources.GetString("label2.Text");
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(537, 29);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(883, 409);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(LblData);
            tabPage1.Controls.Add(btnPeekStaticStack);
            tabPage1.Controls.Add(btnPopStaticStack);
            tabPage1.Controls.Add(btnPushStaticStack);
            tabPage1.Controls.Add(lstStaticStack);
            tabPage1.Controls.Add(txtInputStaticStack);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(875, 376);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Static Stack";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 43);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 22;
            label3.Text = "data to enter";
            // 
            // LblData
            // 
            LblData.AutoSize = true;
            LblData.Location = new Point(449, 3);
            LblData.Name = "LblData";
            LblData.Size = new Size(263, 20);
            LblData.TabIndex = 21;
            LblData.Text = "Static stack with a space of 8 elements";
            // 
            // btnPeekStaticStack
            // 
            btnPeekStaticStack.Location = new Point(167, 221);
            btnPeekStaticStack.Margin = new Padding(3, 4, 3, 4);
            btnPeekStaticStack.Name = "btnPeekStaticStack";
            btnPeekStaticStack.Size = new Size(87, 53);
            btnPeekStaticStack.TabIndex = 20;
            btnPeekStaticStack.Text = "Peek";
            btnPeekStaticStack.UseVisualStyleBackColor = true;
            btnPeekStaticStack.Click += btnPeekStaticStack_Click;
            // 
            // btnPopStaticStack
            // 
            btnPopStaticStack.Location = new Point(167, 156);
            btnPopStaticStack.Margin = new Padding(3, 4, 3, 4);
            btnPopStaticStack.Name = "btnPopStaticStack";
            btnPopStaticStack.Size = new Size(87, 53);
            btnPopStaticStack.TabIndex = 19;
            btnPopStaticStack.Text = "Pop";
            btnPopStaticStack.UseVisualStyleBackColor = true;
            btnPopStaticStack.Click += btnPopStaticStack_Click;
            // 
            // btnPushStaticStack
            // 
            btnPushStaticStack.Location = new Point(167, 86);
            btnPushStaticStack.Margin = new Padding(3, 4, 3, 4);
            btnPushStaticStack.Name = "btnPushStaticStack";
            btnPushStaticStack.Size = new Size(87, 53);
            btnPushStaticStack.TabIndex = 18;
            btnPushStaticStack.Text = "Push";
            btnPushStaticStack.UseVisualStyleBackColor = true;
            btnPushStaticStack.Click += btnPushStaticStack_Click;
            // 
            // lstStaticStack
            // 
            lstStaticStack.Font = new Font("Berlin Sans FB", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstStaticStack.FormattingEnabled = true;
            lstStaticStack.ItemHeight = 57;
            lstStaticStack.Location = new Point(449, 27);
            lstStaticStack.Margin = new Padding(3, 4, 3, 4);
            lstStaticStack.Name = "lstStaticStack";
            lstStaticStack.Size = new Size(364, 289);
            lstStaticStack.TabIndex = 17;
            // 
            // txtInputStaticStack
            // 
            txtInputStaticStack.Location = new Point(118, 39);
            txtInputStaticStack.Margin = new Padding(3, 4, 3, 4);
            txtInputStaticStack.Name = "txtInputStaticStack";
            txtInputStaticStack.Size = new Size(220, 27);
            txtInputStaticStack.TabIndex = 16;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(875, 376);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dynamic stack";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Stacks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 450);
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Name = "Stacks";
            Text = "Stacks";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private Label LblData;
        private Button btnPeekStaticStack;
        private Button btnPopStaticStack;
        private Button btnPushStaticStack;
        private ListBox lstStaticStack;
        private TextBox txtInputStaticStack;
    }
}