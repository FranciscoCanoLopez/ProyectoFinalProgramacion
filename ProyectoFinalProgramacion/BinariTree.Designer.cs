namespace ProyectoFinalProgramacion
{
    partial class BinariTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinariTree));
            btnBack = new Button();
            btnPostorden = new Button();
            btnPreorden = new Button();
            btnInorden = new Button();
            btnAgregarBinariTreeNode = new Button();
            label1 = new Label();
            label2 = new Label();
            pnlArbol = new Panel();
            txtValorNodo = new TextBox();
            txtResultado = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(74, 316);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnPostorden
            // 
            btnPostorden.Location = new Point(790, 221);
            btnPostorden.Name = "btnPostorden";
            btnPostorden.Size = new Size(94, 29);
            btnPostorden.TabIndex = 8;
            btnPostorden.Text = "Postorden";
            btnPostorden.UseVisualStyleBackColor = true;
            btnPostorden.Click += btnPostorden_Click;
            // 
            // btnPreorden
            // 
            btnPreorden.Location = new Point(790, 186);
            btnPreorden.Name = "btnPreorden";
            btnPreorden.Size = new Size(94, 29);
            btnPreorden.TabIndex = 9;
            btnPreorden.Text = "Preorden";
            btnPreorden.UseVisualStyleBackColor = true;
            btnPreorden.Click += btnPreorden_Click;
            // 
            // btnInorden
            // 
            btnInorden.Location = new Point(790, 151);
            btnInorden.Name = "btnInorden";
            btnInorden.Size = new Size(94, 29);
            btnInorden.TabIndex = 10;
            btnInorden.Text = "Inorden";
            btnInorden.UseVisualStyleBackColor = true;
            btnInorden.Click += btnInorden_Click;
            // 
            // btnAgregarBinariTreeNode
            // 
            btnAgregarBinariTreeNode.Location = new Point(790, 116);
            btnAgregarBinariTreeNode.Name = "btnAgregarBinariTreeNode";
            btnAgregarBinariTreeNode.Size = new Size(94, 29);
            btnAgregarBinariTreeNode.TabIndex = 11;
            btnAgregarBinariTreeNode.Text = "Agg";
            btnAgregarBinariTreeNode.UseVisualStyleBackColor = true;
            btnAgregarBinariTreeNode.Click += btnAgregarBinariTreeNode_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 32);
            label1.Name = "label1";
            label1.Size = new Size(191, 46);
            label1.TabIndex = 12;
            label1.Text = "Binari Tree";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 86);
            label2.Name = "label2";
            label2.Size = new Size(634, 200);
            label2.TabIndex = 13;
            label2.Text = resources.GetString("label2.Text");
            // 
            // pnlArbol
            // 
            pnlArbol.Location = new Point(965, 32);
            pnlArbol.Name = "pnlArbol";
            pnlArbol.Size = new Size(435, 302);
            pnlArbol.TabIndex = 14;
            pnlArbol.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlArbol_Paint);
            // 
            // txtValorNodo
            // 
            txtValorNodo.Location = new Point(790, 63);
            txtValorNodo.Name = "txtValorNodo";
            txtValorNodo.Size = new Size(125, 27);
            txtValorNodo.TabIndex = 15;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(790, 269);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(125, 27);
            txtResultado.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(790, 32);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 17;
            label3.Text = "Value";
            // 
            // BinariTree
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 352);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(txtValorNodo);
            Controls.Add(pnlArbol);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregarBinariTreeNode);
            Controls.Add(btnInorden);
            Controls.Add(btnPreorden);
            Controls.Add(btnPostorden);
            Controls.Add(btnBack);
            Name = "BinariTree";
            Text = "BinariTree";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnPostorden;
        private Button btnPreorden;
        private Button btnInorden;
        private Button btnAgregarBinariTreeNode;
        private Label label1;
        private Label label2;
        private Panel pnlArbol;
        private TextBox txtValorNodo;
        private TextBox txtResultado;
        private Label label3;
    }
}