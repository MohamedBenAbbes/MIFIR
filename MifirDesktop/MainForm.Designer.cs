namespace MifirDesktop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbxCsvFilePath = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblMifirCsv = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.dataGridErrorResults = new System.Windows.Forms.DataGridView();
            this.btnBrowseCsvFile = new System.Windows.Forms.Button();
            this.btnExportToTextFile = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridErrorResults)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxCsvFilePath
            // 
            this.tbxCsvFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCsvFilePath.Location = new System.Drawing.Point(244, 28);
            this.tbxCsvFilePath.Name = "tbxCsvFilePath";
            this.tbxCsvFilePath.Size = new System.Drawing.Size(585, 31);
            this.tbxCsvFilePath.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(50, 147);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1249, 38);
            this.progressBar1.TabIndex = 4;
            // 
            // lblMifirCsv
            // 
            this.lblMifirCsv.AutoSize = true;
            this.lblMifirCsv.Location = new System.Drawing.Point(50, 33);
            this.lblMifirCsv.Name = "lblMifirCsv";
            this.lblMifirCsv.Size = new System.Drawing.Size(188, 25);
            this.lblMifirCsv.TabIndex = 5;
            this.lblMifirCsv.Text = "Mifir CSV File Location";
            // 
            // btnValidate
            // 
            this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidate.Location = new System.Drawing.Point(952, 25);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(111, 35);
            this.btnValidate.TabIndex = 7;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click_1);
            // 
            // dataGridErrorResults
            // 
            this.dataGridErrorResults.AllowUserToOrderColumns = true;
            this.dataGridErrorResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridErrorResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridErrorResults.Location = new System.Drawing.Point(50, 193);
            this.dataGridErrorResults.Name = "dataGridErrorResults";
            this.dataGridErrorResults.RowHeadersWidth = 62;
            this.dataGridErrorResults.RowTemplate.Height = 33;
            this.dataGridErrorResults.Size = new System.Drawing.Size(1249, 392);
            this.dataGridErrorResults.TabIndex = 8;
            // 
            // btnBrowseCsvFile
            // 
            this.btnBrowseCsvFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseCsvFile.Location = new System.Drawing.Point(835, 25);
            this.btnBrowseCsvFile.Name = "btnBrowseCsvFile";
            this.btnBrowseCsvFile.Size = new System.Drawing.Size(111, 36);
            this.btnBrowseCsvFile.TabIndex = 9;
            this.btnBrowseCsvFile.Text = "Browse";
            this.btnBrowseCsvFile.UseVisualStyleBackColor = true;
            this.btnBrowseCsvFile.Click += new System.EventHandler(this.btnBrowseCsvFile_Click);
            // 
            // btnExportToTextFile
            // 
            this.btnExportToTextFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToTextFile.Location = new System.Drawing.Point(1069, 25);
            this.btnExportToTextFile.Name = "btnExportToTextFile";
            this.btnExportToTextFile.Size = new System.Drawing.Size(112, 36);
            this.btnExportToTextFile.TabIndex = 10;
            this.btnExportToTextFile.Text = "Export";
            this.btnExportToTextFile.UseVisualStyleBackColor = true;
            this.btnExportToTextFile.Click += new System.EventHandler(this.btnExportErrorResults_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.Location = new System.Drawing.Point(244, 88);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(585, 31);
            this.tbxSearch.TabIndex = 11;
            this.tbxSearch.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(50, 91);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 25);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Search";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1187, 26);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1366, 615);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnExportToTextFile);
            this.Controls.Add(this.btnBrowseCsvFile);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblMifirCsv);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tbxCsvFilePath);
            this.Controls.Add(this.dataGridErrorResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mifir";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridErrorResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbxCsvFilePath;
        private ProgressBar progressBar1;
        private Label lblMifirCsv;
        private Button btnValidate;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridErrorResults;
        private Button btnBrowseCsvFile;
        private Button btnExportToTextFile;
        private TextBox tbxSearch;
        private Label lblSearch;
        private Button btnCancel;
    }
}