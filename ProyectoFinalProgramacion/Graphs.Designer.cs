namespace ProyectoFinalProgramacion
{
    partial class Graphs
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
            label1 = new Label();
            label2 = new Label();
            btnBack = new Button();
            btnRemoveAll = new Button();
            btnShowDFSRecursive = new Button();
            label6 = new Label();
            btnShowBFS = new Button();
            btnRemoveNode = new Button();
            txtStartNode = new TextBox();
            btnShowDFS = new Button();
            chkDirected = new CheckBox();
            label5 = new Label();
            txtWeight = new TextBox();
            txtGraphRepresentation = new TextBox();
            btnRemoveEdge = new Button();
            btnAddEdge = new Button();
            label4 = new Label();
            txtTo = new TextBox();
            label3 = new Label();
            txtFrom = new TextBox();
            label7 = new Label();
            txtNode = new TextBox();
            btnAddNode = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 28);
            label1.Name = "label1";
            label1.Size = new Size(132, 46);
            label1.TabIndex = 0;
            label1.Text = "Graphs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 101);
            label2.Name = "label2";
            label2.Size = new Size(467, 80);
            label2.TabIndex = 1;
            label2.Text = "Graphs are data structures used to model problems \r\nand represent relationships between objects or physical entities.\r\n\r\nThey consist of a set of nodes or vertices, connected by edges or arcs.";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(208, 269);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnRemoveAll
            // 
            btnRemoveAll.Location = new Point(1071, 44);
            btnRemoveAll.Margin = new Padding(3, 4, 3, 4);
            btnRemoveAll.Name = "btnRemoveAll";
            btnRemoveAll.Size = new Size(96, 31);
            btnRemoveAll.TabIndex = 44;
            btnRemoveAll.Text = "Remove All";
            btnRemoveAll.UseVisualStyleBackColor = true;
            btnRemoveAll.Click += btnRemoveAll_Click;
            // 
            // btnShowDFSRecursive
            // 
            btnShowDFSRecursive.Location = new Point(706, 340);
            btnShowDFSRecursive.Margin = new Padding(3, 4, 3, 4);
            btnShowDFSRecursive.Name = "btnShowDFSRecursive";
            btnShowDFSRecursive.Size = new Size(86, 52);
            btnShowDFSRecursive.TabIndex = 43;
            btnShowDFSRecursive.Text = "Show DFS Recursive Algorithm";
            btnShowDFSRecursive.UseVisualStyleBackColor = true;
            btnShowDFSRecursive.Click += btnShowDFSRecursive_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(532, 302);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 42;
            label6.Text = "Node Start:";
            // 
            // btnShowBFS
            // 
            btnShowBFS.Location = new Point(520, 340);
            btnShowBFS.Margin = new Padding(3, 4, 3, 4);
            btnShowBFS.Name = "btnShowBFS";
            btnShowBFS.Size = new Size(86, 52);
            btnShowBFS.TabIndex = 41;
            btnShowBFS.Text = "Show BFS Algorithm";
            btnShowBFS.UseVisualStyleBackColor = true;
            btnShowBFS.Click += btnShowBFS_Click;
            // 
            // btnRemoveNode
            // 
            btnRemoveNode.Location = new Point(963, 42);
            btnRemoveNode.Margin = new Padding(3, 4, 3, 4);
            btnRemoveNode.Name = "btnRemoveNode";
            btnRemoveNode.Size = new Size(86, 31);
            btnRemoveNode.TabIndex = 40;
            btnRemoveNode.Text = "Remove";
            btnRemoveNode.UseVisualStyleBackColor = true;
            btnRemoveNode.Click += btnRemoveNode_Click;
            // 
            // txtStartNode
            // 
            txtStartNode.Location = new Point(622, 302);
            txtStartNode.Margin = new Padding(3, 4, 3, 4);
            txtStartNode.Name = "txtStartNode";
            txtStartNode.Size = new Size(118, 27);
            txtStartNode.TabIndex = 39;
            // 
            // btnShowDFS
            // 
            btnShowDFS.Location = new Point(614, 340);
            btnShowDFS.Margin = new Padding(3, 4, 3, 4);
            btnShowDFS.Name = "btnShowDFS";
            btnShowDFS.Size = new Size(86, 52);
            btnShowDFS.TabIndex = 38;
            btnShowDFS.Text = "Show DFS Algorithm";
            btnShowDFS.UseVisualStyleBackColor = true;
            btnShowDFS.Click += btnShowDFS_Click;
            // 
            // chkDirected
            // 
            chkDirected.AutoSize = true;
            chkDirected.Location = new Point(528, 263);
            chkDirected.Margin = new Padding(3, 4, 3, 4);
            chkDirected.Name = "chkDirected";
            chkDirected.Size = new Size(88, 24);
            chkDirected.TabIndex = 37;
            chkDirected.Text = "Directed";
            chkDirected.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(520, 207);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 36;
            label5.Text = "Weight:";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(612, 207);
            txtWeight.Margin = new Padding(3, 4, 3, 4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(118, 27);
            txtWeight.TabIndex = 35;
            // 
            // txtGraphRepresentation
            // 
            txtGraphRepresentation.Font = new Font("Yu Gothic Medium", 11F);
            txtGraphRepresentation.Location = new Point(857, 81);
            txtGraphRepresentation.Margin = new Padding(3, 4, 3, 4);
            txtGraphRepresentation.Multiline = true;
            txtGraphRepresentation.Name = "txtGraphRepresentation";
            txtGraphRepresentation.Size = new Size(413, 268);
            txtGraphRepresentation.TabIndex = 34;
            // 
            // btnRemoveEdge
            // 
            btnRemoveEdge.Location = new Point(755, 149);
            btnRemoveEdge.Margin = new Padding(3, 4, 3, 4);
            btnRemoveEdge.Name = "btnRemoveEdge";
            btnRemoveEdge.Size = new Size(86, 52);
            btnRemoveEdge.TabIndex = 33;
            btnRemoveEdge.Text = "Remove Edge";
            btnRemoveEdge.UseVisualStyleBackColor = true;
            btnRemoveEdge.Click += btnRemoveEdge_Click;
            // 
            // btnAddEdge
            // 
            btnAddEdge.Location = new Point(755, 98);
            btnAddEdge.Margin = new Padding(3, 4, 3, 4);
            btnAddEdge.Name = "btnAddEdge";
            btnAddEdge.Size = new Size(86, 31);
            btnAddEdge.TabIndex = 32;
            btnAddEdge.Text = "Add Edge";
            btnAddEdge.UseVisualStyleBackColor = true;
            btnAddEdge.Click += btnAddEdge_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(523, 149);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 31;
            label4.Text = "Node to:";
            // 
            // txtTo
            // 
            txtTo.Location = new Point(612, 149);
            txtTo.Margin = new Padding(3, 4, 3, 4);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(118, 27);
            txtTo.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 98);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 29;
            label3.Text = "Node From:";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(613, 98);
            txtFrom.Margin = new Padding(3, 4, 3, 4);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(118, 27);
            txtFrom.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(523, 48);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 27;
            label7.Text = "Node Name:";
            // 
            // txtNode
            // 
            txtNode.Location = new Point(614, 44);
            txtNode.Margin = new Padding(3, 4, 3, 4);
            txtNode.Name = "txtNode";
            txtNode.Size = new Size(205, 27);
            txtNode.TabIndex = 26;
            // 
            // btnAddNode
            // 
            btnAddNode.Location = new Point(857, 40);
            btnAddNode.Margin = new Padding(3, 4, 3, 4);
            btnAddNode.Name = "btnAddNode";
            btnAddNode.Size = new Size(86, 31);
            btnAddNode.TabIndex = 25;
            btnAddNode.Text = "Add Node";
            btnAddNode.UseVisualStyleBackColor = true;
            btnAddNode.Click += btnAddNode_Click;
            // 
            // Graphs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 450);
            Controls.Add(btnRemoveAll);
            Controls.Add(btnShowDFSRecursive);
            Controls.Add(label6);
            Controls.Add(btnShowBFS);
            Controls.Add(btnRemoveNode);
            Controls.Add(txtStartNode);
            Controls.Add(btnShowDFS);
            Controls.Add(chkDirected);
            Controls.Add(label5);
            Controls.Add(txtWeight);
            Controls.Add(txtGraphRepresentation);
            Controls.Add(btnRemoveEdge);
            Controls.Add(btnAddEdge);
            Controls.Add(label4);
            Controls.Add(txtTo);
            Controls.Add(label3);
            Controls.Add(txtFrom);
            Controls.Add(label7);
            Controls.Add(txtNode);
            Controls.Add(btnAddNode);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Graphs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Graphs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnBack;
        private Button btnRemoveAll;
        private Button btnShowDFSRecursive;
        private Label label6;
        private Button btnShowBFS;
        private Button btnRemoveNode;
        private TextBox txtStartNode;
        private Button btnShowDFS;
        private CheckBox chkDirected;
        private Label label5;
        private TextBox txtWeight;
        private TextBox txtGraphRepresentation;
        private Button btnRemoveEdge;
        private Button btnAddEdge;
        private Label label4;
        private TextBox txtTo;
        private Label label3;
        private TextBox txtFrom;
        private Label label7;
        private TextBox txtNode;
        private Button btnAddNode;
    }
}