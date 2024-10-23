using System.Data;

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
            string csvFilePath = "Data/casepoint expenses.csv";
            DataTable dataTable = LoadCsvData(csvFilePath);

            dataGridView.DataSource = dataTable;
            dataGridView.AllowUserToAddRows = true;
            dataGridView.ReadOnly = false;

            ShowStatistics(dataTable);
        }

        private async void loadFile(object sender, EventArgs e)
        {
            string csvFilePath = "https://github.com/KalashShah19/ExpenseTracker/blob/main/Data/casepoint%20expenses.csv";
            try
            {
                DataTable dataTable = await LoadCsvDataAsync(csvFilePath);
                dataGridView.DataSource = dataTable;

                dataGridView.AllowUserToAddRows = true;
                dataGridView.ReadOnly = false;

                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading CSV: {ex.Message}");
            }
        }

        private async Task<DataTable> LoadCsvDataAsync(string csvFilePath)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(csvFilePath);
                response.EnsureSuccessStatusCode();

                string csvContent = await response.Content.ReadAsStringAsync();

                return ProcessCsv(csvContent);
            }
        }

        private DataTable ProcessCsv(string csvContent)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Amount", typeof(decimal));
            dataTable.Columns.Add("Purpose", typeof(string));
            dataTable.Columns.Add("Category", typeof(string));
            dataTable.Columns.Add("Date", typeof(DateTime));

            using (StringReader reader = new StringReader(csvContent))
            {
                string line;
                bool isFirstLine = true;

                while ((line = reader.ReadLine()!) != null)
                {
                    var values = line.Split(',');

                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }

                    if (values.Length == 4)
                    {
                        DataRow row = dataTable.NewRow();

                        decimal amount;
                        if (decimal.TryParse(values[0], out amount))
                        {
                            row["Amount"] = amount;
                        }
                        else
                        {
                            row["Amount"] = 0;
                        }

                        row["Purpose"] = values[1];
                        row["Category"] = values[2];

                        // Parse "Date"
                        DateTime date;
                        if (DateTime.TryParse(values[3], out date))
                        {
                            row["Date"] = date;
                        }
                        else
                        {
                            row["Date"] = DateTime.MinValue;
                        }

                        dataTable.Rows.Add(row);
                    }
                }
            }

            return dataTable;
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
    }
}