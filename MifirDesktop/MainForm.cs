using System.ComponentModel;
using System.Diagnostics;
using System.Resources;

namespace MifirDesktop
{
    public partial class MainForm : Form
    {
        private readonly ResourceManager rm = new(typeof(MainForm));
        private string errorResult = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            lblSearch.Visible = false;
            tbxSearch.Visible = false;
            btnExportToTextFile.Enabled = false;
            btnCancel.Enabled = false;
            tbxCsvFilePath.Text = rm.GetString($@"MifirDataFilePath");
            if (string.IsNullOrEmpty(tbxCsvFilePath.Text))
            {
                tbxCsvFilePath.Text = @"C:/Workplace/Winforms/MifirDesktop/bin/Debug/net6.0-windows/MiFirDataFinal.csv";
            }
        }

        private void btnValidate_Click_1(object sender, EventArgs e)
        {
          //  backgroundWorker1.CancellationPending = true;
            btnBrowseCsvFile.Enabled = false;
            btnValidate.Enabled = false;
            progressBar1.Visible = true;
            btnCancel.Enabled = true;
            Application.DoEvents();
            backgroundWorker1.RunWorkerAsync();
            while (backgroundWorker1.IsBusy)
            {
                Application.DoEvents();
            }
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            PopulateDataGrid();
            if (backgroundWorker1.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            progressBar1.Visible = false;
            lblSearch.Visible = true;
            tbxSearch.Visible = true;
            btnExportToTextFile.Enabled = true;

            var errorList = errorResult.Split("\n").ToList();
            errorList.RemoveAt(errorList.Count - 1);

            dataGridErrorResults.DataSource = errorList.Select(x => new { Error = x }).ToList();

            dataGridErrorResults.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridErrorResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridErrorResults.AllowUserToOrderColumns = true;
            dataGridErrorResults.AllowUserToResizeColumns = true;
            dataGridErrorResults.AllowUserToResizeRows = true;
            dataGridErrorResults.ScrollBars = ScrollBars.Both;
            dataGridErrorResults.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridErrorResults.ContextMenuStrip = new ContextMenuStrip();
            dataGridErrorResults.ContextMenuStrip.Items.Add("Copy").Click += (_, _) => Clipboard.SetText(dataGridErrorResults.GetClipboardContent()?.GetText() ?? throw new InvalidOperationException());

            dataGridErrorResults.Refresh();
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void btnBrowseCsvFile_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbxCsvFilePath.Text = openFileDialog.FileName;
            }
        }

        private void PopulateDataGrid()
        {
            var mifirDataObject = CsvXmlHelper.SaveToListFromCsv(tbxCsvFilePath.Text, worker: backgroundWorker1);
            var xmlTextFromMifirObject = CsvXmlHelper.SerializeObject(mifirDataObject);
            var xsdSchemaFile = rm.GetObject("MifirConstraintFile3");
            Debug.Assert(xsdSchemaFile != null, nameof(xsdSchemaFile) + " != null");
            Parallel.Invoke(
                () =>
                    {
                        errorResult = CsvXmlHelper.XmlSchemaVerification(xmlTextFromMifirObject, xsdSchemaFile.ToString() ?? throw new InvalidOperationException(), worker: backgroundWorker1);
                    }
                );
            //errorResult = CsvXmlHelper.XmlSchemaVerification(xmlTextFromMifirObject, xsdSchemaFile.ToString() ?? throw new InvalidOperationException(), worker: backgroundWorker1);
        }

        private void btnExportErrorResults_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = @"Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, errorResult);
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchText = tbxSearch.Text;
            if (string.IsNullOrEmpty(searchText))
            {
                dataGridErrorResults.DataSource = null;
                return;
            }

            var errorList = errorResult.Split("\n").ToList();
            errorList.RemoveAt(errorList.Count - 1);

            var filteredErrorList = errorList.Where(x => x.Contains(searchText)).ToList();

            dataGridErrorResults.DataSource = filteredErrorList.Select(x => new { Error = x }).ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            btnBrowseCsvFile.Enabled = true;
            btnValidate.Enabled = true;
            btnCancel.Enabled = false;
            btnBrowseCsvFile.Enabled = true;
            btnValidate.Enabled = true;
            progressBar1.Visible = false;
            lblSearch.Visible = false;
            tbxSearch.Visible = false;
            btnExportToTextFile.Enabled = false;
        }
    }
}