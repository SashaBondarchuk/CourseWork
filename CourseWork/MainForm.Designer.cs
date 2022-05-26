using System.Windows.Forms;

namespace CourseWork
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.DocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStampToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdditionalFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewDocumentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDocumentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateDocumentBox = new System.Windows.Forms.GroupBox();
            this.ChooseUserForDocumentLabel = new System.Windows.Forms.Label();
            this.SelectUserForDocumentComboBox = new System.Windows.Forms.ComboBox();
            this.DocNameLabel = new System.Windows.Forms.Label();
            this.DocTermOfImplementationLabel = new System.Windows.Forms.Label();
            this.DocDegreeOfPubLabel = new System.Windows.Forms.Label();
            this.DocOriginLabel = new System.Windows.Forms.Label();
            this.TermOfImplementationComboBox = new System.Windows.Forms.ComboBox();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.DegreeOfPublicityComboBox = new System.Windows.Forms.ComboBox();
            this.OriginComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseDocumentListLabel = new System.Windows.Forms.Label();
            this.DocumentListComboBox = new System.Windows.Forms.ComboBox();
            this.CreateDocumentBtn = new System.Windows.Forms.Button();
            this.OriginLabel = new System.Windows.Forms.Label();
            this.DocumentNameTextBox = new System.Windows.Forms.TextBox();
            this.DocumentNameLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CreateDocumentListGroupBox = new System.Windows.Forms.GroupBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserListComboBox = new System.Windows.Forms.ComboBox();
            this.CreateListBtn = new System.Windows.Forms.Button();
            this.DocumentListNameTextBox = new System.Windows.Forms.TextBox();
            this.DocumentListNameLabel = new System.Windows.Forms.Label();
            this.DocumentListsDataGrid = new System.Windows.Forms.DataGridView();
            this.CreateUserGroupBox = new System.Windows.Forms.GroupBox();
            this.IsPremiumCheckBox = new System.Windows.Forms.CheckBox();
            this.UserNickNameTextBox = new System.Windows.Forms.TextBox();
            this.NickNameLabel = new System.Windows.Forms.Label();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.BirthdayDateTimePickerLabel = new System.Windows.Forms.Label();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UserLastNameTextBox = new System.Windows.Forms.TextBox();
            this.UserLastNameLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.EditDocumentListGroupBox = new System.Windows.Forms.GroupBox();
            this.EditDocumentListPanel = new System.Windows.Forms.Panel();
            this.ListNameLabel = new System.Windows.Forms.Label();
            this.RenameDocumentListBtn = new System.Windows.Forms.Button();
            this.ListNameTextBox = new System.Windows.Forms.TextBox();
            this.ChooseUserLabel = new System.Windows.Forms.Label();
            this.SelectUserForListsComboBox = new System.Windows.Forms.ComboBox();
            this.BackToCreatingDocumentListBtn = new System.Windows.Forms.Button();
            this.DeleteDocumentListBtn = new System.Windows.Forms.Button();
            this.ShowDocumentListBtn = new System.Windows.Forms.Button();
            this.DocumentsDataGrid = new System.Windows.Forms.DataGridView();
            this.DocumentsInListGroupBox = new System.Windows.Forms.GroupBox();
            this.BackToListsBtn = new System.Windows.Forms.Button();
            this.NameOfDocumentLabel = new System.Windows.Forms.Label();
            this.DocumentTypeNameToChangeComboBox = new System.Windows.Forms.ComboBox();
            this.DocumentTermOfImplementationLabel = new System.Windows.Forms.Label();
            this.DocumentTypeTermOfImplementationToChangeComboBox = new System.Windows.Forms.ComboBox();
            this.DocumentDegreeOfPublicityLabel = new System.Windows.Forms.Label();
            this.DocumentTypeDegreeOfPublicityToChangeComboBox = new System.Windows.Forms.ComboBox();
            this.DocumentOriginLabel = new System.Windows.Forms.Label();
            this.DocumentTypeOriginToChangeComboBox = new System.Windows.Forms.ComboBox();
            this.DocumentNameToChangeTextBox = new System.Windows.Forms.TextBox();
            this.DocumentNameToChangeLabel = new System.Windows.Forms.Label();
            this.EditDocumentBtn = new System.Windows.Forms.Button();
            this.DeleteDocumentBtn = new System.Windows.Forms.Button();
            this.UsersGroupBox = new System.Windows.Forms.GroupBox();
            this.BackToUserCreatingBtn = new System.Windows.Forms.Button();
            this.UserNickNameToEditTextBox = new System.Windows.Forms.TextBox();
            this.UserNickNameLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.UserBirthdayDateToEditTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UserLastNameToEditTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.UserNameToEditTextBox = new System.Windows.Forms.TextBox();
            this.NameOfUserLabel = new System.Windows.Forms.Label();
            this.DeleteUserBtn = new System.Windows.Forms.Button();
            this.EditUserBtn = new System.Windows.Forms.Button();
            this.UsersDataGrid = new System.Windows.Forms.DataGridView();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.FirstMessageLabel = new System.Windows.Forms.Label();
            this.PremiumUserBtn = new System.Windows.Forms.Button();
            this.DefaultUserBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu.SuspendLayout();
            this.CreateDocumentBox.SuspendLayout();
            this.CreateDocumentListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentListsDataGrid)).BeginInit();
            this.CreateUserGroupBox.SuspendLayout();
            this.EditDocumentListGroupBox.SuspendLayout();
            this.EditDocumentListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentsDataGrid)).BeginInit();
            this.DocumentsInListGroupBox.SuspendLayout();
            this.UsersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).BeginInit();
            this.StartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DocumentToolStripMenuItem,
            this.ChooseActionToolStripMenuItem,
            this.UserToolStripMenuItem});
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            // 
            // DocumentToolStripMenuItem
            // 
            this.DocumentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNewDocumentToolStripMenuItem,
            this.AddStampToolStripMenuItem,
            this.AdditionalFunctionsToolStripMenuItem});
            resources.ApplyResources(this.DocumentToolStripMenuItem, "DocumentToolStripMenuItem");
            this.DocumentToolStripMenuItem.Name = "DocumentToolStripMenuItem";
            // 
            // CreateNewDocumentToolStripMenuItem
            // 
            resources.ApplyResources(this.CreateNewDocumentToolStripMenuItem, "CreateNewDocumentToolStripMenuItem");
            this.CreateNewDocumentToolStripMenuItem.Image = global::CourseWork.Properties.Resources.plus_icon;
            this.CreateNewDocumentToolStripMenuItem.Name = "CreateNewDocumentToolStripMenuItem";
            this.CreateNewDocumentToolStripMenuItem.Click += new System.EventHandler(this.CreateNewDocumentToolStripMenuItem_Click);
            // 
            // AddStampToolStripMenuItem
            // 
            resources.ApplyResources(this.AddStampToolStripMenuItem, "AddStampToolStripMenuItem");
            this.AddStampToolStripMenuItem.Image = global::CourseWork.Properties.Resources.flag_icon;
            this.AddStampToolStripMenuItem.Name = "AddStampToolStripMenuItem";
            this.AddStampToolStripMenuItem.Click += new System.EventHandler(this.AddStampToolStripMenuItem_Click);
            // 
            // AdditionalFunctionsToolStripMenuItem
            // 
            resources.ApplyResources(this.AdditionalFunctionsToolStripMenuItem, "AdditionalFunctionsToolStripMenuItem");
            this.AdditionalFunctionsToolStripMenuItem.Image = global::CourseWork.Properties.Resources.diamond_icon;
            this.AdditionalFunctionsToolStripMenuItem.Name = "AdditionalFunctionsToolStripMenuItem";
            this.AdditionalFunctionsToolStripMenuItem.Click += new System.EventHandler(this.AdditionalFunctionsToolStripMenuItem_Click);
            // 
            // ChooseActionToolStripMenuItem
            // 
            this.ChooseActionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNewDocumentListToolStripMenuItem,
            this.EditDocumentListToolStripMenuItem});
            resources.ApplyResources(this.ChooseActionToolStripMenuItem, "ChooseActionToolStripMenuItem");
            this.ChooseActionToolStripMenuItem.Name = "ChooseActionToolStripMenuItem";
            // 
            // CreateNewDocumentListToolStripMenuItem
            // 
            resources.ApplyResources(this.CreateNewDocumentListToolStripMenuItem, "CreateNewDocumentListToolStripMenuItem");
            this.CreateNewDocumentListToolStripMenuItem.Image = global::CourseWork.Properties.Resources.plus_icon;
            this.CreateNewDocumentListToolStripMenuItem.Name = "CreateNewDocumentListToolStripMenuItem";
            this.CreateNewDocumentListToolStripMenuItem.Click += new System.EventHandler(this.CreateNewDocumentListToolStripMenuItem_Click);
            // 
            // EditDocumentListToolStripMenuItem
            // 
            resources.ApplyResources(this.EditDocumentListToolStripMenuItem, "EditDocumentListToolStripMenuItem");
            this.EditDocumentListToolStripMenuItem.Image = global::CourseWork.Properties.Resources.edit_icon;
            this.EditDocumentListToolStripMenuItem.Name = "EditDocumentListToolStripMenuItem";
            this.EditDocumentListToolStripMenuItem.Click += new System.EventHandler(this.EditDocumentListToolStripMenuItem_Click);
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewUserToolStripMenuItem,
            this.ShowUsersToolStripMenuItem});
            resources.ApplyResources(this.UserToolStripMenuItem, "UserToolStripMenuItem");
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            // 
            // AddNewUserToolStripMenuItem
            // 
            resources.ApplyResources(this.AddNewUserToolStripMenuItem, "AddNewUserToolStripMenuItem");
            this.AddNewUserToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.AddNewUserToolStripMenuItem.Image = global::CourseWork.Properties.Resources.add_user_icon;
            this.AddNewUserToolStripMenuItem.Name = "AddNewUserToolStripMenuItem";
            this.AddNewUserToolStripMenuItem.Click += new System.EventHandler(this.AddNewUserToolStripMenuItem_Click);
            // 
            // ShowUsersToolStripMenuItem
            // 
            resources.ApplyResources(this.ShowUsersToolStripMenuItem, "ShowUsersToolStripMenuItem");
            this.ShowUsersToolStripMenuItem.Image = global::CourseWork.Properties.Resources.users_icon;
            this.ShowUsersToolStripMenuItem.Name = "ShowUsersToolStripMenuItem";
            this.ShowUsersToolStripMenuItem.Click += new System.EventHandler(this.ShowUsersToolStripMenuItem_Click);
            // 
            // CreateDocumentBox
            // 
            this.CreateDocumentBox.Controls.Add(this.ChooseUserForDocumentLabel);
            this.CreateDocumentBox.Controls.Add(this.SelectUserForDocumentComboBox);
            this.CreateDocumentBox.Controls.Add(this.DocNameLabel);
            this.CreateDocumentBox.Controls.Add(this.DocTermOfImplementationLabel);
            this.CreateDocumentBox.Controls.Add(this.DocDegreeOfPubLabel);
            this.CreateDocumentBox.Controls.Add(this.DocOriginLabel);
            this.CreateDocumentBox.Controls.Add(this.TermOfImplementationComboBox);
            this.CreateDocumentBox.Controls.Add(this.NameComboBox);
            this.CreateDocumentBox.Controls.Add(this.DegreeOfPublicityComboBox);
            this.CreateDocumentBox.Controls.Add(this.OriginComboBox);
            this.CreateDocumentBox.Controls.Add(this.ChooseDocumentListLabel);
            this.CreateDocumentBox.Controls.Add(this.DocumentListComboBox);
            this.CreateDocumentBox.Controls.Add(this.CreateDocumentBtn);
            this.CreateDocumentBox.Controls.Add(this.OriginLabel);
            this.CreateDocumentBox.Controls.Add(this.DocumentNameTextBox);
            this.CreateDocumentBox.Controls.Add(this.DocumentNameLabel);
            resources.ApplyResources(this.CreateDocumentBox, "CreateDocumentBox");
            this.CreateDocumentBox.Name = "CreateDocumentBox";
            this.CreateDocumentBox.TabStop = false;
            // 
            // ChooseUserForDocumentLabel
            // 
            resources.ApplyResources(this.ChooseUserForDocumentLabel, "ChooseUserForDocumentLabel");
            this.ChooseUserForDocumentLabel.Name = "ChooseUserForDocumentLabel";
            // 
            // SelectUserForDocumentComboBox
            // 
            this.SelectUserForDocumentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.SelectUserForDocumentComboBox, "SelectUserForDocumentComboBox");
            this.SelectUserForDocumentComboBox.FormattingEnabled = true;
            this.SelectUserForDocumentComboBox.Name = "SelectUserForDocumentComboBox";
            this.SelectUserForDocumentComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectUserForDocumentComboBox_SelectedIndexChanged);
            // 
            // DocNameLabel
            // 
            resources.ApplyResources(this.DocNameLabel, "DocNameLabel");
            this.DocNameLabel.Name = "DocNameLabel";
            // 
            // DocTermOfImplementationLabel
            // 
            resources.ApplyResources(this.DocTermOfImplementationLabel, "DocTermOfImplementationLabel");
            this.DocTermOfImplementationLabel.Name = "DocTermOfImplementationLabel";
            // 
            // DocDegreeOfPubLabel
            // 
            resources.ApplyResources(this.DocDegreeOfPubLabel, "DocDegreeOfPubLabel");
            this.DocDegreeOfPubLabel.Name = "DocDegreeOfPubLabel";
            // 
            // DocOriginLabel
            // 
            resources.ApplyResources(this.DocOriginLabel, "DocOriginLabel");
            this.DocOriginLabel.Name = "DocOriginLabel";
            // 
            // TermOfImplementationComboBox
            // 
            this.TermOfImplementationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TermOfImplementationComboBox.FormattingEnabled = true;
            this.TermOfImplementationComboBox.Items.AddRange(new object[] {
            resources.GetString("TermOfImplementationComboBox.Items"),
            resources.GetString("TermOfImplementationComboBox.Items1")});
            resources.ApplyResources(this.TermOfImplementationComboBox, "TermOfImplementationComboBox");
            this.TermOfImplementationComboBox.Name = "TermOfImplementationComboBox";
            // 
            // NameComboBox
            // 
            this.NameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Items.AddRange(new object[] {
            resources.GetString("NameComboBox.Items"),
            resources.GetString("NameComboBox.Items1"),
            resources.GetString("NameComboBox.Items2"),
            resources.GetString("NameComboBox.Items3"),
            resources.GetString("NameComboBox.Items4"),
            resources.GetString("NameComboBox.Items5"),
            resources.GetString("NameComboBox.Items6"),
            resources.GetString("NameComboBox.Items7"),
            resources.GetString("NameComboBox.Items8"),
            resources.GetString("NameComboBox.Items9"),
            resources.GetString("NameComboBox.Items10"),
            resources.GetString("NameComboBox.Items11"),
            resources.GetString("NameComboBox.Items12"),
            resources.GetString("NameComboBox.Items13"),
            resources.GetString("NameComboBox.Items14"),
            resources.GetString("NameComboBox.Items15"),
            resources.GetString("NameComboBox.Items16"),
            resources.GetString("NameComboBox.Items17"),
            resources.GetString("NameComboBox.Items18"),
            resources.GetString("NameComboBox.Items19"),
            resources.GetString("NameComboBox.Items20"),
            resources.GetString("NameComboBox.Items21"),
            resources.GetString("NameComboBox.Items22")});
            resources.ApplyResources(this.NameComboBox, "NameComboBox");
            this.NameComboBox.Name = "NameComboBox";
            // 
            // DegreeOfPublicityComboBox
            // 
            this.DegreeOfPublicityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DegreeOfPublicityComboBox.FormattingEnabled = true;
            this.DegreeOfPublicityComboBox.Items.AddRange(new object[] {
            resources.GetString("DegreeOfPublicityComboBox.Items"),
            resources.GetString("DegreeOfPublicityComboBox.Items1"),
            resources.GetString("DegreeOfPublicityComboBox.Items2")});
            resources.ApplyResources(this.DegreeOfPublicityComboBox, "DegreeOfPublicityComboBox");
            this.DegreeOfPublicityComboBox.Name = "DegreeOfPublicityComboBox";
            // 
            // OriginComboBox
            // 
            this.OriginComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("OriginComboBox.AutoCompleteCustomSource"),
            resources.GetString("OriginComboBox.AutoCompleteCustomSource1")});
            this.OriginComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OriginComboBox.FormattingEnabled = true;
            this.OriginComboBox.Items.AddRange(new object[] {
            resources.GetString("OriginComboBox.Items"),
            resources.GetString("OriginComboBox.Items1")});
            resources.ApplyResources(this.OriginComboBox, "OriginComboBox");
            this.OriginComboBox.Name = "OriginComboBox";
            // 
            // ChooseDocumentListLabel
            // 
            resources.ApplyResources(this.ChooseDocumentListLabel, "ChooseDocumentListLabel");
            this.ChooseDocumentListLabel.Name = "ChooseDocumentListLabel";
            // 
            // DocumentListComboBox
            // 
            this.DocumentListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.DocumentListComboBox, "DocumentListComboBox");
            this.DocumentListComboBox.Name = "DocumentListComboBox";
            // 
            // CreateDocumentBtn
            // 
            this.CreateDocumentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.CreateDocumentBtn, "CreateDocumentBtn");
            this.CreateDocumentBtn.Name = "CreateDocumentBtn";
            this.CreateDocumentBtn.UseVisualStyleBackColor = true;
            this.CreateDocumentBtn.Click += new System.EventHandler(this.CreateDocumentBtn_Click);
            // 
            // OriginLabel
            // 
            resources.ApplyResources(this.OriginLabel, "OriginLabel");
            this.OriginLabel.Name = "OriginLabel";
            // 
            // DocumentNameTextBox
            // 
            resources.ApplyResources(this.DocumentNameTextBox, "DocumentNameTextBox");
            this.DocumentNameTextBox.Name = "DocumentNameTextBox";
            // 
            // DocumentNameLabel
            // 
            resources.ApplyResources(this.DocumentNameLabel, "DocumentNameLabel");
            this.DocumentNameLabel.Name = "DocumentNameLabel";
            // 
            // CreateDocumentListGroupBox
            // 
            this.CreateDocumentListGroupBox.Controls.Add(this.UserLabel);
            this.CreateDocumentListGroupBox.Controls.Add(this.UserListComboBox);
            this.CreateDocumentListGroupBox.Controls.Add(this.CreateListBtn);
            this.CreateDocumentListGroupBox.Controls.Add(this.DocumentListNameTextBox);
            this.CreateDocumentListGroupBox.Controls.Add(this.DocumentListNameLabel);
            resources.ApplyResources(this.CreateDocumentListGroupBox, "CreateDocumentListGroupBox");
            this.CreateDocumentListGroupBox.Name = "CreateDocumentListGroupBox";
            this.CreateDocumentListGroupBox.TabStop = false;
            // 
            // UserLabel
            // 
            resources.ApplyResources(this.UserLabel, "UserLabel");
            this.UserLabel.Name = "UserLabel";
            // 
            // UserListComboBox
            // 
            this.UserListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserListComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.UserListComboBox, "UserListComboBox");
            this.UserListComboBox.Name = "UserListComboBox";
            // 
            // CreateListBtn
            // 
            this.CreateListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.CreateListBtn, "CreateListBtn");
            this.CreateListBtn.Name = "CreateListBtn";
            this.CreateListBtn.UseVisualStyleBackColor = true;
            this.CreateListBtn.Click += new System.EventHandler(this.CreateListBtn_Click);
            // 
            // DocumentListNameTextBox
            // 
            resources.ApplyResources(this.DocumentListNameTextBox, "DocumentListNameTextBox");
            this.DocumentListNameTextBox.Name = "DocumentListNameTextBox";
            // 
            // DocumentListNameLabel
            // 
            resources.ApplyResources(this.DocumentListNameLabel, "DocumentListNameLabel");
            this.DocumentListNameLabel.Name = "DocumentListNameLabel";
            // 
            // DocumentListsDataGrid
            // 
            this.DocumentListsDataGrid.AllowUserToAddRows = false;
            this.DocumentListsDataGrid.AllowUserToDeleteRows = false;
            this.DocumentListsDataGrid.AllowUserToResizeRows = false;
            this.DocumentListsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DocumentListsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.DocumentListsDataGrid, "DocumentListsDataGrid");
            this.DocumentListsDataGrid.MultiSelect = false;
            this.DocumentListsDataGrid.Name = "DocumentListsDataGrid";
            this.DocumentListsDataGrid.ReadOnly = true;
            this.DocumentListsDataGrid.RowTemplate.Height = 24;
            this.DocumentListsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DocumentListsDataGrid.SelectionChanged += new System.EventHandler(this.DocumentListsDataGrid_SelectionChanged);
            // 
            // CreateUserGroupBox
            // 
            this.CreateUserGroupBox.Controls.Add(this.IsPremiumCheckBox);
            this.CreateUserGroupBox.Controls.Add(this.UserNickNameTextBox);
            this.CreateUserGroupBox.Controls.Add(this.NickNameLabel);
            this.CreateUserGroupBox.Controls.Add(this.AddUserBtn);
            this.CreateUserGroupBox.Controls.Add(this.BirthdayDateTimePickerLabel);
            this.CreateUserGroupBox.Controls.Add(this.BirthdayDateTimePicker);
            this.CreateUserGroupBox.Controls.Add(this.UserLastNameTextBox);
            this.CreateUserGroupBox.Controls.Add(this.UserLastNameLabel);
            this.CreateUserGroupBox.Controls.Add(this.UserNameTextBox);
            this.CreateUserGroupBox.Controls.Add(this.UserNameLabel);
            resources.ApplyResources(this.CreateUserGroupBox, "CreateUserGroupBox");
            this.CreateUserGroupBox.Name = "CreateUserGroupBox";
            this.CreateUserGroupBox.TabStop = false;
            // 
            // IsPremiumCheckBox
            // 
            resources.ApplyResources(this.IsPremiumCheckBox, "IsPremiumCheckBox");
            this.IsPremiumCheckBox.Name = "IsPremiumCheckBox";
            this.IsPremiumCheckBox.UseVisualStyleBackColor = true;
            // 
            // UserNickNameTextBox
            // 
            resources.ApplyResources(this.UserNickNameTextBox, "UserNickNameTextBox");
            this.UserNickNameTextBox.Name = "UserNickNameTextBox";
            // 
            // NickNameLabel
            // 
            resources.ApplyResources(this.NickNameLabel, "NickNameLabel");
            this.NickNameLabel.Name = "NickNameLabel";
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.AddUserBtn, "AddUserBtn");
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // BirthdayDateTimePickerLabel
            // 
            resources.ApplyResources(this.BirthdayDateTimePickerLabel, "BirthdayDateTimePickerLabel");
            this.BirthdayDateTimePickerLabel.Name = "BirthdayDateTimePickerLabel";
            // 
            // BirthdayDateTimePicker
            // 
            resources.ApplyResources(this.BirthdayDateTimePicker, "BirthdayDateTimePicker");
            this.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayDateTimePicker.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.BirthdayDateTimePicker.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Value = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            // 
            // UserLastNameTextBox
            // 
            resources.ApplyResources(this.UserLastNameTextBox, "UserLastNameTextBox");
            this.UserLastNameTextBox.Name = "UserLastNameTextBox";
            // 
            // UserLastNameLabel
            // 
            resources.ApplyResources(this.UserLastNameLabel, "UserLastNameLabel");
            this.UserLastNameLabel.Name = "UserLastNameLabel";
            // 
            // UserNameTextBox
            // 
            resources.ApplyResources(this.UserNameTextBox, "UserNameTextBox");
            this.UserNameTextBox.Name = "UserNameTextBox";
            // 
            // UserNameLabel
            // 
            resources.ApplyResources(this.UserNameLabel, "UserNameLabel");
            this.UserNameLabel.Name = "UserNameLabel";
            // 
            // EditDocumentListGroupBox
            // 
            this.EditDocumentListGroupBox.Controls.Add(this.EditDocumentListPanel);
            this.EditDocumentListGroupBox.Controls.Add(this.ChooseUserLabel);
            this.EditDocumentListGroupBox.Controls.Add(this.SelectUserForListsComboBox);
            this.EditDocumentListGroupBox.Controls.Add(this.BackToCreatingDocumentListBtn);
            this.EditDocumentListGroupBox.Controls.Add(this.DocumentListsDataGrid);
            this.EditDocumentListGroupBox.Controls.Add(this.DeleteDocumentListBtn);
            this.EditDocumentListGroupBox.Controls.Add(this.ShowDocumentListBtn);
            resources.ApplyResources(this.EditDocumentListGroupBox, "EditDocumentListGroupBox");
            this.EditDocumentListGroupBox.Name = "EditDocumentListGroupBox";
            this.EditDocumentListGroupBox.TabStop = false;
            // 
            // EditDocumentListPanel
            // 
            this.EditDocumentListPanel.Controls.Add(this.ListNameLabel);
            this.EditDocumentListPanel.Controls.Add(this.RenameDocumentListBtn);
            this.EditDocumentListPanel.Controls.Add(this.ListNameTextBox);
            resources.ApplyResources(this.EditDocumentListPanel, "EditDocumentListPanel");
            this.EditDocumentListPanel.Name = "EditDocumentListPanel";
            // 
            // ListNameLabel
            // 
            resources.ApplyResources(this.ListNameLabel, "ListNameLabel");
            this.ListNameLabel.Name = "ListNameLabel";
            // 
            // RenameDocumentListBtn
            // 
            this.RenameDocumentListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.RenameDocumentListBtn, "RenameDocumentListBtn");
            this.RenameDocumentListBtn.Name = "RenameDocumentListBtn";
            this.RenameDocumentListBtn.UseVisualStyleBackColor = true;
            this.RenameDocumentListBtn.Click += new System.EventHandler(this.RenameDocumentListBtn_Click);
            // 
            // ListNameTextBox
            // 
            resources.ApplyResources(this.ListNameTextBox, "ListNameTextBox");
            this.ListNameTextBox.Name = "ListNameTextBox";
            // 
            // ChooseUserLabel
            // 
            resources.ApplyResources(this.ChooseUserLabel, "ChooseUserLabel");
            this.ChooseUserLabel.Name = "ChooseUserLabel";
            // 
            // SelectUserForListsComboBox
            // 
            this.SelectUserForListsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.SelectUserForListsComboBox, "SelectUserForListsComboBox");
            this.SelectUserForListsComboBox.FormattingEnabled = true;
            this.SelectUserForListsComboBox.Name = "SelectUserForListsComboBox";
            this.SelectUserForListsComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectUserForListsComboBox_SelectedIndexChanged);
            // 
            // BackToCreatingDocumentListBtn
            // 
            resources.ApplyResources(this.BackToCreatingDocumentListBtn, "BackToCreatingDocumentListBtn");
            this.BackToCreatingDocumentListBtn.Name = "BackToCreatingDocumentListBtn";
            this.BackToCreatingDocumentListBtn.UseVisualStyleBackColor = true;
            this.BackToCreatingDocumentListBtn.Click += new System.EventHandler(this.BackToCreatingDocumentListBtn_Click);
            // 
            // DeleteDocumentListBtn
            // 
            this.DeleteDocumentListBtn.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteDocumentListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteDocumentListBtn.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.DeleteDocumentListBtn, "DeleteDocumentListBtn");
            this.DeleteDocumentListBtn.Name = "DeleteDocumentListBtn";
            this.DeleteDocumentListBtn.UseVisualStyleBackColor = false;
            this.DeleteDocumentListBtn.Click += new System.EventHandler(this.DeleteDocumentListBtn_Click);
            // 
            // ShowDocumentListBtn
            // 
            this.ShowDocumentListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ShowDocumentListBtn, "ShowDocumentListBtn");
            this.ShowDocumentListBtn.Name = "ShowDocumentListBtn";
            this.ShowDocumentListBtn.UseVisualStyleBackColor = true;
            this.ShowDocumentListBtn.Click += new System.EventHandler(this.ShowDocumentListBtn_Click);
            // 
            // DocumentsDataGrid
            // 
            this.DocumentsDataGrid.AllowUserToAddRows = false;
            this.DocumentsDataGrid.AllowUserToDeleteRows = false;
            this.DocumentsDataGrid.AllowUserToResizeRows = false;
            this.DocumentsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DocumentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.DocumentsDataGrid, "DocumentsDataGrid");
            this.DocumentsDataGrid.MultiSelect = false;
            this.DocumentsDataGrid.Name = "DocumentsDataGrid";
            this.DocumentsDataGrid.ReadOnly = true;
            this.DocumentsDataGrid.RowTemplate.Height = 24;
            this.DocumentsDataGrid.RowTemplate.ReadOnly = true;
            this.DocumentsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DocumentsDataGrid.ShowEditingIcon = false;
            this.DocumentsDataGrid.SelectionChanged += new System.EventHandler(this.DocumentsDataGrid_SelectionChanged);
            // 
            // DocumentsInListGroupBox
            // 
            this.DocumentsInListGroupBox.Controls.Add(this.BackToListsBtn);
            this.DocumentsInListGroupBox.Controls.Add(this.NameOfDocumentLabel);
            this.DocumentsInListGroupBox.Controls.Add(this.DocumentTypeNameToChangeComboBox);
            this.DocumentsInListGroupBox.Controls.Add(this.DocumentTermOfImplementationLabel);
            this.DocumentsInListGroupBox.Controls.Add(this.DocumentTypeTermOfImplementationToChangeComboBox);
            this.DocumentsInListGroupBox.Controls.Add(this.DocumentDegreeOfPublicityLabel);
            this.DocumentsInListGroupBox.Controls.Add(this.DocumentTypeDegreeOfPublicityToChangeComboBox);
            this.DocumentsInListGroupBox.Controls.Add(this.DocumentOriginLabel);
            this.DocumentsInListGroupBox.Controls.Add(this.DocumentTypeOriginToChangeComboBox);
            this.DocumentsInListGroupBox.Controls.Add(this.DocumentNameToChangeTextBox);
            this.DocumentsInListGroupBox.Controls.Add(this.DocumentNameToChangeLabel);
            this.DocumentsInListGroupBox.Controls.Add(this.EditDocumentBtn);
            this.DocumentsInListGroupBox.Controls.Add(this.DeleteDocumentBtn);
            this.DocumentsInListGroupBox.Controls.Add(this.DocumentsDataGrid);
            resources.ApplyResources(this.DocumentsInListGroupBox, "DocumentsInListGroupBox");
            this.DocumentsInListGroupBox.Name = "DocumentsInListGroupBox";
            this.DocumentsInListGroupBox.TabStop = false;
            // 
            // BackToListsBtn
            // 
            resources.ApplyResources(this.BackToListsBtn, "BackToListsBtn");
            this.BackToListsBtn.Name = "BackToListsBtn";
            this.BackToListsBtn.UseVisualStyleBackColor = true;
            this.BackToListsBtn.Click += new System.EventHandler(this.BackToListsBtn_Click);
            // 
            // NameOfDocumentLabel
            // 
            resources.ApplyResources(this.NameOfDocumentLabel, "NameOfDocumentLabel");
            this.NameOfDocumentLabel.Name = "NameOfDocumentLabel";
            // 
            // DocumentTypeNameToChangeComboBox
            // 
            this.DocumentTypeNameToChangeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocumentTypeNameToChangeComboBox.FormattingEnabled = true;
            this.DocumentTypeNameToChangeComboBox.Items.AddRange(new object[] {
            resources.GetString("DocumentTypeNameToChangeComboBox.Items"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items1"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items2"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items3"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items4"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items5"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items6"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items7"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items8"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items9"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items10"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items11"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items12"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items13"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items14"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items15"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items16"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items17"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items18"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items19"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items20"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items21"),
            resources.GetString("DocumentTypeNameToChangeComboBox.Items22")});
            resources.ApplyResources(this.DocumentTypeNameToChangeComboBox, "DocumentTypeNameToChangeComboBox");
            this.DocumentTypeNameToChangeComboBox.Name = "DocumentTypeNameToChangeComboBox";
            // 
            // DocumentTermOfImplementationLabel
            // 
            resources.ApplyResources(this.DocumentTermOfImplementationLabel, "DocumentTermOfImplementationLabel");
            this.DocumentTermOfImplementationLabel.Name = "DocumentTermOfImplementationLabel";
            // 
            // DocumentTypeTermOfImplementationToChangeComboBox
            // 
            this.DocumentTypeTermOfImplementationToChangeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocumentTypeTermOfImplementationToChangeComboBox.FormattingEnabled = true;
            this.DocumentTypeTermOfImplementationToChangeComboBox.Items.AddRange(new object[] {
            resources.GetString("DocumentTypeTermOfImplementationToChangeComboBox.Items"),
            resources.GetString("DocumentTypeTermOfImplementationToChangeComboBox.Items1")});
            resources.ApplyResources(this.DocumentTypeTermOfImplementationToChangeComboBox, "DocumentTypeTermOfImplementationToChangeComboBox");
            this.DocumentTypeTermOfImplementationToChangeComboBox.Name = "DocumentTypeTermOfImplementationToChangeComboBox";
            // 
            // DocumentDegreeOfPublicityLabel
            // 
            resources.ApplyResources(this.DocumentDegreeOfPublicityLabel, "DocumentDegreeOfPublicityLabel");
            this.DocumentDegreeOfPublicityLabel.Name = "DocumentDegreeOfPublicityLabel";
            // 
            // DocumentTypeDegreeOfPublicityToChangeComboBox
            // 
            this.DocumentTypeDegreeOfPublicityToChangeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocumentTypeDegreeOfPublicityToChangeComboBox.FormattingEnabled = true;
            this.DocumentTypeDegreeOfPublicityToChangeComboBox.Items.AddRange(new object[] {
            resources.GetString("DocumentTypeDegreeOfPublicityToChangeComboBox.Items"),
            resources.GetString("DocumentTypeDegreeOfPublicityToChangeComboBox.Items1"),
            resources.GetString("DocumentTypeDegreeOfPublicityToChangeComboBox.Items2")});
            resources.ApplyResources(this.DocumentTypeDegreeOfPublicityToChangeComboBox, "DocumentTypeDegreeOfPublicityToChangeComboBox");
            this.DocumentTypeDegreeOfPublicityToChangeComboBox.Name = "DocumentTypeDegreeOfPublicityToChangeComboBox";
            // 
            // DocumentOriginLabel
            // 
            resources.ApplyResources(this.DocumentOriginLabel, "DocumentOriginLabel");
            this.DocumentOriginLabel.Name = "DocumentOriginLabel";
            // 
            // DocumentTypeOriginToChangeComboBox
            // 
            this.DocumentTypeOriginToChangeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("DocumentTypeOriginToChangeComboBox.AutoCompleteCustomSource"),
            resources.GetString("DocumentTypeOriginToChangeComboBox.AutoCompleteCustomSource1")});
            this.DocumentTypeOriginToChangeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocumentTypeOriginToChangeComboBox.FormattingEnabled = true;
            this.DocumentTypeOriginToChangeComboBox.Items.AddRange(new object[] {
            resources.GetString("DocumentTypeOriginToChangeComboBox.Items"),
            resources.GetString("DocumentTypeOriginToChangeComboBox.Items1")});
            resources.ApplyResources(this.DocumentTypeOriginToChangeComboBox, "DocumentTypeOriginToChangeComboBox");
            this.DocumentTypeOriginToChangeComboBox.Name = "DocumentTypeOriginToChangeComboBox";
            // 
            // DocumentNameToChangeTextBox
            // 
            resources.ApplyResources(this.DocumentNameToChangeTextBox, "DocumentNameToChangeTextBox");
            this.DocumentNameToChangeTextBox.Name = "DocumentNameToChangeTextBox";
            // 
            // DocumentNameToChangeLabel
            // 
            resources.ApplyResources(this.DocumentNameToChangeLabel, "DocumentNameToChangeLabel");
            this.DocumentNameToChangeLabel.Name = "DocumentNameToChangeLabel";
            // 
            // EditDocumentBtn
            // 
            this.EditDocumentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.EditDocumentBtn, "EditDocumentBtn");
            this.EditDocumentBtn.Name = "EditDocumentBtn";
            this.EditDocumentBtn.UseVisualStyleBackColor = true;
            this.EditDocumentBtn.Click += new System.EventHandler(this.EditDocumentBtn_Click);
            // 
            // DeleteDocumentBtn
            // 
            this.DeleteDocumentBtn.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteDocumentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteDocumentBtn.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.DeleteDocumentBtn, "DeleteDocumentBtn");
            this.DeleteDocumentBtn.Name = "DeleteDocumentBtn";
            this.DeleteDocumentBtn.UseVisualStyleBackColor = false;
            this.DeleteDocumentBtn.Click += new System.EventHandler(this.DeleteDocumentBtn_Click);
            // 
            // UsersGroupBox
            // 
            this.UsersGroupBox.Controls.Add(this.BackToUserCreatingBtn);
            this.UsersGroupBox.Controls.Add(this.UserNickNameToEditTextBox);
            this.UsersGroupBox.Controls.Add(this.UserNickNameLabel);
            this.UsersGroupBox.Controls.Add(this.label10);
            this.UsersGroupBox.Controls.Add(this.UserBirthdayDateToEditTimePicker);
            this.UsersGroupBox.Controls.Add(this.UserLastNameToEditTextBox);
            this.UsersGroupBox.Controls.Add(this.LastNameLabel);
            this.UsersGroupBox.Controls.Add(this.UserNameToEditTextBox);
            this.UsersGroupBox.Controls.Add(this.NameOfUserLabel);
            this.UsersGroupBox.Controls.Add(this.DeleteUserBtn);
            this.UsersGroupBox.Controls.Add(this.EditUserBtn);
            this.UsersGroupBox.Controls.Add(this.UsersDataGrid);
            resources.ApplyResources(this.UsersGroupBox, "UsersGroupBox");
            this.UsersGroupBox.Name = "UsersGroupBox";
            this.UsersGroupBox.TabStop = false;
            // 
            // BackToUserCreatingBtn
            // 
            resources.ApplyResources(this.BackToUserCreatingBtn, "BackToUserCreatingBtn");
            this.BackToUserCreatingBtn.Name = "BackToUserCreatingBtn";
            this.BackToUserCreatingBtn.UseVisualStyleBackColor = true;
            this.BackToUserCreatingBtn.Click += new System.EventHandler(this.BackToUserCreatingBtn_Click);
            // 
            // UserNickNameToEditTextBox
            // 
            resources.ApplyResources(this.UserNickNameToEditTextBox, "UserNickNameToEditTextBox");
            this.UserNickNameToEditTextBox.Name = "UserNickNameToEditTextBox";
            // 
            // UserNickNameLabel
            // 
            resources.ApplyResources(this.UserNickNameLabel, "UserNickNameLabel");
            this.UserNickNameLabel.Name = "UserNickNameLabel";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // UserBirthdayDateToEditTimePicker
            // 
            resources.ApplyResources(this.UserBirthdayDateToEditTimePicker, "UserBirthdayDateToEditTimePicker");
            this.UserBirthdayDateToEditTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UserBirthdayDateToEditTimePicker.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.UserBirthdayDateToEditTimePicker.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.UserBirthdayDateToEditTimePicker.Name = "UserBirthdayDateToEditTimePicker";
            this.UserBirthdayDateToEditTimePicker.Value = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            // 
            // UserLastNameToEditTextBox
            // 
            resources.ApplyResources(this.UserLastNameToEditTextBox, "UserLastNameToEditTextBox");
            this.UserLastNameToEditTextBox.Name = "UserLastNameToEditTextBox";
            // 
            // LastNameLabel
            // 
            resources.ApplyResources(this.LastNameLabel, "LastNameLabel");
            this.LastNameLabel.Name = "LastNameLabel";
            // 
            // UserNameToEditTextBox
            // 
            resources.ApplyResources(this.UserNameToEditTextBox, "UserNameToEditTextBox");
            this.UserNameToEditTextBox.Name = "UserNameToEditTextBox";
            // 
            // NameOfUserLabel
            // 
            resources.ApplyResources(this.NameOfUserLabel, "NameOfUserLabel");
            this.NameOfUserLabel.Name = "NameOfUserLabel";
            // 
            // DeleteUserBtn
            // 
            this.DeleteUserBtn.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteUserBtn.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.DeleteUserBtn, "DeleteUserBtn");
            this.DeleteUserBtn.Name = "DeleteUserBtn";
            this.DeleteUserBtn.UseVisualStyleBackColor = false;
            this.DeleteUserBtn.Click += new System.EventHandler(this.DeleteUserBtn_Click);
            // 
            // EditUserBtn
            // 
            this.EditUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.EditUserBtn, "EditUserBtn");
            this.EditUserBtn.Name = "EditUserBtn";
            this.EditUserBtn.UseVisualStyleBackColor = true;
            this.EditUserBtn.Click += new System.EventHandler(this.EditUserBtn_Click);
            // 
            // UsersDataGrid
            // 
            this.UsersDataGrid.AllowUserToAddRows = false;
            this.UsersDataGrid.AllowUserToDeleteRows = false;
            this.UsersDataGrid.AllowUserToResizeRows = false;
            this.UsersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.UsersDataGrid, "UsersDataGrid");
            this.UsersDataGrid.MultiSelect = false;
            this.UsersDataGrid.Name = "UsersDataGrid";
            this.UsersDataGrid.ReadOnly = true;
            this.UsersDataGrid.RowTemplate.Height = 24;
            this.UsersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataGrid.SelectionChanged += new System.EventHandler(this.UsersDataGrid_SelectionChanged);
            // 
            // StartPanel
            // 
            this.StartPanel.BackColor = System.Drawing.Color.White;
            this.StartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartPanel.Controls.Add(this.FirstMessageLabel);
            this.StartPanel.Controls.Add(this.PremiumUserBtn);
            this.StartPanel.Controls.Add(this.DefaultUserBtn);
            resources.ApplyResources(this.StartPanel, "StartPanel");
            this.StartPanel.Name = "StartPanel";
            // 
            // FirstMessageLabel
            // 
            resources.ApplyResources(this.FirstMessageLabel, "FirstMessageLabel");
            this.FirstMessageLabel.BackColor = System.Drawing.Color.White;
            this.FirstMessageLabel.Name = "FirstMessageLabel";
            // 
            // PremiumUserBtn
            // 
            this.PremiumUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PremiumUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.PremiumUserBtn, "PremiumUserBtn");
            this.PremiumUserBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PremiumUserBtn.Name = "PremiumUserBtn";
            this.PremiumUserBtn.UseVisualStyleBackColor = false;
            this.PremiumUserBtn.Click += new System.EventHandler(this.PremiumUserBtn_Click);
            // 
            // DefaultUserBtn
            // 
            this.DefaultUserBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DefaultUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.DefaultUserBtn, "DefaultUserBtn");
            this.DefaultUserBtn.ForeColor = System.Drawing.Color.White;
            this.DefaultUserBtn.Name = "DefaultUserBtn";
            this.DefaultUserBtn.UseVisualStyleBackColor = false;
            this.DefaultUserBtn.Click += new System.EventHandler(this.DefaultUserBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.CreateDocumentListGroupBox);
            this.Controls.Add(this.CreateDocumentBox);
            this.Controls.Add(this.DocumentsInListGroupBox);
            this.Controls.Add(this.CreateUserGroupBox);
            this.Controls.Add(this.UsersGroupBox);
            this.Controls.Add(this.EditDocumentListGroupBox);
            this.Controls.Add(this.menu);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.CreateDocumentBox.ResumeLayout(false);
            this.CreateDocumentBox.PerformLayout();
            this.CreateDocumentListGroupBox.ResumeLayout(false);
            this.CreateDocumentListGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentListsDataGrid)).EndInit();
            this.CreateUserGroupBox.ResumeLayout(false);
            this.CreateUserGroupBox.PerformLayout();
            this.EditDocumentListGroupBox.ResumeLayout(false);
            this.EditDocumentListGroupBox.PerformLayout();
            this.EditDocumentListPanel.ResumeLayout(false);
            this.EditDocumentListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentsDataGrid)).EndInit();
            this.DocumentsInListGroupBox.ResumeLayout(false);
            this.DocumentsInListGroupBox.PerformLayout();
            this.UsersGroupBox.ResumeLayout(false);
            this.UsersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).EndInit();
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem ChooseActionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateNewDocumentListToolStripMenuItem;
        private System.Windows.Forms.GroupBox CreateDocumentBox;
        private System.Windows.Forms.TextBox DocumentNameTextBox;
        private System.Windows.Forms.Label DocumentNameLabel;
        private System.Windows.Forms.Label OriginLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button CreateDocumentBtn;
        private System.Windows.Forms.ToolStripMenuItem EditDocumentListToolStripMenuItem;
        private System.Windows.Forms.ComboBox DocumentListComboBox;
        private System.Windows.Forms.Label ChooseDocumentListLabel;
        private ToolStripMenuItem DocumentToolStripMenuItem;
        private ToolStripMenuItem CreateNewDocumentToolStripMenuItem;
        private ToolStripMenuItem UserToolStripMenuItem;
        private ToolStripMenuItem AddNewUserToolStripMenuItem;
        private GroupBox CreateDocumentListGroupBox;
        private Button CreateListBtn;
        private TextBox DocumentListNameTextBox;
        private Label DocumentListNameLabel;
        private GroupBox CreateUserGroupBox;
        private Label BirthdayDateTimePickerLabel;
        private DateTimePicker BirthdayDateTimePicker;
        private TextBox UserLastNameTextBox;
        private Label UserLastNameLabel;
        private TextBox UserNameTextBox;
        private Label UserNameLabel;
        private Button AddUserBtn;
        private GroupBox EditDocumentListGroupBox;
        private Button ShowDocumentListBtn;
        private Button DeleteDocumentListBtn;
        private Button RenameDocumentListBtn;
        private DataGridView DocumentsDataGrid;
        private GroupBox DocumentsInListGroupBox;
        private Button EditDocumentBtn;
        private Button DeleteDocumentBtn;
        private ToolStripMenuItem ShowUsersToolStripMenuItem;
        private GroupBox UsersGroupBox;
        private DataGridView UsersDataGrid;
        private Label UserLabel;
        private ComboBox UserListComboBox;
        private DataGridView DocumentListsDataGrid;
        private Button DeleteUserBtn;
        private Button EditUserBtn;
        private Panel StartPanel;
        private Label FirstMessageLabel;
        private Button PremiumUserBtn;
        private Button DefaultUserBtn;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox UserNickNameTextBox;
        private Label NickNameLabel;
        private Label DocTermOfImplementationLabel;
        private Label DocDegreeOfPubLabel;
        private Label DocOriginLabel;
        private ComboBox NameComboBox;
        private ComboBox DegreeOfPublicityComboBox;
        private ComboBox OriginComboBox;
        private Label DocNameLabel;
        private ComboBox TermOfImplementationComboBox;
        private ToolStripMenuItem AddStampToolStripMenuItem;
        private ComboBox SelectUserForListsComboBox;
        private Button BackToCreatingDocumentListBtn;
        private Label ListNameLabel;
        private TextBox ListNameTextBox;
        private Label ChooseUserLabel;
        private Panel EditDocumentListPanel;
        private Label ChooseUserForDocumentLabel;
        private ComboBox SelectUserForDocumentComboBox;
        private Button BackToListsBtn;
        private Label NameOfDocumentLabel;
        private ComboBox DocumentTypeNameToChangeComboBox;
        private Label DocumentTermOfImplementationLabel;
        private ComboBox DocumentTypeTermOfImplementationToChangeComboBox;
        private Label DocumentDegreeOfPublicityLabel;
        private ComboBox DocumentTypeDegreeOfPublicityToChangeComboBox;
        private Label DocumentOriginLabel;
        private ComboBox DocumentTypeOriginToChangeComboBox;
        private TextBox DocumentNameToChangeTextBox;
        private Label DocumentNameToChangeLabel;
        private Button BackToUserCreatingBtn;
        private TextBox UserNickNameToEditTextBox;
        private Label UserNickNameLabel;
        private Label label10;
        private DateTimePicker UserBirthdayDateToEditTimePicker;
        private TextBox UserLastNameToEditTextBox;
        private Label LastNameLabel;
        private TextBox UserNameToEditTextBox;
        private Label NameOfUserLabel;
        private ToolStripMenuItem AdditionalFunctionsToolStripMenuItem;
        private CheckBox IsPremiumCheckBox;
    }
}

