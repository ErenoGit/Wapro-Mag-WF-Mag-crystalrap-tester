using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaproCrystalrapTester
{
    public partial class Form1 : Form
    {
        string _connectionString = null;
        string _company = "";
        string _report = "";
        string _document = "";
        string _employee = "";
        string _warehouse = "";

        List<ComboboxItem> _companyList = new List<ComboboxItem>();
        List<ComboboxItem> _reportList = new List<ComboboxItem>();
        List<ComboboxItem> _documentList = new List<ComboboxItem>();
        List<ComboboxItem> _employeeList = new List<ComboboxItem>();
        List<ComboboxItem> _warehouseList = new List<ComboboxItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void sqlConnectBtn_Click(object sender, EventArgs e)
        {
            if (!TestConnectionString(sqlServer.Text, sqlDatabase.Text, sqlUser.Text, sqlPassword.Text))
                return;

            GetCompanyList();
            GetReportList();
        }


        private bool TestConnectionString(string server, string database, string user, string password)
        {
            if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(database) || string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Brak uzupełnionych danych do serwera SQL! Crystalrap.exe wymaga do działania uzupełniania danych połączeniowych do SQL, koniecznie z hasłem", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.UserID = user;
            sqlConnectionStringBuilder.Password = password;
            sqlConnectionStringBuilder.InitialCatalog = database;
            sqlConnectionStringBuilder.DataSource = server;
            var connectionString = sqlConnectionStringBuilder.ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    _connectionString = connectionString;
                    companyComboBox.Enabled = true;
                    reportComboBox.Enabled = true;
                    MessageBox.Show("Poprawnie do serwera SQL poprawne", "Połączenie OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (SqlException ex)
                {
                    ChangeOptionsAvibility(false);
                    _companyList = new List<ComboboxItem>();
                    _reportList = new List<ComboboxItem>();
                    _documentList = new List<ComboboxItem>();
                    _employeeList = new List<ComboboxItem>();
                    _warehouseList = new List<ComboboxItem>();
                    MessageBox.Show("Połączenie do serwera SQL się nie powiodło! Błąd: "+ex.Message, "Błąd połączenia SQL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void ChangeOptionsAvibility(bool toggle)
        {
            companyComboBox.Enabled = toggle;
            reportComboBox.Enabled = toggle;
            documentComboBox.Enabled = toggle;
            generatePdfBtn.Enabled = toggle;
        }

        #region SQL querries

        private void GetCompanyList()
        {
            _companyList = new List<ComboboxItem>();
            companyComboBox.Items.Clear();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT ID_FIRMY AS value, NAZWA_PELNA AS name FROM dbo.FIRMA;", connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            ComboboxItem item = new ComboboxItem();
                            item.Text = reader["name"].ToString();
                            item.Value = reader["value"].ToString();
                            _companyList.Add(item);
                        }
                    }
                    finally
                    {
                        reader.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Błąd SQL: " + ex.Message, "Błąd SQL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            foreach (var item in _companyList)
                companyComboBox.Items.Add(item);
        }

        private void GetReportList()
        {
            _reportList = new List<ComboboxItem>();
            reportComboBox.Items.Clear();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT ID_RAPORTU AS value, nazwa AS name FROM dbo.RAPORT WHERE CRYSTAL = 1 ORDER BY ID_RAPORTU DESC;", connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            ComboboxItem item = new ComboboxItem();
                            item.Text = reader["name"].ToString();
                            item.Value = reader["value"].ToString();
                            _reportList.Add(item);
                        }
                    }
                    finally
                    {
                        reader.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Błąd SQL: " + ex.Message, "Błąd SQL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            foreach (var item in _reportList)
                reportComboBox.Items.Add(item);
        }

        private void GetDocumentList(string company_id, string warehouse_id)
        {
            _documentList = new List<ComboboxItem>();
            documentComboBox.Items.Clear();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("SELECT ID_DOKUMENTU_HANDLOWEGO AS value, ID_PRACOWNIKA AS value2, ID_MAGAZYNU AS value3, NUMER AS name FROM dbo.DOKUMENT_HANDLOWY WHERE ID_FIRMY = @COMPANY_ID ORDER BY ID_DOKUMENTU_HANDLOWEGO DESC;".Replace("@COMPANY_ID", company_id), connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            ComboboxItem item = new ComboboxItem();
                            item.Text = reader["name"].ToString();
                            item.Value = reader["value"].ToString();
                            item.Value2 = reader["value2"].ToString();
                            item.Value3 = reader["value3"].ToString();
                            _documentList.Add(item);
                        }
                    }
                    finally
                    {
                        reader.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Błąd SQL: " + ex.Message, "Błąd SQL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            foreach (var item in _documentList)
                documentComboBox.Items.Add(item);
        }

        #endregion

        private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _company = (companyComboBox.SelectedItem as ComboboxItem).Value.ToString();

            GetDocumentList(_company, _warehouse);
            documentComboBox.Enabled = true;
            documentComboBox.SelectedIndex = -1;
        }

        private void reportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _report = (reportComboBox.SelectedItem as ComboboxItem).Value.ToString();
        }

        private void documentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _document = (documentComboBox.SelectedItem as ComboboxItem).Value.ToString();
            _employee = (documentComboBox.SelectedItem as ComboboxItem).Value2.ToString();
            _warehouse = (documentComboBox.SelectedItem as ComboboxItem).Value3.ToString();

            generatePdfBtn.Enabled = true;
        }

        private void generatePdfBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sqlServer.Text) || string.IsNullOrEmpty(sqlDatabase.Text) || string.IsNullOrEmpty(sqlUser.Text) || string.IsNullOrEmpty(sqlPassword.Text))
            {
                MessageBox.Show("Brak uzupełnionych danych do serwera SQL! Crystalrap.exe wymaga uzupełniania danych połączeniowych do SQL, włącznie z hasłem", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(_company))
            {
                MessageBox.Show("Brak wybranej firmy!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(_report))
            {
                MessageBox.Show("Brak wybranego raportu!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(_document))
            {
                MessageBox.Show("Brak wybranego dokumentu!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(waproFolder.Text))
            {
                MessageBox.Show("Brak wybranej ścieżki do Wapro!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(pdfFolder.Text))
            {
                MessageBox.Show("Brak wybranej ścieżki zapisu PDF!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }





            var argsConnection = $"\"{sqlServer.Text},{sqlDatabase.Text},{sqlUser.Text},{sqlPassword.Text}\"";
            var argsDoc = $"\"{_report}\" \"{_document}\" \"{_company}\" \"{_warehouse}\" \"\" \"{_employee}\" \"4\" \"FakturaPDF\" \"{pdfFolder.Text}\"";
            generateCommand.Text = $"CRYSTALRAP.exe " + argsConnection + " " + argsDoc;

            try
            {
                var fileName = "CRYSTALRAP.exe";
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Process generatorProcess = new Process();
                generatorProcess.StartInfo.UseShellExecute = false;
                generatorProcess.StartInfo.FileName = Path.Combine(waproFolder.Text, fileName);
                generatorProcess.StartInfo.WorkingDirectory = waproFolder.Text;
                generatorProcess.StartInfo.Arguments = $"{argsConnection} {argsDoc}";
                generatorProcess.StartInfo.CreateNoWindow = true;
                //_writeDebug("GeneratePdf Start called");
                generatorProcess.Start();
                //_writeDebug("GeneratePdf WaitForExit called");
                generatorProcess.WaitForExit();
                stopwatch.Stop();
                //_writeDebug("Time elapsed GeneratePdf :" + stopwatch.Elapsed);

                MessageBox.Show("Crystalrap zakończył działanie, sprawdź czy plik PDF został wygenerowany", "Crystalrap zakończył działanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas generowania pliku PDF: "+ex.Message, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                waproFolder.Text = folderDlg.SelectedPath;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                pdfFolder.Text = folderDlg.SelectedPath;
            }
        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
