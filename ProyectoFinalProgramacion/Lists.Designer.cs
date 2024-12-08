namespace ProyectoFinalProgramacion
{
    partial class Lists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lists));
            label1 = new Label();
            label2 = new Label();
            btnBack = new Button();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            txtZipCode = new TextBox();
            label4 = new Label();
            btnCountSingleList = new Button();
            txtPhoneNumber = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label5 = new Label();
            btnRemoveSingleList = new Button();
            btnContainsSingleList = new Button();
            btnAddSingleList = new Button();
            txtValue = new TextBox();
            label6 = new Label();
            tabPage2 = new TabPage();
            btnContainsCircularsLists = new Button();
            lstNodes = new ListBox();
            btnCountCircularsLists = new Button();
            lblValue = new Label();
            btnRemoveCircularsLists = new Button();
            txtValueCircularList = new TextBox();
            btnAddCircularsLists = new Button();
            tabPage3 = new TabPage();
            btnSearchDoubleList = new Button();
            lblData = new Label();
            btnDeleteDoubleList = new Button();
            txtDataDoubleList = new TextBox();
            btnAggDoubleList = new Button();
            lvDisplayDoubleList = new ListView();
            tabPage4 = new TabPage();
            btnContainsDoubleCircularList = new Button();
            btnRemoveDoubleCircularList = new Button();
            btnAddDoubleCircularList = new Button();
            txtNumberDoubleCircularList = new TextBox();
            label7 = new Label();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(503, 180);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(90, 46);
            label2.TabIndex = 1;
            label2.Text = "Lists";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(172, 300);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Location = new Point(572, 20);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(821, 405);
            tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtZipCode);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(btnCountSingleList);
            tabPage1.Controls.Add(txtPhoneNumber);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(btnRemoveSingleList);
            tabPage1.Controls.Add(btnContainsSingleList);
            tabPage1.Controls.Add(btnAddSingleList);
            tabPage1.Controls.Add(txtValue);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(813, 372);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Singles";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtZipCode
            // 
            txtZipCode.Font = new Font("Segoe UI", 20F);
            txtZipCode.Location = new Point(253, 256);
            txtZipCode.Margin = new Padding(3, 4, 3, 4);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(242, 52);
            txtZipCode.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(88, 260);
            label4.Name = "label4";
            label4.Size = new Size(155, 46);
            label4.TabIndex = 23;
            label4.Text = "Zip Code";
            // 
            // btnCountSingleList
            // 
            btnCountSingleList.Font = new Font("Segoe UI", 20F);
            btnCountSingleList.Location = new Point(543, 256);
            btnCountSingleList.Margin = new Padding(3, 4, 3, 4);
            btnCountSingleList.Name = "btnCountSingleList";
            btnCountSingleList.Size = new Size(182, 57);
            btnCountSingleList.TabIndex = 22;
            btnCountSingleList.Text = "Count";
            btnCountSingleList.UseVisualStyleBackColor = true;
            btnCountSingleList.Click += btnCountSingleList_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 20F);
            txtPhoneNumber.Location = new Point(253, 191);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(242, 52);
            txtPhoneNumber.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(126, 191);
            label3.Name = "label3";
            label3.Size = new Size(115, 46);
            label3.TabIndex = 20;
            label3.Text = "Phone";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 20F);
            txtName.Location = new Point(253, 125);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 52);
            txtName.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(126, 125);
            label5.Name = "label5";
            label5.Size = new Size(109, 46);
            label5.TabIndex = 18;
            label5.Text = "Name";
            // 
            // btnRemoveSingleList
            // 
            btnRemoveSingleList.Font = new Font("Segoe UI", 20F);
            btnRemoveSingleList.Location = new Point(543, 191);
            btnRemoveSingleList.Margin = new Padding(3, 4, 3, 4);
            btnRemoveSingleList.Name = "btnRemoveSingleList";
            btnRemoveSingleList.Size = new Size(182, 57);
            btnRemoveSingleList.TabIndex = 17;
            btnRemoveSingleList.Text = "Remove";
            btnRemoveSingleList.UseVisualStyleBackColor = true;
            btnRemoveSingleList.Click += btnRemoveSingleList_Click;
            // 
            // btnContainsSingleList
            // 
            btnContainsSingleList.Font = new Font("Segoe UI", 20F);
            btnContainsSingleList.Location = new Point(543, 125);
            btnContainsSingleList.Margin = new Padding(3, 4, 3, 4);
            btnContainsSingleList.Name = "btnContainsSingleList";
            btnContainsSingleList.Size = new Size(182, 57);
            btnContainsSingleList.TabIndex = 16;
            btnContainsSingleList.Text = "Contains";
            btnContainsSingleList.UseVisualStyleBackColor = true;
            btnContainsSingleList.Click += btnContainsSingleList_Click;
            // 
            // btnAddSingleList
            // 
            btnAddSingleList.Font = new Font("Segoe UI", 20F);
            btnAddSingleList.Location = new Point(543, 60);
            btnAddSingleList.Margin = new Padding(3, 4, 3, 4);
            btnAddSingleList.Name = "btnAddSingleList";
            btnAddSingleList.Size = new Size(182, 57);
            btnAddSingleList.TabIndex = 15;
            btnAddSingleList.Text = "Add";
            btnAddSingleList.UseVisualStyleBackColor = true;
            btnAddSingleList.Click += btnAddSingleList_Click;
            // 
            // txtValue
            // 
            txtValue.Font = new Font("Segoe UI", 20F);
            txtValue.Location = new Point(253, 60);
            txtValue.Margin = new Padding(3, 4, 3, 4);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(242, 52);
            txtValue.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(126, 60);
            label6.Name = "label6";
            label6.Size = new Size(101, 46);
            label6.TabIndex = 13;
            label6.Text = "Value";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnContainsCircularsLists);
            tabPage2.Controls.Add(lstNodes);
            tabPage2.Controls.Add(btnCountCircularsLists);
            tabPage2.Controls.Add(lblValue);
            tabPage2.Controls.Add(btnRemoveCircularsLists);
            tabPage2.Controls.Add(txtValueCircularList);
            tabPage2.Controls.Add(btnAddCircularsLists);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(813, 372);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Circulars";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnContainsCircularsLists
            // 
            btnContainsCircularsLists.BackColor = Color.FromArgb(255, 192, 192);
            btnContainsCircularsLists.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnContainsCircularsLists.ForeColor = Color.FromArgb(255, 128, 128);
            btnContainsCircularsLists.Location = new Point(332, 169);
            btnContainsCircularsLists.Name = "btnContainsCircularsLists";
            btnContainsCircularsLists.Size = new Size(115, 56);
            btnContainsCircularsLists.TabIndex = 17;
            btnContainsCircularsLists.Text = "Contains";
            btnContainsCircularsLists.UseVisualStyleBackColor = false;
            btnContainsCircularsLists.Click += btnContainsCircularsLists_Click;
            // 
            // lstNodes
            // 
            lstNodes.BackColor = Color.FromArgb(255, 192, 192);
            lstNodes.Font = new Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstNodes.ForeColor = Color.FromArgb(255, 128, 128);
            lstNodes.FormattingEnabled = true;
            lstNodes.ItemHeight = 39;
            lstNodes.Location = new Point(453, 30);
            lstNodes.Name = "lstNodes";
            lstNodes.Size = new Size(235, 277);
            lstNodes.TabIndex = 13;
            // 
            // btnCountCircularsLists
            // 
            btnCountCircularsLists.BackColor = Color.FromArgb(255, 192, 192);
            btnCountCircularsLists.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCountCircularsLists.ForeColor = Color.FromArgb(255, 128, 128);
            btnCountCircularsLists.Location = new Point(332, 234);
            btnCountCircularsLists.Name = "btnCountCircularsLists";
            btnCountCircularsLists.Size = new Size(115, 56);
            btnCountCircularsLists.TabIndex = 16;
            btnCountCircularsLists.Text = "Count";
            btnCountCircularsLists.UseVisualStyleBackColor = false;
            btnCountCircularsLists.Click += btnCountCircularsLists_Click;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Font = new Font("Bernard MT Condensed", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblValue.ForeColor = Color.FromArgb(255, 128, 128);
            lblValue.Location = new Point(79, 28);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(94, 40);
            lblValue.TabIndex = 11;
            lblValue.Text = "Value";
            // 
            // btnRemoveCircularsLists
            // 
            btnRemoveCircularsLists.BackColor = Color.FromArgb(255, 192, 192);
            btnRemoveCircularsLists.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRemoveCircularsLists.ForeColor = Color.FromArgb(255, 128, 128);
            btnRemoveCircularsLists.Location = new Point(332, 107);
            btnRemoveCircularsLists.Name = "btnRemoveCircularsLists";
            btnRemoveCircularsLists.Size = new Size(115, 56);
            btnRemoveCircularsLists.TabIndex = 15;
            btnRemoveCircularsLists.Text = "Remove";
            btnRemoveCircularsLists.UseVisualStyleBackColor = false;
            btnRemoveCircularsLists.Click += btnRemoveCircularsLists_Click;
            // 
            // txtValueCircularList
            // 
            txtValueCircularList.BackColor = Color.FromArgb(255, 192, 192);
            txtValueCircularList.Font = new Font("Agency FB", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtValueCircularList.ForeColor = Color.FromArgb(255, 128, 128);
            txtValueCircularList.Location = new Point(179, 30);
            txtValueCircularList.Multiline = true;
            txtValueCircularList.Name = "txtValueCircularList";
            txtValueCircularList.Size = new Size(143, 38);
            txtValueCircularList.TabIndex = 12;
            // 
            // btnAddCircularsLists
            // 
            btnAddCircularsLists.BackColor = Color.FromArgb(255, 192, 192);
            btnAddCircularsLists.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCircularsLists.ForeColor = Color.FromArgb(255, 128, 128);
            btnAddCircularsLists.Location = new Point(332, 40);
            btnAddCircularsLists.Name = "btnAddCircularsLists";
            btnAddCircularsLists.Size = new Size(115, 56);
            btnAddCircularsLists.TabIndex = 14;
            btnAddCircularsLists.Text = "Add";
            btnAddCircularsLists.UseVisualStyleBackColor = false;
            btnAddCircularsLists.Click += btnAddCircularsLists_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnSearchDoubleList);
            tabPage3.Controls.Add(lblData);
            tabPage3.Controls.Add(btnDeleteDoubleList);
            tabPage3.Controls.Add(txtDataDoubleList);
            tabPage3.Controls.Add(btnAggDoubleList);
            tabPage3.Controls.Add(lvDisplayDoubleList);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(813, 372);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Doubles";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSearchDoubleList
            // 
            btnSearchDoubleList.Location = new Point(494, 260);
            btnSearchDoubleList.Name = "btnSearchDoubleList";
            btnSearchDoubleList.Size = new Size(94, 29);
            btnSearchDoubleList.TabIndex = 21;
            btnSearchDoubleList.Text = "Search";
            btnSearchDoubleList.UseVisualStyleBackColor = true;
            btnSearchDoubleList.Click += btnSearchDoubleList_Click;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.Location = new Point(494, 93);
            lblData.Name = "lblData";
            lblData.Size = new Size(79, 38);
            lblData.TabIndex = 17;
            lblData.Text = "Data";
            // 
            // btnDeleteDoubleList
            // 
            btnDeleteDoubleList.Location = new Point(494, 225);
            btnDeleteDoubleList.Name = "btnDeleteDoubleList";
            btnDeleteDoubleList.Size = new Size(94, 29);
            btnDeleteDoubleList.TabIndex = 20;
            btnDeleteDoubleList.Text = "Delete";
            btnDeleteDoubleList.UseVisualStyleBackColor = true;
            btnDeleteDoubleList.Click += btnDeleteDoubleList_Click;
            // 
            // txtDataDoubleList
            // 
            txtDataDoubleList.Location = new Point(494, 146);
            txtDataDoubleList.Name = "txtDataDoubleList";
            txtDataDoubleList.Size = new Size(125, 27);
            txtDataDoubleList.TabIndex = 16;
            // 
            // btnAggDoubleList
            // 
            btnAggDoubleList.Location = new Point(494, 190);
            btnAggDoubleList.Name = "btnAggDoubleList";
            btnAggDoubleList.Size = new Size(94, 29);
            btnAggDoubleList.TabIndex = 19;
            btnAggDoubleList.Text = "Agg";
            btnAggDoubleList.UseVisualStyleBackColor = true;
            btnAggDoubleList.Click += btnAggDoubleList_Click;
            // 
            // lvDisplayDoubleList
            // 
            lvDisplayDoubleList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvDisplayDoubleList.Location = new Point(223, 83);
            lvDisplayDoubleList.Name = "lvDisplayDoubleList";
            lvDisplayDoubleList.Size = new Size(220, 213);
            lvDisplayDoubleList.TabIndex = 18;
            lvDisplayDoubleList.UseCompatibleStateImageBehavior = false;
            lvDisplayDoubleList.View = View.Details;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnContainsDoubleCircularList);
            tabPage4.Controls.Add(btnRemoveDoubleCircularList);
            tabPage4.Controls.Add(btnAddDoubleCircularList);
            tabPage4.Controls.Add(txtNumberDoubleCircularList);
            tabPage4.Controls.Add(label7);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(813, 372);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Double Circulars";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnContainsDoubleCircularList
            // 
            btnContainsDoubleCircularList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContainsDoubleCircularList.Location = new Point(554, 219);
            btnContainsDoubleCircularList.Margin = new Padding(3, 4, 3, 4);
            btnContainsDoubleCircularList.Name = "btnContainsDoubleCircularList";
            btnContainsDoubleCircularList.Size = new Size(111, 49);
            btnContainsDoubleCircularList.TabIndex = 9;
            btnContainsDoubleCircularList.Text = "Contains";
            btnContainsDoubleCircularList.UseVisualStyleBackColor = true;
            btnContainsDoubleCircularList.Click += btnContainsDoubleCircularList_Click;
            // 
            // btnRemoveDoubleCircularList
            // 
            btnRemoveDoubleCircularList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveDoubleCircularList.Location = new Point(554, 162);
            btnRemoveDoubleCircularList.Margin = new Padding(3, 4, 3, 4);
            btnRemoveDoubleCircularList.Name = "btnRemoveDoubleCircularList";
            btnRemoveDoubleCircularList.Size = new Size(111, 49);
            btnRemoveDoubleCircularList.TabIndex = 8;
            btnRemoveDoubleCircularList.Text = "Remove";
            btnRemoveDoubleCircularList.UseVisualStyleBackColor = true;
            btnRemoveDoubleCircularList.Click += btnRemoveDoubleCircularList_Click;
            // 
            // btnAddDoubleCircularList
            // 
            btnAddDoubleCircularList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddDoubleCircularList.Location = new Point(554, 104);
            btnAddDoubleCircularList.Margin = new Padding(3, 4, 3, 4);
            btnAddDoubleCircularList.Name = "btnAddDoubleCircularList";
            btnAddDoubleCircularList.Size = new Size(111, 49);
            btnAddDoubleCircularList.TabIndex = 7;
            btnAddDoubleCircularList.Text = "Add";
            btnAddDoubleCircularList.UseVisualStyleBackColor = true;
            btnAddDoubleCircularList.Click += btnAddDoubleCircularList_Click;
            // 
            // txtNumberDoubleCircularList
            // 
            txtNumberDoubleCircularList.Location = new Point(236, 138);
            txtNumberDoubleCircularList.Margin = new Padding(3, 4, 3, 4);
            txtNumberDoubleCircularList.Name = "txtNumberDoubleCircularList";
            txtNumberDoubleCircularList.Size = new Size(227, 27);
            txtNumberDoubleCircularList.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(148, 140);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 5;
            label7.Text = "Number:";
            // 
            // Lists
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1614, 450);
            Controls.Add(tabControl);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lists";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lists";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnBack;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox txtZipCode;
        private Label label4;
        private Button btnCountSingleList;
        private TextBox txtPhoneNumber;
        private Label label3;
        private TextBox txtName;
        private Label label5;
        private Button btnRemoveSingleList;
        private Button btnContainsSingleList;
        private Button btnAddSingleList;
        private TextBox txtValue;
        private Label label6;
        private Button btnContainsCircularsLists;
        private ListBox lstNodes;
        private Button btnCountCircularsLists;
        private Label lblValue;
        private Button btnRemoveCircularsLists;
        private TextBox txtValueCircularList;
        private Button btnAddCircularsLists;
        private Button btnSearchDoubleList;
        private Label lblData;
        private Button btnDeleteDoubleList;
        private TextBox txtDataDoubleList;
        private Button btnAggDoubleList;
        private ListView lvDisplayDoubleList;
        private Button btnContainsDoubleCircularList;
        private Button btnRemoveDoubleCircularList;
        private Button btnAddDoubleCircularList;
        private TextBox txtNumberDoubleCircularList;
        private Label label7;
    }
}