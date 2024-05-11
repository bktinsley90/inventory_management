namespace Brittany_wguC968
{
    partial class addProductForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            productIDtxtBox = new TextBox();
            productNameTxt = new TextBox();
            numInventory = new TextBox();
            numPrice = new TextBox();
            numMax = new TextBox();
            numMin = new TextBox();
            saveProductBtn = new Button();
            cancelProductBtn = new Button();
            deletePartsBtn = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            searchPartsBtn = new Button();
            addProductBtn = new Button();
            searchPartTextBox = new TextBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 84);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 128);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 168);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 206);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 245);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 5;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(163, 245);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 6;
            label7.Text = "Min";
            // 
            // productIDtxtBox
            // 
            productIDtxtBox.Enabled = false;
            productIDtxtBox.Location = new Point(91, 76);
            productIDtxtBox.Name = "productIDtxtBox";
            productIDtxtBox.Size = new Size(100, 23);
            productIDtxtBox.TabIndex = 7;
            // 
            // productNameTxt
            // 
            productNameTxt.Location = new Point(91, 120);
            productNameTxt.Name = "productNameTxt";
            productNameTxt.Size = new Size(100, 23);
            productNameTxt.TabIndex = 8;
            productNameTxt.TextChanged += Control_TxtChanged;
            // 
            // numInventory
            // 
            numInventory.Location = new Point(91, 160);
            numInventory.Name = "numInventory";
            numInventory.Size = new Size(100, 23);
            numInventory.TabIndex = 9;
            numInventory.TextChanged += Control_TxtChanged;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(91, 198);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(100, 23);
            numPrice.TabIndex = 10;
            numPrice.TextChanged += Control_TxtChanged;
            // 
            // numMax
            // 
            numMax.Location = new Point(91, 237);
            numMax.Name = "numMax";
            numMax.Size = new Size(46, 23);
            numMax.TabIndex = 11;
            numMax.TextChanged += Control_TxtChanged;
            // 
            // numMin
            // 
            numMin.Location = new Point(197, 237);
            numMin.Name = "numMin";
            numMin.Size = new Size(48, 23);
            numMin.TabIndex = 12;
            numMin.TextChanged += Control_TxtChanged;
            // 
            // saveProductBtn
            // 
            saveProductBtn.Location = new Point(597, 457);
            saveProductBtn.Name = "saveProductBtn";
            saveProductBtn.Size = new Size(75, 23);
            saveProductBtn.TabIndex = 13;
            saveProductBtn.Text = "Save";
            saveProductBtn.UseVisualStyleBackColor = true;
            saveProductBtn.Click += SaveProductBtn_Click;
            // 
            // cancelProductBtn
            // 
            cancelProductBtn.Location = new Point(688, 457);
            cancelProductBtn.Name = "cancelProductBtn";
            cancelProductBtn.Size = new Size(75, 23);
            cancelProductBtn.TabIndex = 14;
            cancelProductBtn.Text = "Cancel";
            cancelProductBtn.UseVisualStyleBackColor = true;
            cancelProductBtn.Click += CancelBtn_Click;
            // 
            // deletePartsBtn
            // 
            deletePartsBtn.Location = new Point(688, 418);
            deletePartsBtn.Name = "deletePartsBtn";
            deletePartsBtn.Size = new Size(75, 23);
            deletePartsBtn.TabIndex = 15;
            deletePartsBtn.Text = "Delete";
            deletePartsBtn.UseVisualStyleBackColor = true;
            deletePartsBtn.Click += DeleteAssociatedPart_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(371, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(392, 150);
            dataGridView1.TabIndex = 16;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(371, 262);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(392, 150);
            dataGridView2.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(369, 237);
            label8.Name = "label8";
            label8.Size = new Size(190, 15);
            label8.TabIndex = 18;
            label8.Text = "Parts Associated With This Product";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(369, 26);
            label9.Name = "label9";
            label9.Size = new Size(107, 15);
            label9.TabIndex = 19;
            label9.Text = "All Candidate Parts";
            // 
            // searchPartsBtn
            // 
            searchPartsBtn.Location = new Point(573, 13);
            searchPartsBtn.Name = "searchPartsBtn";
            searchPartsBtn.Size = new Size(75, 23);
            searchPartsBtn.TabIndex = 20;
            searchPartsBtn.Text = "Search";
            searchPartsBtn.UseVisualStyleBackColor = true;
            searchPartsBtn.Click += SearchPartBtn_Click;
            // 
            // addProductBtn
            // 
            addProductBtn.Location = new Point(688, 206);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(75, 23);
            addProductBtn.TabIndex = 21;
            addProductBtn.Text = "Add";
            addProductBtn.UseVisualStyleBackColor = true;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // searchPartTextBox
            // 
            searchPartTextBox.Location = new Point(663, 14);
            searchPartTextBox.Name = "searchPartTextBox";
            searchPartTextBox.Size = new Size(100, 23);
            searchPartTextBox.TabIndex = 22;
            // 
            // addProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(searchPartTextBox);
            Controls.Add(addProductBtn);
            Controls.Add(searchPartsBtn);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(deletePartsBtn);
            Controls.Add(cancelProductBtn);
            Controls.Add(saveProductBtn);
            Controls.Add(numMin);
            Controls.Add(numMax);
            Controls.Add(numPrice);
            Controls.Add(numInventory);
            Controls.Add(productNameTxt);
            Controls.Add(productIDtxtBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "addProductForm";
            Text = "addProductForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox productIDtxtBox;
        private TextBox productNameTxt;
        private TextBox numInventory;
        private TextBox numPrice;
        private TextBox numMax;
        private TextBox numMin;
        private Button saveProductBtn;
        private Button cancelProductBtn;
        private Button deletePartsBtn;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label8;
        private Label label9;
        private Button searchPartsBtn;
        private Button addProductBtn;
        private TextBox searchPartTextBox;
        private ToolTip toolTip1;
    }
}