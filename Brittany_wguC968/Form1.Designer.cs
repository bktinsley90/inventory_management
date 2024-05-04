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
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            addPartBtn = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(374, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
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
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(293, 80);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
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
            // 
            // button3
            // 
            button3.Location = new Point(318, 351);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Modify";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(399, 351);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(833, 79);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 8;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(914, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
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
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(555, 109);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(459, 215);
            dataGridView2.TabIndex = 11;
            // 
            // button6
            // 
            button6.Location = new Point(777, 351);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 12;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(858, 351);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 13;
            button7.Text = "Modify";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(939, 351);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 14;
            button8.Text = "Delete";
            button8.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(939, 419);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 23);
            exitBtn.TabIndex = 15;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 498);
            Controls.Add(exitBtn);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(addPartBtn);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button addPartBtn;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox2;
        private Label label3;
        private DataGridView dataGridView2;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button exitBtn;
    }
}
