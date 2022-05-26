using System;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork
{
    public partial class AdditionalOptionsForm : Form
    {
        public AdditionalOptionsForm()
        {
            InitializeComponent();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            if(ChooseOptionComboBox.SelectedIndex == 0)
            {
                if (Document.DocumentsStampCount() > 0)
                {
                    MessageBox.Show(
                         "Не всі документи у списку містять унікальну відмітку.\nЩоб завершити створення документу/документів,\nдодайте унікальну відмітку.",
                         "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MainDataGrid.DataSource = null;
                    MainDataGrid.DataSource = Document.LongTermDocuments();
                    ShowDocumentsDataGrid();
                }
            }
            else if (ChooseOptionComboBox.SelectedIndex == 1)
            {
                MainDataGrid.DataSource = null;
                MainDataGrid.DataSource = User.AdultUsers();
                ShowUserDataGrid();
            }
            else if(ChooseOptionComboBox.SelectedIndex == 2)
            {
                MainDataGrid.DataSource = null;
                MainDataGrid.DataSource = User.UsersWithListCount();
                ShowUserDataGrid();
            }
            else if(ChooseOptionComboBox.SelectedIndex == 3)
            {
                MainDataGrid.DataSource = null;
                MainDataGrid.DataSource = User.UserWithoutDocuments();
                ShowUserDataGrid();
            }
            else if (ChooseOptionComboBox.SelectedIndex == 4)
            {
                MainDataGrid.DataSource = null;
                MainDataGrid.DataSource = PremiumUser.PremiumUsers();
                ShowUserDataGrid();
            }
            else if (ChooseOptionComboBox.SelectedIndex == 5)
            {
                MainDataGrid.DataSource = null;
                MainDataGrid.DataSource = User.OrdianryUsers();
                ShowUserDataGrid();
            }
            else if (ChooseOptionComboBox.SelectedIndex == 6)
            {
                MainDataGrid.DataSource = null;
                MainDataGrid.DataSource = User.AllUsers();
                ShowUserDataGrid();
            }
            else if (ChooseOptionComboBox.SelectedIndex == 7)
            {
                MainDataGrid.DataSource = null;
                MainDataGrid.DataSource = DocumentList.AllDocumentLists();
                ShowDocumentListsDataGrid();
            }
            else if (ChooseOptionComboBox.SelectedIndex == 8)
            {
                MainDataGrid.DataSource = null;
                MainDataGrid.DataSource = DocumentList.DocumentListsWithDocumentCount();
                ShowDocumentListsDataGrid();
            }
            else if (ChooseOptionComboBox.SelectedIndex == 9)
            {
                if (Document.DocumentsStampCount() > 0)
                {
                    MessageBox.Show(
                         "Не всі документи у списку містять унікальну відмітку.\nЩоб завершити створення документу/документів,\nдодайте унікальну відмітку.",
                         "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MainDataGrid.DataSource = null;
                    MainDataGrid.DataSource = Document.AllDocuments();
                    ShowDocumentsDataGrid();
                }
            }
            else
            {
                MessageBox.Show(
                   "Ви не вибрали дію!",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Показує таблицю користувачів.
        /// </summary>
        private void ShowUserDataGrid()
        {
            MainDataGrid.Columns[0].Name = "Name";
            MainDataGrid.Columns[0].HeaderText = "Ім'я";
            MainDataGrid.Columns[1].HeaderText = "Прізвище";
            MainDataGrid.Columns[2].HeaderText = "Нікнейм";
            MainDataGrid.Columns[3].HeaderText = "Дата\nнародження";
            MainDataGrid.Columns[4].HeaderText = "Tип";
            MainDataGrid.Columns[5].Visible = false;
            MainDataGrid.Columns[6].HeaderText = "Кількість\nсписків";
            MainDataGrid.Columns[7].Visible = false;
            MainDataGrid.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        /// <summary>
        /// Показує таблицю документів.
        /// </summary>
        private void ShowDocumentsDataGrid()
        {

            MainDataGrid.Columns[0].HeaderText = "Ім'я";
            MainDataGrid.Columns[1].HeaderText = "Дата\nстворення";
            MainDataGrid.Columns[2].HeaderText = "Список";
            MainDataGrid.Columns[3].HeaderText = "Унікальна\nвідмітка";
            MainDataGrid.Columns[4].HeaderText = "Тип\nдокумента";
            MainDataGrid.Columns[5].HeaderText = "Id";
        }

        /// <summary>
        /// Показує таблицю списків документів.
        /// </summary>
        private void ShowDocumentListsDataGrid()
        {
            MainDataGrid.Columns[0].HeaderText = "Список";
            MainDataGrid.Columns[1].HeaderText = "Користувач";
            MainDataGrid.Columns[2].Visible = false;
        }
    }
}
