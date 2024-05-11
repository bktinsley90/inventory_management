namespace Brittany_wguC968
{
    partial class AddPartForm
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
            imageList1 = new ImageList(components);
            label3 = new Label();
            IDtextBox = new TextBox();
            txtPartName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            numInventory = new TextBox();
            numPrice = new TextBox();
            label6 = new Label();
            numMax = new TextBox();
            label7 = new Label();
            numMin = new TextBox();
            cancelBtn = new Button();
            saveBtn = new Button();
            inHouseRadioBtn = new RadioButton();
            outSourcedRadioBtn = new RadioButton();
            numMachineID = new TextBox();
            label8 = new Label();
            txtCompanyName = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 13);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Add Part";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 83);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 116);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // IDtextBox
            // 
            IDtextBox.Enabled = false;
            IDtextBox.Location = new Point(139, 75);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new Size(100, 23);
            IDtextBox.TabIndex = 3;
            // 
            // txtPartName
            // 
            txtPartName.Location = new Point(139, 108);
            txtPartName.Name = "txtPartName";
            txtPartName.Size = new Size(100, 23);
            txtPartName.TabIndex = 4;
            txtPartName.TextChanged += Control_TxtChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 157);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 196);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 6;
            label5.Text = "Price / Costs";
            // 
            // numInventory
            // 
            numInventory.Location = new Point(139, 149);
            numInventory.Name = "numInventory";
            numInventory.Size = new Size(100, 23);
            numInventory.TabIndex = 7;
            numInventory.TextChanged += Control_TxtChanged;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(139, 188);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(100, 23);
            numPrice.TabIndex = 8;
            numPrice.TextChanged += Control_TxtChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 254);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 9;
            label6.Text = "Max";
            // 
            // numMax
            // 
            numMax.Location = new Point(139, 246);
            numMax.Name = "numMax";
            numMax.Size = new Size(62, 23);
            numMax.TabIndex = 10;
            numMax.TextChanged += Control_TxtChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(231, 249);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 11;
            label7.Text = "Min";
            // 
            // numMin
            // 
            numMin.Location = new Point(265, 246);
            numMin.Name = "numMin";
            numMin.Size = new Size(66, 23);
            numMin.TabIndex = 12;
            numMin.TextChanged += Control_TxtChanged;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(288, 336);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 13;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += CancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(207, 334);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 25);
            saveBtn.TabIndex = 14;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += btnSave_Click;
            // 
            // inHouseRadioBtn
            // 
            inHouseRadioBtn.AutoSize = true;
            inHouseRadioBtn.Location = new Point(139, 12);
            inHouseRadioBtn.Name = "inHouseRadioBtn";
            inHouseRadioBtn.Size = new Size(74, 19);
            inHouseRadioBtn.TabIndex = 15;
            inHouseRadioBtn.TabStop = true;
            inHouseRadioBtn.Text = "In-House";
            inHouseRadioBtn.UseVisualStyleBackColor = true;
            inHouseRadioBtn.CheckedChanged += inHouseRadioBtn_CheckedChanged;
            // 
            // outSourcedRadioBtn
            // 
            outSourcedRadioBtn.AutoSize = true;
            outSourcedRadioBtn.Location = new Point(249, 12);
            outSourcedRadioBtn.Name = "outSourcedRadioBtn";
            outSourcedRadioBtn.Size = new Size(87, 19);
            outSourcedRadioBtn.TabIndex = 16;
            outSourcedRadioBtn.TabStop = true;
            outSourcedRadioBtn.Text = "Outsourced";
            outSourcedRadioBtn.UseVisualStyleBackColor = true;
            outSourcedRadioBtn.CheckedChanged += outSourcedRadioBtn_CheckedChanged;
            // 
            // numMachineID
            // 
            numMachineID.Location = new Point(159, 292);
            numMachineID.Name = "numMachineID";
            numMachineID.Size = new Size(100, 23);
            numMachineID.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 295);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 18;
            label8.Text = "Machine ID";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(159, 292);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(100, 23);
            txtCompanyName.TabIndex = 19;
            txtCompanyName.Visible = false;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // AddPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 360);
            Controls.Add(txtCompanyName);
            Controls.Add(label8);
            Controls.Add(numMachineID);
            Controls.Add(outSourcedRadioBtn);
            Controls.Add(inHouseRadioBtn);
            Controls.Add(saveBtn);
            Controls.Add(cancelBtn);
            Controls.Add(numMin);
            Controls.Add(label7);
            Controls.Add(numMax);
            Controls.Add(label6);
            Controls.Add(numPrice);
            Controls.Add(numInventory);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPartName);
            Controls.Add(IDtextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddPartForm";
            Text = "addPartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ImageList imageList1;
        private Label label3;
        private TextBox IDtextBox;
        private TextBox txtPartName;
        private Label label4;
        private Label label5;
        private TextBox numInventory;
        private TextBox numPrice;
        private Label label6;
        private TextBox numMax;
        private Label label7;
        private TextBox numMin;
        private Button cancelBtn;
        private Button saveBtn;
        private RadioButton inHouseRadioBtn;
        private RadioButton outSourcedRadioBtn;
        private TextBox numMachineID;
        private Label label8;
        private TextBox txtCompanyName;
        private ToolTip toolTip1;
    }
}