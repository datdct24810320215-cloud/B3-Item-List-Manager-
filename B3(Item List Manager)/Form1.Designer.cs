namespace B3_Item_List_Manager_
{
    partial class Form1
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
            groupLeft = new GroupBox();
            btnClearAll = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtPrice = new TextBox();
            cmbUnit = new ComboBox();
            txtName = new TextBox();
            txtCode = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupRight = new GroupBox();
            lvItems = new ListView();
            groupLeft.SuspendLayout();
            groupRight.SuspendLayout();
            SuspendLayout();
            // 
            // groupLeft
            // 
            groupLeft.Controls.Add(btnClearAll);
            groupLeft.Controls.Add(btnDelete);
            groupLeft.Controls.Add(btnUpdate);
            groupLeft.Controls.Add(btnAdd);
            groupLeft.Controls.Add(txtPrice);
            groupLeft.Controls.Add(cmbUnit);
            groupLeft.Controls.Add(txtName);
            groupLeft.Controls.Add(txtCode);
            groupLeft.Controls.Add(label4);
            groupLeft.Controls.Add(label3);
            groupLeft.Controls.Add(label2);
            groupLeft.Controls.Add(label1);
            groupLeft.Location = new Point(12, 12);
            groupLeft.Name = "groupLeft";
            groupLeft.Size = new Size(360, 426);
            groupLeft.TabIndex = 0;
            groupLeft.TabStop = false;
            groupLeft.Text = "Thông tin";
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(286, 200);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(75, 30);
            btnClearAll.TabIndex = 8;
            btnClearAll.Text = "Xóa toàn bộ";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += BtnClearAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(196, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 30);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa dòng";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(106, 200);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 30);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(16, 200);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 30);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(112, 149);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(224, 23);
            txtPrice.TabIndex = 4;
            // 
            // cmbUnit
            // 
            cmbUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnit.Location = new Point(112, 109);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(224, 23);
            cmbUnit.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(224, 23);
            txtName.TabIndex = 2;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(112, 29);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(224, 23);
            txtCode.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 152);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 0;
            label4.Text = "Đơn giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 112);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 0;
            label3.Text = "Đơn vị tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 72);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "Tên vật tư";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã vật tư";
            // 
            // groupRight
            // 
            groupRight.Controls.Add(lvItems);
            groupRight.Location = new Point(388, 12);
            groupRight.Name = "groupRight";
            groupRight.Size = new Size(400, 426);
            groupRight.TabIndex = 1;
            groupRight.TabStop = false;
            groupRight.Text = "Danh sách";
            // 
            // lvItems
            // 
            lvItems.FullRowSelect = true;
            lvItems.Location = new Point(16, 24);
            lvItems.Name = "lvItems";
            lvItems.Size = new Size(368, 392);
            lvItems.TabIndex = 0;
            lvItems.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupRight);
            Controls.Add(groupLeft);
            Name = "Form1";
            Text = "Quản lý Vật tư / Linh kiện";
            groupLeft.ResumeLayout(false);
            groupLeft.PerformLayout();
            groupRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupLeft;
        private System.Windows.Forms.GroupBox groupRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ListView lvItems;
    }
}
