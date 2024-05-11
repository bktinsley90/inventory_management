namespace Brittany_wguC968
{
    partial class modifyPartForm
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
            label8 = new Label();
            saveBtn = new Button();
            cancelBtn = new Button();
            IDtextBox = new TextBox();
            txtPartName = new TextBox();
            numInventory = new TextBox();
            numPrice = new TextBox();
            numMax = new TextBox();
            numMin = new TextBox();
            inHouseRadioBtn = new RadioButton();
            outSourcedRadioBtn = new RadioButton();
            numMachineID = new TextBox();
            txtCompanyName = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 7);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Modify Part";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 50);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 90);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 126);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 162);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 4;
            label5.Text = "Price / Costs";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(106, 206);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 5;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(243, 206);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 6;
            label7.Text = "Min";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(69, 252);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 7;
            label8.Text = "Machine ID";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(249, 314);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 8;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += savePartBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(337, 314);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += CancelBtn_Click;
            // 
            // IDtextBox
            // 
            IDtextBox.Enabled = false;
            IDtextBox.Location = new Point(148, 42);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new Size(100, 23);
            IDtextBox.TabIndex = 10;
            // 
            // txtPartName
            // 
            txtPartName.Location = new Point(148, 82);
            txtPartName.Name = "txtPartName";
            txtPartName.Size = new Size(100, 23);
            txtPartName.TabIndex = 11;
            txtPartName.TextChanged += Control_TxtChanged;
            // 
            // numInventory
            // 
            numInventory.Location = new Point(148, 118);
            numInventory.Name = "numInventory";
            numInventory.Size = new Size(100, 23);
            numInventory.TabIndex = 12;
            numInventory.TextChanged += Control_TxtChanged;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(148, 159);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(100, 23);
            numPrice.TabIndex = 13;
            numPrice.TextChanged += Control_TxtChanged;
            // 
            // numMax
            // 
            numMax.Location = new Point(148, 198);
            numMax.Name = "numMax";
            numMax.Size = new Size(76, 23);
            numMax.TabIndex = 14;
            numMax.TextChanged += Control_TxtChanged;
            // 
            // numMin
            // 
            numMin.Location = new Point(277, 198);
            numMin.Name = "numMin";
            numMin.Size = new Size(74, 23);
            numMin.TabIndex = 15;
            numMin.TextChanged += Control_TxtChanged;
            // 
            // inHouseRadioBtn
            // 
            inHouseRadioBtn.AutoSize = true;
            inHouseRadioBtn.Location = new Point(197, 10);
            inHouseRadioBtn.Name = "inHouseRadioBtn";
            inHouseRadioBtn.Size = new Size(74, 19);
            inHouseRadioBtn.TabIndex = 16;
            inHouseRadioBtn.TabStop = true;
            inHouseRadioBtn.Text = "In-House";
            inHouseRadioBtn.UseVisualStyleBackColor = true;
            inHouseRadioBtn.CheckedChanged += inHouseRadioBtn_CheckedChanged;
            // 
            // outSourcedRadioBtn
            // 
            outSourcedRadioBtn.AutoSize = true;
            outSourcedRadioBtn.Location = new Point(307, 12);
            outSourcedRadioBtn.Name = "outSourcedRadioBtn";
            outSourcedRadioBtn.Size = new Size(88, 19);
            outSourcedRadioBtn.TabIndex = 17;
            outSourcedRadioBtn.TabStop = true;
            outSourcedRadioBtn.Text = "OutSourced";
            outSourcedRadioBtn.UseVisualStyleBackColor = true;
            outSourcedRadioBtn.CheckedChanged += outSourcedRadioBtn_CheckedChanged;
            // 
            // numMachineID
            // 
            numMachineID.Location = new Point(171, 244);
            numMachineID.Name = "numMachineID";
            numMachineID.Size = new Size(100, 23);
            numMachineID.TabIndex = 18;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(171, 244);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(100, 23);
            txtCompanyName.TabIndex = 19;
            txtCompanyName.Visible = false;
            txtCompanyName.TextChanged += Control_TxtChanged;
            // 
            // modifyPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 383);
            Controls.Add(txtCompanyName);
            Controls.Add(numMachineID);
            Controls.Add(outSourcedRadioBtn);
            Controls.Add(inHouseRadioBtn);
            Controls.Add(numMin);
            Controls.Add(numMax);
            Controls.Add(numPrice);
            Controls.Add(numInventory);
            Controls.Add(txtPartName);
            Controls.Add(IDtextBox);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "modifyPartForm";
            Text = "modifyPartForm";
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
        private Label label8;
        private Button saveBtn;
        private Button cancelBtn;
        private TextBox IDtextBox;
        private TextBox txtPartName;
        private TextBox numInventory;
        private TextBox numPrice;
        private TextBox numMax;
        private TextBox numMin;
        private RadioButton inHouseRadioBtn;
        private RadioButton outSourcedRadioBtn;
        private TextBox numMachineID;
        private TextBox txtCompanyName;
        private ToolTip toolTip1;
    }
}