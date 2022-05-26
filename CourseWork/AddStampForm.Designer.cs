namespace CourseWork
{
    partial class AddStampForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStampForm));
            this.СreateStampBtn = new System.Windows.Forms.Button();
            this.ExpirationDateLabel = new System.Windows.Forms.Label();
            this.ExpirationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ChooseDocumentListLabel = new System.Windows.Forms.Label();
            this.ChooseDocumentLabel = new System.Windows.Forms.Label();
            this.ChooseDocumentListComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseDocumentComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // СreateStampBtn
            // 
            this.СreateStampBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.СreateStampBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.СreateStampBtn.Location = new System.Drawing.Point(146, 191);
            this.СreateStampBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.СreateStampBtn.Name = "СreateStampBtn";
            this.СreateStampBtn.Size = new System.Drawing.Size(353, 55);
            this.СreateStampBtn.TabIndex = 0;
            this.СreateStampBtn.Text = "Створити унікальну відмітку";
            this.СreateStampBtn.UseVisualStyleBackColor = true;
            this.СreateStampBtn.Click += new System.EventHandler(this.СreateStampBtn_Click);
            // 
            // ExpirationDateLabel
            // 
            this.ExpirationDateLabel.AutoSize = true;
            this.ExpirationDateLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDateLabel.Location = new System.Drawing.Point(20, 36);
            this.ExpirationDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ExpirationDateLabel.Name = "ExpirationDateLabel";
            this.ExpirationDateLabel.Size = new System.Drawing.Size(378, 27);
            this.ExpirationDateLabel.TabIndex = 1;
            this.ExpirationDateLabel.Text = "Вкажіть кінцевий термін дії відмітки:";
            // 
            // ExpirationDateTimePicker
            // 
            this.ExpirationDateTimePicker.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpirationDateTimePicker.Location = new System.Drawing.Point(408, 36);
            this.ExpirationDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ExpirationDateTimePicker.MinDate = new System.DateTime(2022, 7, 1, 0, 0, 0, 0);
            this.ExpirationDateTimePicker.Name = "ExpirationDateTimePicker";
            this.ExpirationDateTimePicker.Size = new System.Drawing.Size(217, 34);
            this.ExpirationDateTimePicker.TabIndex = 2;
            this.ExpirationDateTimePicker.Value = new System.DateTime(2022, 7, 1, 0, 0, 0, 0);
            // 
            // ChooseDocumentListLabel
            // 
            this.ChooseDocumentListLabel.AutoSize = true;
            this.ChooseDocumentListLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseDocumentListLabel.Location = new System.Drawing.Point(23, 88);
            this.ChooseDocumentListLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ChooseDocumentListLabel.Name = "ChooseDocumentListLabel";
            this.ChooseDocumentListLabel.Size = new System.Drawing.Size(299, 27);
            this.ChooseDocumentListLabel.TabIndex = 3;
            this.ChooseDocumentListLabel.Text = "Виберіть список документів:";
            // 
            // ChooseDocumentLabel
            // 
            this.ChooseDocumentLabel.AutoSize = true;
            this.ChooseDocumentLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseDocumentLabel.Location = new System.Drawing.Point(20, 137);
            this.ChooseDocumentLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ChooseDocumentLabel.Name = "ChooseDocumentLabel";
            this.ChooseDocumentLabel.Size = new System.Drawing.Size(353, 27);
            this.ChooseDocumentLabel.TabIndex = 4;
            this.ChooseDocumentLabel.Text = "Документ, що не містить відмітки:";
            // 
            // ChooseDocumentListComboBox
            // 
            this.ChooseDocumentListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseDocumentListComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseDocumentListComboBox.FormattingEnabled = true;
            this.ChooseDocumentListComboBox.Location = new System.Drawing.Point(332, 88);
            this.ChooseDocumentListComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ChooseDocumentListComboBox.Name = "ChooseDocumentListComboBox";
            this.ChooseDocumentListComboBox.Size = new System.Drawing.Size(293, 35);
            this.ChooseDocumentListComboBox.TabIndex = 5;
            this.ChooseDocumentListComboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseDocumentListComboBox_SelectedIndexChanged);
            // 
            // ChooseDocumentComboBox
            // 
            this.ChooseDocumentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseDocumentComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseDocumentComboBox.FormattingEnabled = true;
            this.ChooseDocumentComboBox.Location = new System.Drawing.Point(383, 134);
            this.ChooseDocumentComboBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ChooseDocumentComboBox.Name = "ChooseDocumentComboBox";
            this.ChooseDocumentComboBox.Size = new System.Drawing.Size(242, 35);
            this.ChooseDocumentComboBox.TabIndex = 6;
            // 
            // AddStampForm
            // 
            this.AcceptButton = this.СreateStampBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 265);
            this.Controls.Add(this.ChooseDocumentComboBox);
            this.Controls.Add(this.ChooseDocumentListComboBox);
            this.Controls.Add(this.ChooseDocumentLabel);
            this.Controls.Add(this.ChooseDocumentListLabel);
            this.Controls.Add(this.ExpirationDateTimePicker);
            this.Controls.Add(this.ExpirationDateLabel);
            this.Controls.Add(this.СreateStampBtn);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "AddStampForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Створення унікальної відмітки";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddStampForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button СreateStampBtn;
        private System.Windows.Forms.Label ExpirationDateLabel;
        private System.Windows.Forms.DateTimePicker ExpirationDateTimePicker;
        private System.Windows.Forms.Label ChooseDocumentListLabel;
        private System.Windows.Forms.Label ChooseDocumentLabel;
        private System.Windows.Forms.ComboBox ChooseDocumentListComboBox;
        private System.Windows.Forms.ComboBox ChooseDocumentComboBox;
    }
}