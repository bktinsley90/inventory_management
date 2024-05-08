namespace Brittany_wguC968
{
    partial class Main
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
            label1 = new Label();
            searchPartTextBox = new TextBox();
            label2 = new Label();
            searchPartBtn = new Button();
            dataGridView1 = new DataGridView();
            addPartBtn = new Button();
            modPartBtn = new Button();
            deletePartBtn = new Button();
            searchProd = new Button();
            searchProdTextBox = new TextBox();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            addProdBtn = new Button();
            modProdBtn = new Button();
            deleteProdBtn = new Button();
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(271, 25);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management System";
            // 
            // searchPartTextBox
            // 
            searchPartTextBox.Location = new Point(374, 80);
            searchPartTextBox.Name = "searchPartTextBox";
            searchPartTextBox.Size = new Size(100, 23);
            searchPartTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 2;
            label2.Text = "Parts\r\n";
            // 
            // searchPartBtn
            // 
            searchPartBtn.Location = new Point(293, 80);
            searchPartBtn.Name = "searchPartBtn";
            searchPartBtn.Size = new Size(75, 23);
            searchPartBtn.TabIndex = 3;
            searchPartBtn.Text = "Search";
            searchPartBtn.UseVisualStyleBackColor = true;
            searchPartBtn.Click += SearchPartBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(462, 215);
            dataGridView1.TabIndex = 4;
            // 
            // addPartBtn
            // 
            addPartBtn.Location = new Point(237, 351);
            addPartBtn.Name = "addPartBtn";
            addPartBtn.Size = new Size(75, 23);
            addPartBtn.TabIndex = 5;
            addPartBtn.Text = "Add";
            addPartBtn.UseVisualStyleBackColor = true;
            addPartBtn.Click += AddPartBtn_Click;
            // 
            // modPartBtn
            // 
            modPartBtn.Location = new Point(318, 351);
            modPartBtn.Name = "modPartBtn";
            modPartBtn.Size = new Size(75, 23);
            modPartBtn.TabIndex = 6;
            modPartBtn.Text = "Modify";
            modPartBtn.UseVisualStyleBackColor = true;
            modPartBtn.Click += ModPartBtn_Click;
            // 
            // deletePartBtn
            // 
            deletePartBtn.Location = new Point(399, 351);
            deletePartBtn.Name = "deletePartBtn";
            deletePartBtn.Size = new Size(75, 23);
            deletePartBtn.TabIndex = 7;
            deletePartBtn.Text = "Delete";
            deletePartBtn.UseVisualStyleBackColor = true;
            deletePartBtn.Click += DeletePartBtn_CLick;
            // 
            // searchProd
            // 
            searchProd.Location = new Point(833, 79);
            searchProd.Name = "searchProd";
            searchProd.Size = new Size(75, 23);
            searchProd.TabIndex = 8;
            searchProd.Text = "Search";
            searchProd.UseVisualStyleBackColor = true;
            searchProd.Click += SearchProductBtn_Click;
            // 
            // searchProdTextBox
            // 
            searchProdTextBox.Location = new Point(914, 79);
            searchProdTextBox.Name = "searchProdTextBox";
            searchProdTextBox.Size = new Size(100, 23);
            searchProdTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(555, 81);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 10;
            label3.Text = "Products";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(555, 109);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(459, 215);
            dataGridView2.TabIndex = 11;
            // 
            // addProdBtn
            // 
            addProdBtn.Location = new Point(777, 351);
            addProdBtn.Name = "addProdBtn";
            addProdBtn.Size = new Size(75, 23);
            addProdBtn.TabIndex = 12;
            addProdBtn.Text = "Add";
            addProdBtn.UseVisualStyleBackColor = true;
            addProdBtn.Click += AddProdBtn_CLick;
            // 
            // modProdBtn
            // 
            modProdBtn.Location = new Point(858, 351);
            modProdBtn.Name = "modProdBtn";
            modProdBtn.Size = new Size(75, 23);
            modProdBtn.TabIndex = 13;
            modProdBtn.Text = "Modify";
            modProdBtn.UseVisualStyleBackColor = true;
            modProdBtn.Click += ModProdBtn_Click;
            // 
            // deleteProdBtn
            // 
            deleteProdBtn.Location = new Point(939, 351);
            deleteProdBtn.Name = "deleteProdBtn";
            deleteProdBtn.Size = new Size(75, 23);
            deleteProdBtn.TabIndex = 14;
            deleteProdBtn.Text = "Delete";
            deleteProdBtn.UseVisualStyleBackColor = true;
            deleteProdBtn.Click += DeleteProdBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(939, 419);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 23);
            exitBtn.TabIndex = 15;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 498);
            Controls.Add(exitBtn);
            Controls.Add(deleteProdBtn);
            Controls.Add(modProdBtn);
            Controls.Add(addProdBtn);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(searchProdTextBox);
            Controls.Add(searchProd);
            Controls.Add(deletePartBtn);
            Controls.Add(modPartBtn);
            Controls.Add(addPartBtn);
            Controls.Add(dataGridView1);
            Controls.Add(searchPartBtn);
            Controls.Add(label2);
            Controls.Add(searchPartTextBox);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox searchPartTextBox;
        private Label label2;
        private Button searchPartBtn;
        private DataGridView dataGridView1;
        private Button addPartBtn;
        private Button modPartBtn;
        private Button deletePartBtn;
        private Button searchProd;
        private TextBox searchProdTextBox;
        private Label label3;
        private DataGridView dataGridView2;
        private Button addProdBtn;
        private Button modProdBtn;
        private Button deleteProdBtn;
        private Button exitBtn;
    }
}
