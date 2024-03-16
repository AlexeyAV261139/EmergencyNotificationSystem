using ENS.ExcelParser;
using ENS.ExcelParser.Interfaces;
using System.Data;

namespace ENS.View
{
    public partial class GetContactsForm : Form
    {
        public GetContactsForm()
        {
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            var filePath = GetPathPathFromDialog();
            if (filePath != "")
            {
                filePathTextBox.Text = filePath;
            }
        }

        private string GetPathPathFromDialog()
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "װאיכû xlsx|*.xlsx";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                return OPF.FileName;
            }
            return "";
        }

        private void GetContactsButton_Click(object sender, EventArgs e)
        {
            string path = filePathTextBox.Text;
            IContactsGetter contactsGetter = new ContactsFromExcelGetter(path);

            DataSet userContacts = contactsGetter.GetContactsAsDataSet();

            userContactsDataGridView.DataSource = userContacts.Tables[0];
        }
    }
}
