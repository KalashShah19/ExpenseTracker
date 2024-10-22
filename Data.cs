using CsvHelper;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void DataDisplayForm_Load(object sender, EventArgs e)
        {
            string csvFilePath = "D:/! Kalash/Extras/Data/casepoint expenses.csv";
            DataTable dataTable = LoadCsvData(csvFilePath);

            dataGridView.DataSource = dataTable;
            dataGridView.AllowUserToAddRows = true;
            dataGridView.ReadOnly = false;

            ShowStatistics(dataTable);
        }

        private DataTable LoadCsvData(string filePath)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string[] headers = sr.ReadLine()!.Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine()!.Split(',');
                        dataTable.Rows.Add(rows);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading CSV file: {ex.Message}");
            }

            return dataTable;
        }

        private void ShowStatistics(DataTable dataTable)
        {
            double totalExpenses = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                if (double.TryParse(row["Amount"].ToString(), out double amount))
                {
                    totalExpenses += amount;
                }
            }

            lblTotalExpenses.Text = $"Total Expenses: ₹{totalExpenses.ToString("N2")}";
        }

        private void SaveCsvData(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridView.DataSource;

            using (StreamWriter sw = new StreamWriter("D:/! Kalash/Extras/Data/casepoint expenses.csv"))
            using (CsvWriter csvWriter = new CsvWriter(sw, CultureInfo.InvariantCulture))
            {
                // csvWriter.WriteRecord(dataTable.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToArray());
                // csvWriter.WriteRecords(dataTable.Rows);
            }
            MessageBox.Show("CSV Updated");
        }
    }
}