using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CourseWork.Data;

namespace CourseWork
{
    public partial class AddStampForm : Form
    {
        public AddStampForm()
        {
            InitializeComponent();
        }

        private void RefreshLists()
        {
            ChooseDocumentListComboBox.DataSource = DocumentList.Items.Values.Where(docList => docList.Documents.Count() != 0 
                && docList.Documents.Where(document => document.Stamp == null).Count() != 0).ToList();
            ChooseDocumentComboBox.DataSource = ((DocumentList)ChooseDocumentListComboBox.SelectedItem).Documents.Where(document => document.Stamp == null).ToList();
        }

        private void СreateStampBtn_Click(object sender, EventArgs e)
        {
            
            if (Stamp.Items.Values.Where(stamp => stamp.Document == ChooseDocumentComboBox.SelectedItem).Count() > 0)
            {
                DialogResult result = MessageBox.Show(
                    $"Унікальну відмітку для документу {ChooseDocumentComboBox.SelectedItem} вже було створено!",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
            }
            else
            {
                ((Document)ChooseDocumentComboBox.SelectedItem).Stamp = new Stamp()
                {
                    ExpirationDate = ExpirationDateTimePicker.Value,
                    Document = (Document)ChooseDocumentComboBox.SelectedItem,
                };
                Stamp.RefreshStampsTxt();
                Document.RefreshDocumentsTxt();
                MessageBox.Show(
                    "Документ створено успішно!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ChooseDocumentListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChooseDocumentComboBox.DataSource = ((DocumentList)ChooseDocumentListComboBox.SelectedItem).Documents.Where(document => document.Stamp == null).ToList();
        }

        private void AddStampForm_Load(object sender, EventArgs e)
        {
            RefreshLists();
        }
    }
}
