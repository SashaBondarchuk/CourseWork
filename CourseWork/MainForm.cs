using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        #region Form
        public MainForm()
        {
            InitializeComponent();
            string pathToUsers = @"..\..\..\users.txt";
            string pathToDocuments = @"..\..\..\documents.txt";
            string pathToDocumentLists = @"..\..\..\documentLists.txt";
            string pathToStamps = @"..\..\..\stamps.txt";

            if (!File.Exists(pathToUsers) || !File.Exists(pathToDocuments) || !File.Exists(pathToDocumentLists) || !File.Exists(pathToStamps))
            {
                File.Delete(pathToUsers);
                File.Delete(pathToDocuments);
                File.Delete(pathToDocumentLists);
                File.Delete(pathToStamps);

                File.AppendAllText(pathToUsers, "Ім'я | Прізвище | Нікнейм | Дата Народження | Тип | Кількість списків | Id\n");
                File.AppendAllText(pathToDocuments, "Назва документа | Дата створення | Id Списку | Унікальна відмітка | Тип | Id\n");
                File.AppendAllText(pathToDocumentLists, "Назва списку | Id Користувача | Нікнейм | Id\n");
                File.AppendAllText(pathToStamps, "Назва документа | Термін дії відмітки | Id відмітки | Id документа\n");
            }
            FillDataFromTxt();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            menu.Visible = false;
            StartPanel.Location = new Point(5, 5);
        }
        private void HideAllElements()
        {
            CreateDocumentBox.Visible = false;
            CreateUserGroupBox.Visible = false;
            CreateDocumentListGroupBox.Visible = false;
            EditDocumentListGroupBox.Visible = false;
            DocumentsInListGroupBox.Visible = false;
            UsersGroupBox.Visible = false;
            StartPanel.Visible = false;
        }
        #endregion


        #region Refresh Functions
        private void RefreshDocumentList()
        {
            if ((User)SelectUserForDocumentComboBox.SelectedItem != null)
                DocumentListComboBox.DataSource = ((User)SelectUserForDocumentComboBox.SelectedItem).DocumentLists.ToList();
        }
        private void RefreshDataGrid()
        {
            DocumentListsDataGrid.DataSource = ((User)SelectUserForListsComboBox.SelectedItem).DocumentLists.ToList();
            DocumentListsDataGrid.Columns[0].HeaderText = "Список";
            DocumentListsDataGrid.Columns[1].HeaderText = "Користувач";
            DocumentListsDataGrid.Columns[2].Visible = false;
        }
        private void RefreshTextBoxes()
        {
            if (DocumentListsDataGrid.SelectedRows.Count != 0)
            {
                ListNameTextBox.Text = DocumentListsDataGrid[0, DocumentListsDataGrid.SelectedRows[0].Index].Value.ToString();
            }
        }
        private void RefreshTextBoxesForDocumentEditing()
        {
            if (DocumentsDataGrid.SelectedRows.Count != 0)
            {
                DocumentNameToChangeTextBox.Text = ((Document)DocumentsDataGrid.SelectedRows[0].DataBoundItem).Name;
            }
        }
        private void RefreshTextBoxesForUserEditing()
        {
            if (UsersDataGrid.SelectedRows.Count != 0)
            {
                UserNameToEditTextBox.Text = ((User)UsersDataGrid.SelectedRows[0].DataBoundItem).FirstName;
                UserLastNameToEditTextBox.Text = ((User)UsersDataGrid.SelectedRows[0].DataBoundItem).LastName;
                UserNickNameToEditTextBox.Text = ((User)UsersDataGrid.SelectedRows[0].DataBoundItem).UserName;
                UserBirthdayDateToEditTimePicker.Value = ((User)UsersDataGrid.SelectedRows[0].DataBoundItem).BirthdayDate;
            }
        }
        private void RefreshDocuments()
        {
            DocumentsDataGrid.DataSource = ((DocumentList)DocumentListsDataGrid.SelectedRows[0].DataBoundItem).Documents;
            DocumentsDataGrid.Columns[0].HeaderText = "Ім'я";
            DocumentsDataGrid.Columns[1].HeaderText = "Дата\nстворення";
            DocumentsDataGrid.Columns[2].HeaderText = "Список";
            DocumentsDataGrid.Columns[3].HeaderText = "Унікальна\nвідмітка";
            DocumentsDataGrid.Columns[4].HeaderText = "Тип\nдокумента";
            DocumentsDataGrid.Columns[5].HeaderText = "Id";
        }
        private void RefreshUsers()
        {
            SelectUserForDocumentComboBox.DataSource = User.Items.Values.Where(user => user.DocumentLists.Count != 0).ToList();
            SelectUserForListsComboBox.DataSource = User.Items.Values.Where(user => user.DocumentLists.Count != 0).ToList();
            UsersDataGrid.DataSource = User.Items.Values.ToList();
            UserListComboBox.DataSource = User.Items.Values.ToList();
            UsersDataGrid.Columns[0].HeaderText = "Ім'я";
            UsersDataGrid.Columns[1].HeaderText = "Прізвище";
            UsersDataGrid.Columns[2].HeaderText = "Нікнейм";
            UsersDataGrid.Columns[3].HeaderText = "Дата\nнародження";
            UsersDataGrid.Columns[4].HeaderText = "Tип";
            UsersDataGrid.Columns[5].Visible = false;
            UsersDataGrid.Columns[6].HeaderText = "Кількість\nсписків";
            UsersDataGrid.Columns[7].Visible = false;
        }
        #endregion


        #region Reset Functions
        private void ResetUserCreateForm()
        {
            UserNickNameTextBox.Text = "";
            UserLastNameTextBox.Text = "";
            UserNameTextBox.Text = "";
        }
        private void ResetUserEditForm()
        {
            UserNameToEditTextBox.Text = "";
            UserLastNameToEditTextBox.Text = "";
            UserNickNameToEditTextBox.Text = "";
        }
        private void ResetDocumentEditForm()
        {
            DocumentTypeDegreeOfPublicityToChangeComboBox.SelectedIndex = -1;
            DocumentTypeOriginToChangeComboBox.SelectedIndex = -1;
            DocumentTypeTermOfImplementationToChangeComboBox.SelectedIndex = -1;
        }
        #endregion

        #region Text Documents
        private void FillDataFromTxt()
        {
            User.FillUsers();
            DocumentList.FillDocumentLists();
            Document.FillDocuments();
            Stamp.FillStamps();
        }
        #endregion

        #region ToolStripMenuItem Click
        private void CreateNewDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DocumentList.Items.Count == 0)
            {
                MessageBox.Show(
                   "Для роботи з документами спочатку створіть список!",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ActiveForm.Size = new Size(530, 820);
                CreateDocumentBox.Location = new Point(12, 32);
                HideAllElements();
                RefreshUsers();
                RefreshDocumentList();
                DocumentNameTextBox.Text = "";
                CreateDocumentBox.Visible = Visible;
            }
        }
        private void CreateNewDocumentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.Items.Count == 0)
            {
                MessageBox.Show(
                    "Для роботи зі списками докуметів спочатку створіть принаймні\nодного користувача!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RefreshUsers();
                ActiveForm.Size = new Size(530, 395);
                HideAllElements();
                CreateDocumentListGroupBox.Visible = Visible;
                CreateDocumentListGroupBox.Location = new Point(12, 40);
            }
        }
        private void AddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllElements();
            menu.Visible = false;
            ActiveForm.Size = new Size(680, 492);
            StartPanel.Visible = Visible;
            CreateUserGroupBox.Location = new Point(12, 40);
        }
        private void EditDocumentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.Items.Count == 0)
            {
                MessageBox.Show(
                    "Для роботи зі списками докуметів спочатку створіть принаймні\nодного користувача!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DocumentList.Items.Count == 0)
            {
                MessageBox.Show(
                    "Для роботи зі списками докуметів спочатку створіть список!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HideAllElements();
            DocumentList.RefreshDocumentListsTxt();
            RefreshUsers();
            RefreshDataGrid();

            ActiveForm.Size = new Size(980, 505);
            EditDocumentListGroupBox.Visible = Visible;
            EditDocumentListGroupBox.Location = new Point(12, 40);
        }
        private void AdditionalFunctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdditionalOptionsForm().Show();
        }
        private void ShowUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (User.Items.Count == 0)
            {
                MessageBox.Show(
                    "Список користувачів пустий! Додайте нового користувача\nщоб продовжити роботу.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UsersGroupBox.Location = new Point(12, 40);
                ActiveForm.Size = new Size(965, 590);
                HideAllElements();
                RefreshUsers();
                UsersGroupBox.Visible = Visible;
            }
        }
        private void AddStampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DocumentList.Items.Count == 0)
            {
                MessageBox.Show(
                   "Для роботи з документами спочатку створіть список!", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Document.Items.Values.Where(document => document.Stamp == null).Count() > 0)
            {
                new AddStampForm().ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "Наразі немає необхідності додавати унікальну мітку!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        #endregion


        #region Document
        private void CreateDocumentBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(DocumentNameTextBox.Text))
            { 
                MessageBox.Show(
                   "Введіть назву документа!",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Regex regex = new Regex(@"^\S*$");
            if (!regex.IsMatch(DocumentNameTextBox.Text))
            {
                MessageBox.Show(
                    "В полі для вводу назви не може бути пробілів!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (((DocumentList)DocumentListComboBox.SelectedItem).Documents.Where(document => document.Name == DocumentNameTextBox.Text).Count() > 0)
            {
                MessageBox.Show(
                    $"Документ з такою назвою вже існує в списку {DocumentListComboBox.SelectedItem}.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DocumentNameTextBox.Text = "";
                return;
            }
            if (NameComboBox.SelectedItem == null)
            {
                MessageBox.Show(
                 "Виберіть найменування документа!",
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new Document()
            {
                Name = DocumentNameTextBox.Text,
                DocumentList = (DocumentList)DocumentListComboBox.SelectedItem,
                DocType = new DocumentType()
                {
                    ByName = NameComboBox.SelectedItem?.ToString() ?? "",
                    ByTermOfImplementation = TermOfImplementationComboBox.SelectedItem?.ToString() ?? "",
                    ByOrigin = OriginComboBox.SelectedItem?.ToString() ?? "",
                    ByDegreeOfPublicity = DegreeOfPublicityComboBox.SelectedItem?.ToString() ?? ""
                }
            };
            new AddStampForm().ShowDialog();
            Document.RefreshDocumentsTxt();

            DocumentNameTextBox.Text = "";
            NameComboBox.SelectedIndex = -1;
            TermOfImplementationComboBox.SelectedIndex = -1;
            OriginComboBox.SelectedIndex = -1;
            DegreeOfPublicityComboBox.SelectedIndex = -1;
        }
        private void EditDocumentBtn_Click(object sender, EventArgs e)
        {
            if (((DocumentList)DocumentListsDataGrid.SelectedRows[0].DataBoundItem).Documents.Count == 0)
            {
                MessageBox.Show(
                     $"Список документів {((DocumentList)DocumentListsDataGrid.SelectedRows[0].DataBoundItem).Name} пустий! Для роботи з документами\nдодайте документи у список.",
                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(DocumentNameToChangeTextBox.Text))
            {
                MessageBox.Show(
                     "Документ має мати назву!",
                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RefreshTextBoxesForDocumentEditing();
                return;
            }
            Regex regex = new Regex(@"^\S*$");
            if (!regex.IsMatch(DocumentNameToChangeTextBox.Text))
            {
                MessageBox.Show(
                    "В полі для вводу назви не може бути пробілів!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (((DocumentList)DocumentListsDataGrid.SelectedRows[0].DataBoundItem).Documents.Where(document => document.Name == DocumentNameToChangeTextBox.Text
                    && document.Name != ((Document)DocumentsDataGrid.SelectedRows[0].DataBoundItem).Name).Count() > 0)
            {
                MessageBox.Show(
                    "Документ з такою назвою вже існує у цьому списку!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RefreshTextBoxesForDocumentEditing();
                return;
            }
            DialogResult dialogResult = MessageBox.Show(
                                                  $"Ви дійсно хочете змінити документ {((Document)DocumentsDataGrid.SelectedRows[0].DataBoundItem).Name}?",
                                                  "Submit action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                ((Document)DocumentsDataGrid.SelectedRows[0].DataBoundItem).Name = DocumentNameToChangeTextBox.Text;
                ((Document)DocumentsDataGrid.SelectedRows[0].DataBoundItem).DocType.ByName = DocumentTypeNameToChangeComboBox.SelectedItem?.ToString() ?? "";
                ((Document)DocumentsDataGrid.SelectedRows[0].DataBoundItem).DocType.ByDegreeOfPublicity = DocumentTypeDegreeOfPublicityToChangeComboBox.SelectedItem?.ToString() ?? "";
                ((Document)DocumentsDataGrid.SelectedRows[0].DataBoundItem).DocType.ByOrigin = DocumentTypeOriginToChangeComboBox.SelectedItem?.ToString() ?? "";
                ((Document)DocumentsDataGrid.SelectedRows[0].DataBoundItem).DocType.ByTermOfImplementation = DocumentTypeTermOfImplementationToChangeComboBox.SelectedItem?.ToString() ?? "";
                RefreshDocuments();
                Document.RefreshDocumentsTxt();
            }

        }
        private void DeleteDocumentBtn_Click(object sender, EventArgs e)
        {
            if (((DocumentList)DocumentListsDataGrid.SelectedRows[0].DataBoundItem).Documents.Count == 0)
            {
                MessageBox.Show(
                     $"Список документів {((DocumentList)DocumentListsDataGrid.SelectedRows[0].DataBoundItem).Name} пустий!\nДля роботи з документами додайте документи у список.",
                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(
                    $"Ви дійсно хочете видалити документ {((Document)DocumentsDataGrid.SelectedRows[0].DataBoundItem).Name}?",
                    "Submit action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Document.Items.Remove(((Document)DocumentsDataGrid.SelectedRows[0].DataBoundItem).Id);
                    Stamp.Items.Remove(((Document)DocumentsDataGrid.SelectedRows[0].DataBoundItem).Stamp.Id);
                    DocumentType.Items.Remove(((Document)DocumentsDataGrid.SelectedRows[0].DataBoundItem).DocType.Id);
                    RefreshDocuments();
                    Stamp.RefreshStampsTxt();
                    Document.RefreshDocumentsTxt();
                }
            }

        }
        private void DocumentsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            RefreshTextBoxesForDocumentEditing();
            if (DocumentsDataGrid.SelectedRows.Count != 0)
                DocumentTypeNameToChangeComboBox.SelectedIndex = DocumentTypeNameToChangeComboBox.Items.IndexOf(((Document)DocumentsDataGrid.SelectedRows[0].DataBoundItem).DocType.ByName);
            ResetDocumentEditForm();
            if (DocumentsDataGrid.SelectedRows.Count == 0)
            {
                DocumentTypeNameToChangeComboBox.SelectedIndex = -1;
                DocumentNameToChangeTextBox.Text = "";
            }
        }
        private void ShowDocumentListBtn_Click(object sender, EventArgs e)
        {
            if (((User)SelectUserForListsComboBox.SelectedItem).DocumentLists.Count == 0)
            {
                MessageBox.Show(
                    $"Списки докуметів користувача {(User)SelectUserForListsComboBox.SelectedItem} порожні!\nСтворіть новий список, щоб продовжити роботу.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (((DocumentList)DocumentListsDataGrid.SelectedRows[0].DataBoundItem).Documents.Count == 0)
            {
                MessageBox.Show(
                     $"Список документів {((DocumentList)DocumentListsDataGrid.SelectedRows[0].DataBoundItem).Name} пустий! Для роботи з документами\nдодайте документи у список.",
                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (((DocumentList)DocumentListsDataGrid.SelectedRows[0].DataBoundItem).Documents.Where(document => document.Stamp == null).Count() > 0)
            {
                MessageBox.Show(
                     "Не всі документи у списку містять унікальну відмітку.\nЩоб завершити створення документу/документів,\nдодайте унікальну відмітку.",
                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RefreshDocuments();
            ActiveForm.Size = new Size(1090, 625);
            DocumentsInListGroupBox.Location = new Point(12, 40);
            HideAllElements();
            DocumentsInListGroupBox.Visible = Visible;
        }
        private void SelectUserForDocumentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDocumentList();
        }
        #endregion


        #region DocumentList
        private void CreateListBtn_Click(object sender, EventArgs e)
        {
            if(((User)UserListComboBox.SelectedItem).ListCount >= ((User)UserListComboBox.SelectedItem).AllowedCountOfLists)
            {
                MessageBox.Show(
                    "Увага, простий користувач може створити не більше 10 списків!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(DocumentListNameTextBox.Text))
            {
                MessageBox.Show(
                    "Введіть назву списку!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Regex regex = new Regex(@"^\S*$");
            if (!regex.IsMatch(DocumentListNameTextBox.Text))
            {
                MessageBox.Show(
                    "В полі для вводу назви не може бути пробілів!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (((User)UserListComboBox.SelectedItem).DocumentLists.Where(docList => docList.Name == DocumentListNameTextBox.Text).Count() > 0)
            {
                MessageBox.Show(
                    $"Список у користувача {UserListComboBox.SelectedItem} з такою назвою вже існує!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                DocumentListNameTextBox.Text = "";
                return;
            }
            new DocumentList(User: (User)UserListComboBox.SelectedItem, Name: DocumentListNameTextBox.Text);
            User.RefreshUsersTxt();
            DocumentList.RefreshDocumentListsTxt();
            RefreshDocumentList();
            MessageBox.Show(
                "Список створено успішно!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DocumentListNameTextBox.Text = "";
        }
        private void DeleteDocumentListBtn_Click(object sender, EventArgs e)
        {
            if (((User)SelectUserForListsComboBox.SelectedItem).DocumentLists.Count == 0)
            {
                MessageBox.Show(
                    $"Списки докуметів користувача {(User)SelectUserForListsComboBox.SelectedItem} порожні! Створіть новий\nсписок, щоб продовжити роботу.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show(
                    $"Ви дійсно хочете видалити список {((DocumentList)DocumentListsDataGrid.SelectedRows[0].DataBoundItem).Name}?",
                    "Submit action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (((DocumentList)DocumentListsDataGrid.SelectedRows[0].DataBoundItem).Documents.Count > 0)
                {
                    var documentsToDelete = ((DocumentList)DocumentListsDataGrid.SelectedRows[0].DataBoundItem).Documents.ToList();
                    foreach (var document in documentsToDelete)
                    {
                        if (document.Stamp != null)
                        {
                            Stamp.Items.Remove(document.Stamp.Id);
                        }
                        Stamp.RefreshStampsTxt();
                        DocumentType.Items.Remove(document.DocType.Id);
                        Document.Items.Remove(document.Id);
                        Document.RefreshDocumentsTxt();
                    }
                }
                DocumentList.Items.Remove(((DocumentList)DocumentListsDataGrid.SelectedRows[0].DataBoundItem).Id);
                ((DocumentList)DocumentListsDataGrid.SelectedRows[0].DataBoundItem).User.ListCount--;

                if (((User)SelectUserForListsComboBox.SelectedItem).DocumentLists.Count == 0)
                    ListNameTextBox.Text = "";

                DocumentList.RefreshDocumentListsTxt();
                RefreshDataGrid();
            }
        }
        private void RenameDocumentListBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ListNameTextBox.Text))
            {
                if (DocumentListsDataGrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        $"Списки документів користувача {(User)SelectUserForListsComboBox.SelectedItem} пусті!",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ListNameTextBox.Text = "";
                    return;
                }
                Regex regex = new Regex(@"^\S*$");
                if (!regex.IsMatch(ListNameTextBox.Text))
                {
                    MessageBox.Show(
                        "В полі для вводу назви не може бути пробілів!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (((User)SelectUserForListsComboBox.SelectedItem).DocumentLists.Where(docList => docList.Name == ListNameTextBox.Text).Count() > 0)
                {
                    MessageBox.Show(
                        "Список з такою назвою вже існує у цього користувача!",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RefreshTextBoxes();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show(
                            $"Ви точно хочете змінити назву списка '{((DocumentList)DocumentListsDataGrid.SelectedRows[0].DataBoundItem).Name}' на '{ListNameTextBox.Text}' ",
                            "Submit action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ((DocumentList)DocumentListsDataGrid.SelectedRows[0].DataBoundItem).Name = ListNameTextBox.Text;
                    RefreshDataGrid();
                    DocumentList.RefreshDocumentListsTxt();
                }
            }
            else
            {
                MessageBox.Show(
                    "Список має мати назву!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RefreshTextBoxes();
            }
        }
        private void SelectUserForListsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
        private void DocumentListsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (((User)SelectUserForListsComboBox.SelectedItem).DocumentLists.Count != 0)
            {
                RefreshTextBoxes();
            }
        }
        #endregion


        #region User
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserNameTextBox.Text) || string.IsNullOrWhiteSpace(UserLastNameTextBox.Text) || string.IsNullOrWhiteSpace(UserNickNameTextBox.Text))
            {
                MessageBox.Show(
                    "Щоб створити користувача, заповніть всі поля!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Regex regex = new Regex(@"^\S*$");
            if (!regex.IsMatch(UserNameTextBox.Text) || !regex.IsMatch(UserLastNameTextBox.Text) || !regex.IsMatch(UserNickNameTextBox.Text))
            {
                MessageBox.Show(
                    "В полях для вводу даних не може бути пробілів!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (User.Items.Values.Where(item => item.UserName == UserNickNameTextBox.Text).Count() > 0)
            {
                MessageBox.Show(
                    "Користувач з таким нікнеймом вже існує!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserNickNameTextBox.Text = "";
                return;
            }
            if (IsPremiumCheckBox.Checked == false)
            {
                new User()
                {
                    FirstName = UserNameTextBox.Text,
                    LastName = UserLastNameTextBox.Text,
                    BirthdayDate = BirthdayDateTimePicker.Value,
                    UserName = UserNickNameTextBox.Text
                };
                RefreshUsers();
                MessageBox.Show(
                    "Користувача створено успішно!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetUserCreateForm();
                User.RefreshUsersTxt();
            }
            else
            {
                new PremiumUser()
                {
                    FirstName = UserNameTextBox.Text,
                    LastName = UserLastNameTextBox.Text,
                    BirthdayDate = BirthdayDateTimePicker.Value,
                    UserName = UserNickNameTextBox.Text
                };
                RefreshUsers();
                MessageBox.Show(
                    "Користувача створено успішно!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetUserCreateForm();
                User.RefreshUsersTxt();
            }
        }
        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            if (User.Items.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(UserNameToEditTextBox.Text))
                {
                    MessageBox.Show(
                         "Користувач має мати ім'я!",
                         "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RefreshTextBoxesForUserEditing();
                    return;
                }
                if (string.IsNullOrWhiteSpace(UserLastNameToEditTextBox.Text))
                {
                    MessageBox.Show(
                     "Користувач має мати прізвище!",
                     "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RefreshTextBoxesForUserEditing();
                    return;
                }
                if (string.IsNullOrWhiteSpace(UserNickNameToEditTextBox.Text))
                {
                    MessageBox.Show(
                        "Користувач має мати нікнейм!",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RefreshTextBoxesForUserEditing();
                    return;
                }
                if (User.Items.Values.Where(user => user.UserName == UserNickNameToEditTextBox.Text
                            && UserNickNameToEditTextBox.Text != ((User)UsersDataGrid.SelectedRows[0].DataBoundItem).UserName).Count() > 0)
                {
                    MessageBox.Show(
                    "Користувач з таким нікнеймом вже існує!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RefreshTextBoxesForUserEditing();
                    return;
                }
                Regex regex = new Regex(@"^\S*$");
                if (!regex.IsMatch(UserNameToEditTextBox.Text) || !regex.IsMatch(UserLastNameToEditTextBox.Text) || !regex.IsMatch(UserNickNameToEditTextBox.Text))
                {
                    MessageBox.Show(
                        "В полях для вводу даних не може бути пробілів!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult dialogResult = MessageBox.Show(
                                                 $"Ви дійсно хочете змінити користувача {((User)UsersDataGrid.SelectedRows[0].DataBoundItem).UserName}?",
                                                 "Submit action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    ((User)UsersDataGrid.SelectedRows[0].DataBoundItem).FirstName = UserNameToEditTextBox.Text;
                    ((User)UsersDataGrid.SelectedRows[0].DataBoundItem).LastName = UserLastNameToEditTextBox.Text;
                    ((User)UsersDataGrid.SelectedRows[0].DataBoundItem).UserName = UserNickNameToEditTextBox.Text;
                    ((User)UsersDataGrid.SelectedRows[0].DataBoundItem).BirthdayDate = UserBirthdayDateToEditTimePicker.Value;
                    User.RefreshUsersTxt();
                    DocumentList.RefreshDocumentListsTxt();
                    RefreshUsers();
                }
            }
            else
            {
                MessageBox.Show(
                    "Створіть нових користувачів, щоб мати змогу їх редагувати!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            if (User.Items.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show(
                   $"Ви дійсно хочете видалити користувача {((User)UsersDataGrid.SelectedRows[0].DataBoundItem).UserName}?\n" +
                   $"Це спричинить видалення всіх списків і документів у цих списках.",
                   "Submit action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var documentListsToDelete = DocumentList.Items.Values.Where(docList => docList.User == (User)UsersDataGrid.SelectedRows[0].DataBoundItem).ToList();
                    foreach (var docList in documentListsToDelete)
                    {
                        if (docList.Documents.Count > 0)
                        {
                            var documentsToDelete = docList.Documents.ToList();
                            foreach (var document in documentsToDelete)
                            {
                                if (document.Stamp != null)
                                {
                                    Stamp.Items.Remove(document.Stamp.Id);
                                    Stamp.RefreshStampsTxt();
                                }
                                DocumentType.Items.Remove(document.DocType.Id);
                                Document.Items.Remove(document.Id);
                                Document.RefreshDocumentsTxt();
                            }
                        }
                        DocumentList.Items.Remove(docList.Id);
                    }
                    User.Items.Remove(((User)UsersDataGrid.SelectedRows[0].DataBoundItem).Id);

                    User.RefreshUsersTxt();
                    DocumentList.RefreshDocumentListsTxt();
                    RefreshUsers();

                    if (UsersDataGrid.SelectedRows.Count == 0)
                    {
                        ResetUserEditForm();
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Створіть нових користувачів, щоб мати змогу їх редагувати!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void DefaultUserBtn_Click(object sender, EventArgs e)
        {
            menu.Visible = true;
            StartPanel.Visible = false;
            ActiveForm.Size = new Size(535, 570);
            ResetUserCreateForm();
            CreateUserGroupBox.Visible = Visible;
            CreateUserGroupBox.Location = new Point(12, 40);
            CreateUserGroupBox.Text = "Створення користувача";
            IsPremiumCheckBox.Checked = false;
            IsPremiumCheckBox.Enabled = false;
            BirthdayDateTimePicker.CustomFormat = "dd/MM/yyyy";
            AddUserBtn.Text = "Додати користувача";
        }
        private void PremiumUserBtn_Click(object sender, EventArgs e)
        {
            menu.Visible = true;
            StartPanel.Visible = false;
            ActiveForm.Size = new Size(535, 570);
            ResetUserCreateForm();
            CreateUserGroupBox.Visible = Visible;
            CreateUserGroupBox.Location = new Point(12, 40);
            CreateUserGroupBox.Text = "Створення преміум користувача";
            IsPremiumCheckBox.Checked = true;
            IsPremiumCheckBox.Enabled = false;
            AddUserBtn.Text = "Додати преміум\nкористувача";
        }
        private void UsersDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            RefreshTextBoxesForUserEditing();
            if (UsersDataGrid.SelectedRows.Count == 0)
            {
                ResetUserEditForm();
            }
        }
        #endregion


        #region Back Buttons
        private void BackToCreatingDocumentListBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Size = new Size(530, 395);
            HideAllElements();
            CreateDocumentListGroupBox.Visible = Visible;
            CreateDocumentListGroupBox.Location = new Point(12, 40);
        }
        private void BackToUserCreatingBtn_Click(object sender, EventArgs e)
        {
            HideAllElements();
            menu.Visible = true;
            StartPanel.Visible = false;
            ActiveForm.Size = new Size(535, 570);
            ResetUserCreateForm();
            CreateUserGroupBox.Visible = Visible;
            CreateUserGroupBox.Location = new Point(12, 40);
        }
        private void BackToListsBtn_Click(object sender, EventArgs e)
        {
            HideAllElements();
            ActiveForm.Size = new Size(970, 510);
            EditDocumentListGroupBox.Visible = Visible;
            EditDocumentListGroupBox.Location = new Point(12, 40);
        }
        #endregion
    }
}
