namespace CourseWork
{
    partial class AdditionalOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalOptionsForm));
            this.MainDataGrid = new System.Windows.Forms.DataGridView();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.ChooseOptionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SortBtn = new System.Windows.Forms.Button();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseSortOptionsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDataGrid
            // 
            this.MainDataGrid.AllowUserToAddRows = false;
            this.MainDataGrid.AllowUserToDeleteRows = false;
            this.MainDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGrid.Location = new System.Drawing.Point(13, 14);
            this.MainDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainDataGrid.MultiSelect = false;
            this.MainDataGrid.Name = "MainDataGrid";
            this.MainDataGrid.ReadOnly = true;
            this.MainDataGrid.RowHeadersWidth = 51;
            this.MainDataGrid.RowTemplate.Height = 24;
            this.MainDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainDataGrid.Size = new System.Drawing.Size(1174, 373);
            this.MainDataGrid.TabIndex = 0;
            // 
            // ShowBtn
            // 
            this.ShowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowBtn.Location = new System.Drawing.Point(17, 480);
            this.ShowBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(272, 56);
            this.ShowBtn.TabIndex = 1;
            this.ShowBtn.Text = "Показати";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // ChooseOptionComboBox
            // 
            this.ChooseOptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseOptionComboBox.FormattingEnabled = true;
            this.ChooseOptionComboBox.Items.AddRange(new object[] {
            "Документи з терміном дії відмітки більше 1 року",
            "Повнолітні користувачі",
            "Користувачі, які мають 5+ списків документів",
            "Користувачі, які не мають документів",
            "Преміум користувачі",
            "Звичайні користувачі",
            "Всі користувачі",
            "Всі списки",
            "Списки, які мають більше трьох документів",
            "Всі документи"});
            this.ChooseOptionComboBox.Location = new System.Drawing.Point(13, 436);
            this.ChooseOptionComboBox.Name = "ChooseOptionComboBox";
            this.ChooseOptionComboBox.Size = new System.Drawing.Size(515, 35);
            this.ChooseOptionComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Виберіть дію:";
            // 
            // SortBtn
            // 
            this.SortBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortBtn.Location = new System.Drawing.Point(671, 480);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(272, 56);
            this.SortBtn.TabIndex = 6;
            this.SortBtn.Text = "Сортувати";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Visible = false;
            // 
            // SortComboBox
            // 
            this.SortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Items.AddRange(new object[] {
            "За іменем користувача (А-Я)",
            "За іменем користувача (Я-А)",
            "За прізвищем користувача (А-Я)",
            "За прізвищем користувача (Я-А)",
            "За кількістю списків (Зростання)",
            "За кількістю списків (Спадання)",
            "За датою створення документа (Спочатку новіші)",
            "За датою створення документа (Спочатку старіші)"});
            this.SortComboBox.Location = new System.Drawing.Point(671, 436);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(516, 35);
            this.SortComboBox.TabIndex = 7;
            this.SortComboBox.Visible = false;
            // 
            // ChooseSortOptionsLabel
            // 
            this.ChooseSortOptionsLabel.AutoSize = true;
            this.ChooseSortOptionsLabel.Location = new System.Drawing.Point(666, 406);
            this.ChooseSortOptionsLabel.Name = "ChooseSortOptionsLabel";
            this.ChooseSortOptionsLabel.Size = new System.Drawing.Size(329, 27);
            this.ChooseSortOptionsLabel.TabIndex = 8;
            this.ChooseSortOptionsLabel.Text = "Виберіть параметр сортування:";
            this.ChooseSortOptionsLabel.Visible = false;
            // 
            // AdditionalOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 548);
            this.Controls.Add(this.ChooseSortOptionsLabel);
            this.Controls.Add(this.SortComboBox);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseOptionComboBox);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.MainDataGrid);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdditionalOptionsForm";
            this.Text = "Document manager";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDataGrid;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.ComboBox ChooseOptionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.ComboBox SortComboBox;
        private System.Windows.Forms.Label ChooseSortOptionsLabel;
    }
}